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
            this.medicinenameEditButton = new System.Windows.Forms.Button();
            this.LogoPictureBox13 = new System.Windows.Forms.PictureBox();
            this.medicinenameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinetypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donornameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NewMedicinesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox13)).BeginInit();
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
            this.medicinetypeColumn,
            this.donornameColumn});
            this.NewMedicinesDataGridView.Location = new System.Drawing.Point(12, 57);
            this.NewMedicinesDataGridView.Name = "NewMedicinesDataGridView";
            this.NewMedicinesDataGridView.ReadOnly = true;
            this.NewMedicinesDataGridView.RowHeadersWidth = 51;
            this.NewMedicinesDataGridView.RowTemplate.Height = 24;
            this.NewMedicinesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NewMedicinesDataGridView.Size = new System.Drawing.Size(493, 327);
            this.NewMedicinesDataGridView.TabIndex = 0;
            // 
            // medicinenameEditButton
            // 
            this.medicinenameEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.medicinenameEditButton.BackColor = System.Drawing.Color.MediumAquamarine;
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
            // LogoPictureBox13
            // 
            this.LogoPictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPictureBox13.Image = global::TeryaqApp.Properties.Resources.favicon__1_;
            this.LogoPictureBox13.Location = new System.Drawing.Point(527, -6);
            this.LogoPictureBox13.Name = "LogoPictureBox13";
            this.LogoPictureBox13.Size = new System.Drawing.Size(120, 88);
            this.LogoPictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox13.TabIndex = 2;
            this.LogoPictureBox13.TabStop = false;
            // 
            // medicinenameColumn
            // 
            this.medicinenameColumn.HeaderText = "Medicine Name";
            this.medicinenameColumn.MinimumWidth = 6;
            this.medicinenameColumn.Name = "medicinenameColumn";
            this.medicinenameColumn.ReadOnly = true;
            this.medicinenameColumn.Width = 125;
            // 
            // medicinetypeColumn
            // 
            this.medicinetypeColumn.HeaderText = "Medicine Type";
            this.medicinetypeColumn.MinimumWidth = 6;
            this.medicinetypeColumn.Name = "medicinetypeColumn";
            this.medicinetypeColumn.ReadOnly = true;
            this.medicinetypeColumn.Width = 125;
            // 
            // donornameColumn
            // 
            this.donornameColumn.HeaderText = "Donor Name";
            this.donornameColumn.MinimumWidth = 6;
            this.donornameColumn.Name = "donornameColumn";
            this.donornameColumn.ReadOnly = true;
            this.donornameColumn.Width = 125;
            // 
            // NewMedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 443);
            this.Controls.Add(this.LogoPictureBox13);
            this.Controls.Add(this.medicinenameEditButton);
            this.Controls.Add(this.NewMedicinesDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewMedicinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Medicines";
            ((System.ComponentModel.ISupportInitialize)(this.NewMedicinesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NewMedicinesDataGridView;
        private System.Windows.Forms.Button medicinenameEditButton;
        private System.Windows.Forms.PictureBox LogoPictureBox13;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinenameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinetypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donornameColumn;
    }
}