namespace DBS_View.View
{
    partial class ArticleForm
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
            this.DgvArticle = new System.Windows.Forms.DataGridView();
            this.colNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticleGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateArticle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CmdAddCustomer = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArticle
            // 
            this.DgvArticle.AllowUserToAddRows = false;
            this.DgvArticle.AllowUserToDeleteRows = false;
            this.DgvArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNr,
            this.colName,
            this.colPrice,
            this.colArticleGroup,
            this.colUpdateArticle});
            this.DgvArticle.Location = new System.Drawing.Point(12, 41);
            this.DgvArticle.Name = "DgvArticle";
            this.DgvArticle.ReadOnly = true;
            this.DgvArticle.RowHeadersVisible = false;
            this.DgvArticle.RowTemplate.Height = 25;
            this.DgvArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticle.Size = new System.Drawing.Size(877, 343);
            this.DgvArticle.TabIndex = 1;
            // 
            // colNr
            // 
            this.colNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNr.HeaderText = "Artikelnr.";
            this.colNr.Name = "colNr";
            this.colNr.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Bezeichnung";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.HeaderText = "Preis";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colArticleGroup
            // 
            this.colArticleGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArticleGroup.HeaderText = "Artikelgruppe";
            this.colArticleGroup.Name = "colArticleGroup";
            this.colArticleGroup.ReadOnly = true;
            // 
            // colUpdateArticle
            // 
            this.colUpdateArticle.HeaderText = "Bearbeiten";
            this.colUpdateArticle.Name = "colUpdateArticle";
            this.colUpdateArticle.ReadOnly = true;
            this.colUpdateArticle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUpdateArticle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CmdAddCustomer
            // 
            this.CmdAddCustomer.Location = new System.Drawing.Point(12, 12);
            this.CmdAddCustomer.Name = "CmdAddCustomer";
            this.CmdAddCustomer.Size = new System.Drawing.Size(94, 23);
            this.CmdAddCustomer.TabIndex = 4;
            this.CmdAddCustomer.Text = "Hinzufügen";
            this.CmdAddCustomer.UseVisualStyleBackColor = true;
            this.CmdAddCustomer.Click += new System.EventHandler(this.CmdAddArticle_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(112, 12);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 23);
            this.CmdDelete.TabIndex = 5;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(437, 12);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(75, 23);
            this.CmdSearch.TabIndex = 6;
            this.CmdSearch.Text = "Suchen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(331, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(100, 23);
            this.TxtSearch.TabIndex = 7;
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 396);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdAddCustomer);
            this.Controls.Add(this.DgvArticle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticleForm";
            this.Text = "Artikel";
            this.Load += new System.EventHandler(this.ArticleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgvArticle;
        private Button CmdAddCustomer;
        private Button CmdDelete;
        private Button CmdSearch;
        private TextBox TxtSearch;
        private DataGridViewTextBoxColumn colNr;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colArticleGroup;
        private DataGridViewButtonColumn colUpdateArticle;
    }
}