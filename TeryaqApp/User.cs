using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teryaq
{
    

    internal class User : Person
    {
        public User() : base() { }

        public User(string email, string name, string phoneNumber, Governorate governorate, string password, Role role) 
                    : base(email, name, phoneNumber, governorate, password, Role.User)
        {
        }


    }
}