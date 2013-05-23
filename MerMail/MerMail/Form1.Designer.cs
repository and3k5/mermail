namespace MerMail
{
    partial class Form1
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
            this.HostNameBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.ListBox();
            this.useSslCheckbox = new System.Windows.Forms.CheckBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HostNameBox
            // 
            this.HostNameBox.Location = new System.Drawing.Point(12, 12);
            this.HostNameBox.Name = "HostNameBox";
            this.HostNameBox.Size = new System.Drawing.Size(100, 20);
            this.HostNameBox.TabIndex = 0;
            this.HostNameBox.Text = "HostName";
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(118, 12);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(100, 20);
            this.PortBox.TabIndex = 1;
            this.PortBox.Text = "Port";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(330, 12);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(100, 20);
            this.UserBox.TabIndex = 3;
            this.UserBox.Text = "Username";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(436, 12);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(100, 20);
            this.PassBox.TabIndex = 4;
            this.PassBox.Text = "Password";
            // 
            // mailBox
            // 
            this.mailBox.FormattingEnabled = true;
            this.mailBox.Location = new System.Drawing.Point(12, 38);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(237, 186);
            this.mailBox.TabIndex = 5;
            // 
            // useSslCheckbox
            // 
            this.useSslCheckbox.AutoSize = true;
            this.useSslCheckbox.Location = new System.Drawing.Point(225, 14);
            this.useSslCheckbox.Name = "useSslCheckbox";
            this.useSslCheckbox.Size = new System.Drawing.Size(68, 17);
            this.useSslCheckbox.TabIndex = 6;
            this.useSslCheckbox.Text = "Use SSL";
            this.useSslCheckbox.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(542, 12);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(89, 19);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(587, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "CREATE_DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.useSslCheckbox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.HostNameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HostNameBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.ListBox mailBox;
        private System.Windows.Forms.CheckBox useSslCheckbox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button button1;
    }
}

