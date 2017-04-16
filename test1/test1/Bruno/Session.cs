using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1.Bruno {

    class Session {

        static string name_;
        static string language_;
        static int idPlayer_;
        static bool isOrganizer_;
        static bool isAdmin_;
        Traducteur traduction = new Traducteur();

        // constructeur
        public Session (string name, string language, int idPlayer, bool isOrganizer, bool isAdmin ) {

            name_ = name;
            language_ = language;
            idPlayer_ = idPlayer;
            isOrganizer_ = isOrganizer;
            isAdmin_ = isAdmin;

        }

        public Session () { }

        public string name {

            get { return name_;  }
            set {

                if ( value.Length > 50 ) {
                   MessageBox.Show( traduction.display(0) );
                } else {

                    name_ = value;

                }

            }

        }

        public string language {

            get { return language_; }
            set {

                if ( value!="fr" || value!="en" ) {
                   MessageBox.Show( traduction.display(1) );
                } else {

                    language_ = value;

                }

            }

        }

        public int idPlayer {

            get { return idPlayer_; }
            set {

                // vérifie que c'est un chiffre
                if ( value.GetType() != typeof(int) ) {
                   MessageBox.Show( traduction.display( 2 ) );
                } else if ( value < 0 ) {
                   MessageBox.Show( traduction.display( 3 ) );
                } else {
                    idPlayer_ = value;
                }

            }

        }

        public bool isOrganizer {

            get { return isOrganizer_; }
            set { isOrganizer_ = value; }

        }

        public bool isAdmin {

            get { return isAdmin_; }
            set { isAdmin_ = value; }

        }

    }
}
