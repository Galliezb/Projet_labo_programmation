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

        Sql_non_identifie test = new Sql_non_identifie();

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

        private void bCreate_Click(object sender, EventArgs e)
        {
            if (tbCreatePwd.Text == tbVerifPwd.Text)
            {
                test.ajoutCompte(tbCreateLogin.Text.ToString(), tbVerifPwd.Text.ToString());
                PageDAccueil page = new PageDAccueil(tbLogin.Text.ToString());
                page.ShowDialog();
                Hide();
            }
            else
            {
                MessageBox.Show("les mots de passe ne correspondent pas");
            }
        }

        private void bIdentification_Click(object sender, EventArgs e)
        {
            if (tbPwd.Text.ToString() == test.test2(tbLogin.Text.ToString(),"password"))
            {
                PageDAccueil page = new PageDAccueil(tbLogin.Text.ToString());
                page.ShowDialog();
                Hide();
            }
            
        }
    }
}
