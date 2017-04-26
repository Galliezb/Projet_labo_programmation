using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.Bruno;
using test1.Norbert.forms;

namespace test1.Norbert
{
    public partial class Form_Page_Accueil : Form
    {
        bool PanelGaucheDeploye = true;

        PlayerClass o = new PlayerClass();
        //Traducteur traduction = new Traducteur();
        
        SQL_Request_Form_Accueil databaseRequest = new SQL_Request_Form_Accueil();

        public Form_Page_Accueil()
        {
            InitializeComponent();
            databaseRequest.UpdatePlayerClass(o);
            
            lbNom.Text = o.name;

        }





        private void btQuit_Click(object sender, EventArgs e)   //Ferme l'application
        {
            this.Close();
        }

        private void btParam_Click(object sender, EventArgs e)
        {

        }

        private void btMenu_Click(object sender, EventArgs e) //Active le timer pour l'animation du menu
        {
            this.tm.Enabled = true;
        }

        private void test1mouseHoverLB1(object sender, EventArgs e) //Change la couleur du panel quand la souris se trouve par dessus
        {
            
            Label LabelReceive;
            PictureBox BoxReceive;
            if (sender.GetType().Name == "Label") {
                LabelReceive = (Label)sender;
                
                LabelReceive.Parent.BackColor = Color.FromArgb(66, 96, 154);
            }
            else{
                BoxReceive = (PictureBox)sender;
                
                BoxReceive.Parent.BackColor = Color.FromArgb(66, 96, 154);
            }
            
        }

        private void test1mouseLeaveLB1(object sender, EventArgs e) // Change la couleur du panel quand la souris ne se trouve plus dessus
        {

            Label LabelReceive;
            PictureBox BoxReceive;
            if (sender.GetType().Name == "Label")
            {
                LabelReceive = (Label)sender;

                LabelReceive.Parent.BackColor = Color.FromArgb(0, 122, 204);
            }
            else
            {
                BoxReceive = (PictureBox)sender;

                BoxReceive.Parent.BackColor = Color.FromArgb(0, 122, 204);
            }


        }



        private void tm_Tick(object sender, EventArgs e) // Tick du timer 
        {
            int past = 0; // sert à éviter de rentrer dans la condition de rétrécissement et ainsi pouvoir garder le grand logo
            Point location_ = new Point();
            if (PanelGaucheDeploye == false)
            {
               
                if (panelGauche.Width >= 275) // si le menu a atteind sa taille maximum, le timer est arrêté , on déplace le bouton Menu à l'endroit voulu 
                {
                    this.tm.Enabled = false;
                    PanelGaucheDeploye = true;
                    location_.X = 240;
                    location_.Y = 6;
                    btMenu.Location= location_;
                    past = 1;
                    
                }
                else
                {
                    panelGauche.Width += 5;
                    panelFill.Width -= 5;

                }
                

            }
            // la variable past sert uniquement dans le cas où on aurait agrandit le menu. Puisque le menu est déployé le panneau serait reduit de 5 pixels et le grand logo serait invisible.
            if (PanelGaucheDeploye == true && past!=1) 
            {
                if (panelGauche.Width <= 50)
                {
                    this.tm.Enabled = false;
                    
                    
                    PanelGaucheDeploye = false;
                    location_.X = 10;
                    location_.Y = 52;
                    btMenu.Location = location_;
                    
                }
                else
                {
                    panelGauche.Width -= 5;
                    panelFill.Width += 5;
                }
               
            }
            past = 0;

        }

        private void PanelClick(object sender, EventArgs e)
        {

        }

        private void BtModifyParam_Click(object sender, EventArgs e) // Quand on cliquera sur le bouton "Modify Informations" tous les labels et les textBox associées seront visibles
        {
            lbFirstName.Visible = true;
            lbMail.Visible = true;
            lbName.Visible = true;
            lbPWD1.Visible = true;
            lbPWD2.Visible = true;
            lbPseudo.Visible = true;

            tbPseudo.Visible = true;
            tbFirstName.Visible = true;
            tbMail.Visible = true;
            tbName.Visible = true;
            tbPwd1.Visible = true;
            tbPwd2.Visible = true;
            btSave.Visible = true;
            tbMail.Text = o.email;
            tbName.Text = o.name;
            tbPwd1.Text = o.password;
            tbFirstName.Text = o.firstName;
            tbPseudo.Text = o.pseudo;
        }

        private void tbPwd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e) // Fonction servant à mettre à jour la base de données avec les informations présentes dans les textBox
        {
            if (tbPwd1.Text.ToString() == tbPwd2.Text.ToString())
            {
                o.email = tbMail.Text.ToString();
                o.firstName = tbFirstName.Text.ToString();
                o.name = tbName.Text.ToString();
                o.password = tbPwd1.Text.ToString();
                o.pseudo = tbPseudo.Text.ToString();

                databaseRequest.updateInfo(o);
                lbNom.Text = tbName.Text;

                //MessageBox.Show( traduction.display( 2002 ) );

            } else {

                //MessageBox.Show( traduction.display( 2001 ) );

            }
        }

        private void panelFill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbSettings_Click(object sender, EventArgs e)
        {

        }
        
        private void CreateFormInPanel(object sender,ref Form MyForm)
        {

            Label LabelReceive;
            PictureBox BoxReceive;
            if (sender.GetType().Name == "Label")
            {
                LabelReceive = (Label)sender;
                panelFill.Controls.Clear();
                MyForm.TopLevel = false;
                MyForm.FormBorderStyle = FormBorderStyle.None;
                MyForm.Parent = panelFill;
                MyForm.Top = 0;
                MyForm.Left = 0;
                MyForm.Size = panelFill.ClientSize;
                //panelFill.AutoScroll = true;
                //  panelFill.AutoScroll = true;
                MyForm.Dock = DockStyle.Fill;
                MyForm.AutoScroll = false;
                MyForm.BringToFront();
                MyForm.Show();

            }
            else
            {
                BoxReceive = (PictureBox)sender;
                panelFill.Controls.Clear();
                //panelFill.AutoScroll = false;
                MyForm.TopLevel = false;
                MyForm.FormBorderStyle = FormBorderStyle.None;
                MyForm.Parent = panelFill;
                MyForm.Top = 0;
                MyForm.Left = 0;
                MyForm.Size = panelFill.ClientSize;
                MyForm.Dock = DockStyle.Fill;
                MyForm.BringToFront();
                MyForm.Show();

            }
        }

        private void PanelHistorique_MouseClick(object sender, MouseEventArgs e)
        {
          


        }

        private void PanelSettings_MouseClick(object sender, MouseEventArgs e)
        {

            //Form_Settings MyForm = new Form_Settings();
            Form MyForm_ = new Form_Settings(o);
            CreateFormInPanel(sender, ref MyForm_);


        }

      

        private void PanelTop10_MouseClick(object sender, MouseEventArgs e)
        {
            //Form_Top10 MyForm = new Form_Top10();
            Form MyForm_ = new Form_Top10();
            CreateFormInPanel(sender, ref MyForm_);
        }

        private void lbTop10_Click(object sender, EventArgs e)
        {

        }

        private void PanelSearchTnm_MouseClick(object sender, MouseEventArgs e)
        {
            //Form_Top10 MyForm = new Form_Top10();
            Form MyForm_ = new Form_Search_Tournament();
            CreateFormInPanel(sender, ref MyForm_);
        }

        private void lbManageTeam_MouseClick(object sender, MouseEventArgs e)
        {
            Form_ManageTeam MyForm = new Form_ManageTeam();
            Form MyForm_ = new Form_ManageTeam();
            CreateFormInPanel(sender, ref MyForm_);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Form_CreateOrg MyForm = new Form_CreateOrg();
            Form MyForm_ = new Form_CreateOrg();
            CreateFormInPanel(sender, ref MyForm_);
        }

        private void lbAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Administration MyForm = new Form_Administration();
            Form MyForm_ = new Form_Administration();
            CreateFormInPanel(sender, ref MyForm_);
        }
    }
}
