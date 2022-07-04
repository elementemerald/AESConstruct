namespace AESConstruct
{
    partial class OptionsForm
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
            this.SaltLabel = new System.Windows.Forms.Label();
            this.SaltBox = new System.Windows.Forms.TextBox();
            this.IVLabel = new System.Windows.Forms.Label();
            this.IVBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaltLabel
            // 
            this.SaltLabel.AutoSize = true;
            this.SaltLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaltLabel.Location = new System.Drawing.Point(82, 88);
            this.SaltLabel.Name = "SaltLabel";
            this.SaltLabel.Size = new System.Drawing.Size(43, 25);
            this.SaltLabel.TabIndex = 0;
            this.SaltLabel.Text = "Salt";
            // 
            // SaltBox
            // 
            this.SaltBox.Location = new System.Drawing.Point(131, 90);
            this.SaltBox.Name = "SaltBox";
            this.SaltBox.Size = new System.Drawing.Size(243, 23);
            this.SaltBox.TabIndex = 1;
            this.SaltBox.TextChanged += new System.EventHandler(this.SaltBox_TextChanged);
            // 
            // IVLabel
            // 
            this.IVLabel.AutoSize = true;
            this.IVLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IVLabel.Location = new System.Drawing.Point(96, 131);
            this.IVLabel.Name = "IVLabel";
            this.IVLabel.Size = new System.Drawing.Size(29, 25);
            this.IVLabel.TabIndex = 2;
            this.IVLabel.Text = "IV";
            // 
            // IVBox
            // 
            this.IVBox.Location = new System.Drawing.Point(131, 133);
            this.IVBox.Name = "IVBox";
            this.IVBox.Size = new System.Drawing.Size(243, 23);
            this.IVBox.TabIndex = 3;
            this.IVBox.TextChanged += new System.EventHandler(this.IVBox_TextChanged);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 245);
            this.Controls.Add(this.IVBox);
            this.Controls.Add(this.IVLabel);
            this.Controls.Add(this.SaltBox);
            this.Controls.Add(this.SaltLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SaltLabel;
        private TextBox SaltBox;
        private Label IVLabel;
        private TextBox IVBox;
    }
}