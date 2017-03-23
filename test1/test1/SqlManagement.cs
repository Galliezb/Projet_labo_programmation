using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace test1 {
    class SqlManagement {

        public void createConnection () {

            SqlConnection conns;
            SqlCommand cmds;
            SqlDataReader dtrds;

            conns = new SqlConnection();
            cmds = new SqlCommand();

            try {
                conn.Open();
                if ( conn.State == ConnectionState.Open ) {
                    //connexion réussie
                    MessageBox.Show( "connexion réussie" );
                } else {
                    //connexion râtée
                    MessageBox.Show( "connexion râtée" );
                }
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message );
            }

        }

    }
}
