using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form_Settings : Form
    {
        SQL_Request_Form_Accueil databaseRequest = new SQL_Request_Form_Accueil();
        PlayerClass Player = new PlayerClass();
        public Form_Settings()
        {
            InitializeComponent();
        }
        public  Form_Settings(PlayerClass o)
        {
            InitializeComponent();
            Player = o;
        }
        private void Form_Settings_Load(object sender, EventArgs e)
        {
            panelLanguage.Parent = this;
            panelUserParam.Parent = this;
            this.panelLanguage.Visible = false;
            this.panelUserParam.Visible = false;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) // quand on selectionne un noeud dans le treeview , on ne montre que le panel en relation avec ce noeud.
        {
            if (treeView1.SelectedNode.Text == "Language")
            {
                panelUserParam.Visible = false;
                panelLanguage.Visible = true;

            }
            if (treeView1.SelectedNode.Text == "User Parameters")
            {
                panelLanguage.Visible = false;
                panelUserParam.Visible = true;
                tbFirstName.Text = Player.firstName;
                tbMail.Text = Player.email;
                tbName.Text = Player.name;
                tbPseudo.Text = Player.pseudo;
                tbPwd1.Text = Player.password;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelLanguage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)     // lorsqu'on appuie sur le bouton SAVE on met a jour les données de l utilisateur dans la base de données.
        {
            if (tbPwd1.Text.ToString() == tbPwd2.Text.ToString())
            {
                Player.email = tbMail.Text.ToString();
                Player.firstName = tbFirstName.Text.ToString();
                Player.name = tbName.Text.ToString();
                Player.password = tbPwd1.Text.ToString();
                Player.pseudo = tbPseudo.Text.ToString();

               // databaseRequest.updateInfo(Player);
                Player.updateToDataBase();
                //lbNom.Text = tbName.Text; petit soucis pratique

                //lbNom
                this.ParentForm.Controls["PanelTop"].Controls["lbNom"].Text = Player.name;
                
                //MessageBox.Show( traduction.display( 2002 ) );

            } else
            {

                MessageBox.Show( "Mots de passe differents" );

            }
        }

        private void panelUserParam_Paint ( object sender , PaintEventArgs e ) {

        }
    }
}
