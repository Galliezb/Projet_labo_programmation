using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Norbert
{
    public class Organization
    {
        string name_;
        int id_;
        string description_;
        string mail_;
        string password_;
        string website_;

        public Organization()
        {

        }

        public string name
        {
            get { return name_; }
            set { name_ = value; }
        }
        public int id
        {
            get { return id_; }
            set { id_ = value; }
        }
        public string website
        {
            get { return website_; }
            set { website_ = value; }
        }
        public string description
        {
            get { return description_; }
            set { description_ = value; }
        }

        public string mail
        {
            get { return mail_; }
            set { mail_ = value; }
        }
        public string password
        {
            get { return password_; }
            set { password_ = value; }
        }



    }
}
