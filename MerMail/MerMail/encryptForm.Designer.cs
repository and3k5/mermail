namespace MerMail
{
    partial class encryptForm
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
            this.useSymmetric = new System.Windows.Forms.CheckBox();
            this.symmetricTextBox = new System.Windows.Forms.TextBox();
            this.symmetricAsymmetricEncrypted = new System.Windows.Forms.CheckBox();
            this.symmetricFileRadio = new System.Windows.Forms.RadioButton();
            this.loadSymmetricFromFileBtn = new System.Windows.Forms.Button();
            this.symmetricTextRadio = new System.Windows.Forms.RadioButton();
            this.groupSymmetric = new System.Windows.Forms.GroupBox();
            this.symKeyFilename = new System.Windows.Forms.Label();
            this.groupAsymmetric = new System.Windows.Forms.GroupBox();
            this.asymKeyFilename = new System.Windows.Forms.Label();
            this.asymmetricTextBox = new System.Windows.Forms.TextBox();
            this.asymmetricTextRadio = new System.Windows.Forms.RadioButton();
            this.asymmetricFileRadio = new System.Windows.Forms.RadioButton();
            this.loadAsymmetricFromFileBtn = new System.Windows.Forms.Button();
            this.OKbtn = new System.Windows.Forms.Button();
            this.CANCELbtn = new System.Windows.Forms.Button();
            this.symmetricStatusLabel = new System.Windows.Forms.Label();
            this.asymmetricStatusLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bytestrengthNum = new System.Windows.Forms.NumericUpDown();
            this.groupSymmetric.SuspendLayout();
            this.groupAsymmetric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bytestrengthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // useSymmetric
            // 
            this.useSymmetric.AutoSize = true;
            this.useSymmetric.Location = new System.Drawing.Point(12, 12);
            this.useSymmetric.Name = "useSymmetric";
            this.useSymmetric.Size = new System.Drawing.Size(114, 17);
            this.useSymmetric.TabIndex = 0;
            this.useSymmetric.Text = "Use symmetric key";
            this.useSymmetric.UseVisualStyleBackColor = true;
            this.useSymmetric.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // symmetricTextBox
            // 
            this.symmetricTextBox.Location = new System.Drawing.Point(36, 111);
            this.symmetricTextBox.Multiline = true;
            this.symmetricTextBox.Name = "symmetricTextBox";
            this.symmetricTextBox.Size = new System.Drawing.Size(195, 56);
            this.symmetricTextBox.TabIndex = 2;
            this.symmetricTextBox.TextChanged += new System.EventHandler(this.symmetricTextBox_TextChanged);
            this.symmetricTextBox.Enter += new System.EventHandler(this.symmetricTextBox_Enter);
            // 
            // symmetricAsymmetricEncrypted
            // 
            this.symmetricAsymmetricEncrypted.AutoSize = true;
            this.symmetricAsymmetricEncrypted.Location = new System.Drawing.Point(23, 173);
            this.symmetricAsymmetricEncrypted.Name = "symmetricAsymmetricEncrypted";
            this.symmetricAsymmetricEncrypted.Size = new System.Drawing.Size(209, 17);
            this.symmetricAsymmetricEncrypted.TabIndex = 3;
            this.symmetricAsymmetricEncrypted.Text = "Symmetric key is asymmetric encrypted";
            this.symmetricAsymmetricEncrypted.UseVisualStyleBackColor = true;
            this.symmetricAsymmetricEncrypted.CheckedChanged += new System.EventHandler(this.symmetricAsymmetricEncrypted_CheckedChanged);
            // 
            // symmetricFileRadio
            // 
            this.symmetricFileRadio.AutoSize = true;
            this.symmetricFileRadio.Location = new System.Drawing.Point(23, 32);
            this.symmetricFileRadio.Name = "symmetricFileRadio";
            this.symmetricFileRadio.Size = new System.Drawing.Size(41, 17);
            this.symmetricFileRadio.TabIndex = 4;
            this.symmetricFileRadio.TabStop = true;
            this.symmetricFileRadio.Text = "File";
            this.symmetricFileRadio.UseVisualStyleBackColor = true;
            // 
            // loadSymmetricFromFileBtn
            // 
            this.loadSymmetricFromFileBtn.Location = new System.Drawing.Point(36, 55);
            this.loadSymmetricFromFileBtn.Name = "loadSymmetricFromFileBtn";
            this.loadSymmetricFromFileBtn.Size = new System.Drawing.Size(57, 23);
            this.loadSymmetricFromFileBtn.TabIndex = 5;
            this.loadSymmetricFromFileBtn.Text = "Load file";
            this.loadSymmetricFromFileBtn.UseVisualStyleBackColor = true;
            this.loadSymmetricFromFileBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // symmetricTextRadio
            // 
            this.symmetricTextRadio.AutoSize = true;
            this.symmetricTextRadio.Location = new System.Drawing.Point(23, 88);
            this.symmetricTextRadio.Name = "symmetricTextRadio";
            this.symmetricTextRadio.Size = new System.Drawing.Size(46, 17);
            this.symmetricTextRadio.TabIndex = 6;
            this.symmetricTextRadio.TabStop = true;
            this.symmetricTextRadio.Text = "Text";
            this.symmetricTextRadio.UseVisualStyleBackColor = true;
            // 
            // groupSymmetric
            // 
            this.groupSymmetric.Controls.Add(this.symKeyFilename);
            this.groupSymmetric.Controls.Add(this.groupAsymmetric);
            this.groupSymmetric.Controls.Add(this.symmetricAsymmetricEncrypted);
            this.groupSymmetric.Controls.Add(this.symmetricTextRadio);
            this.groupSymmetric.Controls.Add(this.symmetricTextBox);
            this.groupSymmetric.Controls.Add(this.loadSymmetricFromFileBtn);
            this.groupSymmetric.Controls.Add(this.symmetricFileRadio);
            this.groupSymmetric.Location = new System.Drawing.Point(24, 35);
            this.groupSymmetric.Name = "groupSymmetric";
            this.groupSymmetric.Size = new System.Drawing.Size(369, 381);
            this.groupSymmetric.TabIndex = 7;
            this.groupSymmetric.TabStop = false;
            this.groupSymmetric.Text = "Symmetric options";
            // 
            // symKeyFilename
            // 
            this.symKeyFilename.AutoSize = true;
            this.symKeyFilename.Location = new System.Drawing.Point(99, 60);
            this.symKeyFilename.Name = "symKeyFilename";
            this.symKeyFilename.Size = new System.Drawing.Size(72, 13);
            this.symKeyFilename.TabIndex = 9;
            this.symKeyFilename.Text = "No file loaded";
            // 
            // groupAsymmetric
            // 
            this.groupAsymmetric.Controls.Add(this.bytestrengthNum);
            this.groupAsymmetric.Controls.Add(this.button1);
            this.groupAsymmetric.Controls.Add(this.asymKeyFilename);
            this.groupAsymmetric.Controls.Add(this.asymmetricTextBox);
            this.groupAsymmetric.Controls.Add(this.asymmetricTextRadio);
            this.groupAsymmetric.Controls.Add(this.asymmetricFileRadio);
            this.groupAsymmetric.Controls.Add(this.loadAsymmetricFromFileBtn);
            this.groupAsymmetric.Location = new System.Drawing.Point(23, 196);
            this.groupAsymmetric.Name = "groupAsymmetric";
            this.groupAsymmetric.Size = new System.Drawing.Size(318, 172);
            this.groupAsymmetric.TabIndex = 8;
            this.groupAsymmetric.TabStop = false;
            this.groupAsymmetric.Text = "Asymmetric options";
            // 
            // asymKeyFilename
            // 
            this.asymKeyFilename.AutoSize = true;
            this.asymKeyFilename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asymKeyFilename.Location = new System.Drawing.Point(219, 50);
            this.asymKeyFilename.Name = "asymKeyFilename";
            this.asymKeyFilename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.asymKeyFilename.Size = new System.Drawing.Size(72, 13);
            this.asymKeyFilename.TabIndex = 11;
            this.asymKeyFilename.Text = "No file loaded";
            // 
            // asymmetricTextBox
            // 
            this.asymmetricTextBox.Location = new System.Drawing.Point(31, 97);
            this.asymmetricTextBox.Multiline = true;
            this.asymmetricTextBox.Name = "asymmetricTextBox";
            this.asymmetricTextBox.Size = new System.Drawing.Size(267, 56);
            this.asymmetricTextBox.TabIndex = 10;
            this.asymmetricTextBox.TextChanged += new System.EventHandler(this.asymmetricTextBox_TextChanged);
            this.asymmetricTextBox.Enter += new System.EventHandler(this.asymmetricTextBox_Enter);
            // 
            // asymmetricTextRadio
            // 
            this.asymmetricTextRadio.AutoSize = true;
            this.asymmetricTextRadio.Location = new System.Drawing.Point(16, 74);
            this.asymmetricTextRadio.Name = "asymmetricTextRadio";
            this.asymmetricTextRadio.Size = new System.Drawing.Size(46, 17);
            this.asymmetricTextRadio.TabIndex = 9;
            this.asymmetricTextRadio.TabStop = true;
            this.asymmetricTextRadio.Text = "Text";
            this.asymmetricTextRadio.UseVisualStyleBackColor = true;
            // 
            // asymmetricFileRadio
            // 
            this.asymmetricFileRadio.AutoSize = true;
            this.asymmetricFileRadio.Location = new System.Drawing.Point(16, 22);
            this.asymmetricFileRadio.Name = "asymmetricFileRadio";
            this.asymmetricFileRadio.Size = new System.Drawing.Size(41, 17);
            this.asymmetricFileRadio.TabIndex = 8;
            this.asymmetricFileRadio.TabStop = true;
            this.asymmetricFileRadio.Text = "File";
            this.asymmetricFileRadio.UseVisualStyleBackColor = true;
            // 
            // loadAsymmetricFromFileBtn
            // 
            this.loadAsymmetricFromFileBtn.Location = new System.Drawing.Point(151, 45);
            this.loadAsymmetricFromFileBtn.Name = "loadAsymmetricFromFileBtn";
            this.loadAsymmetricFromFileBtn.Size = new System.Drawing.Size(62, 23);
            this.loadAsymmetricFromFileBtn.TabIndex = 7;
            this.loadAsymmetricFromFileBtn.Text = "Load file";
            this.loadAsymmetricFromFileBtn.UseVisualStyleBackColor = true;
            this.loadAsymmetricFromFileBtn.Click += new System.EventHandler(this.loadAsymmetricFromFileBtn_Click);
            // 
            // OKbtn
            // 
            this.OKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbtn.Location = new System.Drawing.Point(271, 458);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(122, 28);
            this.OKbtn.TabIndex = 8;
            this.OKbtn.Text = "Decrypt";
            this.OKbtn.UseVisualStyleBackColor = true;
            // 
            // CANCELbtn
            // 
            this.CANCELbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CANCELbtn.Location = new System.Drawing.Point(168, 458);
            this.CANCELbtn.Name = "CANCELbtn";
            this.CANCELbtn.Size = new System.Drawing.Size(97, 28);
            this.CANCELbtn.TabIndex = 9;
            this.CANCELbtn.Text = "Cancel";
            this.CANCELbtn.UseVisualStyleBackColor = true;
            // 
            // symmetricStatusLabel
            // 
            this.symmetricStatusLabel.AutoSize = true;
            this.symmetricStatusLabel.Location = new System.Drawing.Point(21, 429);
            this.symmetricStatusLabel.Name = "symmetricStatusLabel";
            this.symmetricStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.symmetricStatusLabel.TabIndex = 10;
            this.symmetricStatusLabel.Text = "label1";
            // 
            // asymmetricStatusLabel
            // 
            this.asymmetricStatusLabel.AutoSize = true;
            this.asymmetricStatusLabel.Location = new System.Drawing.Point(21, 442);
            this.asymmetricStatusLabel.Name = "asymmetricStatusLabel";
            this.asymmetricStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.asymmetricStatusLabel.TabIndex = 11;
            this.asymmetricStatusLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bytestrengthNum
            // 
            this.bytestrengthNum.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.bytestrengthNum.Location = new System.Drawing.Point(31, 48);
            this.bytestrengthNum.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.bytestrengthNum.Minimum = new decimal(new int[] {
            384,
            0,
            0,
            0});
            this.bytestrengthNum.Name = "bytestrengthNum";
            this.bytestrengthNum.Size = new System.Drawing.Size(64, 20);
            this.bytestrengthNum.TabIndex = 13;
            this.bytestrengthNum.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // encryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 497);
            this.Controls.Add(this.asymmetricStatusLabel);
            this.Controls.Add(this.symmetricStatusLabel);
            this.Controls.Add(this.CANCELbtn);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.groupSymmetric);
            this.Controls.Add(this.useSymmetric);
            this.Name = "encryptForm";
            this.Text = "encryptForm";
            this.Load += new System.EventHandler(this.encryptForm_Load);
            this.groupSymmetric.ResumeLayout(false);
            this.groupSymmetric.PerformLayout();
            this.groupAsymmetric.ResumeLayout(false);
            this.groupAsymmetric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bytestrengthNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSymmetric;
        private System.Windows.Forms.Label symKeyFilename;
        private System.Windows.Forms.GroupBox groupAsymmetric;
        private System.Windows.Forms.Label asymKeyFilename;
        private System.Windows.Forms.TextBox asymmetricTextBox;
        private System.Windows.Forms.RadioButton asymmetricTextRadio;
        private System.Windows.Forms.RadioButton asymmetricFileRadio;
        private System.Windows.Forms.Button loadAsymmetricFromFileBtn;
        private System.Windows.Forms.CheckBox symmetricAsymmetricEncrypted;
        private System.Windows.Forms.RadioButton symmetricTextRadio;
        private System.Windows.Forms.TextBox symmetricTextBox;
        private System.Windows.Forms.Button loadSymmetricFromFileBtn;
        private System.Windows.Forms.RadioButton symmetricFileRadio;
        private System.Windows.Forms.CheckBox useSymmetric;
        private System.Windows.Forms.Label asymmetricStatusLabel;
        private System.Windows.Forms.Label symmetricStatusLabel;
        private System.Windows.Forms.Button CANCELbtn;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown bytestrengthNum;
    }
}