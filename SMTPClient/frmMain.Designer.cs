namespace SMTPClient
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.chkRequiredSSL = new System.Windows.Forms.CheckBox();
            this.comboServerName = new System.Windows.Forms.ComboBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.webBody = new System.Windows.Forms.WebBrowser();
            this.lblAttach = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(517, 987);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(129, 53);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "SMTP Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "SMTP Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(390, 178);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(98, 35);
            this.txtPort.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(390, 259);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(383, 35);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(390, 338);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(383, 35);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "To";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(390, 529);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(383, 35);
            this.txtTo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(390, 623);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(383, 35);
            this.txtSubject.TabIndex = 7;
            this.txtSubject.Text = "SMTP Email Client Sending Test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 730);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Body";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(390, 434);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(383, 35);
            this.txtFrom.TabIndex = 5;
            // 
            // chkRequiredSSL
            // 
            this.chkRequiredSSL.AutoSize = true;
            this.chkRequiredSSL.Location = new System.Drawing.Point(577, 180);
            this.chkRequiredSSL.Name = "chkRequiredSSL";
            this.chkRequiredSSL.Size = new System.Drawing.Size(196, 33);
            this.chkRequiredSSL.TabIndex = 2;
            this.chkRequiredSSL.Text = "Required SSL";
            this.chkRequiredSSL.UseVisualStyleBackColor = true;
            // 
            // comboServerName
            // 
            this.comboServerName.FormattingEnabled = true;
            this.comboServerName.Location = new System.Drawing.Point(383, 97);
            this.comboServerName.Name = "comboServerName";
            this.comboServerName.Size = new System.Drawing.Size(390, 37);
            this.comboServerName.TabIndex = 0;
            this.comboServerName.SelectedIndexChanged += new System.EventHandler(this.comboServerName_SelectedIndexChanged);
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(383, 987);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(128, 53);
            this.btnAttach.TabIndex = 9;
            this.btnAttach.Text = "&Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // webBody
            // 
            this.webBody.Location = new System.Drawing.Point(383, 730);
            this.webBody.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBody.Name = "webBody";
            this.webBody.Size = new System.Drawing.Size(390, 131);
            this.webBody.TabIndex = 10;
            // 
            // lblAttach
            // 
            this.lblAttach.BackColor = System.Drawing.SystemColors.Menu;
            this.lblAttach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAttach.Enabled = false;
            this.lblAttach.Location = new System.Drawing.Point(127, 867);
            this.lblAttach.Multiline = true;
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(639, 102);
            this.lblAttach.TabIndex = 3;
            this.lblAttach.TabStop = false;
            this.lblAttach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lblAttach.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(652, 987);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 53);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 1101);
            this.Controls.Add(this.webBody);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.comboServerName);
            this.Controls.Add(this.chkRequiredSSL);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblAttach);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP Client Testing Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.CheckBox chkRequiredSSL;
        private System.Windows.Forms.ComboBox comboServerName;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.WebBrowser webBody;
        private System.Windows.Forms.TextBox lblAttach;
        private System.Windows.Forms.Button btnClose;
    }
}

