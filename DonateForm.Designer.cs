namespace TeryaqApp
{
    partial class DonateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonateForm));
            this.MedicineNameLabel = new System.Windows.Forms.Label();
            this.MedicineFormComboBox = new System.Windows.Forms.ComboBox();
            this.MedicineFormLabel = new System.Windows.Forms.Label();
            this.MedicineQuantityLabel = new System.Windows.Forms.Label();
            this.ExpiryDateLabel = new System.Windows.Forms.Label();
            this.MedicineQuantityTextBox = new System.Windows.Forms.TextBox();
            this.ExpiryDateTextBox = new System.Windows.Forms.TextBox();
            this.MedicineNameComboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.RemindLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineNameLabel
            // 
            this.MedicineNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MedicineNameLabel.AutoSize = true;
            this.MedicineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineNameLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.MedicineNameLabel.Location = new System.Drawing.Point(38, 72);
            this.MedicineNameLabel.Name = "MedicineNameLabel";
            this.MedicineNameLabel.Size = new System.Drawing.Size(161, 25);
            this.MedicineNameLabel.TabIndex = 0;
            this.MedicineNameLabel.Text = "Medicine Name";
            // 
            // MedicineFormComboBox
            // 
            this.MedicineFormComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicineFormComboBox.FormattingEnabled = true;
            this.MedicineFormComboBox.Location = new System.Drawing.Point(230, 127);
            this.MedicineFormComboBox.Name = "MedicineFormComboBox";
            this.MedicineFormComboBox.Size = new System.Drawing.Size(266, 28);
            this.MedicineFormComboBox.TabIndex = 2;
            // 
            // MedicineFormLabel
            // 
            this.MedicineFormLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MedicineFormLabel.AutoSize = true;
            this.MedicineFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineFormLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.MedicineFormLabel.Location = new System.Drawing.Point(38, 130);
            this.MedicineFormLabel.Name = "MedicineFormLabel";
            this.MedicineFormLabel.Size = new System.Drawing.Size(154, 25);
            this.MedicineFormLabel.TabIndex = 3;
            this.MedicineFormLabel.Text = "Medicine Form";
            // 
            // MedicineQuantityLabel
            // 
            this.MedicineQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MedicineQuantityLabel.AutoSize = true;
            this.MedicineQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineQuantityLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.MedicineQuantityLabel.Location = new System.Drawing.Point(38, 180);
            this.MedicineQuantityLabel.Name = "MedicineQuantityLabel";
            this.MedicineQuantityLabel.Size = new System.Drawing.Size(186, 25);
            this.MedicineQuantityLabel.TabIndex = 4;
            this.MedicineQuantityLabel.Text = "Medicine Quantity";
            this.MedicineQuantityLabel.Click += new System.EventHandler(this.MedicineQuantityLabel_Click);
            // 
            // ExpiryDateLabel
            // 
            this.ExpiryDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExpiryDateLabel.AutoSize = true;
            this.ExpiryDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDateLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.ExpiryDateLabel.Location = new System.Drawing.Point(38, 236);
            this.ExpiryDateLabel.Name = "ExpiryDateLabel";
            this.ExpiryDateLabel.Size = new System.Drawing.Size(123, 25);
            this.ExpiryDateLabel.TabIndex = 5;
            this.ExpiryDateLabel.Text = "Expiry Date";
            // 
            // MedicineQuantityTextBox
            // 
            this.MedicineQuantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicineQuantityTextBox.Location = new System.Drawing.Point(230, 178);
            this.MedicineQuantityTextBox.Name = "MedicineQuantityTextBox";
            this.MedicineQuantityTextBox.Size = new System.Drawing.Size(266, 27);
            this.MedicineQuantityTextBox.TabIndex = 6;
            // 
            // ExpiryDateTextBox
            // 
            this.ExpiryDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpiryDateTextBox.Location = new System.Drawing.Point(230, 234);
            this.ExpiryDateTextBox.Name = "ExpiryDateTextBox";
            this.ExpiryDateTextBox.Size = new System.Drawing.Size(266, 27);
            this.ExpiryDateTextBox.TabIndex = 7;
            this.ExpiryDateTextBox.Text = "                 /       /";
            // 
            // MedicineNameComboBox
            // 
            this.MedicineNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicineNameComboBox.FormattingEnabled = true;
            this.MedicineNameComboBox.Location = new System.Drawing.Point(230, 69);
            this.MedicineNameComboBox.Name = "MedicineNameComboBox";
            this.MedicineNameComboBox.Size = new System.Drawing.Size(266, 28);
            this.MedicineNameComboBox.TabIndex = 8;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.Location = new System.Drawing.Point(565, 301);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(121, 39);
            this.OKButton.TabIndex = 9;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            // 
            // RemindLabel
            // 
            this.RemindLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RemindLabel.AutoSize = true;
            this.RemindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemindLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.RemindLabel.Location = new System.Drawing.Point(227, 264);
            this.RemindLabel.Name = "RemindLabel";
            this.RemindLabel.Size = new System.Drawing.Size(202, 18);
            this.RemindLabel.TabIndex = 10;
            this.RemindLabel.Text = "Enter the expiry date correctly";
            // 
            // LogoPictureBox7
            // 
            this.LogoPictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPictureBox7.Image = global::TeryaqApp.Properties.Resources.IMG_20260502_195001_378;
            this.LogoPictureBox7.Location = new System.Drawing.Point(605, 2);
            this.LogoPictureBox7.Name = "LogoPictureBox7";
            this.LogoPictureBox7.Size = new System.Drawing.Size(125, 94);
            this.LogoPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox7.TabIndex = 11;
            this.LogoPictureBox7.TabStop = false;
            // 
            // DonateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(731, 364);
            this.Controls.Add(this.LogoPictureBox7);
            this.Controls.Add(this.RemindLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MedicineNameComboBox);
            this.Controls.Add(this.ExpiryDateTextBox);
            this.Controls.Add(this.MedicineQuantityTextBox);
            this.Controls.Add(this.ExpiryDateLabel);
            this.Controls.Add(this.MedicineQuantityLabel);
            this.Controls.Add(this.MedicineFormLabel);
            this.Controls.Add(this.MedicineFormComboBox);
            this.Controls.Add(this.MedicineNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DonateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Donate ";
            this.Load += new System.EventHandler(this.DonateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MedicineNameLabel;
        private System.Windows.Forms.ComboBox MedicineFormComboBox;
        private System.Windows.Forms.Label MedicineFormLabel;
        private System.Windows.Forms.Label MedicineQuantityLabel;
        private System.Windows.Forms.Label ExpiryDateLabel;
        private System.Windows.Forms.TextBox MedicineQuantityTextBox;
        private System.Windows.Forms.TextBox ExpiryDateTextBox;
        private System.Windows.Forms.ComboBox MedicineNameComboBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label RemindLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox7;
    }
}