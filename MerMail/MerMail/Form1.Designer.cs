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
            this.SslBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
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
            // SslBox
            // 
            this.SslBox.Location = new System.Drawing.Point(224, 12);
            this.SslBox.Name = "SslBox";
            this.SslBox.Size = new System.Drawing.Size(100, 20);
            this.SslBox.TabIndex = 2;
            this.SslBox.Text = "SSL?";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 530);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.SslBox);
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
        private System.Windows.Forms.TextBox SslBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PassBox;
    }
}

