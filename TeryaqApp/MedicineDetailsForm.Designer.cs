namespace TeryaqApp
{
    partial class MedicineDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineDetailsForm));
            this.MedNameLabel = new System.Windows.Forms.Label();
            this.MedQuantityLabel = new System.Windows.Forms.Label();
            this.MedQuantityTextBox = new System.Windows.Forms.TextBox();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PhoneNumberLabel1 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox1 = new System.Windows.Forms.TextBox();
            this.MedicinePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MedNameLabel
            // 
            this.MedNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MedNameLabel.AutoSize = true;
            this.MedNameLabel.BackColor = System.Drawing.Color.White;
            this.MedNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.MedNameLabel.Location = new System.Drawing.Point(12, 26);
            this.MedNameLabel.Name = "MedNameLabel";
            this.MedNameLabel.Size = new System.Drawing.Size(161, 25);
            this.MedNameLabel.TabIndex = 0;
            this.MedNameLabel.Text = "Medicine Name";
            // 
            // MedQuantityLabel
            // 
            this.MedQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MedQuantityLabel.AutoSize = true;
            this.MedQuantityLabel.BackColor = System.Drawing.Color.White;
            this.MedQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedQuantityLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.MedQuantityLabel.Location = new System.Drawing.Point(12, 341);
            this.MedQuantityLabel.Name = "MedQuantityLabel";
            this.MedQuantityLabel.Size = new System.Drawing.Size(186, 25);
            this.MedQuantityLabel.TabIndex = 2;
            this.MedQuantityLabel.Text = "Medicine Quantity";
            this.MedQuantityLabel.Click += new System.EventHandler(this.MedQuantityLabel_Click);
            // 
            // MedQuantityTextBox
            // 
            this.MedQuantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MedQuantityTextBox.Location = new System.Drawing.Point(242, 339);
            this.MedQuantityTextBox.Name = "MedQuantityTextBox";
            this.MedQuantityTextBox.Size = new System.Drawing.Size(114, 27);
            this.MedQuantityTextBox.TabIndex = 3;
            // 
            // CompleteButton
            // 
            this.CompleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteButton.BackColor = System.Drawing.Color.DarkBlue;
            this.CompleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteButton.ForeColor = System.Drawing.Color.White;
            this.CompleteButton.Location = new System.Drawing.Point(591, 467);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(118, 43);
            this.CompleteButton.TabIndex = 4;
            this.CompleteButton.Text = "Complete";
            this.CompleteButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.DarkBlue;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(450, 467);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(118, 43);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // PhoneNumberLabel1
            // 
            this.PhoneNumberLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PhoneNumberLabel1.AutoSize = true;
            this.PhoneNumberLabel1.BackColor = System.Drawing.Color.White;
            this.PhoneNumberLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.PhoneNumberLabel1.Location = new System.Drawing.Point(12, 390);
            this.PhoneNumberLabel1.Name = "PhoneNumberLabel1";
            this.PhoneNumberLabel1.Size = new System.Drawing.Size(155, 25);
            this.PhoneNumberLabel1.TabIndex = 6;
            this.PhoneNumberLabel1.Text = "Phone Number";
            // 
            // PhoneNumberTextBox1
            // 
            this.PhoneNumberTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberTextBox1.Location = new System.Drawing.Point(199, 388);
            this.PhoneNumberTextBox1.Name = "PhoneNumberTextBox1";
            this.PhoneNumberTextBox1.Size = new System.Drawing.Size(214, 27);
            this.PhoneNumberTextBox1.TabIndex = 7;
            this.PhoneNumberTextBox1.TextChanged += new System.EventHandler(this.PhoneNumberTextBox1_TextChanged);
            // 
            // MedicinePictureBox
            // 
            this.MedicinePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicinePictureBox.Image = global::TeryaqApp.Properties.Resources.favicon__1_;
            this.MedicinePictureBox.Location = new System.Drawing.Point(12, 64);
            this.MedicinePictureBox.Name = "MedicinePictureBox";
            this.MedicinePictureBox.Size = new System.Drawing.Size(444, 249);
            this.MedicinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MedicinePictureBox.TabIndex = 1;
            this.MedicinePictureBox.TabStop = false;
            this.MedicinePictureBox.Click += new System.EventHandler(this.MedicinePictureBox_Click);
            // 
            // MedicineDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 522);
            this.Controls.Add(this.PhoneNumberTextBox1);
            this.Controls.Add(this.PhoneNumberLabel1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.MedQuantityTextBox);
            this.Controls.Add(this.MedQuantityLabel);
            this.Controls.Add(this.MedicinePictureBox);
            this.Controls.Add(this.MedNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicineDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medicine Details";
            this.Load += new System.EventHandler(this.MedicineDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicinePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MedNameLabel;
        private System.Windows.Forms.PictureBox MedicinePictureBox;
        private System.Windows.Forms.Label MedQuantityLabel;
        private System.Windows.Forms.TextBox MedQuantityTextBox;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label PhoneNumberLabel1;
        private System.Windows.Forms.TextBox PhoneNumberTextBox1;
    }
}