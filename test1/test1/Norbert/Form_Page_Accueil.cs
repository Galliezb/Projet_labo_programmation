using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1.Norbert
{
    public partial class Form_Page_Accueil : Form
    {
        bool PanelGaucheDeploye = true;

        Objet_A_Update o = new Objet_A_Update();
        string name_;
        SQL_Request_Form_Accueil test = new SQL_Request_Form_Accueil();

        public Form_Page_Accueil(string name)
        {
            InitializeComponent();
            name_ = name;
            lbNom.Text = name_;

        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btParam_Click(object sender, EventArgs e)
        {

        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.tm.Enabled = true;
        }

        private void test1mouseHoverLB1(object sender, EventArgs e)
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

        private void test1mouseLeaveLB1(object sender, EventArgs e)
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



        private void tm_Tick(object sender, EventArgs e)
        {
            int past = 0;
            Point location_ = new Point();
            if (PanelGaucheDeploye == false)
            {
               
                if (panelGauche.Width >= 275)
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
                    pbLogoBig.Visible = true;
                }
            }

            if (PanelGaucheDeploye == true && past!=1)
            {
                if (panelGauche.Width <= 50)
                {
                    this.tm.Enabled = false;
                    
                    
                    PanelGaucheDeploye = false;
                    location_.X = 12;
                    location_.Y = 52;
                    btMenu.Location = location_;
                    
                }
                else
                {
                    panelGauche.Width -= 5;
                    pbLogoBig.Visible = false;
                }
            }
            past = 0;

        }

        private void PanelClick(object sender, EventArgs e)
        {

        }

        private void BtModifyParam_Click(object sender, EventArgs e)
        {
            lbFirstName.Visible = true;
            lbMail.Visible = true;
            lbName.Visible = true;
            lbPWD1.Visible = true;
            lbPWD2.Visible = true;

            tbFirstName.Visible = true;
            tbMail.Visible = true;
            tbName.Visible = true;
            tbPwd1.Visible = true;
            tbPwd2.Visible = true;
            btSave.Visible = true;
            tbMail.Text = test.getMailUser(name_);
            tbName.Text = name_;
            tbPwd1.Text = test.getPWDUser(name_);
            tbFirstName.Text = test.getFirstnameUser(name_);
        }

        private void tbPwd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbPwd1.Text.ToString() == tbPwd2.Text.ToString())
            {
                o.email = tbMail.Text.ToString();
                o.firstName = tbFirstName.Text.ToString();
                o.name = tbName.Text.ToString();
                o.password = tbPwd1.Text.ToString();

                test.updateInfo(o, lbNom.Text.ToString());
                lbNom.Text = tbName.Text;
            }
        }


    }
}
