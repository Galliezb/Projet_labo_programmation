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
        string name_;
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
        }
    }
}
