using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace test1
{
    public class Users
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

        /// <summary>
        /// Constructeur d'instance de Player
        /// </summary>
        /// <param name="idUser">L'id de l'utilisateur ( chiffre uniquement )</param>
        /// <param name="name">Le nom de l'utilisateur ( max 50 caractères )</param>
        /// <param name="firstName">le prénom de l'utilisateur ( max 50 caractères )</param>
        /// <param name="email">L'email de l'utilisateur ( max 255 caractères )</param>
        /// <param name="password">le mot de passe non crypté de l'utilisateur ( max 50 caractères )</param>
        /// <param name="pseudo">le pseudonyme de l'utilisateur ( visible par les autres personnes )</param>
        /// <param name="language">La langue par défaut de l'utilisation ( 'fr' ou 'en' uniquement )</param>
        /// <param name="isOrganizer">L'utilisateur est-il Organisateur de tournoi ( booléen uniquement )</param>
        /// <param name="isAdmin">L'utilisateur est-il administrateur du logiciel  ( booléen uniquement )</param>
        public Users(int idUser = -1, string name = "non défini" , string firstName = "non défini" , string email = "non défini" , string password = "non défini" , string pseudo = "non défini" , string language = "non défini" , bool isOrganizer=false, bool isAdmin=false){

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


        /// <summary>
        /// Récupère ou définit l'ID de l'utilisateur ( chiffre > 1 uniquement )
        /// </summary>
        public int ID {
            get { return IDUser_; }
            set {
                if ( value < 1 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "L'ID est incorrect" );
                    } else {
                        MessageBox.Show( "the ID is incorrect" );
                    }
                } else {
                    IDUser_ = value;
                }
            }
        }


        /// <summary>
        /// récupèrer ou modifier le nom de l'utilisateur ( max 50 caractères )
        /// </summary>
        public string name
        {
            get { return name_; }
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


        /// <summary>
        /// Récupèrer ou modifier le prénom de l'utilisateur ( max 50 caractères )
        /// </summary>
        public string firstName {
            get { return firstName_; }
            set {
                if ( value.Length > 50 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Le prenom ne peut dépasser 50 caractères" );
                    } else {
                        MessageBox.Show( "The first name can not exceed 50 characters" );
                    }
                } else {
                    firstName_ = value;
                }

            }
        }

        /// <summary>
        /// Récupère ou modifie l'email de l'utlisateur ( max 255 caractères )
        /// </summary>
        public string email {
            get { return email_; }
            set {

                if ( value.Length > 255 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "L'email ne peut dépasser 255 caractères" );
                    } else {
                        MessageBox.Show( "The mail can not exceed 255 characters" );
                    }
                } else {
                    email_ = value;
                }

            }
        }


        /// <summary>
        /// récupère ou modifie le mot de passe non crypté de l'utilisateur ( max 50 caractères )
        /// </summary>
        public string password {
            get { return pass_; }
            set {
                if ( value.Length > 255 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Le mot de passe ne peut dépasser 255 caractères" );
                    } else {
                        MessageBox.Show( "The password can not exceed 255 characters" );
                    }
                } else {
                    pass_ = value;
                }
            }
        }


        /// <summary>
        /// Récupère ou défini le pseudo de l'utilisateur ( max 50 caractères )
        /// </summary>
        public string pseudo
        {
            get { return pseudo_; }
            set {
                if ( value.Length > 50 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Le pseudo ne peut dépasser 50 caractères" );
                    } else {
                        MessageBox.Show( "The pseudonym can not exceed 50 characters" );
                    }
                } else {
                    pseudo_ = value;
                }
            }
        }


        /// <summary>
        /// récupère ou défini la langue utilisateur ( 'fr' ou 'en' uniquement )
        /// </summary>
        public string language {
            get { return language_; }
            set {

                if ( value.ToString() == "fr" || value.ToString() == "en" ) {
                    language_ = value;
                } else {

                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "La langue ne peut être que 'fr' ou 'en'" );
                    } else {
                        MessageBox.Show( "the language can only be 'fr' or 'en'" );
                    }

                }
            }
        }


        /// <summary>
        /// récupère ou Défini sur l'utilisateur est un organisateur ou non ( booléen )
        /// </summary>
        public bool isOrganizer {
            get { return isOrganizer_; }
            set {
                if ( value == true || value == false ) {
                    isOrganizer_ = value;
                } else {

                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "isOrganizer nécessite un booléen" );
                    } else {
                        MessageBox.Show( "isOrganizer is bool only" );
                    }
                }
            }
        }


        /// <summary>
        /// Récupère ou défini si l'utilisateur est administrateur ou non ( booléen )
        /// </summary>
        public bool isAdmin {
            get { return isAdmin_; }
            set {
                if ( value == true || value == false ) {
                    isAdmin = value;
                } else {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "isAdmin nécessite un booléen" );
                    } else {
                        MessageBox.Show( "isAdmin is bool only" );
                    }
                }
            }
        }



        /// <summary>
        /// Mets à jours les informations de l'instance dans la BDD ou insert si nécessaire
        /// </summary>
        public void updateToDataBase () {

            // si l'idUser est défini alors on update
            if ( IDUser_ != -1 ) {

                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "UPDATE user SET name=@_name , firstName=@_firstName , email=@_email , password = @_pass , pseudo = @_pseudo , language=@_language , isOrganizer=@_isOrganizer , isAdmin = @_isAdmin WHERE idUser = @_idUser ";
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
                string sqlRequest = "INSERT INTO user SET name=@_name , firstName=@_firstName , email=@_email , password = @_pass , pseudo = @_pseudo , language=@_language , isOrganizer=@_isOrganizer , isAdmin = @_isAdmin";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_firstName" , firstName_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_email" , email );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_pass" , pass_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_pseudo" , pseudo_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_language" , language_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_isOrganizer" , isOrganizer_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_isAdmin" , isAdmin_ );
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


        /// <summary>
        /// Mets à jours la BDD depuis une liste d'instance PLayerlcass
        /// </summary>
        /// <param name="listPlayer"></param>
        public void updateToDataBase ( List<Users> listPlayer ) {

            if ( listPlayer.Count < 1 ) {
                MessageBox.Show( "Impossible d'update depuis une liste vide" );
            } else {

                foreach ( Users player in listPlayer ) {
                    player.updateToDataBase();
                }

            }
        }


        /// <summary>
        /// Supprime l'instance de la BDD ( ID doit être différent de -1 )
        /// </summary>
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


        /// <summary>
        ///  Supprime de la BDD depuis une liste d'instance de Users
        /// </summary>
        /// <param name="listPlayer"></param>
        public void deleteFromDataBase ( List<Users> listPlayer ) {

            if ( listPlayer.Count < 1 ) {
                MessageBox.Show( "Impossible de supprimer depuis une liste vide" );
            } else {

                string sqlRequest = "DELETE FROM user WHERE idUser IN(";

                foreach ( Users player in listPlayer ) {

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
