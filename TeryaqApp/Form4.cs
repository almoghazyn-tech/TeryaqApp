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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm2_Load(object sender, EventArgs e)
        {

        }

        private void BackButton3_Click(object sender, EventArgs e)
        {

        }

        private void NextButton2_Click(object sender, EventArgs e)
        {
            SignUpForm3 signup3 = new SignUpForm3();
            signup3.ShowDialog();
        }

        private void EmailLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
