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
        private char[] searchLetters;

        public Woerterbuch()
        {
            InitializeComponent();

            path = "dictonary.csv";

            LoadDictonaryFromCsv();

            this.searchLetters = new char[26];

            for (int i = 0; i < this.searchLetters.Length; i++)
            {
                this.searchLetters[i] = (char)(i + 65);
                Console.WriteLine("letter: " + this.searchLetters[i]);
            }

            lBoxSearchLetterGerman.DataSource = this.searchLetters.ToList();
            lBoxSearchLetterEnglisch.DataSource = this.searchLetters.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //dictionary.Add("Hallo", "Hello");
            var germanWord = tbGermanWord.Text;
            var englischWord = tbEnglischWord.Text;

            if (!String.IsNullOrEmpty(germanWord) && !String.IsNullOrEmpty(englischWord))
            {
                // Ein Wort kann nur einmal eingegeben werden
                if (!dictionary.ContainsKey(germanWord))
                {
                    dictionary.Add(germanWord, englischWord);
                    UpdateTranslations();
                }

            }
        }

        private void UpdateTranslations()
        {
            // Mit Linq! Ergänzung:  OrderBy(myWord => myWord).
            lBoxWords.DataSource = dictionary.Keys.OrderBy(myWord => myWord).ToList();

            var numberList = new List<int>();
            numberList.Add(2);
            numberList.Add(-2);
            numberList.Add(11);
            numberList.Add(6);
            numberList.Add(4);
            numberList.Add(9);

            var sum = numberList.Sum(x => x);
            var sum2 = numberList.Sum();
            var average = numberList.Average();
            var max = numberList.Max();
            var mint = numberList.Min();

            var skipResult = numberList.Skip(3).Sum(); // die ersten 3 Zahlen werden ausgelassen, dann wird die Summer gebildet

            var take = numberList.Take(3).Sum(); // es werden 3 Zahlen aus der Liste genommen

            var ortherNumberList = new List<int>();
            ortherNumberList.Add(37);

            var newList = numberList.Union(ortherNumberList); // Führt zwei Listen zusammen
            var newListTakeUnion = numberList.Take(3).Union(ortherNumberList);

            var newListFrom = from number in numberList
                              where number > 2 && number % 2 == 0
                              select number;

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
            // Export to csv file.

            SortList();

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
            sortListKeys.Sort();

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

                if (dictionary.Values.Any(x => x == selectedWord))
                {
                    germanWord = dictionary.FirstOrDefault(x => x.Value == selectedWord).Key;
                    isUpdating = true;
                    lBoxSearchResultGerman.SelectedItem = germanWord;
                    isUpdating = false;
                }
            }
        }

        private void tbSearchWithLinqGermanWord_TextChanged(object sender, EventArgs e)
        {
            var list = this.dictionary.Where(x => x.Key.ToLower().Contains(tbSearchWithLinqGermanWord.Text.ToLower())).Select(x => x.Key).ToList();
            lBoxWords.DataSource = list;

        }

        private void lBoxSearchLetterGerman_SelectedIndexChanged(object sender, EventArgs e)
        {
            char searchLetter = (char)lBoxSearchLetterGerman.SelectedItem;
            SearchFirstLetterGerman(searchLetter);
        }

        private void SearchFirstLetterGerman(char firstLetter)
        {
            Dictionary<string, string> seachDictionary = new Dictionary<string, string>();

            foreach (var item in this.dictionary)
            {
                if (item.Key.ToUpper().Substring(0, 1).Equals(firstLetter.ToString().ToUpper()))
                    seachDictionary.Add(item.Key, item.Value);
            }

            updateSearchBox(seachDictionary);
        }

        private void lBoxSearchLetterEnglisch_SelectedIndexChanged(object sender, EventArgs e)
        {
            char searchLetter = (char)lBoxSearchLetterEnglisch.SelectedItem;
            SearchFirstLetterEnglisch(searchLetter);
        }

        private void SearchFirstLetterEnglisch(char firstLetter)
        {
            Dictionary<string, string> seachDictionary = new Dictionary<string, string>();

            foreach (var item in this.dictionary)
            {
                if (item.Value.ToUpper().Substring(0, 1).Equals(firstLetter.ToString().ToUpper()))
                    seachDictionary.Add(item.Key, item.Value);
            }

            updateSearchBox(seachDictionary);
        }
    }

}
