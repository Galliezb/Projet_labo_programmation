using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1.Bruno {
    public partial class Form_organizer_start : Form {

        Traducteur traduction = new Traducteur();

        public Form_organizer_start () {
            InitializeComponent();
        }

        private void form_organisateur_accueil_Load ( object sender , EventArgs e ) {

            labelCreationTournoi.Text = traduction.display( 0 );

        }

        private void pictureBox1_Click ( object sender , EventArgs e ) {

            // on récupère la picture cliqué
            PictureBox pict = (PictureBox) sender;
            // récuperation taille panel parent
            Size sizePanel = pict.Parent.Size;

            // replier le panel
            if ( sizePanel.Width == 200 ) {

                pict.Parent.Dock = DockStyle.None;

                // OMG LA VILAINE BOUCLE INFINI
                while ( true ) {

                    if ( sizePanel.Width > 50 ) {
                        // animation de retrecissement à la vitesse max de calcul du pc = PAS BIEN
                        sizePanel.Width -= 1;
                        sizePanel.Height -= 6;
                        if ( sizePanel.Height < 50 ) { sizePanel.Height = 50; }
                        pict.Parent.Size = new Size( sizePanel.Width , sizePanel.Height );
                        pict.Location = new Point( sizePanel.Width - 50 , 0 );

                    } else {
                        break;
                    }

                }

                // déployer le panel
            } else {

                // cale la panel à gauche
                pict.Parent.Dock = DockStyle.Left;

                // OMG LA VILAINE BOUCLE INFINI
                while ( true ) {

                    if ( sizePanel.Width < 200 ) {
                        // animation d'agrandissement à la vitesse max de calcul du pc = PAS BIEN
                        sizePanel.Width += 1;
                        sizePanel.Height += 6;
                        if ( sizePanel.Height > 840 ) { sizePanel.Height = 840;  }
                        pict.Parent.Size = new Size( sizePanel.Width , sizePanel.Height );
                        pict.Location = new Point( sizePanel.Width - 50 , 0 );

                    } else {
                        break;
                    }

                }

            }


            
        }

        private void pictureMenuHover ( object sender , EventArgs e ) {

            // on récupère le tag et on change en conséquence.
            Label lb = (Label) sender;
            lb.ForeColor = Color.Cyan;
        }

        private void pictureMenuOut ( object sender , EventArgs e ) {

            // on récupère le tag et on change en conséquence.
            Label lb = (Label) sender;
            lb.ForeColor = Color.White;

        }
    }
}
