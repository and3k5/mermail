namespace MerMail
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginBtn = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.useSslCheckbox = new System.Windows.Forms.CheckBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.HostNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SmtpName = new System.Windows.Forms.TextBox();
            this.SmtpPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usesmtpssl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(118, 212);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(89, 25);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(106, 159);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(101, 20);
            this.PassBox.TabIndex = 8;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(106, 133);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(101, 20);
            this.UserBox.TabIndex = 7;
            // 
            // useSslCheckbox
            // 
            this.useSslCheckbox.AutoSize = true;
            this.useSslCheckbox.Location = new System.Drawing.Point(137, 110);
            this.useSslCheckbox.Name = "useSslCheckbox";
            this.useSslCheckbox.Size = new System.Drawing.Size(62, 17);
            this.useSslCheckbox.TabIndex = 6;
            this.useSslCheckbox.Text = "Pop Ssl";
            this.useSslCheckbox.UseVisualStyleBackColor = true;
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(106, 32);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(103, 20);
            this.PortBox.TabIndex = 2;
            // 
            // HostNameBox
            // 
            this.HostNameBox.Location = new System.Drawing.Point(106, 6);
            this.HostNameBox.Name = "HostNameBox";
            this.HostNameBox.Size = new System.Drawing.Size(103, 20);
            this.HostNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pop3 HostName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pop3 Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "UserName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SmtpName
            // 
            this.SmtpName.Location = new System.Drawing.Point(106, 58);
            this.SmtpName.Name = "SmtpName";
            this.SmtpName.Size = new System.Drawing.Size(103, 20);
            this.SmtpName.TabIndex = 3;
            // 
            // SmtpPort
            // 
            this.SmtpPort.Location = new System.Drawing.Point(106, 84);
            this.SmtpPort.Name = "SmtpPort";
            this.SmtpPort.Size = new System.Drawing.Size(103, 20);
            this.SmtpPort.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Smtpserver:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Smtp Port:";
            // 
            // usesmtpssl
            // 
            this.usesmtpssl.AutoSize = true;
            this.usesmtpssl.Location = new System.Drawing.Point(64, 110);
            this.usesmtpssl.Name = "usesmtpssl";
            this.usesmtpssl.Size = new System.Drawing.Size(67, 17);
            this.usesmtpssl.TabIndex = 5;
            this.usesmtpssl.Text = "Smtp Ssl";
            this.usesmtpssl.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 247);
            this.Controls.Add(this.usesmtpssl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SmtpPort);
            this.Controls.Add(this.SmtpName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.useSslCheckbox);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.HostNameBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.CheckBox useSslCheckbox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.TextBox HostNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox SmtpName;
        private System.Windows.Forms.TextBox SmtpPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox usesmtpssl;

    }
}