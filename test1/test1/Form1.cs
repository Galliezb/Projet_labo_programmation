using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
    


namespace test1 {
    public partial class Form1 : Form {
        int op;
        bool Hided;
        
        public Form1 () {
            InitializeComponent();
            testpanel.Visible = false;
            Hided = true;
            op = 0;
         
        }

        private void Form1_Load ( object sender , EventArgs e ) {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            testpanel.BackColor = Color.FromArgb(op, Color.Teal);

            if (Hided)
            {
                testpanel.Visible = true;
                op += 4;
                if (op == 252)
                {
                    timer1.Stop();
                    Hided = false;
                }
                
                //this.Refresh();

            }
            else
            {

                op -= 4;
                if (op <= 4)
                {
                    testpanel.Visible = false;
                    timer1.Stop();
                    Hided = true;
                }
               // this.Refresh();

            }
             

            
        }

        private void testpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
