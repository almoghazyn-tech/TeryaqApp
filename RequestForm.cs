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
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_Enter(object sender, EventArgs e)     //عند ضغط المستخدم على شريط البحث 
        {
            if(SearchTextBox.Text == "Search for the medicine...." )   // يحصل الآتي
            {
                SearchTextBox.Text = "";                               // تختفي الجملة الموجودة بداخل شريط البحث
                SearchTextBox.ForeColor = Color.Black;                 // و يتغير اللون إلى الأسود ليكون ما يكتبه المستخدم واضح
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)     // لما المستخدم يغادر شريط البحث أو يضغط على أي شيء آخر خارج الشريط
        {
            if( String.IsNullOrWhiteSpace(SearchTextBox.Text))                // ( white space) أو يكون الشريط فاضي أو ضغطنا على    
            {
                SearchTextBox.Text = "Search for the medicine....";          //وقتها تظهر عبارة ابحث عن الدواء كما هو موضح
                SearchTextBox.BackColor = Color.LightGray;                  // يتحول لون الشريط نفسه للرمادي الفاتح
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
