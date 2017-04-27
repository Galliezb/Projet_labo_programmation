using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.Bruno;

namespace test1.Norbert.forms
{
    public partial class Form_CreateOrg : Form
    {

        Session laSession = new Session();

        public Form_CreateOrg()
        {
            InitializeComponent();
        }

        private void Form_CreateOrg_Load ( object sender , EventArgs e ) {

            // traduit en français si nécessaire
            if ( laSession.language == "fr" ) {

                lbCreateTnm.Text = "Créer un tournoi : ";
                lbNameTnm.Text = " Nom : ";
                lbDateDebutTnm.Text = "Date de début : ";
                lbDateFinTnm.Text = "Date de fin : ";
                lbDescTnm.Text = "Description : ";
                lbMaxPlayerTnm.Text = "Nombre max de joueurs : ";
                btSubmissionTnm.Text = "Soumettre";

                comboType.Items.Clear();
                comboType.Items.Add( "Championnat toute ronde" );
                comboType.Items.Add( "Elimination directe" );
                comboType.Items.Add( "Phase de groupe" );


            }

            // mets à jour les dates préselectionnés
            dateTimePickerStartDate.Value = DateTime.Now.AddDays( 1 );
            dateTimePickerEndDate.Value = DateTime.Now.AddDays( 4 );
            
        }

        private void btSubmissionTnm_Click ( object sender , EventArgs e ) {

            Tournament tournoi = new Tournament();

            tournoi.name = tnNameTnm.Text;
            tournoi.typeTournoi = comboType.SelectedText;
            tournoi.startDate = dateTimePickerStartDate.Value;
            tournoi.endDate = dateTimePickerEndDate.Value;
            tournoi.maxPlayer = Convert.ToInt32(tbMaxpPlayerTnm.Text);
            tournoi.Description = rtbDescTnm.Text;

            tournoi.insertInDataBase();

            this.Refresh();

        }
    }
}
