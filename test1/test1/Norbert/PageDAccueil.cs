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
    public partial class PageDAccueil : Form
    {
        Objet_A_Update o= new Objet_A_Update();
        string name_;
        SQL_Request_Form_Accueil test = new SQL_Request_Form_Accueil();
        public PageDAccueil()
        {
            InitializeComponent();
        }
        public PageDAccueil(string name)
        {
            InitializeComponent();
            name_ = name;
            lbNom.Text = name_;
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
            tbMail.Text= test.getMailUser(name_);
            tbName.Text = name_;
            tbPwd1.Text = test.getPWDUser(name_);
            tbFirstName.Text = test.getFirstnameUser(name_);
            
        }

        private void tbName_TextChanged ( object sender , EventArgs e ) {

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

        private void PageDAccueil_Load(object sender, EventArgs e)
        {

        }
    }
}
