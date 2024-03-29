﻿namespace DBS_View.View
{
    partial class AddCustomerForm
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
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdAbort = new System.Windows.Forms.Button();
            this.TxtCustomerNr = new System.Windows.Forms.TextBox();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.TxtTown = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtWebsite = new System.Windows.Forms.TextBox();
            this.LblCustomerNr = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblStreet = new System.Windows.Forms.Label();
            this.LblTown = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblWebsite = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblAddCustomerTitle = new System.Windows.Forms.Label();
            this.TxtZipCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(10, 468);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(94, 35);
            this.CmdSave.TabIndex = 8;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdAbort
            // 
            this.CmdAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdAbort.Location = new System.Drawing.Point(110, 468);
            this.CmdAbort.Name = "CmdAbort";
            this.CmdAbort.Size = new System.Drawing.Size(91, 35);
            this.CmdAbort.TabIndex = 9;
            this.CmdAbort.Text = "Abbrechen";
            this.CmdAbort.UseVisualStyleBackColor = true;
            // 
            // TxtCustomerNr
            // 
            this.TxtCustomerNr.Location = new System.Drawing.Point(209, 82);
            this.TxtCustomerNr.Name = "TxtCustomerNr";
            this.TxtCustomerNr.Size = new System.Drawing.Size(119, 23);
            this.TxtCustomerNr.TabIndex = 1;
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(12, 82);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(170, 23);
            this.TxtCustomerName.TabIndex = 0;
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(12, 145);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(173, 23);
            this.TxtStreet.TabIndex = 2;
            // 
            // TxtTown
            // 
            this.TxtTown.Location = new System.Drawing.Point(12, 214);
            this.TxtTown.Name = "TxtTown";
            this.TxtTown.Size = new System.Drawing.Size(168, 23);
            this.TxtTown.TabIndex = 3;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(12, 282);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(173, 23);
            this.TxtEmail.TabIndex = 5;
            // 
            // TxtWebsite
            // 
            this.TxtWebsite.Location = new System.Drawing.Point(12, 351);
            this.TxtWebsite.Name = "TxtWebsite";
            this.TxtWebsite.Size = new System.Drawing.Size(319, 23);
            this.TxtWebsite.TabIndex = 6;
            // 
            // LblCustomerNr
            // 
            this.LblCustomerNr.AutoSize = true;
            this.LblCustomerNr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCustomerNr.Location = new System.Drawing.Point(207, 59);
            this.LblCustomerNr.Name = "LblCustomerNr";
            this.LblCustomerNr.Size = new System.Drawing.Size(75, 20);
            this.LblCustomerNr.TabIndex = 8;
            this.LblCustomerNr.Text = "Kundennr.";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(12, 59);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(96, 20);
            this.LblName.TabIndex = 9;
            this.LblName.Text = "Kundenname";
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStreet.Location = new System.Drawing.Point(12, 122);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(55, 20);
            this.LblStreet.TabIndex = 10;
            this.LblStreet.Text = "Strasse";
            // 
            // LblTown
            // 
            this.LblTown.AutoSize = true;
            this.LblTown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTown.Location = new System.Drawing.Point(12, 191);
            this.LblTown.Name = "LblTown";
            this.LblTown.Size = new System.Drawing.Size(30, 20);
            this.LblTown.TabIndex = 11;
            this.LblTown.Text = "Ort";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEmail.Location = new System.Drawing.Point(12, 259);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(46, 20);
            this.LblEmail.TabIndex = 12;
            this.LblEmail.Text = "Email";
            // 
            // LblWebsite
            // 
            this.LblWebsite.AutoSize = true;
            this.LblWebsite.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblWebsite.Location = new System.Drawing.Point(10, 328);
            this.LblWebsite.Name = "LblWebsite";
            this.LblWebsite.Size = new System.Drawing.Size(62, 20);
            this.LblWebsite.TabIndex = 13;
            this.LblWebsite.Text = "Website";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(12, 421);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(173, 23);
            this.TxtPassword.TabIndex = 7;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPassword.Location = new System.Drawing.Point(12, 398);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(66, 20);
            this.LblPassword.TabIndex = 15;
            this.LblPassword.Text = "Passwort";
            // 
            // LblAddCustomerTitle
            // 
            this.LblAddCustomerTitle.AutoSize = true;
            this.LblAddCustomerTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddCustomerTitle.Location = new System.Drawing.Point(7, 9);
            this.LblAddCustomerTitle.Name = "LblAddCustomerTitle";
            this.LblAddCustomerTitle.Size = new System.Drawing.Size(213, 32);
            this.LblAddCustomerTitle.TabIndex = 16;
            this.LblAddCustomerTitle.Text = "Kunde hinzufügen";
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.Location = new System.Drawing.Point(209, 214);
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(100, 23);
            this.TxtZipCode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "PLZ";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtZipCode);
            this.Controls.Add(this.LblAddCustomerTitle);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblWebsite);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblTown);
            this.Controls.Add(this.LblStreet);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblCustomerNr);
            this.Controls.Add(this.TxtWebsite);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTown);
            this.Controls.Add(this.TxtStreet);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.TxtCustomerNr);
            this.Controls.Add(this.CmdAbort);
            this.Controls.Add(this.CmdSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdSave;
        private Button CmdAbort;
        private TextBox TxtCustomerNr;
        private TextBox TxtCustomerName;
        private TextBox TxtStreet;
        private TextBox TxtTown;
        private TextBox TxtEmail;
        private TextBox TxtWebsite;
        private Label LblCustomerNr;
        private Label LblName;
        private Label LblStreet;
        private Label LblTown;
        private Label LblEmail;
        private Label LblWebsite;
        private TextBox TxtPassword;
        private Label LblPassword;
        private Label LblAddCustomerTitle;
        private TextBox TxtZipCode;
        private Label label1;
    }
}