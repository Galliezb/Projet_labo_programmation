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
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            panelLanguage.Parent = this;
            panelUserParam.Parent = this;
            this.panelLanguage.Visible = false;
            this.panelUserParam.Visible = false;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
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
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
