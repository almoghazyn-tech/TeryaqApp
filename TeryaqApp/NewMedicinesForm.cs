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
    public partial class NewMedicinesForm : Form
    {
        public NewMedicinesForm()
        {
            InitializeComponent();
        }

        private void medicinenameEditButton_Click(object sender, EventArgs e)
        {
            MedicineNameEditForm medicineNameEdit=new MedicineNameEditForm();
            medicineNameEdit.ShowDialog ();
        }
    }
}
