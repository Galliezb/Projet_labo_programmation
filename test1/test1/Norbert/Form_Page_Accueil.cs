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
        //Animator bonjour;// = new Animator();
        public Form_Page_Accueil()
        {
            InitializeComponent();
            
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
            //MessageBox.Show(sender.GetType().Name);
            Label LabelReceive;
            PictureBox BoxReceive;
            if (sender.GetType().Name == "Label") {
                LabelReceive = (Label)sender;
                //MessageBox.Show(LabelReceive.Parent.Name.ToString());
                LabelReceive.Parent.BackColor = Color.FromArgb(66, 96, 154);
            }
            else{
                BoxReceive = (PictureBox)sender;
                //MessageBox.Show(BoxReceive.Parent.Name.ToString());
                BoxReceive.Parent.BackColor = Color.FromArgb(66, 96, 154);
            }
            //BoxReceive.Parent 
            //Panel monpanel = (Panel)sender;
            /*foreach (Control p in monpanel.Controls)
            {
                if (p is Label)
                {
                    MessageBox.Show(p.Text.ToString());
                }
            }
            monpanel.BackColor= Color.FromArgb(66, 96, 154);*/
        }

        private void test1mouseLeaveLB1(object sender, EventArgs e)
        {
            //MessageBox.Show("mouse OUTE");
            /*Panel panel = (Panel)sender;
            panel.BackColor = Color.FromArgb(0, 122, 204);*/
            Label LabelReceive;
            PictureBox BoxReceive;
            if (sender.GetType().Name == "Label")
            {
                LabelReceive = (Label)sender;
                //MessageBox.Show(LabelReceive.Parent.Name.ToString());
                LabelReceive.Parent.BackColor = Color.FromArgb(0, 122, 204);
            }
            else
            {
                BoxReceive = (PictureBox)sender;
                //MessageBox.Show(BoxReceive.Parent.Name.ToString());
                BoxReceive.Parent.BackColor = Color.FromArgb(0, 122, 204);
            }
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            Point location_ = new Point();
            if (PanelGaucheDeploye == false)
            {
                if (panelGauche.Width >= 276)
                {
                    this.tm.Enabled = false;
                    PanelGaucheDeploye = true;
                    location_.X = 240;
                    location_.Y = 6;
                    btMenu.Location= location_;
                }
                else
                {
                    panelGauche.Width += 2;
                }
            }

            if (PanelGaucheDeploye == true)
            {
                if (panelGauche.Width <= 49)
                {
                    this.tm.Enabled = false;
                    
                    
                    PanelGaucheDeploye = false;
                    location_.X = 12;
                    location_.Y = 52;
                    btMenu.Location = location_;
                }
                else
                {
                    panelGauche.Width -= 2;
                }
            }

        }
    }
}
