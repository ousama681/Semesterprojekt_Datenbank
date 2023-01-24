namespace DBS_View.View
{
    partial class OrdersForm
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
            this.CmdAddPosition = new System.Windows.Forms.Button();
            this.CmdDeletePosition = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.DgVOrders = new System.Windows.Forms.DataGridView();
            this.colOrderNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbPositionen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdAddOrder = new System.Windows.Forms.Button();
            this.CmdDeleteOrder = new System.Windows.Forms.Button();
            this.NumQuantity = new System.Windows.Forms.NumericUpDown();
            this.TrVArticleGroupOrder = new System.Windows.Forms.TreeView();
            this.LblArticleName = new System.Windows.Forms.Label();
            this.CmbArticle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgVOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAddPosition
            // 
            this.CmdAddPosition.Location = new System.Drawing.Point(1724, 439);
            this.CmdAddPosition.Margin = new System.Windows.Forms.Padding(6);
            this.CmdAddPosition.Name = "CmdAddPosition";
            this.CmdAddPosition.Size = new System.Drawing.Size(225, 85);
            this.CmdAddPosition.TabIndex = 5;
            this.CmdAddPosition.Text = "Position hinzufügen";
            this.CmdAddPosition.UseVisualStyleBackColor = true;
            this.CmdAddPosition.Click += new System.EventHandler(this.CmdAddPosition_Click);
            // 
            // CmdDeletePosition
            // 
            this.CmdDeletePosition.Location = new System.Drawing.Point(1960, 439);
            this.CmdDeletePosition.Margin = new System.Windows.Forms.Padding(6);
            this.CmdDeletePosition.Name = "CmdDeletePosition";
            this.CmdDeletePosition.Size = new System.Drawing.Size(139, 85);
            this.CmdDeletePosition.TabIndex = 6;
            this.CmdDeletePosition.Text = "Position löschen";
            this.CmdDeletePosition.UseVisualStyleBackColor = true;
            this.CmdDeletePosition.Click += new System.EventHandler(this.CmdDeletePosition_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(1724, 819);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(221, 39);
            this.TxtSearch.TabIndex = 7;
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(1960, 819);
            this.CmdSearch.Margin = new System.Windows.Forms.Padding(6);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(139, 49);
            this.CmdSearch.TabIndex = 8;
            this.CmdSearch.Text = "Suchen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            // 
            // DgVOrders
            // 
            this.DgVOrders.AllowUserToDeleteRows = false;
            this.DgVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNr,
            this.colCustomerName});
            this.DgVOrders.Location = new System.Drawing.Point(22, 26);
            this.DgVOrders.Margin = new System.Windows.Forms.Padding(6);
            this.DgVOrders.Name = "DgVOrders";
            this.DgVOrders.ReadOnly = true;
            this.DgVOrders.RowHeadersVisible = false;
            this.DgVOrders.RowHeadersWidth = 82;
            this.DgVOrders.RowTemplate.Height = 25;
            this.DgVOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgVOrders.Size = new System.Drawing.Size(377, 841);
            this.DgVOrders.TabIndex = 9;
            this.DgVOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgVOrders_CellDoubleClick);
            // 
            // colOrderNr
            // 
            this.colOrderNr.FillWeight = 40F;
            this.colOrderNr.HeaderText = "Auftragsnr";
            this.colOrderNr.MinimumWidth = 10;
            this.colOrderNr.Name = "colOrderNr";
            this.colOrderNr.ReadOnly = true;
            this.colOrderNr.Width = 80;
            // 
            // colCustomerName
            // 
            this.colCustomerName.HeaderText = "Kundenname";
            this.colCustomerName.MinimumWidth = 10;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            this.colCustomerName.Width = 120;
            // 
            // LbPositionen
            // 
            this.LbPositionen.FormattingEnabled = true;
            this.LbPositionen.ItemHeight = 32;
            this.LbPositionen.Location = new System.Drawing.Point(427, 26);
            this.LbPositionen.Margin = new System.Windows.Forms.Padding(6);
            this.LbPositionen.Name = "LbPositionen";
            this.LbPositionen.Size = new System.Drawing.Size(845, 836);
            this.LbPositionen.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1724, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 41);
            this.label1.TabIndex = 39;
            this.label1.Text = "Anzahl";
            // 
            // CmbCustomer
            // 
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Location = new System.Drawing.Point(1724, 77);
            this.CmbCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(368, 40);
            this.CmbCustomer.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1724, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 41);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kunde";
            // 
            // CmdAddOrder
            // 
            this.CmdAddOrder.Location = new System.Drawing.Point(1724, 685);
            this.CmdAddOrder.Margin = new System.Windows.Forms.Padding(6);
            this.CmdAddOrder.Name = "CmdAddOrder";
            this.CmdAddOrder.Size = new System.Drawing.Size(225, 85);
            this.CmdAddOrder.TabIndex = 44;
            this.CmdAddOrder.Text = "Auftrag erstellen";
            this.CmdAddOrder.UseVisualStyleBackColor = true;
            this.CmdAddOrder.Click += new System.EventHandler(this.CmdAddOrder_Click);
            // 
            // CmdDeleteOrder
            // 
            this.CmdDeleteOrder.Location = new System.Drawing.Point(1960, 685);
            this.CmdDeleteOrder.Margin = new System.Windows.Forms.Padding(6);
            this.CmdDeleteOrder.Name = "CmdDeleteOrder";
            this.CmdDeleteOrder.Size = new System.Drawing.Size(139, 85);
            this.CmdDeleteOrder.TabIndex = 45;
            this.CmdDeleteOrder.Text = "Auftrag löschen";
            this.CmdDeleteOrder.UseVisualStyleBackColor = true;
            this.CmdDeleteOrder.Click += new System.EventHandler(this.CmdDeleteOrder_Click);
            // 
            // NumQuantity
            // 
            this.NumQuantity.Location = new System.Drawing.Point(1726, 343);
            this.NumQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(98, 39);
            this.NumQuantity.TabIndex = 46;
            // 
            // TrVArticleGroupOrder
            // 
            this.TrVArticleGroupOrder.Location = new System.Drawing.Point(1296, 26);
            this.TrVArticleGroupOrder.Margin = new System.Windows.Forms.Padding(6);
            this.TrVArticleGroupOrder.Name = "TrVArticleGroupOrder";
            this.TrVArticleGroupOrder.Size = new System.Drawing.Size(396, 832);
            this.TrVArticleGroupOrder.TabIndex = 47;
            this.TrVArticleGroupOrder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrVArticleGroupOrder_AfterSelect);
            // 
            // LblArticleName
            // 
            this.LblArticleName.AutoSize = true;
            this.LblArticleName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblArticleName.Location = new System.Drawing.Point(1724, 158);
            this.LblArticleName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblArticleName.Name = "LblArticleName";
            this.LblArticleName.Size = new System.Drawing.Size(176, 41);
            this.LblArticleName.TabIndex = 36;
            this.LblArticleName.Text = "Artikelname";
            // 
            // CmbArticle
            // 
            this.CmbArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbArticle.FormattingEnabled = true;
            this.CmbArticle.Location = new System.Drawing.Point(1724, 207);
            this.CmbArticle.Margin = new System.Windows.Forms.Padding(6);
            this.CmbArticle.Name = "CmbArticle";
            this.CmbArticle.Size = new System.Drawing.Size(368, 40);
            this.CmbArticle.TabIndex = 37;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2132, 917);
            this.Controls.Add(this.TrVArticleGroupOrder);
            this.Controls.Add(this.NumQuantity);
            this.Controls.Add(this.CmdDeleteOrder);
            this.Controls.Add(this.CmdAddOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbArticle);
            this.Controls.Add(this.LblArticleName);
            this.Controls.Add(this.LbPositionen);
            this.Controls.Add(this.DgVOrders);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CmdDeletePosition);
            this.Controls.Add(this.CmdAddPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OrdersForm";
            this.Text = "Aufträge";
            ((System.ComponentModel.ISupportInitialize)(this.DgVOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CmdAddPosition;
        private Button CmdDeletePosition;
        private TextBox TxtSearch;
        private Button CmdSearch;
        private DataGridView DgVOrders;
        private ListBox LbPositionen;
        private Label label1;
        private ComboBox CmbCustomer;
        private Label label3;
        private Button CmdAddOrder;
        private Button CmdDeleteOrder;
        private DataGridViewTextBoxColumn colOrderNr;
        private DataGridViewTextBoxColumn colCustomerName;
        private NumericUpDown NumQuantity;
        private TreeView TrVArticleGroupOrder;
        private Label LblArticleName;
        private ComboBox CmbArticle;
    }
}