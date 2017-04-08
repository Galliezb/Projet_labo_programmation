using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1 {
    public partial class FormStart : Form {

        sql_non_identifie test = new sql_non_identifie();

        public FormStart () {
            InitializeComponent();


            // Passage en full screen
            //FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            Label lbLogin = new Label();
            TextBox txtLogin = new TextBox();

            Label lbMdp = new Label();
            TextBox txtMdp = new TextBox();
        }

        private void Form1_Load ( object sender , EventArgs e ) {

            test.test();

        }

        private void domainUpDown1_SelectedItemChanged ( object sender , EventArgs e ) {

        }
    }
}
