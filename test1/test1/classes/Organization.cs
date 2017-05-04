﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace test1 {
    public class Organisation {
        int idOrganization_;
        string nameOrganization_;
        string nameResponsable_;
        string mailResponsable_;
        DateTime dateCreation_;
        string description_;
        DatabaseConnection dbConnect = new DatabaseConnection();
        Session laSession = new Session();
        Dictionary<string , bool> checkVariable = new Dictionary<string , bool>();

        public Organisation ( int IdOrga = -1 , string Name = "non défini" , string NameResp = "non défini" , string Mail = "non défini" , DateTime DateCreation = new DateTime() , string Description = "non défini" ) {
            idOrganization_ = IdOrga;
            nameOrganization_ = Name;
            nameResponsable_ = NameResp;
            mailResponsable_ = Mail;
            dateCreation_ = DateCreation;
            description_ = Description;

            checkVariable.Add( "idOrganization" , true );
            checkVariable.Add( "nameOrganization" , false );
            checkVariable.Add( "nameResponsable" , false );
            checkVariable.Add( "mailResponsable" , false );
            checkVariable.Add( "dateCreation" , false );
            checkVariable.Add( "description" , false );


        }
        /// <summary>
        /// Récupère l'ID de l'organisation
        /// </summary>
        public int ID {
            get { return idOrganization_; }
        }
        /// <summary>
        /// Récupère ou modifie le nom de l'organisation
        /// </summary>
        public string Name {
            get { return nameOrganization_; }
            set {
                if ( value.Length > 50 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Le nom ne peut dépasser 50 caractères" );
                    } else {
                        MessageBox.Show( "The name can not exceed 50 characters" );
                    }
                    checkVariable["nameOrganization"] = false;

                } else {
                    nameOrganization_ = value;
                    checkVariable["nameOrganization"] = true;

                }
            }
        }



        /// <summary>
        /// Récupère ou modifie le nom du responsable de l'organisation
        /// </summary>
        public string Nameresp {
            get { return nameResponsable_; }
            set {
                if ( value.Length > 50 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Le nom ne peut dépasser 50 caractères" );
                    } else {
                        MessageBox.Show( "The name can not exceed 50 characters" );
                    }
                    checkVariable["nameResponsable"] = true;
                } else {

                    nameResponsable_ = value;
                    checkVariable["nameResponsable"] = true;

                }

            }
        }
        /// <summary>
        /// récupère ou modifie le mail du responsable de l'organisation
        /// </summary>
        public string Mail {
            get { return mailResponsable_; }
            set {
                if ( value.Length > 50 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Le nom ne peut dépasser 50 caractères" );
                    } else {
                        MessageBox.Show( "The name can not exceed 50 characters" );
                    }

                    checkVariable["mailResponsable"] = true;

                } else {

                    checkVariable["mailResponsable"] = true;
                    mailResponsable_ = value;

                }
            }
        }
        /// <summary>
        /// récupère ou modifie la date de création de l'organisation
        /// </summary>
        public DateTime DateCreation {
            get { return dateCreation_; }
            set {
                if ( DateTime.Compare( value , DateTime.Now ) < 0 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "La date ne peut être passée" );

                    } else {
                        MessageBox.Show( "Date can not be past" );
                    }
                    checkVariable["dateCreation"] = true;
                } else {
                    checkVariable["dateCreation"] = false;
                    dateCreation_ = value;

                }
            }
        }


        /// <summary>
        /// récupère ou modifie la description de l'organisation
        /// </summary>
        public string Description {
            get { return description_; }
            set {
                if ( value.Length > 255 ) {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "La description ne peut dépasser 255 caractères" );
                    } else {
                        MessageBox.Show( "Description can not exceed 255 characters" );
                    }
                    checkVariable["description"] = true;
                } else {

                    mailResponsable_ = value;
                    checkVariable["description"] = false;

                }
            }
        }


        /// <summary>
        /// mets à jours cette organisation en BDD
        /// </summary>
        public void update () {

            if ( idOrganization_ != -1 && !checkVariable.Any( p => p.Value == false ) ) {

                dbConnect.Laconnexion.Open();
                string sqlRequest = "UPDATE team SET name= @_idOrganization , 	nameOrganization=@_nameOrganization , description =@_description , NameResponsable = @_NameResponsable , mailResponsable = @_mailResponsable , creatingDate = @_creatingDate;";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganization" , idOrganization_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_nameOrganization" , nameOrganization_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_NameResponsable" , nameResponsable_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_mailResponsable" , mailResponsable_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_creatingDate" , dateCreation_.ToString( "yyyy-MM-dd" ) );



                dbConnect.Lacommande.CommandText = sqlRequest;

                //éxécution de la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();
            } else {

                if ( laSession.language == "fr" ) {
                    MessageBox.Show( "Id de l'organisation incorrect pour une mise à jour en BDD" );
                } else {
                    MessageBox.Show( "Incorrect organization ID for a BDD update" );
                }

            }
        }

        /// <summary>
        /// insert cette organisation dans la BDD
        /// </summary>
        public void insert () {

            if ( !checkVariable.Any( p => p.Value == false ) ) {

                dbConnect.Laconnexion.Open();
                string sqlRequest = "INSERT INTO team SET name= @_idOrganization , 	nameOrganization=@_nameOrganization , description =@_description , NameResponsable = @_NameResponsable , mailResponsable = @_mailResponsable , creatingDate=@_creatingDate;";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganization" , idOrganization_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_nameOrganization" , nameOrganization_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_NameResponsable" , nameResponsable_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_mailResponsable" , mailResponsable_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_creatingDate" , dateCreation_.ToString( "yyyy-MM-dd" ) );

                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                long idReturn = dbConnect.Lacommande.LastInsertedId;

                if ( idReturn > 0 ) {
                    idOrganization_ = Convert.ToInt32( idReturn );
                } else {
                    if ( laSession.language == "fr" ) {
                        MessageBox.Show( "Erreur de retour d'ID après insertion en BDD" );
                    } else {
                        MessageBox.Show( "Error returning ID after insertion in BDD" );
                    }
                }

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            }

        }


        /// <summary>
        /// supprime cette organisation de la BDD
        /// </summary>
        public void delete () {

            if ( idOrganization_ < 0 ) {

                if ( laSession.language == "fr" ) {
                    MessageBox.Show( "Id de l'organisation incorrect pour suppression en BDD" );
                } else {
                    MessageBox.Show( "Incorrect organization ID for a BDD delete" );
                }

            } else if ( !checkVariable.Any( p => p.Value == false ) ) {
                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM team WHERE idOrganization=@_idOrganization";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganization" , idOrganization_ );
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();
                if ( laSession.language == "fr" ) {
                    MessageBox.Show( "Organisation surpprimée" );
                } else {
                    MessageBox.Show( "Organization delete" );
                }

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            }


        }



    }
}
