using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace test1 {
    class sql_non_identifie {

        DatabaseConnection maConnexionMysql;

        public sql_non_identifie () {

            maConnexionMysql = new DatabaseConnection();

        }

        public void test () {

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            string sqlRequest = "SELECT * FROM user";
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            if ( monReaderMysql.HasRows ) {

                monReaderMysql.Read();
                MessageBox.Show( "id : " + monReaderMysql.GetInt32( 0 ).ToString() );
                MessageBox.Show( "Name : " + monReaderMysql.GetString( 1 ).ToString() );
                MessageBox.Show( "firstName : " + monReaderMysql.GetString( 2 ).ToString() );
                MessageBox.Show( "Email : " + monReaderMysql.GetString( 3 ).ToString() );

            }

            maConnexionMysql.Laconnexion.Close();

        }

    }
}
