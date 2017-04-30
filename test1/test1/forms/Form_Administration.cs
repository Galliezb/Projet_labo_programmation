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
    public partial class Form_Administration : Form
    {
        public Form_Administration()
        {
            InitializeComponent();
        }

        private void cbbSelectType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Text == "Add User to DB")
            {
                panelChangeInfo.Visible = false;
                panelUpdateInfo.Visible = false;
                panelAddUser.Visible = true;
            }
            if(treeView1.SelectedNode.Text == "Update Informations")
            {
               panelChangeInfo.Visible = false;
               panelUpdateInfo.Visible = true;
               panelAddUser.Visible = false;
            }
            if(treeView1.SelectedNode.Text == "Change Your Informations")
            {
                panelAddUser.Visible = false;
                panelUpdateInfo.Visible = false;
                panelChangeInfo.Visible = true;
            }
        }

        private void Form_Administration_Load(object sender, EventArgs e)
        {
            panelAddUser.Parent = this;
            panelUpdateInfo.Parent = this;
            panelChangeInfo.Parent = this;
            
        }
    }
}
