using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySql.Data;
using System.Data;
namespace test1.Norbert
{
    class SQL_Request_Form_Login
    {

        DatabaseConnection maConnexionMysql;

        public SQL_Request_Form_Login()
        {
            maConnexionMysql = new DatabaseConnection();
        }

        public int ajoutCompte(string name, string pass)
        {

            maConnexionMysql.Laconnexion.Open();

            maConnexionMysql.Lacommande.CommandText = "INSERT INTO user (name,password) VALUES (@name,@pass );";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@name", name);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@pass", pass);
            maConnexionMysql.Lacommande.ExecuteNonQuery();
            maConnexionMysql.Lacommande.Parameters.Clear();
            maConnexionMysql.Laconnexion.Close();
            return Identification( name,  pass);
        }

        public int Identification(string namedd, string password)
        {

            maConnexionMysql.Laconnexion.Open();
            // creation requête et ajout à la commande
            string sqlRequest = "SELECT idUser FROM user where name = @namelogin && password =@passlogin ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@namelogin", namedd);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@passlogin", password);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;
            int result;
            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();

            if (monReaderMysql.HasRows)
            {
                monReaderMysql.Read();
                result = Convert.ToInt32(monReaderMysql["idUser"]);

            }
            else
            {
                result = -1; 
            }
            maConnexionMysql.Lacommande.Parameters.Clear();
            maConnexionMysql.Laconnexion.Close();
            return result;
            //MessageBox.Show("Identifiants incorrects");
            ///return "NONE";

        }
    }
}
