namespace TeryaqApp
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.ExpiredMedicineButton = new System.Windows.Forms.Button();
            this.NearingExpiryDateMedicineButton = new System.Windows.Forms.Button();
            this.NewMedicinesButton = new System.Windows.Forms.Button();
            this.LogoPictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpiredMedicineButton
            // 
            this.ExpiredMedicineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExpiredMedicineButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ExpiredMedicineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiredMedicineButton.ForeColor = System.Drawing.Color.White;
            this.ExpiredMedicineButton.Location = new System.Drawing.Point(34, 150);
            this.ExpiredMedicineButton.Name = "ExpiredMedicineButton";
            this.ExpiredMedicineButton.Size = new System.Drawing.Size(335, 57);
            this.ExpiredMedicineButton.TabIndex = 0;
            this.ExpiredMedicineButton.Text = "Expired Medicines";
            this.ExpiredMedicineButton.UseVisualStyleBackColor = false;
            this.ExpiredMedicineButton.Click += new System.EventHandler(this.ExpiredMedicineButton_Click);
            // 
            // NearingExpiryDateMedicineButton
            // 
            this.NearingExpiryDateMedicineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NearingExpiryDateMedicineButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.NearingExpiryDateMedicineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NearingExpiryDateMedicineButton.ForeColor = System.Drawing.Color.White;
            this.NearingExpiryDateMedicineButton.Location = new System.Drawing.Point(392, 150);
            this.NearingExpiryDateMedicineButton.Name = "NearingExpiryDateMedicineButton";
            this.NearingExpiryDateMedicineButton.Size = new System.Drawing.Size(335, 57);
            this.NearingExpiryDateMedicineButton.TabIndex = 1;
            this.NearingExpiryDateMedicineButton.Text = "Nearing Expiry Date Medicines";
            this.NearingExpiryDateMedicineButton.UseVisualStyleBackColor = false;
            this.NearingExpiryDateMedicineButton.Click += new System.EventHandler(this.NearingExpiryDateMedicineButton_Click);
            // 
            // NewMedicinesButton
            // 
            this.NewMedicinesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewMedicinesButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.NewMedicinesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMedicinesButton.ForeColor = System.Drawing.Color.White;
            this.NewMedicinesButton.Location = new System.Drawing.Point(212, 232);
            this.NewMedicinesButton.Name = "NewMedicinesButton";
            this.NewMedicinesButton.Size = new System.Drawing.Size(335, 57);
            this.NewMedicinesButton.TabIndex = 2;
            this.NewMedicinesButton.Text = "New Medicines";
            this.NewMedicinesButton.UseVisualStyleBackColor = false;
            this.NewMedicinesButton.Click += new System.EventHandler(this.NewMedicinesButton_Click);
            // 
            // LogoPictureBox10
            // 
            this.LogoPictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPictureBox10.Image = global::TeryaqApp.Properties.Resources.IMG_20260502_195001_378;
            this.LogoPictureBox10.Location = new System.Drawing.Point(303, 12);
            this.LogoPictureBox10.Name = "LogoPictureBox10";
            this.LogoPictureBox10.Size = new System.Drawing.Size(150, 111);
            this.LogoPictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox10.TabIndex = 3;
            this.LogoPictureBox10.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(765, 349);
            this.Controls.Add(this.LogoPictureBox10);
            this.Controls.Add(this.NewMedicinesButton);
            this.Controls.Add(this.NearingExpiryDateMedicineButton);
            this.Controls.Add(this.ExpiredMedicineButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExpiredMedicineButton;
        private System.Windows.Forms.Button NearingExpiryDateMedicineButton;
        private System.Windows.Forms.Button NewMedicinesButton;
        private System.Windows.Forms.PictureBox LogoPictureBox10;
    }
}