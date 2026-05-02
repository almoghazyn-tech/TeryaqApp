namespace TeryaqApp
{
    partial class ExpiredMedicinesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpiredMedicinesForm));
            this.ExpiryMedicinesDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MednameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryMedicinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpiryMedicinesDataGridView
            // 
            this.ExpiryMedicinesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpiryMedicinesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ExpiryMedicinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpiryMedicinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MednameColumn,
            this.ExpiryDateColumn,
            this.DonorNameColumn});
            this.ExpiryMedicinesDataGridView.Location = new System.Drawing.Point(2, 3);
            this.ExpiryMedicinesDataGridView.Name = "ExpiryMedicinesDataGridView";
            this.ExpiryMedicinesDataGridView.ReadOnly = true;
            this.ExpiryMedicinesDataGridView.RowHeadersWidth = 51;
            this.ExpiryMedicinesDataGridView.RowTemplate.Height = 24;
            this.ExpiryMedicinesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpiryMedicinesDataGridView.Size = new System.Drawing.Size(530, 396);
            this.ExpiryMedicinesDataGridView.TabIndex = 0;
            this.ExpiryMedicinesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpiryMedicineDataGridView_CellContentClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(526, 418);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 40);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // MednameColumn
            // 
            this.MednameColumn.HeaderText = "Medicine Name";
            this.MednameColumn.MinimumWidth = 6;
            this.MednameColumn.Name = "MednameColumn";
            this.MednameColumn.ReadOnly = true;
            this.MednameColumn.Width = 125;
            // 
            // ExpiryDateColumn
            // 
            this.ExpiryDateColumn.HeaderText = "Expiry Date";
            this.ExpiryDateColumn.MinimumWidth = 6;
            this.ExpiryDateColumn.Name = "ExpiryDateColumn";
            this.ExpiryDateColumn.ReadOnly = true;
            this.ExpiryDateColumn.Width = 125;
            // 
            // DonorNameColumn
            // 
            this.DonorNameColumn.HeaderText = "Donor Name";
            this.DonorNameColumn.MinimumWidth = 6;
            this.DonorNameColumn.Name = "DonorNameColumn";
            this.DonorNameColumn.ReadOnly = true;
            this.DonorNameColumn.Width = 125;
            // 
            // ExpiredMedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 484);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ExpiryMedicinesDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExpiredMedicinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Expired Medicines";
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryMedicinesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExpiryMedicinesDataGridView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MednameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorNameColumn;
    }
}