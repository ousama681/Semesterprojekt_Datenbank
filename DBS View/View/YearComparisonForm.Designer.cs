namespace DBS_View.View
{
    partial class YearComparisonForm
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
            this.DgVJahresvergleich = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgVJahresvergleich)).BeginInit();
            this.SuspendLayout();
            // 
            // DgVJahresvergleich
            // 
            this.DgVJahresvergleich.AllowUserToAddRows = false;
            this.DgVJahresvergleich.AllowUserToDeleteRows = false;
            this.DgVJahresvergleich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVJahresvergleich.Location = new System.Drawing.Point(0, 0);
            this.DgVJahresvergleich.Name = "DgVJahresvergleich";
            this.DgVJahresvergleich.ReadOnly = true;
            this.DgVJahresvergleich.RowHeadersVisible = false;
            this.DgVJahresvergleich.RowTemplate.Height = 25;
            this.DgVJahresvergleich.Size = new System.Drawing.Size(1116, 336);
            this.DgVJahresvergleich.TabIndex = 0;
            // 
            // YearComparisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 420);
            this.Controls.Add(this.DgVJahresvergleich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YearComparisonForm";
            this.Text = "Jahresvergleich";
            ((System.ComponentModel.ISupportInitialize)(this.DgVJahresvergleich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DgVJahresvergleich;
    }
}