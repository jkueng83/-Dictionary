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
            // Export to csv file.
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

            Dictionary<string, string> orderedDictionary = new Dictionary<string, string>();

            for (int i = 0; i < sortListKeys.Count; i++)
            {
                orderedDictionary.Add(sortListKeys[i], dictionary[sortListKeys[i]]);
            }

            dictionary.Clear();
            dictionary = orderedDictionary;
        }

    }

}
