﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1 {
    public partial class Form_Administration : Form {

        Users newUser;
        Users userForDataGrid = new Users();
        DataSet dataForDataGrid = new DataSet();
        Session laSession = new Session();

        public Form_Administration () {
            InitializeComponent();

            cbbSelectType.SelectedIndex = 0;
            cbLanguage.SelectedIndex = 0;

        }

        private void cbbSelectType_SelectedIndexChanged ( object sender , EventArgs e ) {

        }

        private void treeView1_AfterSelect ( object sender , TreeViewEventArgs e ) {
            if ( treeView1.SelectedNode.Text == "Add User to DB" ) {
                foreach ( Control c in panelAddUser.Controls ) {
                    if ( c is TextBox )
                        c.Text = String.Empty;
                    if ( c is ComboBox )
                        c.Text = String.Empty;
                }
                panelAddUser.Controls["cbbSelectType"].Text = String.Empty;


                panelChangeInfo.Visible = false;
                panelUpdateInfo.Visible = false;
                panelAddUser.Visible = true;
                //panelAddUser.
            }
            if ( treeView1.SelectedNode.Text == "Update Informations" ) {
                foreach ( Control c in panelAddUser.Controls ) {
                    if ( c is TextBox )
                        c.Text = String.Empty;
                    if ( c is ComboBox )
                        c.Text = String.Empty;
                }
                panelChangeInfo.Visible = false;
                panelUpdateInfo.Visible = true;
                panelAddUser.Visible = false;

            }
            if ( treeView1.SelectedNode.Text == "Change Your Informations" ) {
                foreach ( Control c in panelAddUser.Controls ) {
                    if ( c is TextBox )
                        c.Text = String.Empty;
                    if ( c is ComboBox )
                        c.Text = String.Empty;
                }
                panelAddUser.Visible = false;
                panelUpdateInfo.Visible = false;
                panelChangeInfo.Visible = true;
            }
        }

        private void Form_Administration_Load ( object sender , EventArgs e ) {
            panelAddUser.Parent = this;
            panelUpdateInfo.Parent = this;
            panelChangeInfo.Parent = this;

        }

        private void btSubmit_Click ( object sender , EventArgs e ) {
            bool done = false;
            if ( cbbSelectType.SelectedItem.ToString() == "Administrator" ) {
                newUser = new Users( -1 , tbNameUser.Text , tbFirstName.Text , tbMail.Text , tbPwd.Text , tbPseudo.Text , cbLanguage.Text , false , true );
                newUser.insert();
                done = true;
            } else if ( cbbSelectType.SelectedItem.ToString() == "Organizer" ) {
                newUser = new Users( -1 , tbNameUser.Text , tbFirstName.Text , tbMail.Text , tbPwd.Text , tbPseudo.Text , cbLanguage.Text , true , false );
                newUser.insert();
                done = true;
            } else if ( cbbSelectType.SelectedItem.ToString() == "User" ) {
                newUser = new Users( -1 , tbNameUser.Text , tbFirstName.Text , tbMail.Text , tbPwd.Text , tbPseudo.Text , cbLanguage.Text , false , false );
                newUser.insert();
                done = true;
            }

            if ( done ) {
                if ( laSession.language == "fr" ) {
                    MessageBox.Show( "User ajouté à la BDD" );
                } else {
                    MessageBox.Show( "User added to the BDD" );
                }

                cbbSelectType.SelectedIndex = 0;
                tbNameUser.Text = "";
                tbFirstName.Text = "";
                tbMail.Text = "";
                tbPseudo.Text = "";
                tbPwd.Text = "";
                cbLanguage.SelectedIndex = 0;
                rtbDesc.Text = "";
                textBox1.Text = "";
            }

        }

        private void cbbItems_SelectedIndexChanged ( object sender , EventArgs e ) {
            if ( cbbItems.SelectedItem.ToString() == "User" ) {
                dataForDataGrid = userForDataGrid.getAllUsers();
                dataGridView1.DataSource = dataForDataGrid;
                dataGridView1.DataMember = "user";
            }
        }


        private void tps_Tick ( object sender , EventArgs e ) {
            dataGridView1.Size = new Size( dataGridView1.Parent.Size.Width , dataGridView1.Size.Height );
            dataGridView1.Parent.Size = new Size( dataGridView1.Parent.Parent.Size.Width-247 , dataGridView1.Size.Height );
        }

        private void button1_Click ( object sender , EventArgs e ) {
            userForDataGrid.update( dataForDataGrid );
        }
    }
}
