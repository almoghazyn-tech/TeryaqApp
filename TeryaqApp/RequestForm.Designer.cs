namespace TeryaqApp
{
    partial class RequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.AvailableMedincineDataGridView1 = new System.Windows.Forms.DataGridView();
            this.LogoPictureBox8 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.MedicineNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GovernorateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableMedincineDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchTextBox.BackColor = System.Drawing.Color.LightGray;
            this.SearchTextBox.Location = new System.Drawing.Point(12, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(244, 27);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.Text = "Search for the medicine....";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // AvailableMedincineDataGridView1
            // 
            this.AvailableMedincineDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailableMedincineDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.AvailableMedincineDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableMedincineDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineNameColumn,
            this.MedicineTypeColumn,
            this.MedicineQuantityColumn,
            this.donorNameColumn,
            this.GovernorateColumn});
            this.AvailableMedincineDataGridView1.Location = new System.Drawing.Point(12, 77);
            this.AvailableMedincineDataGridView1.Name = "AvailableMedincineDataGridView1";
            this.AvailableMedincineDataGridView1.ReadOnly = true;
            this.AvailableMedincineDataGridView1.RowHeadersWidth = 51;
            this.AvailableMedincineDataGridView1.RowTemplate.Height = 24;
            this.AvailableMedincineDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AvailableMedincineDataGridView1.Size = new System.Drawing.Size(740, 256);
            this.AvailableMedincineDataGridView1.TabIndex = 1;
            this.AvailableMedincineDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LogoPictureBox8
            // 
            this.LogoPictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPictureBox8.Image = global::TeryaqApp.Properties.Resources.favicon__1_;
            this.LogoPictureBox8.Location = new System.Drawing.Point(626, -1);
            this.LogoPictureBox8.Name = "LogoPictureBox8";
            this.LogoPictureBox8.Size = new System.Drawing.Size(138, 72);
            this.LogoPictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox8.TabIndex = 3;
            this.LogoPictureBox8.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(502, 344);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(118, 43);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // CompleteButton
            // 
            this.CompleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.CompleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteButton.ForeColor = System.Drawing.Color.White;
            this.CompleteButton.Location = new System.Drawing.Point(626, 344);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(118, 43);
            this.CompleteButton.TabIndex = 6;
            this.CompleteButton.Text = "Complete";
            this.CompleteButton.UseVisualStyleBackColor = false;
            // 
            // MedicineNameColumn
            // 
            this.MedicineNameColumn.HeaderText = "Medicine Name";
            this.MedicineNameColumn.MinimumWidth = 6;
            this.MedicineNameColumn.Name = "MedicineNameColumn";
            this.MedicineNameColumn.ReadOnly = true;
            this.MedicineNameColumn.Width = 125;
            // 
            // MedicineTypeColumn
            // 
            this.MedicineTypeColumn.HeaderText = "Medicine Type";
            this.MedicineTypeColumn.MinimumWidth = 6;
            this.MedicineTypeColumn.Name = "MedicineTypeColumn";
            this.MedicineTypeColumn.ReadOnly = true;
            this.MedicineTypeColumn.Width = 125;
            // 
            // MedicineQuantityColumn
            // 
            this.MedicineQuantityColumn.HeaderText = "Medicine Quantity";
            this.MedicineQuantityColumn.MinimumWidth = 6;
            this.MedicineQuantityColumn.Name = "MedicineQuantityColumn";
            this.MedicineQuantityColumn.ReadOnly = true;
            this.MedicineQuantityColumn.Width = 125;
            // 
            // donorNameColumn
            // 
            this.donorNameColumn.HeaderText = "Donor Name";
            this.donorNameColumn.MinimumWidth = 6;
            this.donorNameColumn.Name = "donorNameColumn";
            this.donorNameColumn.ReadOnly = true;
            this.donorNameColumn.Width = 125;
            // 
            // GovernorateColumn
            // 
            this.GovernorateColumn.HeaderText = "Governorate ";
            this.GovernorateColumn.MinimumWidth = 6;
            this.GovernorateColumn.Name = "GovernorateColumn";
            this.GovernorateColumn.ReadOnly = true;
            this.GovernorateColumn.Width = 125;
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 399);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.LogoPictureBox8);
            this.Controls.Add(this.AvailableMedincineDataGridView1);
            this.Controls.Add(this.SearchTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Request ";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableMedincineDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView AvailableMedincineDataGridView1;
        private System.Windows.Forms.PictureBox LogoPictureBox8;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GovernorateColumn;
    }
}