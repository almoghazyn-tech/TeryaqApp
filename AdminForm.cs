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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void NearingExpiryDateMedicineButton_Click(object sender, EventArgs e)
        {
            NearingExpiryDateMedicinesForm nearingExpiryDateMedicines = new NearingExpiryDateMedicinesForm();
            nearingExpiryDateMedicines.ShowDialog();
        }

        private void ExpiredMedicineButton_Click(object sender, EventArgs e)
        {
            ExpiredMedicinesForm expiredMedicines = new ExpiredMedicinesForm();
            expiredMedicines.ShowDialog();
        }

        private void NewMedicinesButton_Click(object sender, EventArgs e)
        {
            NewMedicinesForm newMedicines = new NewMedicinesForm();
            newMedicines.ShowDialog();
        }
    }
}
