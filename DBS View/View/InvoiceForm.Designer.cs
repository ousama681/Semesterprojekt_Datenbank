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
            this.DgvSearch = new System.Windows.Forms.DataGridView();
            this.articleGroupVmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleVmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RadSuche = new System.Windows.Forms.RadioButton();
            this.RadQuarterlyView = new System.Windows.Forms.RadioButton();
            this.GbxFilter = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Cbx = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleGroupVmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleVmBindingSource)).BeginInit();
            this.GbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvSearch
            // 
            this.DgvSearch.AllowUserToAddRows = false;
            this.DgvSearch.AllowUserToDeleteRows = false;
            this.DgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearch.Location = new System.Drawing.Point(12, 12);
            this.DgvSearch.Name = "DgvSearch";
            this.DgvSearch.ReadOnly = true;
            this.DgvSearch.RowTemplate.Height = 25;
            this.DgvSearch.Size = new System.Drawing.Size(921, 357);
            this.DgvSearch.TabIndex = 0;
            // 
            // articleGroupVmBindingSource
            // 
            this.articleGroupVmBindingSource.DataSource = typeof(Semesterprojekt_Datenbank.Viewmodel.ArticleGroupVm);
            // 
            // articleVmBindingSource
            // 
            this.articleVmBindingSource.DataSource = typeof(Semesterprojekt_Datenbank.Viewmodel.ArticleVm);
            // 
            // RadSuche
            // 
            this.RadSuche.AutoSize = true;
            this.RadSuche.Location = new System.Drawing.Point(1031, 20);
            this.RadSuche.Name = "RadSuche";
            this.RadSuche.Size = new System.Drawing.Size(57, 19);
            this.RadSuche.TabIndex = 1;
            this.RadSuche.TabStop = true;
            this.RadSuche.Text = "Suche";
            this.RadSuche.UseVisualStyleBackColor = true;
            // 
            // RadQuarterlyView
            // 
            this.RadQuarterlyView.AutoSize = true;
            this.RadQuarterlyView.Location = new System.Drawing.Point(970, 45);
            this.RadQuarterlyView.Name = "RadQuarterlyView";
            this.RadQuarterlyView.Size = new System.Drawing.Size(118, 19);
            this.RadQuarterlyView.TabIndex = 2;
            this.RadQuarterlyView.TabStop = true;
            this.RadQuarterlyView.Text = "Quartalsübersicht";
            this.RadQuarterlyView.UseVisualStyleBackColor = true;
            // 
            // GbxFilter
            // 
            this.GbxFilter.Controls.Add(this.checkBox5);
            this.GbxFilter.Controls.Add(this.checkBox6);
            this.GbxFilter.Controls.Add(this.checkBox11);
            this.GbxFilter.Controls.Add(this.checkBox7);
            this.GbxFilter.Controls.Add(this.checkBox12);
            this.GbxFilter.Controls.Add(this.checkBox8);
            this.GbxFilter.Controls.Add(this.checkBox3);
            this.GbxFilter.Controls.Add(this.checkBox4);
            this.GbxFilter.Controls.Add(this.checkBox2);
            this.GbxFilter.Controls.Add(this.Cbx);
            this.GbxFilter.Location = new System.Drawing.Point(939, 99);
            this.GbxFilter.Name = "GbxFilter";
            this.GbxFilter.Size = new System.Drawing.Size(149, 270);
            this.GbxFilter.TabIndex = 3;
            this.GbxFilter.TabStop = false;
            this.GbxFilter.Text = "Filter";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 197);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(83, 19);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 172);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(83, 19);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(6, 247);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(89, 19);
            this.checkBox11.TabIndex = 5;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 147);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(83, 19);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(6, 222);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(89, 19);
            this.checkBox12.TabIndex = 4;
            this.checkBox12.Text = "checkBox12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(6, 122);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(83, 19);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 97);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 19);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 72);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(83, 19);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Cbx
            // 
            this.Cbx.AutoSize = true;
            this.Cbx.Location = new System.Drawing.Point(6, 22);
            this.Cbx.Name = "Cbx";
            this.Cbx.Size = new System.Drawing.Size(83, 19);
            this.Cbx.TabIndex = 0;
            this.Cbx.Text = "checkBox1";
            this.Cbx.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(939, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 23);
            this.textBox1.TabIndex = 4;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 381);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GbxFilter);
            this.Controls.Add(this.RadQuarterlyView);
            this.Controls.Add(this.RadSuche);
            this.Controls.Add(this.DgvSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "Rechnungen";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleGroupVmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleVmBindingSource)).EndInit();
            this.GbxFilter.ResumeLayout(false);
            this.GbxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgvSearch;
        private BindingSource articleGroupVmBindingSource;
        private BindingSource articleVmBindingSource;
        private RadioButton RadSuche;
        private RadioButton RadQuarterlyView;
        private GroupBox GbxFilter;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox11;
        private CheckBox checkBox7;
        private CheckBox checkBox12;
        private CheckBox checkBox8;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox2;
        private CheckBox Cbx;
        private TextBox textBox1;
    }
}