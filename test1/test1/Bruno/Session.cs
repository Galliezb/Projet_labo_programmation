﻿using System;
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

        public string language {

            get { return language_; }
            set {

                if ( value!="fr" || value!="en" ) {
                    if ( language_ == "fr" ) {
                        MessageBox.Show( "La valeur de langue ne peut être que 'fr' ou 'en'" );
                    } else {
                        MessageBox.Show( "The language value can only be 'fr' or 'en'" );
                    }
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
