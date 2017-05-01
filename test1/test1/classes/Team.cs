using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1 {
    public class Team {
        int idTeam_;
        string name_;
        DateTime creationDate_;
        int idCaptain_;
        DatabaseConnection dbConnect = new DatabaseConnection();
        Session laSession = new Session();
        string description_;

        public Team ( int idTeam = -1 , string name = "...." , string description = "" ) {
            idTeam_ = idTeam;
            creationDate_ = DateTime.Now;
            name_ = name;
            description_ = description;

        }
        public Team ( Team team ) {
            idTeam_ = team.idTeam_;
            name_ = team.name_;
            creationDate_ = team.creationDate_;
            description_ = team.description_;
        }
        public string name {
            get { return name_; }
            set { name_ = value; }
        }
        public int idCaptain {
            get { return idCaptain_; }
            set { idCaptain_ = value; }
        }
        public int idTeam {
            get { return idTeam_; }
            set { idTeam_ = value; }
        }
        public string description {
            get { return description_; }
            set { description_ = value; }
        }
        public DateTime creationDate {

            get { return creationDate_; }
            set {
                if ( DateTime.Compare( value , DateTime.Now ) < 0 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "La date ne peut être passée" );

                    } else {
                        MessageBox.Show( "Date can not be past" );
                    }
                } else {

                    creationDate_ = value;

                }


            }
        }

        public void update () {
            if ( idTeam_ != -1 ) {
                dbConnect.Laconnexion.Open();
                string sqlRequest = "UPDATE team SET idTeam= @_idTeam , name= @_name , description=@_description , captain =@_captain , dateCreation = @_dateCreation;";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTeam" , idTeam_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_captain" , idCaptain_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_dateCreation" , creationDate_.ToString( "yyyy-MM-dd" ) );



                dbConnect.Lacommande.CommandText = sqlRequest;

                //éxécution de la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();
            } else {
                MessageBox.Show( "It's impossible to update the database " );
            }
        }

        public void insert () {

            dbConnect.Laconnexion.Open();
            string sqlRequest = "INSERT INTO team SET name= @_name , description=@_description , captain =@_captain , dateCreation = @_dateCreation;";
            dbConnect.Lacommande.Parameters.AddWithValue( "@_idTeam" , idTeam_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_captain" , idCaptain_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_dateCreation" , creationDate_.ToString( "yyyy-MM-dd" ) );

            dbConnect.Lacommande.CommandText = sqlRequest;

            // exécute la requête
            dbConnect.Lacommande.ExecuteNonQuery();

            long idReturn = dbConnect.Lacommande.LastInsertedId;

            if ( idReturn > 0 ) {
                idTeam_ = Convert.ToInt32( idReturn );
            } else {
                MessageBox.Show( "The DataBase didn't return the Team Identifier and the Team id hasn't been updated. Please Contact the administrator " );
            }

            // clear commande et ferme la connection
            dbConnect.Lacommande.Parameters.Clear();
            dbConnect.Laconnexion.Close();


        }
        public void delete () {

            if ( idTeam_ < 0 ) {

                if ( laSession.language == "fr" ) {
                    MessageBox.Show( "Id Team incorrect pour une suppression en BDD" );
                } else {
                    MessageBox.Show( "Id Team incorrect for deletion in BDD" );
                }

            } else {
                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM team WHERE idTournament=@_idTeam";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTeam" , idTeam_ );
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
