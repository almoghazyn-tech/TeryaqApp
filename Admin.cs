using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teryaq
{
    internal class Admin : Person
    {
        public Admin() : base()
        {
           this.Role = Role.Admin;
        }

        public Admin(string email, string name, string phoneNumber, Governorate governorate ,string password)
                    : base(email, name, phoneNumber,governorate, password, Role.Admin)
        {

        }
    }
}