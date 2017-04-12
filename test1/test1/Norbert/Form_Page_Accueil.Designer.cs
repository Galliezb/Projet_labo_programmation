namespace test1.Norbert
{
    partial class Form_Page_Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Page_Accueil));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelGauche = new System.Windows.Forms.Panel();
            this.PanelBot = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelAccueil = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelFill = new System.Windows.Forms.Panel();
            this.pbLogoBig = new System.Windows.Forms.PictureBox();
            this.btMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btManageTeam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btFriendsList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btRecords = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btQuit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelGauche.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btQuit)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // panelGauche
            // 
            this.panelGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelGauche.Controls.Add(this.pbLogoBig);
            this.panelGauche.Controls.Add(this.btMenu);
            this.panelGauche.Controls.Add(this.btManageTeam);
            this.panelGauche.Controls.Add(this.btFriendsList);
            this.panelGauche.Controls.Add(this.btRecords);
            this.panelGauche.Controls.Add(this.btSettings);
            this.panelGauche.Controls.Add(this.pbLogo);
            this.panelGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGauche.Location = new System.Drawing.Point(0, 39);
            this.panelGauche.Name = "panelGauche";
            this.panelGauche.Size = new System.Drawing.Size(275, 768);
            this.panelGauche.TabIndex = 0;
            // 
            // PanelBot
            // 
            this.PanelBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PanelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBot.Location = new System.Drawing.Point(0, 807);
            this.PanelBot.Name = "PanelBot";
            this.PanelBot.Size = new System.Drawing.Size(1280, 33);
            this.PanelBot.TabIndex = 1;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PanelTop.Controls.Add(this.btQuit);
            this.PanelTop.Controls.Add(this.LabelAccueil);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1280, 39);
            this.PanelTop.TabIndex = 2;
            // 
            // LabelAccueil
            // 
            this.LabelAccueil.AutoSize = true;
            this.LabelAccueil.ForeColor = System.Drawing.Color.White;
            this.LabelAccueil.Location = new System.Drawing.Point(29, 13);
            this.LabelAccueil.Name = "LabelAccueil";
            this.LabelAccueil.Size = new System.Drawing.Size(42, 18);
            this.LabelAccueil.TabIndex = 0;
            this.LabelAccueil.Text = "Test";
            // 
            // panelFill
            // 
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(275, 39);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1005, 768);
            this.panelFill.TabIndex = 3;
            // 
            // pbLogoBig
            // 
            this.pbLogoBig.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoBig.Image")));
            this.pbLogoBig.Location = new System.Drawing.Point(49, 6);
            this.pbLogoBig.Name = "pbLogoBig";
            this.pbLogoBig.Size = new System.Drawing.Size(185, 98);
            this.pbLogoBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoBig.TabIndex = 6;
            this.pbLogoBig.TabStop = false;
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btMenu.Image = ((System.Drawing.Image)(resources.GetObject("btMenu.Image")));
            this.btMenu.ImageActive = null;
            this.btMenu.Location = new System.Drawing.Point(240, 6);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(30, 30);
            this.btMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMenu.TabIndex = 3;
            this.btMenu.TabStop = false;
            this.btMenu.Zoom = 20;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // btManageTeam
            // 
            this.btManageTeam.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.btManageTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btManageTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btManageTeam.BorderRadius = 0;
            this.btManageTeam.ButtonText = "             Manage Teams";
            this.btManageTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btManageTeam.DisabledColor = System.Drawing.Color.Gray;
            this.btManageTeam.Iconcolor = System.Drawing.Color.Transparent;
            this.btManageTeam.Iconimage = ((System.Drawing.Image)(resources.GetObject("btManageTeam.Iconimage")));
            this.btManageTeam.Iconimage_right = null;
            this.btManageTeam.Iconimage_right_Selected = null;
            this.btManageTeam.Iconimage_Selected = null;
            this.btManageTeam.IconMarginLeft = 0;
            this.btManageTeam.IconMarginRight = 0;
            this.btManageTeam.IconRightVisible = true;
            this.btManageTeam.IconRightZoom = 0D;
            this.btManageTeam.IconVisible = true;
            this.btManageTeam.IconZoom = 50D;
            this.btManageTeam.IsTab = true;
            this.btManageTeam.Location = new System.Drawing.Point(0, 267);
            this.btManageTeam.Margin = new System.Windows.Forms.Padding(22, 11, 22, 11);
            this.btManageTeam.Name = "btManageTeam";
            this.btManageTeam.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btManageTeam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btManageTeam.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.btManageTeam.selected = false;
            this.btManageTeam.Size = new System.Drawing.Size(275, 48);
            this.btManageTeam.TabIndex = 5;
            this.btManageTeam.Text = "             Manage Teams";
            this.btManageTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btManageTeam.Textcolor = System.Drawing.Color.White;
            this.btManageTeam.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btFriendsList
            // 
            this.btFriendsList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.btFriendsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btFriendsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFriendsList.BorderRadius = 0;
            this.btFriendsList.ButtonText = "             Friends List";
            this.btFriendsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFriendsList.DisabledColor = System.Drawing.Color.Gray;
            this.btFriendsList.Iconcolor = System.Drawing.Color.Transparent;
            this.btFriendsList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btFriendsList.Iconimage")));
            this.btFriendsList.Iconimage_right = null;
            this.btFriendsList.Iconimage_right_Selected = null;
            this.btFriendsList.Iconimage_Selected = null;
            this.btFriendsList.IconMarginLeft = 0;
            this.btFriendsList.IconMarginRight = 0;
            this.btFriendsList.IconRightVisible = true;
            this.btFriendsList.IconRightZoom = 0D;
            this.btFriendsList.IconVisible = true;
            this.btFriendsList.IconZoom = 50D;
            this.btFriendsList.IsTab = true;
            this.btFriendsList.Location = new System.Drawing.Point(0, 218);
            this.btFriendsList.Margin = new System.Windows.Forms.Padding(13, 8, 13, 8);
            this.btFriendsList.Name = "btFriendsList";
            this.btFriendsList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btFriendsList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btFriendsList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.btFriendsList.selected = false;
            this.btFriendsList.Size = new System.Drawing.Size(275, 48);
            this.btFriendsList.TabIndex = 5;
            this.btFriendsList.Text = "             Friends List";
            this.btFriendsList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFriendsList.Textcolor = System.Drawing.Color.White;
            this.btFriendsList.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btRecords
            // 
            this.btRecords.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.btRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRecords.BorderRadius = 0;
            this.btRecords.ButtonText = "             Records";
            this.btRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRecords.DisabledColor = System.Drawing.Color.Gray;
            this.btRecords.Iconcolor = System.Drawing.Color.Transparent;
            this.btRecords.Iconimage = ((System.Drawing.Image)(resources.GetObject("btRecords.Iconimage")));
            this.btRecords.Iconimage_right = null;
            this.btRecords.Iconimage_right_Selected = null;
            this.btRecords.Iconimage_Selected = null;
            this.btRecords.IconMarginLeft = 0;
            this.btRecords.IconMarginRight = 0;
            this.btRecords.IconRightVisible = true;
            this.btRecords.IconRightZoom = 0D;
            this.btRecords.IconVisible = true;
            this.btRecords.IconZoom = 50D;
            this.btRecords.IsTab = true;
            this.btRecords.Location = new System.Drawing.Point(0, 166);
            this.btRecords.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btRecords.Name = "btRecords";
            this.btRecords.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btRecords.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btRecords.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.btRecords.selected = false;
            this.btRecords.Size = new System.Drawing.Size(275, 48);
            this.btRecords.TabIndex = 4;
            this.btRecords.Text = "             Records";
            this.btRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRecords.Textcolor = System.Drawing.Color.White;
            this.btRecords.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btSettings
            // 
            this.btSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.btSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSettings.BorderRadius = 0;
            this.btSettings.ButtonText = "             Settings";
            this.btSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btSettings.Iconimage")));
            this.btSettings.Iconimage_right = null;
            this.btSettings.Iconimage_right_Selected = null;
            this.btSettings.Iconimage_Selected = null;
            this.btSettings.IconMarginLeft = 0;
            this.btSettings.IconMarginRight = 0;
            this.btSettings.IconRightVisible = true;
            this.btSettings.IconRightZoom = 0D;
            this.btSettings.IconVisible = true;
            this.btSettings.IconZoom = 50D;
            this.btSettings.IsTab = true;
            this.btSettings.Location = new System.Drawing.Point(0, 117);
            this.btSettings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btSettings.Name = "btSettings";
            this.btSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSettings.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.btSettings.selected = false;
            this.btSettings.Size = new System.Drawing.Size(275, 48);
            this.btSettings.TabIndex = 2;
            this.btSettings.Text = "             Settings";
            this.btSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSettings.Textcolor = System.Drawing.Color.White;
            this.btSettings.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSettings.Click += new System.EventHandler(this.btParam_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(43, 46);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btQuit.Image = ((System.Drawing.Image)(resources.GetObject("btQuit.Image")));
            this.btQuit.ImageActive = null;
            this.btQuit.Location = new System.Drawing.Point(1227, 6);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(25, 25);
            this.btQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btQuit.TabIndex = 4;
            this.btQuit.TabStop = false;
            this.btQuit.Zoom = 20;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // Form_Page_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1280, 840);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelGauche);
            this.Controls.Add(this.PanelBot);
            this.Controls.Add(this.PanelTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form_Page_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Page_Accueil";
            this.panelGauche.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btQuit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Panel panelGauche;
        private Bunifu.Framework.UI.BunifuImageButton btMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btSettings;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel PanelBot;
        private System.Windows.Forms.Panel PanelTop;
        private Bunifu.Framework.UI.BunifuImageButton btQuit;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelAccueil;
        private Bunifu.Framework.UI.BunifuFlatButton btRecords;
        private Bunifu.Framework.UI.BunifuFlatButton btManageTeam;
        private Bunifu.Framework.UI.BunifuFlatButton btFriendsList;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.PictureBox pbLogoBig;
    }
}