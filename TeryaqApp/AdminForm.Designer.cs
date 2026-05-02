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
            this.SuspendLayout();
            // 
            // ExpiredMedicineButton
            // 
            this.ExpiredMedicineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExpiredMedicineButton.BackColor = System.Drawing.Color.DarkRed;
            this.ExpiredMedicineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiredMedicineButton.ForeColor = System.Drawing.Color.White;
            this.ExpiredMedicineButton.Location = new System.Drawing.Point(12, 103);
            this.ExpiredMedicineButton.Name = "ExpiredMedicineButton";
            this.ExpiredMedicineButton.Size = new System.Drawing.Size(369, 57);
            this.ExpiredMedicineButton.TabIndex = 0;
            this.ExpiredMedicineButton.Text = "Expired Medicines";
            this.ExpiredMedicineButton.UseVisualStyleBackColor = false;
            this.ExpiredMedicineButton.Click += new System.EventHandler(this.ExpiredMedicineButton_Click);
            // 
            // NearingExpiryDateMedicineButton
            // 
            this.NearingExpiryDateMedicineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NearingExpiryDateMedicineButton.BackColor = System.Drawing.Color.DarkOrange;
            this.NearingExpiryDateMedicineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NearingExpiryDateMedicineButton.ForeColor = System.Drawing.Color.White;
            this.NearingExpiryDateMedicineButton.Location = new System.Drawing.Point(387, 103);
            this.NearingExpiryDateMedicineButton.Name = "NearingExpiryDateMedicineButton";
            this.NearingExpiryDateMedicineButton.Size = new System.Drawing.Size(366, 57);
            this.NearingExpiryDateMedicineButton.TabIndex = 1;
            this.NearingExpiryDateMedicineButton.Text = "Nearing Expiry Date Medicines";
            this.NearingExpiryDateMedicineButton.UseVisualStyleBackColor = false;
            this.NearingExpiryDateMedicineButton.Click += new System.EventHandler(this.NearingExpiryDateMedicineButton_Click);
            // 
            // NewMedicinesButton
            // 
            this.NewMedicinesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewMedicinesButton.BackColor = System.Drawing.Color.Salmon;
            this.NewMedicinesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMedicinesButton.ForeColor = System.Drawing.Color.White;
            this.NewMedicinesButton.Location = new System.Drawing.Point(222, 178);
            this.NewMedicinesButton.Name = "NewMedicinesButton";
            this.NewMedicinesButton.Size = new System.Drawing.Size(326, 57);
            this.NewMedicinesButton.TabIndex = 2;
            this.NewMedicinesButton.Text = "New Medicines";
            this.NewMedicinesButton.UseVisualStyleBackColor = false;
            this.NewMedicinesButton.Click += new System.EventHandler(this.NewMedicinesButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 349);
            this.Controls.Add(this.NewMedicinesButton);
            this.Controls.Add(this.NearingExpiryDateMedicineButton);
            this.Controls.Add(this.ExpiredMedicineButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExpiredMedicineButton;
        private System.Windows.Forms.Button NearingExpiryDateMedicineButton;
        private System.Windows.Forms.Button NewMedicinesButton;
    }
}