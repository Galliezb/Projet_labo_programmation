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
    public partial class Form_ManageTeam : Form
    {
        public Form_ManageTeam()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCreateTeam_Click(object sender, EventArgs e)
        {
            PanelRightCT.Visible = true;
            PanelModifyTeam.Visible = false;
        }

        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void cbbChooseTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNameCT.Text = "Chicken Kick Chicks";
            tbTagCT.Text = "CKC";
            tbAddGameCT.Text = "";
            tbAddPlayerCT.Text = "";
            PanelRightCT.Visible = true;
            PanelModifyTeam.Visible = true;
        }
    }
}
