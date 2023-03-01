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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdAddOrder = new System.Windows.Forms.Button();
            this.CmdDeleteOrder = new System.Windows.Forms.Button();
            this.NumQuantity = new System.Windows.Forms.NumericUpDown();
            this.TrVArticleGroupOrder = new System.Windows.Forms.TreeView();
            this.LblArticleName = new System.Windows.Forms.Label();
            this.CmbArticle = new System.Windows.Forms.ComboBox();
            this.DgVPositions = new System.Windows.Forms.DataGridView();
            this.Positionsnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBrutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdGenerateInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgVOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgVPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAddPosition
            // 
            this.CmdAddPosition.Location = new System.Drawing.Point(903, 204);
            this.CmdAddPosition.Name = "CmdAddPosition";
            this.CmdAddPosition.Size = new System.Drawing.Size(121, 40);
            this.CmdAddPosition.TabIndex = 5;
            this.CmdAddPosition.Text = "Position hinzufügen";
            this.CmdAddPosition.UseVisualStyleBackColor = true;
            this.CmdAddPosition.Click += new System.EventHandler(this.CmdAddPosition_Click);
            // 
            // CmdDeletePosition
            // 
            this.CmdDeletePosition.Location = new System.Drawing.Point(1030, 204);
            this.CmdDeletePosition.Name = "CmdDeletePosition";
            this.CmdDeletePosition.Size = new System.Drawing.Size(75, 40);
            this.CmdDeletePosition.TabIndex = 6;
            this.CmdDeletePosition.Text = "Position löschen";
            this.CmdDeletePosition.UseVisualStyleBackColor = true;
            this.CmdDeletePosition.Click += new System.EventHandler(this.CmdDeletePosition_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(903, 382);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(121, 23);
            this.TxtSearch.TabIndex = 7;
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(1030, 382);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(75, 23);
            this.CmdSearch.TabIndex = 8;
            this.CmdSearch.Text = "Suchen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            // 
            // DgVOrders
            // 
            this.DgVOrders.AllowUserToAddRows = false;
            this.DgVOrders.AllowUserToDeleteRows = false;
            this.DgVOrders.AllowUserToResizeColumns = false;
            this.DgVOrders.AllowUserToResizeRows = false;
            this.DgVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNr,
            this.colCustomerName});
            this.DgVOrders.Location = new System.Drawing.Point(12, 12);
            this.DgVOrders.Name = "DgVOrders";
            this.DgVOrders.ReadOnly = true;
            this.DgVOrders.RowHeadersVisible = false;
            this.DgVOrders.RowHeadersWidth = 82;
            this.DgVOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgVOrders.RowTemplate.Height = 25;
            this.DgVOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgVOrders.Size = new System.Drawing.Size(227, 394);
            this.DgVOrders.TabIndex = 9;
            this.DgVOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgVOrders_CellDoubleClick);
            this.DgVOrders.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgVOrders_RowEnter);
            // 
            // colOrderNr
            // 
            this.colOrderNr.FillWeight = 30F;
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
            this.colCustomerName.Width = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(903, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Anzahl";
            // 
            // CmbCustomer
            // 
            this.CmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Location = new System.Drawing.Point(903, 34);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(200, 23);
            this.CmbCustomer.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(903, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kunde";
            // 
            // CmdAddOrder
            // 
            this.CmdAddOrder.Location = new System.Drawing.Point(903, 265);
            this.CmdAddOrder.Name = "CmdAddOrder";
            this.CmdAddOrder.Size = new System.Drawing.Size(121, 40);
            this.CmdAddOrder.TabIndex = 44;
            this.CmdAddOrder.Text = "Auftrag erstellen";
            this.CmdAddOrder.UseVisualStyleBackColor = true;
            this.CmdAddOrder.Click += new System.EventHandler(this.CmdAddOrder_Click);
            // 
            // CmdDeleteOrder
            // 
            this.CmdDeleteOrder.Location = new System.Drawing.Point(1030, 265);
            this.CmdDeleteOrder.Name = "CmdDeleteOrder";
            this.CmdDeleteOrder.Size = new System.Drawing.Size(75, 40);
            this.CmdDeleteOrder.TabIndex = 45;
            this.CmdDeleteOrder.Text = "Auftrag löschen";
            this.CmdDeleteOrder.UseVisualStyleBackColor = true;
            this.CmdDeleteOrder.Click += new System.EventHandler(this.CmdDeleteOrder_Click);
            // 
            // NumQuantity
            // 
            this.NumQuantity.Location = new System.Drawing.Point(904, 159);
            this.NumQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(53, 23);
            this.NumQuantity.TabIndex = 46;
            this.NumQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TrVArticleGroupOrder
            // 
            this.TrVArticleGroupOrder.Location = new System.Drawing.Point(655, 12);
            this.TrVArticleGroupOrder.Name = "TrVArticleGroupOrder";
            this.TrVArticleGroupOrder.Size = new System.Drawing.Size(242, 394);
            this.TrVArticleGroupOrder.TabIndex = 47;
            this.TrVArticleGroupOrder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrVArticleGroupOrder_AfterSelect);
            // 
            // LblArticleName
            // 
            this.LblArticleName.AutoSize = true;
            this.LblArticleName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblArticleName.Location = new System.Drawing.Point(903, 72);
            this.LblArticleName.Name = "LblArticleName";
            this.LblArticleName.Size = new System.Drawing.Size(89, 20);
            this.LblArticleName.TabIndex = 36;
            this.LblArticleName.Text = "Artikelname";
            // 
            // CmbArticle
            // 
            this.CmbArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbArticle.FormattingEnabled = true;
            this.CmbArticle.Location = new System.Drawing.Point(903, 95);
            this.CmbArticle.Name = "CmbArticle";
            this.CmbArticle.Size = new System.Drawing.Size(200, 23);
            this.CmbArticle.TabIndex = 37;
            // 
            // DgVPositions
            // 
            this.DgVPositions.AllowUserToAddRows = false;
            this.DgVPositions.AllowUserToDeleteRows = false;
            this.DgVPositions.AllowUserToResizeColumns = false;
            this.DgVPositions.AllowUserToResizeRows = false;
            this.DgVPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Positionsnr,
            this.Articlename,
            this.Quantity,
            this.PriceBrutto});
            this.DgVPositions.Location = new System.Drawing.Point(245, 12);
            this.DgVPositions.Name = "DgVPositions";
            this.DgVPositions.ReadOnly = true;
            this.DgVPositions.RowHeadersVisible = false;
            this.DgVPositions.RowHeadersWidth = 82;
            this.DgVPositions.RowTemplate.Height = 25;
            this.DgVPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgVPositions.Size = new System.Drawing.Size(404, 394);
            this.DgVPositions.TabIndex = 48;
            // 
            // Positionsnr
            // 
            this.Positionsnr.HeaderText = "Positionnr";
            this.Positionsnr.Name = "Positionsnr";
            this.Positionsnr.ReadOnly = true;
            // 
            // Articlename
            // 
            this.Articlename.HeaderText = "Artikelname";
            this.Articlename.Name = "Articlename";
            this.Articlename.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Anzahl";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // PriceBrutto
            // 
            this.PriceBrutto.HeaderText = "Preis";
            this.PriceBrutto.Name = "PriceBrutto";
            this.PriceBrutto.ReadOnly = true;
            // 
            // CmdGenerateInvoice
            // 
            this.CmdGenerateInvoice.Location = new System.Drawing.Point(903, 322);
            this.CmdGenerateInvoice.Name = "CmdGenerateInvoice";
            this.CmdGenerateInvoice.Size = new System.Drawing.Size(121, 40);
            this.CmdGenerateInvoice.TabIndex = 49;
            this.CmdGenerateInvoice.Text = "Rechnung erstellen";
            this.CmdGenerateInvoice.UseVisualStyleBackColor = true;
            this.CmdGenerateInvoice.Click += new System.EventHandler(this.CmdGenerateInvoice_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 420);
            this.Controls.Add(this.CmdGenerateInvoice);
            this.Controls.Add(this.DgVPositions);
            this.Controls.Add(this.TrVArticleGroupOrder);
            this.Controls.Add(this.NumQuantity);
            this.Controls.Add(this.CmdDeleteOrder);
            this.Controls.Add(this.CmdAddOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbArticle);
            this.Controls.Add(this.LblArticleName);
            this.Controls.Add(this.DgVOrders);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CmdDeletePosition);
            this.Controls.Add(this.CmdAddPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersForm";
            this.Text = "Aufträge";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgVOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgVPositions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CmdAddPosition;
        private Button CmdDeletePosition;
        private TextBox TxtSearch;
        private Button CmdSearch;
        private DataGridView DgVOrders;
        private Label label1;
        private ComboBox CmbCustomer;
        private Label label3;
        private Button CmdAddOrder;
        private Button CmdDeleteOrder;
        private NumericUpDown NumQuantity;
        private TreeView TrVArticleGroupOrder;
        private Label LblArticleName;
        private ComboBox CmbArticle;
        private DataGridViewTextBoxColumn colOrderNr;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridView DgVPositions;
        private DataGridViewTextBoxColumn Positionsnr;
        private DataGridViewTextBoxColumn Articlename;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn PriceBrutto;
        private Button CmdGenerateInvoice;
    }
}