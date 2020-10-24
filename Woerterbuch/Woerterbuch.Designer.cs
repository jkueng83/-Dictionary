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
            this.lbWordGerman = new System.Windows.Forms.Label();
            this.lBoxWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btnExportToCsv = new System.Windows.Forms.Button();
            this.btnImportFromCsv = new System.Windows.Forms.Button();
            this.lbWoerterbuch = new System.Windows.Forms.Label();
            this.lbEnglisch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(96, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(96, 101);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(250, 20);
            this.tbGermanWord.TabIndex = 1;
            // 
            // tbEnglischWord
            // 
            this.tbEnglischWord.Location = new System.Drawing.Point(432, 101);
            this.tbEnglischWord.Name = "tbEnglischWord";
            this.tbEnglischWord.Size = new System.Drawing.Size(250, 20);
            this.tbEnglischWord.TabIndex = 2;
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
            this.lBoxWords.Location = new System.Drawing.Point(96, 203);
            this.lBoxWords.Name = "lBoxWords";
            this.lBoxWords.Size = new System.Drawing.Size(250, 121);
            this.lBoxWords.TabIndex = 4;
            this.lBoxWords.SelectedIndexChanged += new System.EventHandler(this.lBoxWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(432, 203);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(250, 20);
            this.tbTranslation.TabIndex = 5;
            // 
            // btnExportToCsv
            // 
            this.btnExportToCsv.Location = new System.Drawing.Point(246, 343);
            this.btnExportToCsv.Name = "btnExportToCsv";
            this.btnExportToCsv.Size = new System.Drawing.Size(100, 23);
            this.btnExportToCsv.TabIndex = 6;
            this.btnExportToCsv.Text = "Export to CSV";
            this.btnExportToCsv.UseVisualStyleBackColor = true;
            this.btnExportToCsv.Click += new System.EventHandler(this.btnExportToCsv_Click);
            // 
            // btnImportFromCsv
            // 
            this.btnImportFromCsv.Location = new System.Drawing.Point(100, 343);
            this.btnImportFromCsv.Name = "btnImportFromCsv";
            this.btnImportFromCsv.Size = new System.Drawing.Size(100, 23);
            this.btnImportFromCsv.TabIndex = 7;
            this.btnImportFromCsv.Text = "Import from CSV";
            this.btnImportFromCsv.UseVisualStyleBackColor = true;
            this.btnImportFromCsv.Click += new System.EventHandler(this.btnImportFromCsv_Click);
            // 
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEnglisch);
            this.Controls.Add(this.lbWoerterbuch);
            this.Controls.Add(this.btnImportFromCsv);
            this.Controls.Add(this.btnExportToCsv);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lBoxWords);
            this.Controls.Add(this.lbWordGerman);
            this.Controls.Add(this.tbEnglischWord);
            this.Controls.Add(this.tbGermanWord);
            this.Controls.Add(this.btnAdd);
            this.Name = "Woerterbuch";
            this.Text = "Wörterbuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.TextBox tbEnglischWord;
        private System.Windows.Forms.Label lbWordGerman;
        private System.Windows.Forms.ListBox lBoxWords;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Button btnExportToCsv;
        private System.Windows.Forms.Button btnImportFromCsv;
        private System.Windows.Forms.Label lbWoerterbuch;
        private System.Windows.Forms.Label lbEnglisch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLine;
    }
}

