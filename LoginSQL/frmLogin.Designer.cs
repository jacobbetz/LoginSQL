﻿namespace LoginSQL
{
    partial class frmLogin
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblCnn = new System.Windows.Forms.Label();
            this.Waiting = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.btnCreateHash = new System.Windows.Forms.Button();
            this.tbPasswordHash = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblHash = new System.Windows.Forms.Label();
            this.tbCnnString = new System.Windows.Forms.TextBox();
            this.lblCnnString = new System.Windows.Forms.Label();
            this.lblRowCountLabel = new System.Windows.Forms.Label();
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.btnCreateLogin = new System.Windows.Forms.Button();
            this.btnCheckUsername = new System.Windows.Forms.Button();
            this.Waiting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(333, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(14, 37);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Window;
            this.tbUsername.Location = new System.Drawing.Point(80, 34);
            this.tbUsername.MaxLength = 50;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(203, 20);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.WordWrap = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(80, 68);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(203, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.WordWrap = false;
            // 
            // lblCnn
            // 
            this.lblCnn.AutoSize = true;
            this.lblCnn.Location = new System.Drawing.Point(13, 13);
            this.lblCnn.Name = "lblCnn";
            this.lblCnn.Size = new System.Drawing.Size(77, 13);
            this.lblCnn.TabIndex = 0;
            this.lblCnn.Text = "Connected to: ";
            // 
            // Waiting
            // 
            this.Waiting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.Waiting.Location = new System.Drawing.Point(0, 321);
            this.Waiting.Name = "Waiting";
            this.Waiting.Size = new System.Drawing.Size(434, 22);
            this.Waiting.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStatus.Text = "Waiting..";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(96, 13);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(87, 13);
            this.lblServerIP.TabIndex = 0;
            this.lblServerIP.Text = "- no connection -";
            this.lblServerIP.Click += new System.EventHandler(this.lblServerIP_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(414, 34);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(13, 13);
            this.lblRowCount.TabIndex = 9;
            this.lblRowCount.Text = "?";
            // 
            // btnCreateHash
            // 
            this.btnCreateHash.Location = new System.Drawing.Point(80, 135);
            this.btnCreateHash.Name = "btnCreateHash";
            this.btnCreateHash.Size = new System.Drawing.Size(128, 23);
            this.btnCreateHash.TabIndex = 10;
            this.btnCreateHash.Text = "Create Password Hash";
            this.btnCreateHash.UseVisualStyleBackColor = true;
            this.btnCreateHash.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbPasswordHash
            // 
            this.tbPasswordHash.Location = new System.Drawing.Point(80, 109);
            this.tbPasswordHash.Name = "tbPasswordHash";
            this.tbPasswordHash.ReadOnly = true;
            this.tbPasswordHash.Size = new System.Drawing.Size(203, 20);
            this.tbPasswordHash.TabIndex = 11;
            this.tbPasswordHash.TabStop = false;
            this.tbPasswordHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(233, 135);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(50, 23);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(163, 93);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(35, 13);
            this.lblHash.TabIndex = 13;
            this.lblHash.Text = "Hash:";
            // 
            // tbCnnString
            // 
            this.tbCnnString.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCnnString.Location = new System.Drawing.Point(12, 204);
            this.tbCnnString.Multiline = true;
            this.tbCnnString.Name = "tbCnnString";
            this.tbCnnString.Size = new System.Drawing.Size(396, 86);
            this.tbCnnString.TabIndex = 14;
            // 
            // lblCnnString
            // 
            this.lblCnnString.AutoSize = true;
            this.lblCnnString.Location = new System.Drawing.Point(19, 188);
            this.lblCnnString.Name = "lblCnnString";
            this.lblCnnString.Size = new System.Drawing.Size(94, 13);
            this.lblCnnString.TabIndex = 15;
            this.lblCnnString.Text = "Connection String:";
            // 
            // lblRowCountLabel
            // 
            this.lblRowCountLabel.AutoSize = true;
            this.lblRowCountLabel.Location = new System.Drawing.Point(306, 34);
            this.lblRowCountLabel.Name = "lblRowCountLabel";
            this.lblRowCountLabel.Size = new System.Drawing.Size(102, 13);
            this.lblRowCountLabel.TabIndex = 16;
            this.lblRowCountLabel.Text = "Selected row count:";
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Location = new System.Drawing.Point(306, 13);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblCurrentDateTime.TabIndex = 17;
            this.lblCurrentDateTime.Text = "DateTime";
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Location = new System.Drawing.Point(314, 68);
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.Size = new System.Drawing.Size(108, 21);
            this.btnCreateLogin.TabIndex = 18;
            this.btnCreateLogin.Text = "Create Login";
            this.btnCreateLogin.UseVisualStyleBackColor = true;
            this.btnCreateLogin.Click += new System.EventHandler(this.btnCreateLogin_Click);
            // 
            // btnCheckUsername
            // 
            this.btnCheckUsername.Location = new System.Drawing.Point(314, 96);
            this.btnCheckUsername.Name = "btnCheckUsername";
            this.btnCheckUsername.Size = new System.Drawing.Size(108, 23);
            this.btnCheckUsername.TabIndex = 19;
            this.btnCheckUsername.Text = "Check Username";
            this.btnCheckUsername.UseVisualStyleBackColor = true;
            this.btnCheckUsername.Click += new System.EventHandler(this.btnCheckUsername_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(434, 343);
            this.Controls.Add(this.btnCheckUsername);
            this.Controls.Add(this.btnCreateLogin);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.lblRowCountLabel);
            this.Controls.Add(this.lblCnnString);
            this.Controls.Add(this.tbCnnString);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbPasswordHash);
            this.Controls.Add(this.btnCreateHash);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.Waiting);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblCnn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Waiting.ResumeLayout(false);
            this.Waiting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblCnn;
        private System.Windows.Forms.StatusStrip Waiting;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Button btnCreateHash;
        private System.Windows.Forms.TextBox tbPasswordHash;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblHash;
        public System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbCnnString;
        private System.Windows.Forms.Label lblCnnString;
        private System.Windows.Forms.Label lblRowCountLabel;
        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Button btnCreateLogin;
        private System.Windows.Forms.Button btnCheckUsername;
    }
}

