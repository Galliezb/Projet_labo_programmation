using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Bruno {

    class Traducteur {

        static string[] theText = new string[3000];


        public Traducteur () {

            /**************************** NORBERT ADD TEXT HERE 2000->3000 *****************************/
            theText[2001] = "Les mots de passes ne sont pas identiques";
            theText[2002] = "Information correctement mises à jours";
            theText[2003] = "";

            /**************************** NICOLAS ADD TEXT HERE 1000->2000 *****************************/
            theText[1001] = "";
            theText[1002] = "";
            theText[1003] = "";

            /**************************** BRUNO ADD TEXT HERE 0->1000 *****************************/
            theText[0] = "Créer un Tournoi" ;
            theText[1] = "La langue doit être sous forme 'fr' ou 'en'";
            theText[2] = "L'id d'un joueur doit être un INT";
            theText[3] = "L'id joueur doit être positif";
            theText[4] = "Un nom de tournoi ne peut dépasser 255 caractères";
            theText[5] = "La description du tournoi doit avoir plus de 10 caractères";
            theText[6] = "Impossible d'enregistrer une date de démarrage ultérieur à aujourd'hui";

        }

        public string display ( int indexToReturn ) {
            return theText[indexToReturn];
        }


    }
}
