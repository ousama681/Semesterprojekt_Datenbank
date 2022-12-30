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
            this.trVArticleGroup = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trVArticleGroup
            // 
            this.trVArticleGroup.Location = new System.Drawing.Point(12, 12);
            this.trVArticleGroup.Name = "trVArticleGroup";
            this.trVArticleGroup.Size = new System.Drawing.Size(358, 372);
            this.trVArticleGroup.TabIndex = 0;
            // 
            // ArticleGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 396);
            this.Controls.Add(this.trVArticleGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticleGroupForm";
            this.Text = "Artikelgruppen";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView trVArticleGroup;
    }
}