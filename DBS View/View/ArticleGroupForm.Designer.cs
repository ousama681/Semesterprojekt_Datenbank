namespace DBS_View.View
{
    partial class ArticleGroupForm
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
            this.TrVArticleGroup = new System.Windows.Forms.TreeView();
            this.CmdAddArticleGroup = new System.Windows.Forms.Button();
            this.CmdDeleteArticleGroup = new System.Windows.Forms.Button();
            this.TxtSearchArticleGroup = new System.Windows.Forms.TextBox();
            this.CmdSearchArticleGroup = new System.Windows.Forms.Button();
            this.TxtAddArticleGroup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TrVArticleGroup
            // 
            this.TrVArticleGroup.Location = new System.Drawing.Point(167, 12);
            this.TrVArticleGroup.Name = "TrVArticleGroup";
            this.TrVArticleGroup.Size = new System.Drawing.Size(362, 372);
            this.TrVArticleGroup.TabIndex = 0;
            // 
            // CmdAddArticleGroup
            // 
            this.CmdAddArticleGroup.Location = new System.Drawing.Point(12, 110);
            this.CmdAddArticleGroup.Name = "CmdAddArticleGroup";
            this.CmdAddArticleGroup.Size = new System.Drawing.Size(131, 23);
            this.CmdAddArticleGroup.TabIndex = 1;
            this.CmdAddArticleGroup.Text = "Hinzufügen";
            this.CmdAddArticleGroup.UseVisualStyleBackColor = true;
            this.CmdAddArticleGroup.Click += new System.EventHandler(this.CmdAddArticleGroup_Click);
            // 
            // CmdDeleteArticleGroup
            // 
            this.CmdDeleteArticleGroup.Location = new System.Drawing.Point(12, 168);
            this.CmdDeleteArticleGroup.Name = "CmdDeleteArticleGroup";
            this.CmdDeleteArticleGroup.Size = new System.Drawing.Size(131, 23);
            this.CmdDeleteArticleGroup.TabIndex = 2;
            this.CmdDeleteArticleGroup.Text = "Löschen";
            this.CmdDeleteArticleGroup.UseVisualStyleBackColor = true;
            this.CmdDeleteArticleGroup.Click += new System.EventHandler(this.CmdDeleteArticleGroup_Click);
            // 
            // TxtSearchArticleGroup
            // 
            this.TxtSearchArticleGroup.Location = new System.Drawing.Point(12, 23);
            this.TxtSearchArticleGroup.Name = "TxtSearchArticleGroup";
            this.TxtSearchArticleGroup.Size = new System.Drawing.Size(131, 23);
            this.TxtSearchArticleGroup.TabIndex = 3;
            // 
            // CmdSearchArticleGroup
            // 
            this.CmdSearchArticleGroup.Location = new System.Drawing.Point(12, 52);
            this.CmdSearchArticleGroup.Name = "CmdSearchArticleGroup";
            this.CmdSearchArticleGroup.Size = new System.Drawing.Size(131, 23);
            this.CmdSearchArticleGroup.TabIndex = 4;
            this.CmdSearchArticleGroup.Text = "Suchen";
            this.CmdSearchArticleGroup.UseVisualStyleBackColor = true;
            this.CmdSearchArticleGroup.Click += new System.EventHandler(this.CmdSearchArticleGroup_Click);
            // 
            // TxtAddArticleGroup
            // 
            this.TxtAddArticleGroup.Location = new System.Drawing.Point(12, 139);
            this.TxtAddArticleGroup.Name = "TxtAddArticleGroup";
            this.TxtAddArticleGroup.Size = new System.Drawing.Size(131, 23);
            this.TxtAddArticleGroup.TabIndex = 5;
            // 
            // ArticleGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 396);
            this.Controls.Add(this.TxtAddArticleGroup);
            this.Controls.Add(this.CmdSearchArticleGroup);
            this.Controls.Add(this.TxtSearchArticleGroup);
            this.Controls.Add(this.CmdDeleteArticleGroup);
            this.Controls.Add(this.CmdAddArticleGroup);
            this.Controls.Add(this.TrVArticleGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticleGroupForm";
            this.Text = "Artikelgruppen";
            this.Load += new System.EventHandler(this.ArticleGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView TrVArticleGroup;
        private Button CmdAddArticleGroup;
        private Button CmdDeleteArticleGroup;
        private TextBox TxtSearchArticleGroup;
        private Button CmdSearchArticleGroup;
        private TextBox TxtAddArticleGroup;
    }
}