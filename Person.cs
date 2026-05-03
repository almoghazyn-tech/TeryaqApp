using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teryaq
{
    enum Role
    {
         Admin,
         User
    }

    enum Governorate
    {
        None, Alexandria, Assiut, Aswan, Beheira, BeniSuef,
        Cairo, Dakahlia, Damietta, Faiyum, Gharbia, Giza,
        Ismailia, KafrElSheikh, Luxor, Matrouh, Minya,
        Monufia, NewValley, NorthSinai, PortSaid, Qalyubia,
        Qena, RedSea, Sharkia, Sohag, SouthSinai, Suez

    }


    internal class Person
    {
        //Feilds
        private Role role = Role.User;
        private string email;
        private string name;
        private string phonenumber;
        private Governorate governorate;
        private string password;

        //Properties
        public Role Role { get; set; }

        public string Email
        {
            get { return email; }       //public string get()

            set                         //public void set(value)
            {
                if (value.Contains("@") && value.Contains(".") && !value.Contains(" "))
                { email = value.ToLower(); }
                else
                { throw new Exception("Please enter a correct email"); }

            }
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a name!");
                }
                else
                {
                    name = value;
                }

            }
        }

        public string PhoneNumber
        {
            get { return phonenumber; }

            set
            {
                if (value.Length == 11 && value.StartsWith("01") && IsDigitOnly(value))
                { phonenumber = value; }
                else
                { throw new Exception("Please enter correct phone number"); }
            }
        }

        public Governorate Governorate
        {
            get { return governorate; }

            set
            {
                if (value == Governorate.None)
                {
                    throw new Exception("Please select your governorate!");
                }
                else
                {
                    governorate = value;
                }
            }
        }

        public string Password
        {
            get { return password; }

            set
            {
                if (value.Length >= 6)
                { password = value; }
                else
                { throw new Exception("Password must be at least 6 characters"); }
            }
        }

        //Metods
        public Person() 
        {
            role = Role.User;
        }

        public Person(string email, string name, string phonenumber, Governorate governorate, string password, Role role) {
            Email = email;
            Name = name;
            PhoneNumber = phonenumber;
            Governorate = governorate;
            Password = password;
            Role = role;
        }

        public static bool IsDigitOnly(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            foreach (char c in s)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}