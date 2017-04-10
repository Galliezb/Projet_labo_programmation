using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;

namespace test1
{
    class Page_D_Accueil_SQL_Request
    {
        DatabaseConnection maConnexionMysql;
        MySqlParameter param; 
        public Page_D_Accueil_SQL_Request()
        {
            maConnexionMysql = new DatabaseConnection();
            param = new MySqlParameter();
        }

        
        public void ajoutCompte(string name, string pass)
        {

            maConnexionMysql.Laconnexion.Open();

            maConnexionMysql.Lacommande.CommandText = "INSERT INTO user (name,password) VALUES (@name,@pass );";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@name", name);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@pass", pass);
            maConnexionMysql.Lacommande.ExecuteNonQuery();

            maConnexionMysql.Laconnexion.Close();
        }

        public string getMailUser(string name)
        {
            //string returnedValue="";

            maConnexionMysql.Laconnexion.Open();
            
            // creation requête et ajout à la commande
            //string sqlRequest = "SELECT email FROM user where name = @nameuser; ";
            string sqlRequest = "SELECT email FROM user where name = @nameusermail; ";
            
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameusermail", name);
            
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            while (monReaderMysql.Read())
            {
                string result = monReaderMysql["email"].ToString();
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();
                return result;

            }
            maConnexionMysql.Lacommande.Parameters.Clear();
            maConnexionMysql.Laconnexion.Close();
            return "NONE";


        }

        public string getFirstnameUser(string name)
        {
            //string returnedValue="";

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            string sqlRequest = "SELECT firstName FROM user where name = @nameuserfn; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameuserfn", name);
            
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            while (monReaderMysql.Read())
            {
                string result = monReaderMysql["firstName"].ToString();
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();
                
                return result;

            }
            maConnexionMysql.Lacommande.Parameters.Clear();
            maConnexionMysql.Laconnexion.Close();
            return "NONE";


        }

        public string getPWDUser(string name)
        {
            //string returnedValue="";

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            string sqlRequest = "SELECT password FROM user where name = @nameuserpwd; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameuserpwd", name);
            
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            while (monReaderMysql.Read())
            {
                string result = monReaderMysql["password"].ToString();
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();
                return result;

            }
            maConnexionMysql.Lacommande.Parameters.Clear();
            maConnexionMysql.Laconnexion.Close();
            return "NONE";


        }

        public void updateInfo(Objet_A_Update o, string PreviousName)
        {
            maConnexionMysql.Laconnexion.Open();
            string sqlRequest = "UPDATE user SET name = @nameupdate, email =@emailupdate, firstName = @firstNameupdate, password= @passwordupdate where name = @nameuserupdate; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameuserupdate", PreviousName);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@emailupdate", o.email);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@firstNameupdate", o.firstName);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameupdate", o.name);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@passwordupdate", o.password);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;
            maConnexionMysql.Lacommande.ExecuteNonQuery();
            maConnexionMysql.Lacommande.Parameters.Clear();
            maConnexionMysql.Laconnexion.Close();

        }


    }
}
