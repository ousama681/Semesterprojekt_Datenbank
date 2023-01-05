namespace DBS_View.View
{
    partial class AddArticleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblArticleGRoup = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblArticleNr = new System.Windows.Forms.Label();
            this.TxtArticleGroup = new System.Windows.Forms.TextBox();
            this.TxtArticleName = new System.Windows.Forms.TextBox();
            this.TxtArticleNr = new System.Windows.Forms.TextBox();
            this.LblAddCustomerTitle = new System.Windows.Forms.Label();
            this.CmdAbort = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrice.Location = new System.Drawing.Point(12, 252);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(40, 20);
            this.LblPrice.TabIndex = 30;
            this.LblPrice.Text = "Preis";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(12, 275);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(128, 23);
            this.TxtPrice.TabIndex = 23;
            // 
            // LblArticleGRoup
            // 
            this.LblArticleGRoup.AutoSize = true;
            this.LblArticleGRoup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblArticleGRoup.Location = new System.Drawing.Point(12, 185);
            this.LblArticleGRoup.Name = "LblArticleGRoup";
            this.LblArticleGRoup.Size = new System.Drawing.Size(100, 20);
            this.LblArticleGRoup.TabIndex = 27;
            this.LblArticleGRoup.Text = "Artikelgruppe";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(12, 56);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(93, 20);
            this.LblName.TabIndex = 26;
            this.LblName.Text = "Bezeichnung";
            // 
            // LblArticleNr
            // 
            this.LblArticleNr.AutoSize = true;
            this.LblArticleNr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblArticleNr.Location = new System.Drawing.Point(12, 120);
            this.LblArticleNr.Name = "LblArticleNr";
            this.LblArticleNr.Size = new System.Drawing.Size(68, 20);
            this.LblArticleNr.TabIndex = 25;
            this.LblArticleNr.Text = "Artikelnr.";
            // 
            // TxtArticleGroup
            // 
            this.TxtArticleGroup.Location = new System.Drawing.Point(12, 208);
            this.TxtArticleGroup.Name = "TxtArticleGroup";
            this.TxtArticleGroup.Size = new System.Drawing.Size(191, 23);
            this.TxtArticleGroup.TabIndex = 21;
            // 
            // TxtArticleName
            // 
            this.TxtArticleName.Location = new System.Drawing.Point(12, 79);
            this.TxtArticleName.Name = "TxtArticleName";
            this.TxtArticleName.Size = new System.Drawing.Size(283, 23);
            this.TxtArticleName.TabIndex = 19;
            // 
            // TxtArticleNr
            // 
            this.TxtArticleNr.Location = new System.Drawing.Point(12, 143);
            this.TxtArticleNr.Name = "TxtArticleNr";
            this.TxtArticleNr.Size = new System.Drawing.Size(128, 23);
            this.TxtArticleNr.TabIndex = 20;
            // 
            // LblAddCustomerTitle
            // 
            this.LblAddCustomerTitle.AutoSize = true;
            this.LblAddCustomerTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddCustomerTitle.Location = new System.Drawing.Point(12, 9);
            this.LblAddCustomerTitle.Name = "LblAddCustomerTitle";
            this.LblAddCustomerTitle.Size = new System.Drawing.Size(216, 32);
            this.LblAddCustomerTitle.TabIndex = 31;
            this.LblAddCustomerTitle.Text = "Artikel hinzufügen";
            // 
            // CmdAbort
            // 
            this.CmdAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdAbort.Location = new System.Drawing.Point(112, 318);
            this.CmdAbort.Name = "CmdAbort";
            this.CmdAbort.Size = new System.Drawing.Size(91, 35);
            this.CmdAbort.TabIndex = 33;
            this.CmdAbort.Text = "Abbrechen";
            this.CmdAbort.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(12, 318);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(94, 35);
            this.CmdSave.TabIndex = 32;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // AddArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 365);
            this.Controls.Add(this.CmdAbort);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.LblAddCustomerTitle);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.LblArticleGRoup);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblArticleNr);
            this.Controls.Add(this.TxtArticleGroup);
            this.Controls.Add(this.TxtArticleName);
            this.Controls.Add(this.TxtArticleNr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddArticleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblPrice;
        private TextBox TxtPrice;
        private Label LblArticleGRoup;
        private Label LblName;
        private Label LblArticleNr;
        private TextBox TxtArticleGroup;
        private TextBox TxtArticleName;
        private TextBox TxtArticleNr;
        private Label LblAddCustomerTitle;
        private Button CmdAbort;
        private Button CmdSave;
    }
}