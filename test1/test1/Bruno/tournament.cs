using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1.Bruno {
    class Tournament {

        int idTournament_;
        int idOrganizer_;
        string name_;
        string description_;
        DateTime startDate_;
        DateTime endDate_;
        string type_;
        int maxPlayer_;
        Session laSession = new Session();

        Tournament () { }

        Tournament (int idTournament = -1, int idOrganizer = -1, string name ="indéfini", string description="indéfini", DateTime startDate = new DateTime(), DateTime endDate = new DateTime() , string type ="indéfini", int maxPlayer = -1) {

            idTournament_ = idTournament;
            idOrganizer_ = idOrganizer;
            name_ = name;
            description_ = description;
            startDate_ = startDate;
            endDate_ = endDate;
            type_ = type;
            maxPlayer_ = maxPlayer;

        }

        public int idTournament {

            get { return idTournament_; }

        }

        public int idOrganizer {

            get { return idOrganizer_; }

        }

        public string Name {
            get { return name_;  }
            set {
                if ( value.Length > 50 ) {

                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Le nom ne peut dépasser 50 caractères" );
                    } else {
                        MessageBox.Show( "The name can not exceed 50 characters" );
                    }

                } else {
                    name_ = value;
                }
                
            }
        }

        public string name {
            get { return this.name_; }
            set {
                if ( value.Length > 50 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Le nom est trop long ( 50 charactères maximum )" );
                    } else {
                        MessageBox.Show( "The name is too long (50 characters maximum)" );
                    }
                } else {
                    name_ = value;
                }

            }
        }

        public string Description {
            get { return this.description_; }
            set {
                if ( value.Length < 10 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "La description doit faire plus de 10 caractères" );
                    } else {
                        MessageBox.Show( "The description must be more than 10 characters long" );
                    }
                } else {
                    description_ = value;
                }
                
            }
        }

        public DateTime startDate {
            get { return startDate_; }
            set {
                if ( DateTime.Compare(value,DateTime.Now) < 0 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "La date ne peut être passée" );
                    } else {
                        MessageBox.Show( "Date can not be placed" );
                    }
                }
                startDate_ = value;
            }
        }


    }
}
