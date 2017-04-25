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
    public partial class Form_Top10 : Form
    {
        public Form_Top10()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Index == 1)
            {
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/fjrfYZsZLJA";
                axShockwaveFlash1.Play();

            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
