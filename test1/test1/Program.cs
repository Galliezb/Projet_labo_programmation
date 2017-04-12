using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.Bruno;
using test1.Norbert;
using test1.Nicolas;

namespace test1 {
    static class Program {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main () {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new Form_organizer_start() );
        }
    }
}
