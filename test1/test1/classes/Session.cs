using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1 {

    class Session {

        static string name_;
        static string email_;
        static string language_;
        static int idPlayer_;
        static bool isOrganizer_;
        static bool isAdmin_;

        // constructeur
        public Session (string name, string email, string language, int idPlayer, bool isOrganizer, bool isAdmin ) {

            name_ = name;
            email_ = email;
            language_ = language;
            idPlayer_ = idPlayer;
            isOrganizer_ = isOrganizer;
            isAdmin_ = isAdmin;

        }

        public Session(Users player ) {

            name_ = player.name;
            email_ = player.email;
            language_ = player.language;
            idPlayer_ = player.ID;
            isOrganizer_ = player.isOrganizer;
            isAdmin_ = player.isAdmin;

        }

        public Session () { }

        public string name {

            get { return name_;  }
            set {

                if ( value.Length > 50 ) {
                    if ( language_ == "fr" ) {
                        MessageBox.Show( "Le nom ne peut dépasser 50 caractères" );
                    } else {
                        MessageBox.Show( "The name can not exceed 50 characters" );
                    }
                } else {

                    name_ = value;

                }

            }

        }

        public string email {

            get { return email_; }
            set {

                if ( IsValidEmail(value) ) {
                    if ( language_ == "fr" ) {
                        MessageBox.Show( "L'email n'est pas au format xxxxx@domaine.ext" );
                    } else {
                        MessageBox.Show( "The email is not in format xxxxx@domaine.ext" );
                    }
                } else {

                    name_ = value;

                }

            }

        }

        private bool IsValidEmail ( string email ) {
            try {
                var addr = new System.Net.Mail.MailAddress( email );
                return true;
            } catch {
                return false;
            }
        }

        public string language {

            get { return language_; }
            set {

                if ( value =="fr" || value == "en" ) {
                    language_ = value;
                } else {
                    MessageBox.Show( "SESSION : La valeur de langue ne peut être que 'fr' ou 'en'" );
                }

            }

        }

        public int idPlayer {

            get { return idPlayer_; }
            set {

                // vérifie que c'est un chiffre
                if ( value.GetType() != typeof(int) ) {
                    if ( language_ == "fr" ) {
                        MessageBox.Show( "La valeur ne peut être qu'un int" );
                    } else {
                        MessageBox.Show( "The value can only be an int" );
                    }
                } else if ( value < 0 ) {
                    if ( language_ == "fr" ) {
                        MessageBox.Show( "La valeur ne peut être négative" );
                    } else {
                        MessageBox.Show( "The value can not be negative" );
                    }
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
