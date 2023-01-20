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
            this.CmdAddArticleGroup = new System.Windows.Forms.Button();
            this.CmdDeleteArticleGroup = new System.Windows.Forms.Button();
            this.TxtSearchArticleGroup = new System.Windows.Forms.TextBox();
            this.CmdSearchArticleGroup = new System.Windows.Forms.Button();
            this.TxtAddArticleGroup = new System.Windows.Forms.TextBox();
            this.LblStreet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdAdjustArticleGroups = new System.Windows.Forms.Button();
            this.TrVArticleGroup = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // CmdAddArticleGroup
            // 
            this.CmdAddArticleGroup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdAddArticleGroup.Location = new System.Drawing.Point(12, 303);
            this.CmdAddArticleGroup.Name = "CmdAddArticleGroup";
            this.CmdAddArticleGroup.Size = new System.Drawing.Size(164, 29);
            this.CmdAddArticleGroup.TabIndex = 1;
            this.CmdAddArticleGroup.Text = "Hinzufügen";
            this.CmdAddArticleGroup.UseVisualStyleBackColor = true;
            this.CmdAddArticleGroup.Click += new System.EventHandler(this.CmdAddArticleGroup_Click);
            // 
            // CmdDeleteArticleGroup
            // 
            this.CmdDeleteArticleGroup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdDeleteArticleGroup.Location = new System.Drawing.Point(12, 354);
            this.CmdDeleteArticleGroup.Name = "CmdDeleteArticleGroup";
            this.CmdDeleteArticleGroup.Size = new System.Drawing.Size(164, 30);
            this.CmdDeleteArticleGroup.TabIndex = 2;
            this.CmdDeleteArticleGroup.Text = "Löschen";
            this.CmdDeleteArticleGroup.UseVisualStyleBackColor = true;
            this.CmdDeleteArticleGroup.Click += new System.EventHandler(this.CmdDeleteArticleGroup_Click);
            // 
            // TxtSearchArticleGroup
            // 
            this.TxtSearchArticleGroup.Location = new System.Drawing.Point(12, 35);
            this.TxtSearchArticleGroup.Name = "TxtSearchArticleGroup";
            this.TxtSearchArticleGroup.Size = new System.Drawing.Size(164, 23);
            this.TxtSearchArticleGroup.TabIndex = 3;
            // 
            // CmdSearchArticleGroup
            // 
            this.CmdSearchArticleGroup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdSearchArticleGroup.Location = new System.Drawing.Point(12, 64);
            this.CmdSearchArticleGroup.Name = "CmdSearchArticleGroup";
            this.CmdSearchArticleGroup.Size = new System.Drawing.Size(164, 29);
            this.CmdSearchArticleGroup.TabIndex = 4;
            this.CmdSearchArticleGroup.Text = "Suchen";
            this.CmdSearchArticleGroup.UseVisualStyleBackColor = true;
            this.CmdSearchArticleGroup.Click += new System.EventHandler(this.CmdSearchArticleGroup_Click);
            // 
            // TxtAddArticleGroup
            // 
            this.TxtAddArticleGroup.Location = new System.Drawing.Point(12, 274);
            this.TxtAddArticleGroup.Name = "TxtAddArticleGroup";
            this.TxtAddArticleGroup.Size = new System.Drawing.Size(164, 23);
            this.TxtAddArticleGroup.TabIndex = 5;
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStreet.Location = new System.Drawing.Point(12, 12);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(164, 20);
            this.LblStreet.TabIndex = 11;
            this.LblStreet.Text = "Artikelgruppe anzeigen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Artikelgruppe hinzufügen";
            // 
            // CmdAdjustArticleGroups
            // 
            this.CmdAdjustArticleGroups.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdAdjustArticleGroups.Location = new System.Drawing.Point(12, 201);
            this.CmdAdjustArticleGroups.Name = "CmdAdjustArticleGroups";
            this.CmdAdjustArticleGroups.Size = new System.Drawing.Size(164, 29);
            this.CmdAdjustArticleGroups.TabIndex = 13;
            this.CmdAdjustArticleGroups.Text = "Bearbeiten";
            this.CmdAdjustArticleGroups.UseVisualStyleBackColor = true;
            this.CmdAdjustArticleGroups.Click += new System.EventHandler(this.CmdAdjustArticleGroups_Click);
            // 
            // TrVArticleGroup
            // 
            this.TrVArticleGroup.Location = new System.Drawing.Point(300, 12);
            this.TrVArticleGroup.Name = "TrVArticleGroup";
            this.TrVArticleGroup.Size = new System.Drawing.Size(225, 368);
            this.TrVArticleGroup.TabIndex = 15;
            this.TrVArticleGroup.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TrVArticleGroup_AfterCheck);
            // 
            // ArticleGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 396);
            this.Controls.Add(this.TrVArticleGroup);
            this.Controls.Add(this.CmdAdjustArticleGroups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblStreet);
            this.Controls.Add(this.TxtAddArticleGroup);
            this.Controls.Add(this.CmdSearchArticleGroup);
            this.Controls.Add(this.TxtSearchArticleGroup);
            this.Controls.Add(this.CmdDeleteArticleGroup);
            this.Controls.Add(this.CmdAddArticleGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticleGroupForm";
            this.Text = "Artikelgruppen";
            this.Load += new System.EventHandler(this.ArticleGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CmdAddArticleGroup;
        private Button CmdDeleteArticleGroup;
        private TextBox TxtSearchArticleGroup;
        private Button CmdSearchArticleGroup;
        private TextBox TxtAddArticleGroup;
        private Label LblStreet;
        private Label label1;
        private Button CmdAdjustArticleGroups;
        private TreeView TrVArticleGroup;
    }
}