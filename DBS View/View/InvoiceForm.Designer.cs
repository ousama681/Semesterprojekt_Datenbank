namespace DBS_View.View
{
    partial class InvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.articleGroupVmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleVmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdvDgvInvoice = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.articleGroupVmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleVmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvDgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // articleGroupVmBindingSource
            // 
            this.articleGroupVmBindingSource.DataSource = typeof(Semesterprojekt_Datenbank.Viewmodel.ArticleGroupVm);
            // 
            // articleVmBindingSource
            // 
            this.articleVmBindingSource.DataSource = typeof(Semesterprojekt_Datenbank.Viewmodel.ArticleVm);
            // 
            // AdvDgvInvoice
            // 
            this.AdvDgvInvoice.AllowUserToAddRows = false;
            this.AdvDgvInvoice.AllowUserToDeleteRows = false;
            this.AdvDgvInvoice.AllowUserToOrderColumns = true;
            this.AdvDgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdvDgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AdvDgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdvDgvInvoice.FilterAndSortEnabled = true;
            this.AdvDgvInvoice.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.AdvDgvInvoice.Location = new System.Drawing.Point(12, 12);
            this.AdvDgvInvoice.Name = "AdvDgvInvoice";
            this.AdvDgvInvoice.ReadOnly = true;
            this.AdvDgvInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdvDgvInvoice.RowHeadersVisible = false;
            this.AdvDgvInvoice.RowTemplate.Height = 25;
            this.AdvDgvInvoice.Size = new System.Drawing.Size(1076, 357);
            this.AdvDgvInvoice.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.AdvDgvInvoice.TabIndex = 5;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 381);
            this.Controls.Add(this.AdvDgvInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceForm";
            this.Text = "Rechnungen";
            ((System.ComponentModel.ISupportInitialize)(this.articleGroupVmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleVmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvDgvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource articleGroupVmBindingSource;
        private BindingSource articleVmBindingSource;
        private Zuby.ADGV.AdvancedDataGridView AdvDgvInvoice;
    }
}