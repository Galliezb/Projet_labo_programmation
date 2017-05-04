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
        Dictionary<string , bool> checkVariable = new Dictionary<string , bool>();


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

            checkVariable.Add( "idTournament" , false );
            checkVariable.Add( "idOrganizer" , false );
            checkVariable.Add( "name" , false );
            checkVariable.Add( "description" , false );
            checkVariable.Add( "endDate" , false );
            checkVariable.Add( "type" , false );
            checkVariable.Add( "maxPlayer" , false );

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
                    checkVariable["name"] = false;
                } else {
                    name_ = value;
                    checkVariable["name"] = true;
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
                    checkVariable["description"] = false;
                } else {
                    description_ = value;
                    checkVariable["description"] = true;
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
                    checkVariable["startDate"] = true;
                } else {
                    startDate_ = value;
                    checkVariable["startDate"] = true;
                }
                
            }
        }

        public DateTime endDate {
            get { return endDate_; }
            set {
                checkVariable["startDate"] = false;
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
                    checkVariable["startDate"] = true;
                }
            }
        }

        public string typeTournoi {
            get { return type_;  }
            set {
                // All - play - all
                //Deathmatch
                //Pool phase
                //comboBoxType.Items.Add( "Championnat toute ronde" );
                //comboBoxType.Items.Add( "Elimination directe" );
                //comboBoxType.Items.Add( "Phase de groupe" );
                

                if ( value == "All - play - all" ||
                     value == "Deathmatch" ||
                     value == "Pool phase" ||
                     value == "Championnat toute ronde" ||
                     value == "Elimination directe" ||
                     value == "Phase de groupe"
                    ) {

                    type_ = value;
                    checkVariable["type"] = true;

                } else {

                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Le type de tournoi est incorrect" );
                    } else {
                        MessageBox.Show( "Tournament type is incorrect" );
                    }

                    checkVariable["type"] = false;
                }
            }
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
                    checkVariable["maxPlayer"] = false;
                } else {
                    maxPlayer_ = value;
                    checkVariable["type"] = true;
                }
            }
        }

        public void update () {

            if ( idTournament_ != -1 ) {

                if ( !checkVariable.Any( p => p.Value == false ) ) {
                    dbConnect.Laconnexion.Open();
                    // creation requête et ajout à la commande
                    string sqlRequest = "UPDATE tournament SET idOrganizer=@_idOrganizer , name=@_name , description=@_description , startDate = @_startDate , endDate = @_endDate , type=@_type , maxPlayer=@_maxPlayer WHERE idTournament = @_idTournament ";
                    dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganizer" , idOrganizer_ );
                    dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                    dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                    // format date requis pour la BDD : YYYY-MM-JJ
                    dbConnect.Lacommande.Parameters.AddWithValue( "@startDate" , startDate_.ToString( "yyyy-MM-dd" ) );
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
                }

            } else {

                if ( laSession.language == "fr" ) {
                    MessageBox.Show( "Minimum 12 joueurs nécessaire pour un tournoi" );
                } else {
                    MessageBox.Show( "Unable to update tournament without idTournament" );
                }

            }

        }


        public void insert () {

            if ( !checkVariable.Any( p => p.Value == false ) ) {

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

            }


        }

        public void delete( ) {

            if ( idTournament_ < 0 ) {

                if ( laSession.language == "fr" ) {
                    MessageBox.Show( "Impossible de créée un tournoi possédant un idTournament déjà présent en BDD" );
                } else {
                    MessageBox.Show( "Unable to create a tournament with an idTournament already present in BDD" );
                }

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
