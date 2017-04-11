using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Objet_A_Update
    {
        string pass_;
        string fn_;
        string name_;
        string email_;


        public Objet_A_Update ()
        {

        }




        public string name
        {
            get { return name_; }
            set { name_ = value; }
        }

        public string firstName
        {
            get { return fn_; }
            set { fn_ = value; }
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
