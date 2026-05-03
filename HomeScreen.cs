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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            DonateForm donateform = new DonateForm();
            donateform.ShowDialog();

        }

        private void YourdonationsButton_Click(object sender, EventArgs e)
        {

        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            RequestForm request = new RequestForm();
            request.ShowDialog();
        }

        private void YourrequestsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
