﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
//using System.Data.SqlClient;

namespace test1 {
    class Sql_non_identifie
    {

        DataSet ds = new DataSet();
        int Identifianttotaux = 2;
        DatabaseConnection maConnexionMysql;
        MySqlDataAdapter maConnexionAdapteur;//=new MySqlDataAdapter();
        public Sql_non_identifie()
        {

            maConnexionMysql = new DatabaseConnection();

        }

        /*
         
         EXEMPLE DE LECTURE DE TOUS LES CHAMPS ET TOUTES LES LIGNES D'UNE BDD

        public void test()
        {

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            string sqlRequest = "SELECT * FROM user";
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            while (monReaderMysql.Read()) {


                MessageBox.Show("id : " + monReaderMysql.GetInt32(0).ToString());
                MessageBox.Show("Name : " + monReaderMysql.GetString(1).ToString());
                MessageBox.Show("firstName : " + monReaderMysql.GetString(2).ToString());
                MessageBox.Show("Email : " + monReaderMysql.GetString(3).ToString());
                MessageBox.Show("PWD : " + monReaderMysql.GetString(4).ToString());
            }

            maConnexionMysql.Laconnexion.Close();

        }
        */

        public string test2(string namedd,string ValueType)
        {

            maConnexionMysql.Laconnexion.Open();
            // creation requête et ajout à la commande
            string sqlRequest = "SELECT * FROM user";
            //maConnexionMysql.Lacommande.Parameters.AddWithValue("@namedd", namedd);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;
            string result;
            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();

            while (monReaderMysql.Read())
            {

               /*MessageBox.Show("id : " + monReaderMysql.GetInt32(0).ToString());
                MessageBox.Show("Name : " + monReaderMysql.GetString(1).ToString());
                MessageBox.Show("firstName : " + monReaderMysql.GetString(2).ToString());
                MessageBox.Show("Email : " + monReaderMysql.GetString(3).ToString());
                MessageBox.Show("PWD : " + monReaderMysql.GetString(4).ToString());*/
                if ( ValueType == "password")
                {
                    if (monReaderMysql.GetString(1).ToString() == namedd)
                    {
                        
                        result=monReaderMysql.GetString(4).ToString();
                        maConnexionMysql.Laconnexion.Close();
                        return result;
                    }
                }

            }
            maConnexionMysql.Laconnexion.Close();
            MessageBox.Show( "Identifiants incorrects" );
            return "NONE";



        }

        public void majBDD()
        {

        }
        public void ajoutCompte(string name, string pass)
        {

            maConnexionMysql.Laconnexion.Open();
            string sqlstr;
            sqlstr = "INSERT INTO user (idUser,name,password) VALUES (" + Identifianttotaux + "," + name + "," + pass + ");";
            // maConnexionMysql.Lacommande.CommandText = sqlstr;
            //cmd.Connection = conn;

            maConnexionMysql.Lacommande.CommandText = "INSERT INTO user (idUser,name,password) VALUES (@id,@name,@pass );";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@name", name);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@pass", pass);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@id", Identifianttotaux);
            maConnexionMysql.Lacommande.ExecuteNonQuery();
            Identifianttotaux++;
            maConnexionMysql.Laconnexion.Close();
        }

        public string getMailUser(string name)
        {
            //string returnedValue="";

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            string sqlRequest = "SELECT email FROM user where name like @nameuser; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameuser", name);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            if (monReaderMysql.Read())
            {
                maConnexionMysql.Laconnexion.Close();
                return monReaderMysql.GetString(0).ToString();
               
            }
            else
            {
                maConnexionMysql.Laconnexion.Close();
                return "NONE";
            }
            
        }

        public string getFirstnameUser(string name)
        {
            //string returnedValue="";

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            string sqlRequest = "SELECT firstName FROM user where name like @nameuser; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameuser", name);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            if (monReaderMysql.Read())
            {
                maConnexionMysql.Laconnexion.Close();
                return monReaderMysql.GetString(0).ToString();

            }
            else
            {
                maConnexionMysql.Laconnexion.Close();
                return "NONE";
            }
            
        }

        public string getPWDUser(string name)
        {
            //string returnedValue="";

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            string sqlRequest = "SELECT password FROM user where name like @nameuser; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameuser", name);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            if (monReaderMysql.Read())
            {
                maConnexionMysql.Laconnexion.Close();
                return monReaderMysql.GetString(0).ToString();

            }
            else
            {
                maConnexionMysql.Laconnexion.Close();
                return "NONE";
            }

        }
        //////////////

        public void VerifiyLogin(string login, string password)
        {

        }

    }

}
