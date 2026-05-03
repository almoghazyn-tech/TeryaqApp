namespace Teryaq
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.WelcomeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Teal;
            this.WelcomeLabel.Enabled = false;
            this.WelcomeLabel.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(133, 253);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(560, 157);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome to Teryaq Platform";
            this.WelcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WelcomeRichTextBox
            // 
            this.WelcomeRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeRichTextBox.BackColor = System.Drawing.Color.White;
            this.WelcomeRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WelcomeRichTextBox.Enabled = false;
            this.WelcomeRichTextBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeRichTextBox.ForeColor = System.Drawing.Color.Teal;
            this.WelcomeRichTextBox.Location = new System.Drawing.Point(60, 315);
            this.WelcomeRichTextBox.Name = "WelcomeRichTextBox";
            this.WelcomeRichTextBox.ReadOnly = true;
            this.WelcomeRichTextBox.Size = new System.Drawing.Size(729, 170);
            this.WelcomeRichTextBox.TabIndex = 2;
            this.WelcomeRichTextBox.Text = resources.GetString("WelcomeRichTextBox.Text");
            this.WelcomeRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // StartLabel
            // 
            this.StartLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.StartLabel.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.ForeColor = System.Drawing.Color.Teal;
            this.StartLabel.Location = new System.Drawing.Point(348, 517);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(134, 46);
            this.StartLabel.TabIndex = 3;
            this.StartLabel.Text = "  Start";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoPictureBox.Image = global::Teryaq.Properties.Resources.IMG_20260502_195001_378;
            this.LogoPictureBox.Location = new System.Drawing.Point(255, 24);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(306, 221);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 5;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(854, 589);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.WelcomeRichTextBox);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion      

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.RichTextBox WelcomeRichTextBox;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}