namespace TeryaqApp
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.DonateButton = new System.Windows.Forms.Button();
            this.RequestButton = new System.Windows.Forms.Button();
            this.LogoPictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // DonateButton
            // 
            this.DonateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DonateButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.DonateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateButton.ForeColor = System.Drawing.Color.White;
            this.DonateButton.Location = new System.Drawing.Point(393, 115);
            this.DonateButton.Margin = new System.Windows.Forms.Padding(4);
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Size = new System.Drawing.Size(211, 70);
            this.DonateButton.TabIndex = 0;
            this.DonateButton.Text = "Donate";
            this.DonateButton.UseVisualStyleBackColor = false;
            this.DonateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // RequestButton
            // 
            this.RequestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RequestButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.RequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestButton.ForeColor = System.Drawing.Color.White;
            this.RequestButton.Location = new System.Drawing.Point(103, 115);
            this.RequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(212, 70);
            this.RequestButton.TabIndex = 2;
            this.RequestButton.Text = "Requst";
            this.RequestButton.UseVisualStyleBackColor = false;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // LogoPictureBox6
            // 
            this.LogoPictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPictureBox6.Image = global::TeryaqApp.Properties.Resources.IMG_20260502_195001_378;
            this.LogoPictureBox6.Location = new System.Drawing.Point(592, 1);
            this.LogoPictureBox6.Name = "LogoPictureBox6";
            this.LogoPictureBox6.Size = new System.Drawing.Size(122, 91);
            this.LogoPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox6.TabIndex = 3;
            this.LogoPictureBox6.TabStop = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(716, 296);
            this.Controls.Add(this.LogoPictureBox6);
            this.Controls.Add(this.RequestButton);
            this.Controls.Add(this.DonateButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DonateButton;
        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.PictureBox LogoPictureBox6;
    }
}