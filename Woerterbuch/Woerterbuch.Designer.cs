namespace Woerterbuch
{
    partial class Woerterbuch
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbGermanWord = new System.Windows.Forms.TextBox();
            this.tbEnglischWord = new System.Windows.Forms.TextBox();
            this.lbTranslationDeutsch = new System.Windows.Forms.Label();
            this.lbWordGerman = new System.Windows.Forms.Label();
            this.lBoxWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btnExportToCsv = new System.Windows.Forms.Button();
            this.btnImportFromCsv = new System.Windows.Forms.Button();
            this.tbFindGermanWord = new System.Windows.Forms.TextBox();
            this.lbTranslationEnglisch = new System.Windows.Forms.Label();
            this.lbSearchGermanWord = new System.Windows.Forms.Label();
            this.lbSearchEnglischWord = new System.Windows.Forms.Label();
            this.tbFindEnglischWord = new System.Windows.Forms.TextBox();
            this.lBoxSearchResultGerman = new System.Windows.Forms.ListBox();
            this.lBoxSearchResultEnglisch = new System.Windows.Forms.ListBox();
            this.lbWoerterbuch = new System.Windows.Forms.Label();
            this.lbEnglisch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(128, 137);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Location = new System.Drawing.Point(96, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(128, 107);
            this.tbGermanWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(300, 22);
            this.tbGermanWord.TabIndex = 1;
            // 
            // tbEnglischWord
            // 
            this.tbEnglischWord.Location = new System.Drawing.Point(539, 107);
            this.tbEnglischWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnglischWord.Name = "tbEnglischWord";
            this.tbEnglischWord.Size = new System.Drawing.Size(300, 22);
            this.tbEnglischWord.TabIndex = 2;
            // 
            // lbTranslationDeutsch
            // 
            this.lbTranslationDeutsch.AutoSize = true;
            this.lbTranslationDeutsch.Location = new System.Drawing.Point(125, 75);
            this.lbTranslationDeutsch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTranslationDeutsch.Name = "lbTranslationDeutsch";
            this.lbTranslationDeutsch.Size = new System.Drawing.Size(60, 17);
            this.lbTranslationDeutsch.TabIndex = 3;
            this.lbTranslationDeutsch.Text = "Deutsch";
            // 
            // lbWordGerman
            // 
            this.lbWordGerman.AutoSize = true;
            this.lbWordGerman.Location = new System.Drawing.Point(93, 85);
            this.lbWordGerman.Name = "lbWordGerman";
            this.lbWordGerman.Size = new System.Drawing.Size(47, 13);
            this.lbWordGerman.TabIndex = 3;
            this.lbWordGerman.Text = "Deutsch";
            // 
            // lBoxWords
            // 
            this.lBoxWords.FormattingEnabled = true;
            this.lBoxWords.ItemHeight = 16;
            this.lBoxWords.Location = new System.Drawing.Point(128, 292);
            this.lBoxWords.Margin = new System.Windows.Forms.Padding(4);
            this.lBoxWords.Name = "lBoxWords";
            this.lBoxWords.Size = new System.Drawing.Size(300, 148);
            this.lBoxWords.TabIndex = 4;
            this.lBoxWords.SelectedIndexChanged += new System.EventHandler(this.lBoxWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(539, 292);
            this.tbTranslation.Margin = new System.Windows.Forms.Padding(4);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(300, 22);
            this.tbTranslation.TabIndex = 5;
            // 
            // btnExportToCsv
            // 
            this.btnExportToCsv.Location = new System.Drawing.Point(128, 173);
            this.btnExportToCsv.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportToCsv.Name = "btnExportToCsv";
            this.btnExportToCsv.Size = new System.Drawing.Size(150, 28);
            this.btnExportToCsv.TabIndex = 6;
            this.btnExportToCsv.Text = "Export to CSV";
            this.btnExportToCsv.UseVisualStyleBackColor = true;
            this.btnExportToCsv.Click += new System.EventHandler(this.btnExportToCsv_Click);
            // 
            // btnImportFromCsv
            // 
            this.btnImportFromCsv.Location = new System.Drawing.Point(128, 210);
            this.btnImportFromCsv.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportFromCsv.Name = "btnImportFromCsv";
            this.btnImportFromCsv.Size = new System.Drawing.Size(150, 28);
            this.btnImportFromCsv.TabIndex = 7;
            this.btnImportFromCsv.Text = "Import from CSV";
            this.btnImportFromCsv.UseVisualStyleBackColor = true;
            this.btnImportFromCsv.Click += new System.EventHandler(this.btnImportFromCsv_Click);
            // 
            // tbFindGermanWord
            // 
            this.tbFindGermanWord.Location = new System.Drawing.Point(128, 490);
            this.tbFindGermanWord.Name = "tbFindGermanWord";
            this.tbFindGermanWord.Size = new System.Drawing.Size(300, 22);
            this.tbFindGermanWord.TabIndex = 8;
            this.tbFindGermanWord.TextChanged += new System.EventHandler(this.tbFindGermanWord_TextChanged);
            // 
            // lbTranslationEnglisch
            // 
            this.lbTranslationEnglisch.AutoSize = true;
            this.lbTranslationEnglisch.Location = new System.Drawing.Point(536, 75);
            this.lbTranslationEnglisch.Name = "lbTranslationEnglisch";
            this.lbTranslationEnglisch.Size = new System.Drawing.Size(61, 17);
            this.lbTranslationEnglisch.TabIndex = 9;
            this.lbTranslationEnglisch.Text = "Englisch";
            // 
            // lbSearchGermanWord
            // 
            this.lbSearchGermanWord.AutoSize = true;
            this.lbSearchGermanWord.Location = new System.Drawing.Point(125, 470);
            this.lbSearchGermanWord.Name = "lbSearchGermanWord";
            this.lbSearchGermanWord.Size = new System.Drawing.Size(159, 17);
            this.lbSearchGermanWord.TabIndex = 10;
            this.lbSearchGermanWord.Text = "Deutsches Wort suchen";
            // 
            // lbSearchEnglischWord
            // 
            this.lbSearchEnglischWord.AutoSize = true;
            this.lbSearchEnglischWord.Location = new System.Drawing.Point(539, 469);
            this.lbSearchEnglischWord.Name = "lbSearchEnglischWord";
            this.lbSearchEnglischWord.Size = new System.Drawing.Size(141, 17);
            this.lbSearchEnglischWord.TabIndex = 11;
            this.lbSearchEnglischWord.Text = "search englisch word";
            // 
            // tbFindEnglischWord
            // 
            this.tbFindEnglischWord.Location = new System.Drawing.Point(539, 489);
            this.tbFindEnglischWord.Name = "tbFindEnglischWord";
            this.tbFindEnglischWord.Size = new System.Drawing.Size(300, 22);
            this.tbFindEnglischWord.TabIndex = 12;
            this.tbFindEnglischWord.TextChanged += new System.EventHandler(this.tbFindEnglischWord_TextChanged);
            // 
            // lBoxSearchResultGerman
            // 
            this.lBoxSearchResultGerman.FormattingEnabled = true;
            this.lBoxSearchResultGerman.ItemHeight = 16;
            this.lBoxSearchResultGerman.Location = new System.Drawing.Point(128, 546);
            this.lBoxSearchResultGerman.Name = "lBoxSearchResultGerman";
            this.lBoxSearchResultGerman.Size = new System.Drawing.Size(300, 132);
            this.lBoxSearchResultGerman.TabIndex = 13;
            this.lBoxSearchResultGerman.SelectedIndexChanged += new System.EventHandler(this.lBoxSearchResultGerman_SelectedIndexChanged);
            // 
            // lBoxSearchResultEnglisch
            // 
            this.lBoxSearchResultEnglisch.FormattingEnabled = true;
            this.lBoxSearchResultEnglisch.ItemHeight = 16;
            this.lBoxSearchResultEnglisch.Location = new System.Drawing.Point(539, 546);
            this.lBoxSearchResultEnglisch.Name = "lBoxSearchResultEnglisch";
            this.lBoxSearchResultEnglisch.Size = new System.Drawing.Size(300, 132);
            this.lBoxSearchResultEnglisch.TabIndex = 14;
            this.lBoxSearchResultEnglisch.SelectedIndexChanged += new System.EventHandler(this.lBoxSearchResultEnglisch_SelectedIndexChanged);
            // lbWoerterbuch
            // 
            this.lbWoerterbuch.AutoSize = true;
            this.lbWoerterbuch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWoerterbuch.Location = new System.Drawing.Point(91, 9);
            this.lbWoerterbuch.Name = "lbWoerterbuch";
            this.lbWoerterbuch.Size = new System.Drawing.Size(124, 25);
            this.lbWoerterbuch.TabIndex = 8;
            this.lbWoerterbuch.Text = "Wörterbuch";
            // 
            // lbEnglisch
            // 
            this.lbEnglisch.AutoSize = true;
            this.lbEnglisch.Location = new System.Drawing.Point(429, 85);
            this.lbEnglisch.Name = "lbEnglisch";
            this.lbEnglisch.Size = new System.Drawing.Size(47, 13);
            this.lbEnglisch.TabIndex = 9;
            this.lbEnglisch.Text = "Englisch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wörter ergänzen";
            // 
            // lbLine
            // 
            this.lbLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLine.Location = new System.Drawing.Point(96, 168);
            this.lbLine.MaximumSize = new System.Drawing.Size(600, 5);
            this.lbLine.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(586, 5);
            this.lbLine.TabIndex = 11;
            // 
            // Woerterbuch
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 763);
            this.Controls.Add(this.lBoxSearchResultEnglisch);
            this.Controls.Add(this.lBoxSearchResultGerman);
            this.Controls.Add(this.tbFindEnglischWord);
            this.Controls.Add(this.lbSearchEnglischWord);
            this.Controls.Add(this.lbSearchGermanWord);
            this.Controls.Add(this.lbTranslationEnglisch);
            this.Controls.Add(this.tbFindGermanWord);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEnglisch);
            this.Controls.Add(this.lbWoerterbuch);
            this.Controls.Add(this.btnImportFromCsv);
            this.Controls.Add(this.btnExportToCsv);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lBoxWords);
            this.Controls.Add(this.lbTranslationDeutsch);
            this.Controls.Add(this.lbWordGerman);
            this.Controls.Add(this.tbEnglischWord);
            this.Controls.Add(this.tbGermanWord);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Woerterbuch";
            this.Text = "Wörterbuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.TextBox tbEnglischWord;
        private System.Windows.Forms.Label lbTranslationDeutsch;
        private System.Windows.Forms.Label lbWordGerman;
        private System.Windows.Forms.ListBox lBoxWords;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Button btnExportToCsv;
        private System.Windows.Forms.Button btnImportFromCsv;
        private System.Windows.Forms.TextBox tbFindGermanWord;
        private System.Windows.Forms.Label lbTranslationEnglisch;
        private System.Windows.Forms.Label lbSearchGermanWord;
        private System.Windows.Forms.Label lbSearchEnglischWord;
        private System.Windows.Forms.TextBox tbFindEnglischWord;
        private System.Windows.Forms.ListBox lBoxSearchResultGerman;
        private System.Windows.Forms.ListBox lBoxSearchResultEnglisch;
        private System.Windows.Forms.Label lbWoerterbuch;
        private System.Windows.Forms.Label lbEnglisch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLine;
    }
}

