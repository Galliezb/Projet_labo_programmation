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
        Traducteur traduction = new Traducteur();

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
                    MessageBox.Show( traduction.display( 4 ) );
                } else {
                    name_ = value;
                }
                
            }
        }

        public string Description {
            get { return this.description_; }
            set {
                if ( value.Length < 10 ) {
                    MessageBox.Show( traduction.display( 5 ) );
                } else {
                    description_ = value;
                }
                
            }
        }

        public DateTime startDate {
            get { return startDate_; }
            set {
                if ( DateTime.Compare(value,DateTime.Now) < 0 ) {
                    MessageBox.Show( traduction.display( 6 ) );
                }
                startDate_ = value;
            }
        }


    }
}
