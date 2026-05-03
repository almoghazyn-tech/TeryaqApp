namespace TeryaqApp
{
    partial class MedicineNameEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineNameEditForm));
            this.MedicineNameEditLabel = new System.Windows.Forms.Label();
            this.NameMedicineEditTextBox = new System.Windows.Forms.TextBox();
            this.SaveNameButton = new System.Windows.Forms.Button();
            this.LogoPictureBox12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineNameEditLabel
            // 
            this.MedicineNameEditLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MedicineNameEditLabel.AutoSize = true;
            this.MedicineNameEditLabel.BackColor = System.Drawing.Color.DarkCyan;
            this.MedicineNameEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineNameEditLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.MedicineNameEditLabel.Location = new System.Drawing.Point(26, 75);
            this.MedicineNameEditLabel.Name = "MedicineNameEditLabel";
            this.MedicineNameEditLabel.Size = new System.Drawing.Size(161, 25);
            this.MedicineNameEditLabel.TabIndex = 0;
            this.MedicineNameEditLabel.Text = "Medicine Name";
            // 
            // NameMedicineEditTextBox
            // 
            this.NameMedicineEditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameMedicineEditTextBox.Location = new System.Drawing.Point(31, 113);
            this.NameMedicineEditTextBox.Name = "NameMedicineEditTextBox";
            this.NameMedicineEditTextBox.Size = new System.Drawing.Size(312, 27);
            this.NameMedicineEditTextBox.TabIndex = 1;
            // 
            // SaveNameButton
            // 
            this.SaveNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveNameButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNameButton.ForeColor = System.Drawing.Color.White;
            this.SaveNameButton.Location = new System.Drawing.Point(380, 228);
            this.SaveNameButton.Name = "SaveNameButton";
            this.SaveNameButton.Size = new System.Drawing.Size(130, 45);
            this.SaveNameButton.TabIndex = 2;
            this.SaveNameButton.Text = "Save";
            this.SaveNameButton.UseVisualStyleBackColor = false;
            // 
            // LogoPictureBox12
            // 
            this.LogoPictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPictureBox12.Image = global::TeryaqApp.Properties.Resources.IMG_20260502_195001_378;
            this.LogoPictureBox12.Location = new System.Drawing.Point(425, 0);
            this.LogoPictureBox12.Name = "LogoPictureBox12";
            this.LogoPictureBox12.Size = new System.Drawing.Size(123, 90);
            this.LogoPictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox12.TabIndex = 3;
            this.LogoPictureBox12.TabStop = false;
            // 
            // MedicineNameEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(549, 301);
            this.Controls.Add(this.LogoPictureBox12);
            this.Controls.Add(this.SaveNameButton);
            this.Controls.Add(this.NameMedicineEditTextBox);
            this.Controls.Add(this.MedicineNameEditLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicineNameEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medicine Name Edit";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MedicineNameEditLabel;
        private System.Windows.Forms.TextBox NameMedicineEditTextBox;
        private System.Windows.Forms.Button SaveNameButton;
        private System.Windows.Forms.PictureBox LogoPictureBox12;
    }
}