﻿namespace DBS_View.View
{
    partial class MainForm
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
            this.PnlSidebar = new System.Windows.Forms.Panel();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmdOrders = new System.Windows.Forms.Button();
            this.CmdArticleGroups = new System.Windows.Forms.Button();
            this.CmdArticle = new System.Windows.Forms.Button();
            this.CmdCustomer = new System.Windows.Forms.Button();
            this.PnlBack = new System.Windows.Forms.Panel();
            this.PnlMainPanel = new System.Windows.Forms.Panel();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlBack.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSidebar
            // 
            this.PnlSidebar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PnlSidebar.Controls.Add(this.CmdSearch);
            this.PnlSidebar.Controls.Add(this.pictureBox1);
            this.PnlSidebar.Controls.Add(this.CmdOrders);
            this.PnlSidebar.Controls.Add(this.CmdArticleGroups);
            this.PnlSidebar.Controls.Add(this.CmdArticle);
            this.PnlSidebar.Controls.Add(this.CmdCustomer);
            this.PnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.PnlSidebar.Name = "PnlSidebar";
            this.PnlSidebar.Size = new System.Drawing.Size(166, 477);
            this.PnlSidebar.TabIndex = 0;
            // 
            // CmdSearch
            // 
            this.CmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CmdSearch.Location = new System.Drawing.Point(3, 335);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(157, 47);
            this.CmdSearch.TabIndex = 5;
            this.CmdSearch.Text = "Rechnungen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DBS_View.Properties.Resources.user_networking;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CmdOrders
            // 
            this.CmdOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CmdOrders.Location = new System.Drawing.Point(3, 282);
            this.CmdOrders.Name = "CmdOrders";
            this.CmdOrders.Size = new System.Drawing.Size(157, 47);
            this.CmdOrders.TabIndex = 3;
            this.CmdOrders.Text = "Aufträge";
            this.CmdOrders.UseVisualStyleBackColor = true;
            this.CmdOrders.Click += new System.EventHandler(this.CmdOrders_Click);
            // 
            // CmdArticleGroups
            // 
            this.CmdArticleGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdArticleGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CmdArticleGroups.Location = new System.Drawing.Point(3, 229);
            this.CmdArticleGroups.Name = "CmdArticleGroups";
            this.CmdArticleGroups.Size = new System.Drawing.Size(157, 47);
            this.CmdArticleGroups.TabIndex = 2;
            this.CmdArticleGroups.Text = "Artikelgruppen";
            this.CmdArticleGroups.UseVisualStyleBackColor = true;
            this.CmdArticleGroups.Click += new System.EventHandler(this.CmdArticleGroup_Click);
            // 
            // CmdArticle
            // 
            this.CmdArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CmdArticle.Location = new System.Drawing.Point(3, 176);
            this.CmdArticle.Name = "CmdArticle";
            this.CmdArticle.Size = new System.Drawing.Size(157, 47);
            this.CmdArticle.TabIndex = 1;
            this.CmdArticle.Text = "Artikel";
            this.CmdArticle.UseVisualStyleBackColor = true;
            this.CmdArticle.Click += new System.EventHandler(this.CmdArticle_Click);
            // 
            // CmdCustomer
            // 
            this.CmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CmdCustomer.Location = new System.Drawing.Point(3, 123);
            this.CmdCustomer.Name = "CmdCustomer";
            this.CmdCustomer.Size = new System.Drawing.Size(157, 47);
            this.CmdCustomer.TabIndex = 2;
            this.CmdCustomer.Text = "Kunde";
            this.CmdCustomer.UseVisualStyleBackColor = true;
            this.CmdCustomer.Click += new System.EventHandler(this.CmdCustomers_Click);
            // 
            // PnlBack
            // 
            this.PnlBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PnlBack.Controls.Add(this.PnlMainPanel);
            this.PnlBack.Controls.Add(this.PnlTitle);
            this.PnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBack.Location = new System.Drawing.Point(166, 0);
            this.PnlBack.Name = "PnlBack";
            this.PnlBack.Size = new System.Drawing.Size(1116, 477);
            this.PnlBack.TabIndex = 4;
            // 
            // PnlMainPanel
            // 
            this.PnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainPanel.Location = new System.Drawing.Point(0, 47);
            this.PnlMainPanel.Name = "PnlMainPanel";
            this.PnlMainPanel.Size = new System.Drawing.Size(1116, 430);
            this.PnlMainPanel.TabIndex = 5;
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.Peru;
            this.PnlTitle.Controls.Add(this.LblTitle);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(1116, 47);
            this.PnlTitle.TabIndex = 4;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(6, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(66, 25);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Kunde";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1282, 477);
            this.Controls.Add(this.PnlBack);
            this.Controls.Add(this.PnlSidebar);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlBack.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlSidebar;
        private Button CmdCustomer;
        private Button CmdOrders;
        private Button CmdArticleGroups;
        private Button CmdArticle;
        private Panel PnlBack;
        private Label LblTitle;
        private PictureBox pictureBox1;
        private Panel PnlMainPanel;
        private Panel PnlTitle;
        private Button CmdSearch;
    }
}