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
    public partial class SignUpForm3 : Form
    {
        public SignUpForm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen homescreen = new HomeScreen();
            homescreen.ShowDialog();
        }
    }
}
