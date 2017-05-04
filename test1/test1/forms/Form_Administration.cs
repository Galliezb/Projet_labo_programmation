using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1{
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
                foreach (Control c in panelAddUser.Controls) {
                    if (c is TextBox)
                        c.Text = String.Empty;
                }
                panelAddUser.Controls["cbbSelectType"].Text = String.Empty;


                panelChangeInfo.Visible = false;
                panelUpdateInfo.Visible = false;
                panelAddUser.Visible = true;
                //panelAddUser.
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

        private void btSubmit_Click(object sender, EventArgs e)
        {
            Users newUser;
            if(cbbSelectType.SelectedText== "Administrator") {
                newUser = new Users(-1, tbNameUser.Text, tbFirstName.Text, tbMail.Text, tbPwd.Text, tbPseudo.Text, cbLanguage.Text,false,true);
                newUser.insert();
            }
            if (cbbSelectType.SelectedText == "Organizer")
            {
                newUser = new Users(-1, tbNameUser.Text, tbFirstName.Text, tbMail.Text, tbPwd.Text, tbPseudo.Text, cbLanguage.Text, true, false);
                newUser.insert();
            }
            if (cbbSelectType.SelectedText == "User")
            {
                newUser = new Users(-1, tbNameUser.Text, tbFirstName.Text, tbMail.Text, tbPwd.Text, tbPseudo.Text, cbLanguage.Text, false, false);
                newUser.insert();
            }
            
            
        }
    }
}
