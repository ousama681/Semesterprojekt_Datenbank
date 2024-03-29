﻿namespace DBS_View.View
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            this.customerVmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.townBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdAddCustomer = new System.Windows.Forms.Button();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.DgvCustomer = new System.Windows.Forms.DataGridView();
            this.colNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerVmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.townBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // customerVmBindingSource
            // 
            this.customerVmBindingSource.DataSource = typeof(Semesterprojekt_Datenbank.Viewmodel.CustomerVm);
            // 
            // townBindingSource
            // 
            this.townBindingSource.DataSource = typeof(Semesterprojekt_Datenbank.Model.Town);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(341, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(100, 23);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(112, 12);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 23);
            this.CmdDelete.TabIndex = 2;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdAddCustomer
            // 
            this.CmdAddCustomer.Location = new System.Drawing.Point(12, 12);
            this.CmdAddCustomer.Name = "CmdAddCustomer";
            this.CmdAddCustomer.Size = new System.Drawing.Size(94, 23);
            this.CmdAddCustomer.TabIndex = 3;
            this.CmdAddCustomer.Text = "Hinzufügen";
            this.CmdAddCustomer.UseVisualStyleBackColor = true;
            this.CmdAddCustomer.Click += new System.EventHandler(this.CmdAddCustomer_Click);
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(447, 12);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(75, 23);
            this.CmdSearch.TabIndex = 4;
            this.CmdSearch.Text = "Suchen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // DgvCustomer
            // 
            this.DgvCustomer.AllowUserToAddRows = false;
            this.DgvCustomer.AllowUserToDeleteRows = false;
            this.DgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNr,
            this.colName,
            this.colEmail,
            this.colWebsite,
            this.colStreet,
            this.colTown,
            this.colZipCode,
            this.ColUpdate});
            this.DgvCustomer.Location = new System.Drawing.Point(12, 41);
            this.DgvCustomer.Name = "DgvCustomer";
            this.DgvCustomer.ReadOnly = true;
            this.DgvCustomer.RowHeadersVisible = false;
            this.DgvCustomer.RowTemplate.Height = 25;
            this.DgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvCustomer.Size = new System.Drawing.Size(901, 396);
            this.DgvCustomer.TabIndex = 0;
            this.DgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataResultList_CellContentClick);
            // 
            // colNr
            // 
            this.colNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNr.FillWeight = 18F;
            this.colNr.HeaderText = "Nr";
            this.colNr.Name = "colNr";
            this.colNr.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.FillWeight = 30.20566F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.FillWeight = 30.20566F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colWebsite
            // 
            this.colWebsite.FillWeight = 30.20566F;
            this.colWebsite.HeaderText = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.ReadOnly = true;
            // 
            // colStreet
            // 
            this.colStreet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStreet.FillWeight = 30.20566F;
            this.colStreet.HeaderText = "Street";
            this.colStreet.Name = "colStreet";
            this.colStreet.ReadOnly = true;
            // 
            // colTown
            // 
            this.colTown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTown.FillWeight = 30.20566F;
            this.colTown.HeaderText = "Town";
            this.colTown.Name = "colTown";
            this.colTown.ReadOnly = true;
            // 
            // colZipCode
            // 
            this.colZipCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colZipCode.FillWeight = 30.20566F;
            this.colZipCode.HeaderText = "Zip Code";
            this.colZipCode.Name = "colZipCode";
            this.colZipCode.ReadOnly = true;
            // 
            // ColUpdate
            // 
            this.ColUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUpdate.FillWeight = 150F;
            this.ColUpdate.HeaderText = "Bearbeiten";
            this.ColUpdate.Name = "ColUpdate";
            this.ColUpdate.ReadOnly = true;
            this.ColUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColUpdate.Text = "Bearbeiten";
            this.ColUpdate.UseColumnTextForButtonValue = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.CmdAddCustomer);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "Kunden";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerVmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.townBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource customerVmBindingSource;
        private BindingSource townBindingSource;
        private TextBox TxtSearch;
        private Button CmdDelete;
        private Button CmdAddCustomer;
        private Button CmdSearch;
        private DataGridView DgvCustomer;
        private DataGridViewTextBoxColumn colNr;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colWebsite;
        private DataGridViewTextBoxColumn colStreet;
        private DataGridViewTextBoxColumn colTown;
        private DataGridViewTextBoxColumn colZipCode;
        private DataGridViewButtonColumn ColUpdate;
    }
}