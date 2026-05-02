namespace TeryaqApp
{
    partial class NearingExpiryDateMedicinesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NearingExpiryDateMedicinesForm));
            this.NearingExpiryDateMedicinesDataGridView = new System.Windows.Forms.DataGridView();
            this.BacktoAdminFormButton1 = new System.Windows.Forms.Button();
            this.medNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NearingExpiryDateMedicinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NearingExpiryDateMedicinesDataGridView
            // 
            this.NearingExpiryDateMedicinesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NearingExpiryDateMedicinesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.NearingExpiryDateMedicinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NearingExpiryDateMedicinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medNameColumn,
            this.medQuantityColumn,
            this.expiryDateColumn,
            this.donorNameColumn});
            this.NearingExpiryDateMedicinesDataGridView.Location = new System.Drawing.Point(2, 1);
            this.NearingExpiryDateMedicinesDataGridView.Name = "NearingExpiryDateMedicinesDataGridView";
            this.NearingExpiryDateMedicinesDataGridView.ReadOnly = true;
            this.NearingExpiryDateMedicinesDataGridView.RowHeadersWidth = 51;
            this.NearingExpiryDateMedicinesDataGridView.RowTemplate.Height = 24;
            this.NearingExpiryDateMedicinesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NearingExpiryDateMedicinesDataGridView.Size = new System.Drawing.Size(581, 389);
            this.NearingExpiryDateMedicinesDataGridView.TabIndex = 0;
            // 
            // BacktoAdminFormButton1
            // 
            this.BacktoAdminFormButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BacktoAdminFormButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.BacktoAdminFormButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoAdminFormButton1.ForeColor = System.Drawing.Color.White;
            this.BacktoAdminFormButton1.Location = new System.Drawing.Point(541, 412);
            this.BacktoAdminFormButton1.Name = "BacktoAdminFormButton1";
            this.BacktoAdminFormButton1.Size = new System.Drawing.Size(130, 40);
            this.BacktoAdminFormButton1.TabIndex = 1;
            this.BacktoAdminFormButton1.Text = "Back";
            this.BacktoAdminFormButton1.UseVisualStyleBackColor = false;
            // 
            // medNameColumn
            // 
            this.medNameColumn.HeaderText = "Medicine Name";
            this.medNameColumn.MinimumWidth = 6;
            this.medNameColumn.Name = "medNameColumn";
            this.medNameColumn.ReadOnly = true;
            this.medNameColumn.Width = 125;
            // 
            // medQuantityColumn
            // 
            this.medQuantityColumn.HeaderText = "Medicine Quantity";
            this.medQuantityColumn.MinimumWidth = 6;
            this.medQuantityColumn.Name = "medQuantityColumn";
            this.medQuantityColumn.ReadOnly = true;
            this.medQuantityColumn.Width = 125;
            // 
            // expiryDateColumn
            // 
            this.expiryDateColumn.HeaderText = "Expiry Date";
            this.expiryDateColumn.MinimumWidth = 6;
            this.expiryDateColumn.Name = "expiryDateColumn";
            this.expiryDateColumn.ReadOnly = true;
            this.expiryDateColumn.Width = 125;
            // 
            // donorNameColumn
            // 
            this.donorNameColumn.HeaderText = "Donor Name";
            this.donorNameColumn.MinimumWidth = 6;
            this.donorNameColumn.Name = "donorNameColumn";
            this.donorNameColumn.ReadOnly = true;
            this.donorNameColumn.Width = 125;
            // 
            // NearingExpiryDateMedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 478);
            this.Controls.Add(this.BacktoAdminFormButton1);
            this.Controls.Add(this.NearingExpiryDateMedicinesDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NearingExpiryDateMedicinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nearing Expiry Date Medicines";
            ((System.ComponentModel.ISupportInitialize)(this.NearingExpiryDateMedicinesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NearingExpiryDateMedicinesDataGridView;
        private System.Windows.Forms.Button BacktoAdminFormButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorNameColumn;
    }
}