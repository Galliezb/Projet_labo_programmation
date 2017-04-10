using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
namespace test1 {
    public partial class FormStart : Form {

        Sql_non_identifie test = new Sql_non_identifie();

        System.Media.SoundPlayer SP = new System.Media.SoundPlayer(@"D:\Storage\Informatique deuxième\Projet C#\Projet_labo_programmation\test1\test1\Resources\Kwouin.wav");
       
        public FormStart () {
            InitializeComponent();
            
            // Passage en full screen
            //FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
           // BackgroundImageLayout = ImageLayout.Stretch;
            Label lbLogin = new Label();
            TextBox txtLogin = new TextBox();
            panel1.BackColor = Color.FromArgb(85, 0, 0, 51);
            pIdentification.BackColor = Color.FromArgb(0, 0, 0, 0);
            pCreate.BackColor = Color.FromArgb(0, 0, 0, 0);
            Label lbMdp = new Label();
            TextBox txtMdp = new TextBox();
            lbIdentification.BackColor = Color.FromArgb(85, 212, 175, 55);
            bIdentification.BackColor = Color.FromArgb(0, 0, 0, 0);
            bIdentification.ForeColor = Color.FromArgb(40, Color.Black);
            
            
        }

        private void Form1_Load ( object sender , EventArgs e ) {

        }

        private void domainUpDown1_SelectedItemChanged ( object sender , EventArgs e ) {

        }

        private void pNews_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbIdentification_Click(object sender, EventArgs e)
        {

        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bIdentification_MouseHover(object sender, EventArgs e)
        {
            bIdentification.ForeColor = Color.FromArgb(40, 212, 175, 55);
            bIdentification.BackColor = Color.FromArgb(40, 80, 193, 221);
        }

        private void bIdentification_MouseLeave(object sender, EventArgs e)
        {
            bIdentification.BackColor = Color.FromArgb(0, 0, 0, 0);
            bIdentification.ForeColor = Color.FromArgb(40, 80, 193, 221);

        }

        private void bCreate_MouseHover(object sender, EventArgs e)
        {
            bCreate.ForeColor = Color.FromArgb(40, 212, 175, 55);
            bCreate.BackColor = Color.FromArgb(40, 80, 193, 221);
        }

        private void bCreate_MouseLeave(object sender, EventArgs e)
        {
            bCreate.BackColor = Color.FromArgb(0, 0, 0, 0);
            bCreate.ForeColor = Color.FromArgb(40, 80, 193, 221);
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            SP.Play();   
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            if (tbCreatePwd.Text == tbVerifPwd.Text)
            {
                test.ajoutCompte(tbCreateLogin.Text.ToString(), tbVerifPwd.Text.ToString());
                PageDAccueil page = new PageDAccueil(tbCreateLogin.Text.ToString());
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
                this.Hide();
                PageDAccueil page = new PageDAccueil( tbLogin.Text.ToString() );
                page.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Les identifiants sont incorrects");
            }

        }
    }
}
