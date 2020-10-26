using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Woerterbuch
{
    public partial class Woerterbuch : Form
    {
        bool isUpdating = false;
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        private string path = "";


        public Woerterbuch()
        {
            InitializeComponent();
            path = "dictonary.csv";

            LoadDictonaryFromCsv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //dictionary.Add("Hallo", "Hello");
            var germanWord = tbGermanWord.Text;
            var englischWord = tbEnglischWord.Text;

            if (!String.IsNullOrEmpty(germanWord) && !String.IsNullOrEmpty(englischWord))
            {
                dictionary.Add(germanWord, englischWord);

                UpdateTranslations();
            }
        }

        private void UpdateTranslations()
        {
            SortList();

            lBoxWords.DataSource = dictionary.Keys.ToList();
        }

        private void lBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lBoxWords.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord) && dictionary.ContainsKey(selectedWord))
            {

                tbTranslation.Text = dictionary[selectedWord];

            }
        }

        private void btnExportToCsv_Click(object sender, EventArgs e)
        {
            // Export in Eine csv Datei
            var exportStrings = new List<string>();

            foreach (var dictonaryItem in dictionary)
            {
                // Hallo;hello; 

                exportStrings.Add(dictonaryItem.Key + ";" + dictonaryItem.Value);

            }

            System.IO.File.WriteAllLines(this.path, exportStrings);

        }

        private void btnImportFromCsv_Click(object sender, EventArgs e)
        {

            LoadDictonaryFromCsv();

        }

        private void LoadDictonaryFromCsv()
        {
            string[] fileContent = System.IO.File.ReadAllLines(this.path);

            dictionary.Clear();

            foreach (string fileLine in fileContent)
            {

                string[] stringArray = fileLine.Split(';');
                dictionary.Add(stringArray[0], stringArray[1]);

            }
            UpdateTranslations();
        }

        private void SortList()
        {

            List<string> sortListKeys = new List<string>(dictionary.Keys);

            sortListKeys.Sort();

            // Dictionary<string, string> unOrderedDictionary = new Dictionary<string, string>( dictionary);

            Dictionary<string, string> orderedDictionary = new Dictionary<string, string>();

            for (int i = 0; i < sortListKeys.Count; i++)
            {
                orderedDictionary.Add(sortListKeys[i], dictionary[sortListKeys[i]]);
            }

            dictionary.Clear();

            dictionary = orderedDictionary;

        }

        private void tbFindGermanWord_TextChanged(object sender, EventArgs e)
        {

            Dictionary<string, string> germanSearchDictionary = new Dictionary<string, string>();
            string germanWordToSearch = tbFindGermanWord.Text;

            foreach (var dictionaryItem in this.dictionary)
            {
                if (dictionaryItem.Key.ToUpper().Contains(germanWordToSearch.ToUpper()))
                {
                    germanSearchDictionary.Add(dictionaryItem.Key, dictionaryItem.Value);
                }
            }

            updateSearchBox(germanSearchDictionary);
        }

        private void updateSearchBox(Dictionary<string, string> dictionary)
        {
            lBoxSearchResultGerman.DataSource = dictionary.Keys.ToList();
            lBoxSearchResultEnglisch.DataSource = dictionary.Values.ToList();
        }

        private void tbFindEnglischWord_TextChanged(object sender, EventArgs e)
        {

            Dictionary<string, string> englischSearchDictionary = new Dictionary<string, string>();
            string germanWordToSearch = tbFindEnglischWord.Text;

            foreach (var dictionaryItem in this.dictionary)
            {
                if (dictionaryItem.Value.ToUpper().Contains(germanWordToSearch.ToUpper()))
                {
                    englischSearchDictionary.Add(dictionaryItem.Key, dictionaryItem.Value);
                }
            }

            updateSearchBox(englischSearchDictionary);
        }

        private void lBoxSearchResultGerman_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (isUpdating)
                return;

            var selectedWord = lBoxSearchResultGerman.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord) && dictionary.ContainsKey(selectedWord))
            {
                // Das war zum Testen: Console.WriteLine(selectedWord);
                string englischWord = "";
                // Das war zum Testen: bbool valueExists = dictionary.TryGetValue(selectedWord, out englischWord);
                // Das war zum Testen: Console.WriteLine(englischWord);

                if (dictionary.TryGetValue(selectedWord, out englischWord))
                {
                    isUpdating = true;
                    lBoxSearchResultEnglisch.SelectedItem = englischWord;
                    isUpdating = false;
                }

            }
        }

        private void lBoxSearchResultEnglisch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            var selectedWord = lBoxSearchResultEnglisch.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord) && dictionary.ContainsValue(selectedWord))
            {
                // Das war zum Testen: Console.WriteLine(selectedWord);
                string germanWord = "";
                // Das war zum Testen: bbool valueExists = dictionary.TryGetValue(selectedWord, out englischWord);
                // Das war zum Testen: Console.WriteLine(englischWord);

                //lBoxSearchResultGerman.SelectedItem = "Hallo";

                bool contains = dictionary.ContainsValue(selectedWord);

                if(dictionary.Values.Any(x => x == selectedWord)) { 
                    germanWord = dictionary.FirstOrDefault(x => x.Value == selectedWord).Key;
                    isUpdating = true;
                    lBoxSearchResultGerman.SelectedItem = germanWord;
                    isUpdating = false;
                }

            }
        }
    }

}
