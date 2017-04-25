using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.Bruno;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace test1
{
    class PlayerClass
    {
        int IDUser_;
        string name_;
        string firstName_;
        string email_;
        string pass_;
        string pseudo_;
        string language_;
        bool isOrganizer_;
        bool isAdmin_;
        DatabaseConnection dbConnect = new DatabaseConnection();
        Session laSession = new Session();

        public PlayerClass(int idUser = -1, string name = "non défini" , string firstName = "non défini" , string email = "non défini" , string password = "non défini" , string pseudo = "non défini" , string language = "non défini" , bool isOrganizer=false, bool isAdmin=false){

            IDUser_ = idUser;
            name_ = name;
            firstName_ = firstName;
            email_ = email;
            pass_ = password;
            pseudo_ = pseudo;
            language_ = language;
            isOrganizer_ = isOrganizer;
            isAdmin_ = isAdmin;

        }

        public int ID {
            get { return IDUser_; }
            set { IDUser_ = value; }
        }

        public string name
        {
            get { return name_; }
            set { name_ = value; }
        }

        public string firstName {
            get { return firstName_; }
            set { firstName_ = value; }
        }

        public string email {
            get { return email_; }
            set { email_ = value; }
        }
        public string password {
            get { return pass_; }
            set { pass_ = value; }
        }

        public string pseudo
        {
            get { return pseudo_; }
            set { pseudo_ = value; }
        }

        public string language {
            get { return language_; }
            set {
                if ( value == "fr" || value == "en" ) {
                    language_ = value;
                } else {
                    MessageBox.Show( "La langue ne peut être que 'fr' ou 'en'" );
                }
            }
        }

        public bool isOrganizer {
            get { return isOrganizer_; }
            set {
                if ( value == true || value == false ) {
                    isOrganizer_ = value;
                } else {
                    MessageBox.Show( "isOrganizer nécessite un booléen" );
                }
            }
        }

        public bool isAdmin {
            get { return isAdmin_; }
            set {
                if ( value == true || value == false ) {
                    isAdmin = value;
                } else {
                    MessageBox.Show( "isAdmin nécessite un booléen" );
                }
            }
        }

        // Mets à jours les information en base de donnée
        public void updateToDataBase () {

            // si l'idUser est défini alors on update
            if ( IDUser_ != -1 ) {

                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "UPDATE user SET name=@_name , firstName=@_firstName , email=@_email , pass = @_pass , pseudo = @_pseudo , language=@_language , isOrganizer=@_isOrganizer , isAdmin = @_isAdmin WHERE idUser = @_idUser ";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_firstName" , firstName_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_email" , email );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_pass" , pass_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_pseudo" , pseudo_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_language" , language_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_isOrganizer" , isOrganizer_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_isAdmin" , isAdmin );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idUser" , IDUser_ );
                dbConnect.Lacommande.CommandText = sqlRequest;


                // mets à jour la session du connecté si c'est lui
                if ( IDUser_ == laSession.idPlayer ) {
                    laSession.name = name_;
                    laSession.language = language_;
                    laSession.isAdmin = isAdmin_;
                    laSession.isOrganizer = isOrganizer_;
                }

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();
            
            // sinon on l'insert
            } else {

                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "INSERT INTO user SET name=@_name , firstName=@_firstName , email=@_email , pass = @_pass , pseudo = @_pseudo , language=@_language , isOrganizer=@_isOrganizer , isAdmin = @_isAdmin WHERE idUser = @_idUser ";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_firstName" , firstName_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_email" , email );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_pass" , pass_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_pseudo" , pseudo_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_language" , language_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_isOrganizer" , isOrganizer_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_isAdmin" , isAdmin );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idUser" , IDUser_ );
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();


                // mets à jour la session du connecté si c'est lui
                if ( IDUser_ == laSession.idPlayer ) {
                    laSession.name = name_;
                    laSession.language = language_;
                    laSession.isAdmin = isAdmin_;
                    laSession.isOrganizer = isOrganizer_;
                }

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            }

        }

        public void updateToDataBase ( List<PlayerClass> listPlayer ) {

            if ( listPlayer.Count < 1 ) {
                MessageBox.Show( "Impossible d'update depuis une liste vide" );
            } else {

                foreach ( PlayerClass player in listPlayer ) {
                    player.updateToDataBase();
                }

            }
        }
        public void deleteFromDataBase () {

            // si l'id existe on supprime
            if ( IDUser_ != -1 ) {

                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM user WHERE idUser = @_idUser ";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idUser" , IDUser_ );
                dbConnect.Lacommande.CommandText = sqlRequest;


                // mets à jour la session du connecté si c'est lui
                if ( IDUser_ == laSession.idPlayer ) {
                    laSession.idPlayer = -1;
                    laSession.name = "non défini";
                    laSession.language = "fr";
                    laSession.isAdmin = false;
                    laSession.isOrganizer = false;
                }

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

                // sinon on préviens de l'erreur
            } else {
                MessageBox.Show( "Impossible de supprimer un utilisateur sans IDuser défini ( nom : "+ name_ + " " + firstName );
            }

        }

        public void deleteFromDataBase ( List<PlayerClass> listPlayer ) {

            if ( listPlayer.Count < 1 ) {
                MessageBox.Show( "Impossible de supprimer depuis une liste vide" );
            } else {

                string sqlRequest = "DELETE FROM user WHERE idUser IN(";

                foreach ( PlayerClass player in listPlayer ) {

                    if ( player.ID != -1 ) {
                        sqlRequest += player.ID + ",";
                    }

                }
                // valeur final attentdu => DELETE FROM user WHERE idUser IN (13,14,15,16)
                sqlRequest = sqlRequest.Substring( 0 , sqlRequest.Length - 1 ) + ")";


                dbConnect.Laconnexion.Open();
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();


            }


        }


    }
}
