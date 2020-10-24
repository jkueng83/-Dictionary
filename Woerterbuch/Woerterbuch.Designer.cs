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
            this.lbTranslation = new System.Windows.Forms.Label();
            this.lBoxWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(96, 87);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(100, 20);
            this.tbGermanWord.TabIndex = 1;
            // 
            // tbEnglischWord
            // 
            this.tbEnglischWord.Location = new System.Drawing.Point(547, 87);
            this.tbEnglischWord.Name = "tbEnglischWord";
            this.tbEnglischWord.Size = new System.Drawing.Size(100, 20);
            this.tbEnglischWord.TabIndex = 2;
            // 
            // lbTranslation
            // 
            this.lbTranslation.AutoSize = true;
            this.lbTranslation.Location = new System.Drawing.Point(259, 90);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(46, 13);
            this.lbTranslation.TabIndex = 3;
            this.lbTranslation.Text = "De -- En";
            // 
            // lBoxWords
            // 
            this.lBoxWords.FormattingEnabled = true;
            this.lBoxWords.Location = new System.Drawing.Point(96, 237);
            this.lBoxWords.Name = "lBoxWords";
            this.lBoxWords.Size = new System.Drawing.Size(247, 121);
            this.lBoxWords.TabIndex = 4;
            this.lBoxWords.SelectedIndexChanged += new System.EventHandler(this.lBoxWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(404, 237);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(264, 20);
            this.tbTranslation.TabIndex = 5;
            // 
            // Woerterbuch
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lBoxWords);
            this.Controls.Add(this.lbTranslation);
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
        private System.Windows.Forms.Label lbTranslation;
        private System.Windows.Forms.ListBox lBoxWords;
        private System.Windows.Forms.TextBox tbTranslation;
    }
}

