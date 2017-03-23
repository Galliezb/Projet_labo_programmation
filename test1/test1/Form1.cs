using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test1 {
    public partial class FormStart : Form {
        public FormStart () {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            /* test génération via code
            Label lbLogin = new Label();
            TextBox txtLogin = new TextBox();

            Label lbMdp = new Label();
            TextBox txtMdp = new TextBox();
            */
        }

        private void Form1_Load ( object sender , EventArgs e ) {
            // TODO: cette ligne de code charge les données dans la table 'csharp_projectDataSet.Tournoi'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tournoiTableAdapter.Fill( this.csharp_projectDataSet.Tournoi );

        }

        private void tournoiBindingNavigatorSaveItem_Click ( object sender , EventArgs e ) {
            this.Validate();
            this.tournoiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll( this.csharp_projectDataSet );

        }

        private void bindingNavigatorMoveNextItem_Click ( object sender , EventArgs e ) {

        }
    }
}
