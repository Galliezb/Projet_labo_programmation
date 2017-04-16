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

        Tournament (int idTournament, int idOrganizer, string name, string description, DateTime startDate, DateTime endDate, string type, int maxPlayer) {

            idTournament_ = idTournament;
            idOrganizer_ = idOrganizer;
            name_ = name;
            description_ = description;
            startDate_ = startDate;
            endDate_ = endDate;
            type_ = type;
            maxPlayer_ = maxPlayer;

        }

        public string Name {
            get { return name_;  }
            set {
                if ( value.Length > 50 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Un nom de tournoi ne peut dépasser 255 caractères" );
                    } else {
                        MessageBox.Show( "A tournament name can not exceed 255 characters" );
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
                        MessageBox.Show( "La description du tournoi doit avoir plus de 10 caractères" );
                    } else {
                        MessageBox.Show( "Tournament description must be more than 10 characters long" );
                    }
                } else {
                    description_ = value;
                }
                
            }
        }

    }
}
