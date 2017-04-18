namespace test1.Bruno {
    partial class Form_organizer_start {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelCreationTournoi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.labelCreationTournoi);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.pictureBoxMenu);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 840);
            this.panelMenu.TabIndex = 0;
            // 
            // labelCreationTournoi
            // 
            this.labelCreationTournoi.BackColor = System.Drawing.Color.Transparent;
            this.labelCreationTournoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCreationTournoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCreationTournoi.Image = global::test1.Properties.Resources.bouton01;
            this.labelCreationTournoi.Location = new System.Drawing.Point(47, 75);
            this.labelCreationTournoi.Name = "labelCreationTournoi";
            this.labelCreationTournoi.Size = new System.Drawing.Size(150, 50);
            this.labelCreationTournoi.TabIndex = 1;
            this.labelCreationTournoi.Text = "Créer un Tournoi";
            this.labelCreationTournoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCreationTournoi.MouseLeave += new System.EventHandler(this.pictureMenuOut);
            this.labelCreationTournoi.MouseHover += new System.EventHandler(this.pictureMenuHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test1.Properties.Resources.creation_tournoi;
            this.pictureBox1.Location = new System.Drawing.Point(0, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMenu.Image = global::test1.Properties.Resources.bouton_config;
            this.pictureBoxMenu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 1;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContent.Location = new System.Drawing.Point(467, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(813, 840);
            this.panelContent.TabIndex = 1;
            // 
            // Form_organizer_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1280, 840);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form_organizer_start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_organisateur_accueil";
            this.Load += new System.EventHandler(this.form_organisateur_accueil_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCreationTournoi;
        private System.Windows.Forms.Panel panelContent;
    }
}