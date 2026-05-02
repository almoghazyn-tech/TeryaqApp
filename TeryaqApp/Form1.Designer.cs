namespace TeryaqApp
{
    partial class teryaqApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teryaqApp));
            this.SignUpButton1 = new System.Windows.Forms.Button();
            this.LoginButton1 = new System.Windows.Forms.Button();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpButton1
            // 
            this.SignUpButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.SignUpButton1.ForeColor = System.Drawing.Color.White;
            this.SignUpButton1.Location = new System.Drawing.Point(185, 113);
            this.SignUpButton1.Name = "SignUpButton1";
            this.SignUpButton1.Size = new System.Drawing.Size(252, 40);
            this.SignUpButton1.TabIndex = 0;
            this.SignUpButton1.Text = "Sign Up";
            this.SignUpButton1.UseVisualStyleBackColor = false;
            this.SignUpButton1.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LoginButton1
            // 
            this.LoginButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.LoginButton1.ForeColor = System.Drawing.Color.White;
            this.LoginButton1.Location = new System.Drawing.Point(185, 199);
            this.LoginButton1.Name = "LoginButton1";
            this.LoginButton1.Size = new System.Drawing.Size(252, 40);
            this.LoginButton1.TabIndex = 1;
            this.LoginButton1.Text = "Log in";
            this.LoginButton1.UseVisualStyleBackColor = false;
            this.LoginButton1.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.BackColor = System.Drawing.Color.White;
            this.SignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.SignUpLabel.Location = new System.Drawing.Point(192, 156);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(171, 16);
            this.SignUpLabel.TabIndex = 2;
            this.SignUpLabel.Text = "If you don\'t have an account";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.LoginLabel.Location = new System.Drawing.Point(192, 242);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(188, 16);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "If you already have an account";
            // 
            // teryaqApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 379);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.LoginButton1);
            this.Controls.Add(this.SignUpButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "teryaqApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teryaq";
            this.Load += new System.EventHandler(this.teryaqApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton1;
        private System.Windows.Forms.Button LoginButton1;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Label LoginLabel;
    }
}

