namespace TeryaqApp
{
    partial class SignUpForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm1));
            this.EmailTextBox1 = new System.Windows.Forms.TextBox();
            this.WelcomeLabel1 = new System.Windows.Forms.Label();
            this.NextButton1 = new System.Windows.Forms.Button();
            this.GuideLabel1 = new System.Windows.Forms.Label();
            this.EmailLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailTextBox1
            // 
            this.EmailTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox1.Location = new System.Drawing.Point(27, 165);
            this.EmailTextBox1.Name = "EmailTextBox1";
            this.EmailTextBox1.Size = new System.Drawing.Size(286, 22);
            this.EmailTextBox1.TabIndex = 0;
            // 
            // WelcomeLabel1
            // 
            this.WelcomeLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeLabel1.AutoSize = true;
            this.WelcomeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.WelcomeLabel1.Location = new System.Drawing.Point(269, 29);
            this.WelcomeLabel1.Name = "WelcomeLabel1";
            this.WelcomeLabel1.Size = new System.Drawing.Size(95, 25);
            this.WelcomeLabel1.TabIndex = 1;
            this.WelcomeLabel1.Text = "Welcome";
            this.WelcomeLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NextButton1
            // 
            this.NextButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.NextButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton1.ForeColor = System.Drawing.Color.White;
            this.NextButton1.Location = new System.Drawing.Point(496, 239);
            this.NextButton1.Name = "NextButton1";
            this.NextButton1.Size = new System.Drawing.Size(90, 45);
            this.NextButton1.TabIndex = 2;
            this.NextButton1.Text = "Next";
            this.NextButton1.UseVisualStyleBackColor = false;
            this.NextButton1.Click += new System.EventHandler(this.NextButton1_Click);
            // 
            // GuideLabel1
            // 
            this.GuideLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuideLabel1.AutoSize = true;
            this.GuideLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuideLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.GuideLabel1.Location = new System.Drawing.Point(214, 64);
            this.GuideLabel1.Name = "GuideLabel1";
            this.GuideLabel1.Size = new System.Drawing.Size(204, 25);
            this.GuideLabel1.TabIndex = 3;
            this.GuideLabel1.Text = "Create new account";
            this.GuideLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmailLabel1
            // 
            this.EmailLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailLabel1.AutoSize = true;
            this.EmailLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.EmailLabel1.Location = new System.Drawing.Point(22, 126);
            this.EmailLabel1.Name = "EmailLabel1";
            this.EmailLabel1.Size = new System.Drawing.Size(65, 25);
            this.EmailLabel1.TabIndex = 4;
            this.EmailLabel1.Text = "Email";
            this.EmailLabel1.Click += new System.EventHandler(this.EmailLabel1_Click);
            // 
            // SignUpForm1
            // 
            this.AcceptButton = this.NextButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 312);
            this.Controls.Add(this.EmailLabel1);
            this.Controls.Add(this.GuideLabel1);
            this.Controls.Add(this.NextButton1);
            this.Controls.Add(this.WelcomeLabel1);
            this.Controls.Add(this.EmailTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextBox1;
        private System.Windows.Forms.Label WelcomeLabel1;
        private System.Windows.Forms.Button NextButton1;
        private System.Windows.Forms.Label GuideLabel1;
        private System.Windows.Forms.Label EmailLabel1;
    }
}