namespace TeryaqApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginButton2 = new System.Windows.Forms.Button();
            this.WelcomLabel = new System.Windows.Forms.Label();
            this.EmailTextBox2 = new System.Windows.Forms.TextBox();
            this.GuideLabel = new System.Windows.Forms.Label();
            this.EmailLable = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LogoPictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton2
            // 
            this.LoginButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.LoginButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton2.ForeColor = System.Drawing.Color.White;
            this.LoginButton2.Location = new System.Drawing.Point(306, 355);
            this.LoginButton2.Name = "LoginButton2";
            this.LoginButton2.Size = new System.Drawing.Size(112, 38);
            this.LoginButton2.TabIndex = 0;
            this.LoginButton2.Text = "Login";
            this.LoginButton2.UseVisualStyleBackColor = false;
            this.LoginButton2.Click += new System.EventHandler(this.LoginButton2_Click);
            // 
            // WelcomLabel
            // 
            this.WelcomLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomLabel.AutoSize = true;
            this.WelcomLabel.BackColor = System.Drawing.Color.Teal;
            this.WelcomLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WelcomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.WelcomLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WelcomLabel.Location = new System.Drawing.Point(287, 85);
            this.WelcomLabel.Name = "WelcomLabel";
            this.WelcomLabel.Size = new System.Drawing.Size(131, 25);
            this.WelcomLabel.TabIndex = 1;
            this.WelcomLabel.Text = "Welcom back";
            this.WelcomLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WelcomLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmailTextBox2
            // 
            this.EmailTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox2.BackColor = System.Drawing.Color.White;
            this.EmailTextBox2.Location = new System.Drawing.Point(93, 191);
            this.EmailTextBox2.Name = "EmailTextBox2";
            this.EmailTextBox2.Size = new System.Drawing.Size(305, 27);
            this.EmailTextBox2.TabIndex = 3;
            // 
            // GuideLabel
            // 
            this.GuideLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuideLabel.AutoSize = true;
            this.GuideLabel.BackColor = System.Drawing.Color.Teal;
            this.GuideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuideLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.GuideLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuideLabel.Location = new System.Drawing.Point(246, 119);
            this.GuideLabel.Name = "GuideLabel";
            this.GuideLabel.Size = new System.Drawing.Size(219, 25);
            this.GuideLabel.TabIndex = 4;
            this.GuideLabel.Text = "Login to your account";
            this.GuideLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuideLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmailLable
            // 
            this.EmailLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLable.AutoSize = true;
            this.EmailLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLable.ForeColor = System.Drawing.Color.Honeydew;
            this.EmailLable.Location = new System.Drawing.Point(13, 193);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(65, 25);
            this.EmailLable.TabIndex = 5;
            this.EmailLable.Text = "Email";
            this.EmailLable.Click += new System.EventHandler(this.EmailLable_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.PasswordLabel.Location = new System.Drawing.Point(13, 264);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 25);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.Location = new System.Drawing.Point(125, 262);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(273, 27);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // LogoPictureBox2
            // 
            this.LogoPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPictureBox2.Image = global::TeryaqApp.Properties.Resources.IMG_20260502_195001_378;
            this.LogoPictureBox2.Location = new System.Drawing.Point(583, 12);
            this.LogoPictureBox2.Name = "LogoPictureBox2";
            this.LogoPictureBox2.Size = new System.Drawing.Size(126, 97);
            this.LogoPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox2.TabIndex = 8;
            this.LogoPictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(721, 434);
            this.Controls.Add(this.LogoPictureBox2);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLable);
            this.Controls.Add(this.GuideLabel);
            this.Controls.Add(this.EmailTextBox2);
            this.Controls.Add(this.WelcomLabel);
            this.Controls.Add(this.LoginButton2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton2;
        private System.Windows.Forms.Label WelcomLabel;
        private System.Windows.Forms.TextBox EmailTextBox2;
        private System.Windows.Forms.Label GuideLabel;
        private System.Windows.Forms.Label EmailLable;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox LogoPictureBox2;
    }
}