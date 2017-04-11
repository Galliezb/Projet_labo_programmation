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

        public void ajoutCompte(string name, string pass)
        {

            maConnexionMysql.Laconnexion.Open();

            maConnexionMysql.Lacommande.CommandText = "INSERT INTO user (name,password) VALUES (@name,@pass );";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@name", name);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@pass", pass);
            maConnexionMysql.Lacommande.ExecuteNonQuery();

            maConnexionMysql.Laconnexion.Close();
        }

        public string test2(string namedd, string ValueType)
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
                if (ValueType == "password")
                {
                    if (monReaderMysql.GetString(1).ToString() == namedd)
                    {

                        result = monReaderMysql.GetString(4).ToString();
                        maConnexionMysql.Laconnexion.Close();
                        return result;
                    }
                }

            }
            maConnexionMysql.Laconnexion.Close();
            MessageBox.Show("Identifiants incorrects");
            return "NONE";



        }
    }
}
