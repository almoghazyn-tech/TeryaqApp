namespace TeryaqApp
{
    partial class SignUpForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm3));
            this.GuideLabel3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.PasswordLabel1 = new System.Windows.Forms.Label();
            this.BackButton2 = new System.Windows.Forms.Button();
            this.LgoPictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LgoPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // GuideLabel3
            // 
            this.GuideLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuideLabel3.AutoSize = true;
            this.GuideLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuideLabel3.ForeColor = System.Drawing.Color.Honeydew;
            this.GuideLabel3.Location = new System.Drawing.Point(104, 32);
            this.GuideLabel3.Name = "GuideLabel3";
            this.GuideLabel3.Size = new System.Drawing.Size(314, 25);
            this.GuideLabel3.TabIndex = 0;
            this.GuideLabel3.Text = "Complete creating new account";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(406, 254);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(102, 44);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox1.Location = new System.Drawing.Point(27, 164);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.Size = new System.Drawing.Size(286, 27);
            this.PasswordTextBox1.TabIndex = 2;
            // 
            // PasswordLabel1
            // 
            this.PasswordLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PasswordLabel1.AutoSize = true;
            this.PasswordLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel1.ForeColor = System.Drawing.Color.Honeydew;
            this.PasswordLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PasswordLabel1.Location = new System.Drawing.Point(22, 121);
            this.PasswordLabel1.Name = "PasswordLabel1";
            this.PasswordLabel1.Size = new System.Drawing.Size(106, 25);
            this.PasswordLabel1.TabIndex = 3;
            this.PasswordLabel1.Text = "Password";
            // 
            // BackButton2
            // 
            this.BackButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackButton2.ForeColor = System.Drawing.Color.White;
            this.BackButton2.Location = new System.Drawing.Point(280, 254);
            this.BackButton2.Name = "BackButton2";
            this.BackButton2.Size = new System.Drawing.Size(102, 44);
            this.BackButton2.TabIndex = 4;
            this.BackButton2.Text = "Back";
            this.BackButton2.UseVisualStyleBackColor = false;
            // 
            // LgoPictureBox5
            // 
            this.LgoPictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LgoPictureBox5.Image = global::TeryaqApp.Properties.Resources.IMG_20260502_195001_378;
            this.LgoPictureBox5.Location = new System.Drawing.Point(436, -2);
            this.LgoPictureBox5.Name = "LgoPictureBox5";
            this.LgoPictureBox5.Size = new System.Drawing.Size(117, 86);
            this.LgoPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LgoPictureBox5.TabIndex = 5;
            this.LgoPictureBox5.TabStop = false;
            // 
            // SignUpForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(554, 321);
            this.Controls.Add(this.LgoPictureBox5);
            this.Controls.Add(this.BackButton2);
            this.Controls.Add(this.PasswordLabel1);
            this.Controls.Add(this.PasswordTextBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GuideLabel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUpForm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.LgoPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuideLabel3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox PasswordTextBox1;
        private System.Windows.Forms.Label PasswordLabel1;
        private System.Windows.Forms.Button BackButton2;
        private System.Windows.Forms.PictureBox LgoPictureBox5;
    }
}