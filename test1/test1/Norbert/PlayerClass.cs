using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class PlayerClass
    {
        static string pass_;
        static string firstName_;
        static string name_;
        static string email_;
        static string pseudo_;
        static int IDUser_;
        public PlayerClass()
        {

        }




        public string name
        {
            get { return name_; }
            set { name_ = value; }
        }

        public int ID
        {
            get { return IDUser_; }
            set { IDUser_ = value; }
        }

        public string pseudo
        {
            get { return pseudo_; }
            set { pseudo_ = value; }
        }

        public string firstName
        {
            get { return firstName_; }
            set { firstName_ = value; }
        }

        public string email
        {
            get { return email_; }
            set { email_ = value; }
        }
        public string password
        {
            get { return pass_; }
            set { pass_ = value; }
        }

    }
}
