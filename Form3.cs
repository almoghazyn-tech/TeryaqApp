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
    public partial class SignUpForm1 : Form
    {
        public SignUpForm1()
        {
            InitializeComponent();
        }

        private void NextButton1_Click(object sender, EventArgs e)
        {
            SignUpForm2 signup2 = new SignUpForm2();
            signup2.ShowDialog();
        }

        private void EmailLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
