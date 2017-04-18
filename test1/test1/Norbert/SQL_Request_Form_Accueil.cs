using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;
using test1.Bruno;

namespace test1
{
    class SQL_Request_Form_Accueil
    {
        DatabaseConnection maConnexionMysql;
        Session playerSession = new Session();
         
        public SQL_Request_Form_Accueil()
        {
            maConnexionMysql = new DatabaseConnection();
        }

        
        public void  UpdatePlayerClass(PlayerClass Player)
        {
            

            maConnexionMysql.Laconnexion.Open();

            string sqlRequest = "SELECT * FROM user where idUser = @PlayerID; ";

            maConnexionMysql.Lacommande.Parameters.AddWithValue("@PlayerID", playerSession.idPlayer);

            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            monReaderMysql.Read();
            Player.name = monReaderMysql["name"].ToString();
            Player.firstName = monReaderMysql["firstName"].ToString();
            Player.email = monReaderMysql["email"].ToString();
            Player.password = monReaderMysql["password"].ToString();
            Player.pseudo = monReaderMysql["pseudo"].ToString();
            maConnexionMysql.Laconnexion.Close();
            maConnexionMysql.Lacommande.Parameters.Clear();
        }

        

        public void updateInfo(PlayerClass o)
        {

            maConnexionMysql.Laconnexion.Open();
            string sqlRequest = "UPDATE user SET name = @nameupdate, email =@emailupdate, firstName = @firstNameupdate, password= @passwordupdate,pseudo=@pseudoupdate where idUser = @IdUser; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@IdUser", playerSession.idPlayer);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@emailupdate", o.email);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@firstNameupdate", o.firstName);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameupdate", o.name);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@passwordupdate", o.password);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@pseudoupdate", o.pseudo);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;
            maConnexionMysql.Lacommande.ExecuteNonQuery();
            
            maConnexionMysql.Laconnexion.Close();
            maConnexionMysql.Lacommande.Parameters.Clear();

        }


    }
}
