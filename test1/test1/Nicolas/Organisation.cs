using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using test1.Bruno;
using System.Windows.Forms;

namespace test1.Nicolas
{
public class Organisation
    {
        int IdOrga_;
        string Name_;
        string NameResp_;
        string Mail_;
        DateTime DateCreation_;
        string Description_;
        DatabaseConnection dbConnect = new DatabaseConnection();
        Session laSession = new Session();

        public Organisation(int IdOrga = -1, string Name ="...", string NameResp = "...", string Mail = "...", DateTime DateCreation = new DateTime(), string Description ="...")
        {
            IdOrga_ = IdOrga;
            Name_ = Name;
            NameResp_ = NameResp;
            Mail_ = Mail;
            DateCreation_ = DateCreation;
            Description_ = Description;

        }

        public int ID
        {
            get { return IdOrga_; }
            set { IdOrga_ = value; }
        }

        public string Name
        {
            get { return this.Name_; }
            set
            {
                if (value.Length > 50)
                {

                    if (laSession.language == "fr")
                    {
                        MessageBox.Show("Le nom ne peut dépasser 50 caractères");
                    }
                    else
                    {
                        MessageBox.Show("The name can not exceed 50 characters");
                    }

                }
                else
                {
                    Name_ = value;
                }
            }
        }




        public string Nameresp
        {
            get { return NameResp_; }
            set { NameResp_ = value; }
        }

        public string Mail
        {
            get { return Mail_; }
            set { Mail_ = value; }
        }

        public DateTime DateCreation
        {
            get { return DateCreation_; }
            set { DateCreation_ = value;}
        }

        public string Description
        {
            get { return Description_; }
            set { Description_ = value; }
        }


    }
}
