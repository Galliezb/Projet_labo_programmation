using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Organizer
    {
        //attibuts
        string description_;
        int idOrganizer_;
        string mail_;
        string name_;
        string password_;
        string website_;

        //fonctions

        Organizer(int id, string name, string pwd,string mail,string desc="" ,string website="")
        {
            idOrganizer_ = id;
            name_ = name;
            password_ = pwd;
            mail_ = mail;
            website_ = website;
        }

        Organizer()
        {

        }
        void createTournament()
        {

        }
        bool sendInvitation(List<int> IdPlayer)
        {
            return true;
        }
        void lookHistory()
        {

        }
        void changeInformation(string target,string value)
        {
            if ( target == "description")
            {
                description_ = value;
            }
            if ( target == "password")
            {
                password_ = value;
            }
            if (target == "name")
            {
                name_ = value;
            }
            if(target== "website")
            {
                website_ = value;
            }
        }




    }
}
