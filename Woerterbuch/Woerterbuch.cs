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
        Dictionary<string   ,string> dictionary = new Dictionary<string,string>();

        public Woerterbuch()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
                    {
            //dictionary.Add("Hallo", "Hello");
            var germanWord = tbGermanWord.Text;
            var englischWord = tbEnglischWord.Text;

            if(!String.IsNullOrEmpty(germanWord) && !String.IsNullOrEmpty(englischWord))
            {
                dictionary.Add(germanWord, englischWord);
                UpdateTranslations();
            }
        }

        private void UpdateTranslations()
        {

            lBoxWords.DataSource = dictionary.Keys.ToList();
        }

        private void lBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lBoxWords.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord)&& dictionary.ContainsKey(selectedWord))
            {

                tbTranslation.Text = dictionary[selectedWord];
                

            }
        }
    }



    
}
