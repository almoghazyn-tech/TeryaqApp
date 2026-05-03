using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeryaqApp
{
    public partial class teryaqApp : Form
    {
        public teryaqApp()
        {
            InitializeComponent();
        }

        private void teryaqApp_Load(object sender, EventArgs e)
        {

        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signup1 = new SignUpForm();
            signup1.ShowDialog();
        }
    }
}
