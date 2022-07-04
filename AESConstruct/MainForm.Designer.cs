namespace AESConstruct
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AboutButton = new System.Windows.Forms.Button();
            this.SecretKeyBox = new System.Windows.Forms.TextBox();
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.SecretKeyShown = new System.Windows.Forms.CheckBox();
            this.InputFileLabel = new System.Windows.Forms.Label();
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.SKGenerateButton = new System.Windows.Forms.Button();
            this.OutputFileLabel = new System.Windows.Forms.Label();
            this.OutputFileNameLabel = new System.Windows.Forms.Label();
            this.OutputFileSelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(12, 457);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SecretKeyBox
            // 
            this.SecretKeyBox.Location = new System.Drawing.Point(234, 363);
            this.SecretKeyBox.Name = "SecretKeyBox";
            this.SecretKeyBox.PasswordChar = '*';
            this.SecretKeyBox.Size = new System.Drawing.Size(321, 23);
            this.SecretKeyBox.TabIndex = 1;
            this.SecretKeyBox.TextChanged += new System.EventHandler(this.SecretKeyBox_TextChanged);
            // 
            // SecretKeyLabel
            // 
            this.SecretKeyLabel.AutoSize = true;
            this.SecretKeyLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecretKeyLabel.Location = new System.Drawing.Point(129, 361);
            this.SecretKeyLabel.Name = "SecretKeyLabel";
            this.SecretKeyLabel.Size = new System.Drawing.Size(99, 25);
            this.SecretKeyLabel.TabIndex = 2;
            this.SecretKeyLabel.Text = "Secret Key";
            // 
            // SecretKeyShown
            // 
            this.SecretKeyShown.AutoSize = true;
            this.SecretKeyShown.Location = new System.Drawing.Point(234, 403);
            this.SecretKeyShown.Name = "SecretKeyShown";
            this.SecretKeyShown.Size = new System.Drawing.Size(62, 19);
            this.SecretKeyShown.TabIndex = 3;
            this.SecretKeyShown.Text = "Shown";
            this.SecretKeyShown.UseVisualStyleBackColor = true;
            this.SecretKeyShown.CheckedChanged += new System.EventHandler(this.SecretKeyShown_CheckedChanged);
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputFileLabel.Location = new System.Drawing.Point(192, 206);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(90, 25);
            this.InputFileLabel.TabIndex = 4;
            this.InputFileLabel.Text = "Input File";
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(543, 206);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.FileSelectButton.TabIndex = 5;
            this.FileSelectButton.Text = "Select File";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(300, 210);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(91, 15);
            this.FileNameLabel.TabIndex = 6;
            this.FileNameLabel.Text = "No File Selected";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(717, 457);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 9;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(636, 457);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 10;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // SKGenerateButton
            // 
            this.SKGenerateButton.Location = new System.Drawing.Point(561, 363);
            this.SKGenerateButton.Name = "SKGenerateButton";
            this.SKGenerateButton.Size = new System.Drawing.Size(75, 23);
            this.SKGenerateButton.TabIndex = 11;
            this.SKGenerateButton.Text = "Generate";
            this.SKGenerateButton.UseVisualStyleBackColor = true;
            this.SKGenerateButton.Click += new System.EventHandler(this.SKGenerateButton_Click);
            // 
            // OutputFileLabel
            // 
            this.OutputFileLabel.AutoSize = true;
            this.OutputFileLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputFileLabel.Location = new System.Drawing.Point(192, 245);
            this.OutputFileLabel.Name = "OutputFileLabel";
            this.OutputFileLabel.Size = new System.Drawing.Size(105, 25);
            this.OutputFileLabel.TabIndex = 12;
            this.OutputFileLabel.Text = "Output File";
            // 
            // OutputFileNameLabel
            // 
            this.OutputFileNameLabel.AutoSize = true;
            this.OutputFileNameLabel.Location = new System.Drawing.Point(303, 253);
            this.OutputFileNameLabel.Name = "OutputFileNameLabel";
            this.OutputFileNameLabel.Size = new System.Drawing.Size(91, 15);
            this.OutputFileNameLabel.TabIndex = 13;
            this.OutputFileNameLabel.Text = "No File Selected";
            // 
            // OutputFileSelectButton
            // 
            this.OutputFileSelectButton.Location = new System.Drawing.Point(543, 249);
            this.OutputFileSelectButton.Name = "OutputFileSelectButton";
            this.OutputFileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.OutputFileSelectButton.TabIndex = 14;
            this.OutputFileSelectButton.Text = "Select File";
            this.OutputFileSelectButton.UseVisualStyleBackColor = true;
            this.OutputFileSelectButton.Click += new System.EventHandler(this.OutputFileSelectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 492);
            this.Controls.Add(this.OutputFileSelectButton);
            this.Controls.Add(this.OutputFileNameLabel);
            this.Controls.Add(this.OutputFileLabel);
            this.Controls.Add(this.SKGenerateButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileSelectButton);
            this.Controls.Add(this.InputFileLabel);
            this.Controls.Add(this.SecretKeyShown);
            this.Controls.Add(this.SecretKeyLabel);
            this.Controls.Add(this.SecretKeyBox);
            this.Controls.Add(this.AboutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "AESConstruct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AboutButton;
        private TextBox SecretKeyBox;
        private Label SecretKeyLabel;
        private CheckBox SecretKeyShown;
        private Label InputFileLabel;
        private Button FileSelectButton;
        private Label FileNameLabel;
        private Button EncryptButton;
        private Button DecryptButton;
        private Button SKGenerateButton;
        private Label OutputFileLabel;
        private Label OutputFileNameLabel;
        private Button OutputFileSelectButton;
    }
}