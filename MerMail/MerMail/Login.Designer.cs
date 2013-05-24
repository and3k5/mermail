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
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(75, 134);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(89, 19);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(75, 108);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(100, 20);
            this.PassBox.TabIndex = 9;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(75, 82);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(100, 20);
            this.UserBox.TabIndex = 8;
            // 
            // useSslCheckbox
            // 
            this.useSslCheckbox.AutoSize = true;
            this.useSslCheckbox.Location = new System.Drawing.Point(75, 59);
            this.useSslCheckbox.Name = "useSslCheckbox";
            this.useSslCheckbox.Size = new System.Drawing.Size(68, 17);
            this.useSslCheckbox.TabIndex = 13;
            this.useSslCheckbox.Text = "Use SSL";
            this.useSslCheckbox.UseVisualStyleBackColor = true;
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(75, 32);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(100, 20);
            this.PortBox.TabIndex = 12;
            // 
            // HostNameBox
            // 
            this.HostNameBox.Location = new System.Drawing.Point(75, 6);
            this.HostNameBox.Name = "HostNameBox";
            this.HostNameBox.Size = new System.Drawing.Size(100, 20);
            this.HostNameBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "HostName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Port NR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "UserName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 161);
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
            this.Name = "Login";
            this.Text = "Login";
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

    }
}