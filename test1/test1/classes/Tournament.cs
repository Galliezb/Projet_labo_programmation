using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1 {
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
        DatabaseConnection dbConnect = new DatabaseConnection();

        public Tournament () { }

        public Tournament ( int idTournament = -1, int idOrganizer = -1, string name ="indéfini", string description="indéfini", DateTime startDate = new DateTime(), DateTime endDate = new DateTime() , string type ="indéfini", int maxPlayer = -1) {

            idTournament_ = idTournament;
            idOrganizer_ = idOrganizer;
            name_ = name;
            description_ = description;
            startDate_ = startDate;
            endDate_ = endDate;
            type_ = type;
            maxPlayer_ = maxPlayer;

        }

        public Tournament ( Tournament tournoi ) {

            idTournament_ = tournoi.idTournament;
            idOrganizer_ = tournoi.idOrganizer;
            name_ = tournoi.name;
            description_ = tournoi.Description;
            startDate_ = tournoi.startDate;
            endDate_ = tournoi.endDate;
            type_ = tournoi.typeTournoi;
            maxPlayer_ = maxPlayer;

        }

        public int idTournament {

            get { return idTournament_; }

        }

        public int idOrganizer {

            get { return idOrganizer_; }

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
                        MessageBox.Show( "Date can not be past" );
                    }
                }
                startDate_ = value;
            }
        }

        public DateTime endDate {
            get { return endDate_; }
            set {
                if ( DateTime.Compare( startDate_ , DateTime.Now ) < 0 ) {
                    MessageBox.Show( "Il faut d'abord enregistré la startDate de start avant la endDate" );
                } else if ( DateTime.Compare( value , startDate_.AddDays(3) ) < 0 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Les tournois doivent avoir minimum 3 jours d'écart entre le début et la fin" );
                    } else {
                        MessageBox.Show( "Tournaments must be at least 3 days apart from start to finish" );
                    }
                } else {
                    endDate_ = value;
                }
            }
        }

        public string typeTournoi {
            get { return type_;  }
            set { type_ = value; }
        }

        public int maxPlayer {
            get { return maxPlayer_; }
            set {
                if ( value < 12 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Minimum 12 joueurs nécessaire pour un tournoi" );
                    } else {
                        MessageBox.Show( "Minimum 12 players required for a tournament" );
                    }
                } else {
                    maxPlayer_ = value;
                }
            }
        }

        public void updateToDataBase () {

            if ( idTournament_ != -1 ) {

                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "UPDATE tournament SET idOrganizer=@_idOrganizer , name=@_name , description=@_description , startDate = @_startDate , endDate = @_endDate , type=@_type , maxPlayer=@_maxPlayer WHERE idTournament = @_idTournament ";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganizer" , idOrganizer_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                // format date requis pour la BDD : YYYY-MM-JJ
                dbConnect.Lacommande.Parameters.AddWithValue( "@startDate" , startDate_.ToString("yyyy-MM-dd") );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_endDate" , endDate_.ToString( "yyyy-MM-dd" ) );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_type" , type_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_maxPlayer" , maxPlayer_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTournament" , idTournament_ );

                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            } else {
                MessageBox.Show( "Impossible de mettre à jour un tournoi ne possédant pas d'idTournament" );
            }

        }


        public void insertInDataBase () {

            if ( idTournament_ == -1 ) {

                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "INSERT INTO tournament SET idOrganizer=@_idOrganizer , name=@_name , description=@_description , startDate = @_startDate , endDate = @_endDate , type=@_type , maxPlayer=@_maxPlayer";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganizer" , idOrganizer_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@startDate" , startDate_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_endDate" , endDate_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_type" , type_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_maxPlayer" , maxPlayer_ );

                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                long idReturn = dbConnect.Lacommande.LastInsertedId;

                if ( idReturn > 0 ) {
                    idTournament_ = Convert.ToInt32(idReturn);
                } else {
                    MessageBox.Show( "La BDD n'as pas retourné l'idTournament créée et l'idTournament n'as donc pas pu être mis à jour. Contacter l'administrateur." );
                }

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            } else {
                MessageBox.Show( "Impossible de créée un tournoi possédant un idTournament déjà présent en BDD" );
            }


        }

        public void deleteTournament( int idTournoi ) {

            if ( idTournament_ < 0 ) {

            } else {
                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM tournament WHERE idTournament=@_idTournament";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTournament" , idTournament_ );
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();
                if ( laSession.language == "fr" ) {
                    MessageBox.Show( "Tournoi surpprimé" );
                } else {
                    MessageBox.Show( "Tournament delete" );
                }

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            }


        }

    }
}
