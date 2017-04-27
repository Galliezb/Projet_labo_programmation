using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1.Norbert.forms
{
    public partial class Form_CreateOrg : Form
    {
        public Form_CreateOrg()
        {
            InitializeComponent();
        }

        private void btCreateTnm_Click(object sender, EventArgs e)
        {
            panelCreateTnm.Visible = true;
            panelCreateOrga.Visible = false;
        }

        private void btCreateOrga_Click(object sender, EventArgs e)
        {
            panelCreateTnm.Visible = false;
            panelCreateOrga.Visible = true;
        }

        private void Form_CreateOrg_Load(object sender, EventArgs e)
        {
            panelCreateOrga.Parent = this;
            panelCreateTnm.Parent = this; 

        }
    }
}
