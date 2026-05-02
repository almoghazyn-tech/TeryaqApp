namespace TeryaqApp
{
    partial class NewMedicinesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMedicinesForm));
            this.NewMedicinesDataGridView = new System.Windows.Forms.DataGridView();
            this.medicinenameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineformColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donornameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinenameEditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NewMedicinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NewMedicinesDataGridView
            // 
            this.NewMedicinesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewMedicinesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.NewMedicinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewMedicinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicinenameColumn,
            this.medicineformColumn,
            this.donornameColumn});
            this.NewMedicinesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.NewMedicinesDataGridView.Name = "NewMedicinesDataGridView";
            this.NewMedicinesDataGridView.ReadOnly = true;
            this.NewMedicinesDataGridView.RowHeadersWidth = 51;
            this.NewMedicinesDataGridView.RowTemplate.Height = 24;
            this.NewMedicinesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NewMedicinesDataGridView.Size = new System.Drawing.Size(518, 370);
            this.NewMedicinesDataGridView.TabIndex = 0;
            // 
            // medicinenameColumn
            // 
            this.medicinenameColumn.HeaderText = "Medicine Name";
            this.medicinenameColumn.MinimumWidth = 6;
            this.medicinenameColumn.Name = "medicinenameColumn";
            this.medicinenameColumn.ReadOnly = true;
            this.medicinenameColumn.Width = 125;
            // 
            // medicineformColumn
            // 
            this.medicineformColumn.HeaderText = "Medicine Form";
            this.medicineformColumn.MinimumWidth = 6;
            this.medicineformColumn.Name = "medicineformColumn";
            this.medicineformColumn.ReadOnly = true;
            this.medicineformColumn.Width = 125;
            // 
            // donornameColumn
            // 
            this.donornameColumn.HeaderText = "Donor Name";
            this.donornameColumn.MinimumWidth = 6;
            this.donornameColumn.Name = "donornameColumn";
            this.donornameColumn.ReadOnly = true;
            this.donornameColumn.Width = 125;
            // 
            // medicinenameEditButton
            // 
            this.medicinenameEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.medicinenameEditButton.BackColor = System.Drawing.Color.Salmon;
            this.medicinenameEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicinenameEditButton.ForeColor = System.Drawing.Color.White;
            this.medicinenameEditButton.Location = new System.Drawing.Point(507, 390);
            this.medicinenameEditButton.Name = "medicinenameEditButton";
            this.medicinenameEditButton.Size = new System.Drawing.Size(127, 41);
            this.medicinenameEditButton.TabIndex = 1;
            this.medicinenameEditButton.Text = "Edit";
            this.medicinenameEditButton.UseVisualStyleBackColor = false;
            this.medicinenameEditButton.Click += new System.EventHandler(this.medicinenameEditButton_Click);
            // 
            // NewMedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 443);
            this.Controls.Add(this.medicinenameEditButton);
            this.Controls.Add(this.NewMedicinesDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewMedicinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Medicines";
            ((System.ComponentModel.ISupportInitialize)(this.NewMedicinesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NewMedicinesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinenameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineformColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donornameColumn;
        private System.Windows.Forms.Button medicinenameEditButton;
    }
}