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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelManage = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFriends = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbFriends = new System.Windows.Forms.Label();
            this.PanelHistorique = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbRecords = new System.Windows.Forms.Label();
            this.PanelSettings = new System.Windows.Forms.Panel();
            this.BoxSettings = new System.Windows.Forms.PictureBox();
            this.lbSettings = new System.Windows.Forms.Label();
            this.pbLogoBig = new System.Windows.Forms.PictureBox();
            this.btMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.PanelBot = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btQuit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbNom = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelFill = new System.Windows.Forms.Panel();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbPwd1 = new System.Windows.Forms.TextBox();
            this.tbPwd2 = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbPWD1 = new System.Windows.Forms.Label();
            this.lbPWD2 = new System.Windows.Forms.Label();
            this.btSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtModifyParam = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelGauche.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelHistorique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btQuit)).BeginInit();
            this.panelFill.SuspendLayout();
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
            this.panelGauche.Controls.Add(this.panel3);
            this.panelGauche.Controls.Add(this.panelManage);
            this.panelGauche.Controls.Add(this.panelFriends);
            this.panelGauche.Controls.Add(this.PanelHistorique);
            this.panelGauche.Controls.Add(this.PanelSettings);
            this.panelGauche.Controls.Add(this.pbLogoBig);
            this.panelGauche.Controls.Add(this.btMenu);
            this.panelGauche.Controls.Add(this.pbLogo);
            this.panelGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGauche.Location = new System.Drawing.Point(0, 39);
            this.panelGauche.Name = "panelGauche";
            this.panelGauche.Size = new System.Drawing.Size(275, 729);
            this.panelGauche.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 48);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::test1.Properties.Resources.Records;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseLeave += new System.EventHandler(this.test1mouseLeaveLB1);
            this.pictureBox4.MouseHover += new System.EventHandler(this.test1mouseHoverLB1);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 48);
            this.label4.TabIndex = 8;
            this.label4.Text = "Records";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseLeave += new System.EventHandler(this.test1mouseLeaveLB1);
            this.label4.MouseHover += new System.EventHandler(this.test1mouseHoverLB1);
            // 
            // panelManage
            // 
            this.panelManage.Controls.Add(this.pictureBox3);
            this.panelManage.Controls.Add(this.label3);
            this.panelManage.Location = new System.Drawing.Point(0, 299);
            this.panelManage.Name = "panelManage";
            this.panelManage.Size = new System.Drawing.Size(275, 48);
            this.panelManage.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::test1.Properties.Resources.Team;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseLeave += new System.EventHandler(this.test1mouseLeaveLB1);
            this.pictureBox3.MouseHover += new System.EventHandler(this.test1mouseHoverLB1);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Manage Team";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseLeave += new System.EventHandler(this.test1mouseLeaveLB1);
            this.label3.MouseHover += new System.EventHandler(this.test1mouseHoverLB1);
            // 
            // panelFriends
            // 
            this.panelFriends.Controls.Add(this.pictureBox1);
            this.panelFriends.Controls.Add(this.lbFriends);
            this.panelFriends.Location = new System.Drawing.Point(0, 245);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(275, 48);
            this.panelFriends.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test1.Properties.Resources.FriendsList;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.test1mouseLeaveLB1);
            this.pictureBox1.MouseHover += new System.EventHandler(this.test1mouseHoverLB1);
            // 
            // lbFriends
            // 
            this.lbFriends.ForeColor = System.Drawing.Color.White;
            this.lbFriends.Location = new System.Drawing.Point(46, 0);
            this.lbFriends.Name = "lbFriends";
            this.lbFriends.Size = new System.Drawing.Size(229, 48);
            this.lbFriends.TabIndex = 8;
            this.lbFriends.Text = "Friends List";
            this.lbFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFriends.MouseLeave += new System.EventHandler(this.test1mouseLeaveLB1);
            this.lbFriends.MouseHover += new System.EventHandler(this.test1mouseHoverLB1);
            // 
            // PanelHistorique
            // 
            this.PanelHistorique.Controls.Add(this.pictureBox2);
            this.PanelHistorique.Controls.Add(this.lbRecords);
            this.PanelHistorique.Location = new System.Drawing.Point(0, 191);
            this.PanelHistorique.Name = "PanelHistorique";
            this.PanelHistorique.Size = new System.Drawing.Size(275, 48);
            this.PanelHistorique.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::test1.Properties.Resources.Records;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.test1mouseLeaveLB1);
            this.pictureBox2.MouseHover += new System.EventHandler(this.test1mouseHoverLB1);
            // 
            // lbRecords
            // 
            this.lbRecords.ForeColor = System.Drawing.Color.White;
            this.lbRecords.Location = new System.Drawing.Point(46, 0);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(229, 48);
            this.lbRecords.TabIndex = 8;
            this.lbRecords.Text = "Records";
            this.lbRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRecords.MouseLeave += new System.EventHandler(this.test1mouseLeaveLB1);
            this.lbRecords.MouseHover += new System.EventHandler(this.test1mouseHoverLB1);
            // 
            // PanelSettings
            // 
            this.PanelSettings.Controls.Add(this.BoxSettings);
            this.PanelSettings.Controls.Add(this.lbSettings);
            this.PanelSettings.Location = new System.Drawing.Point(0, 137);
            this.PanelSettings.Name = "PanelSettings";
            this.PanelSettings.Size = new System.Drawing.Size(275, 48);
            this.PanelSettings.TabIndex = 9;
            this.PanelSettings.Click += new System.EventHandler(this.PanelClick);
            // 
            // BoxSettings
            // 
            this.BoxSettings.Image = global::test1.Properties.Resources.Settings;
            this.BoxSettings.Location = new System.Drawing.Point(0, 0);
            this.BoxSettings.Name = "BoxSettings";
            this.BoxSettings.Size = new System.Drawing.Size(48, 48);
            this.BoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoxSettings.TabIndex = 7;
            this.BoxSettings.TabStop = false;
            this.BoxSettings.MouseLeave += new System.EventHandler(this.test1mouseLeaveLB1);
            this.BoxSettings.MouseHover += new System.EventHandler(this.test1mouseHoverLB1);
            // 
            // lbSettings
            // 
            this.lbSettings.ForeColor = System.Drawing.Color.White;
            this.lbSettings.Location = new System.Drawing.Point(46, 0);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(229, 48);
            this.lbSettings.TabIndex = 8;
            this.lbSettings.Text = "Settings";
            this.lbSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSettings.MouseLeave += new System.EventHandler(this.test1mouseLeaveLB1);
            this.lbSettings.MouseHover += new System.EventHandler(this.test1mouseHoverLB1);
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
            // PanelBot
            // 
            this.PanelBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PanelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBot.Location = new System.Drawing.Point(0, 768);
            this.PanelBot.Name = "PanelBot";
            this.PanelBot.Size = new System.Drawing.Size(1264, 33);
            this.PanelBot.TabIndex = 1;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PanelTop.Controls.Add(this.btQuit);
            this.PanelTop.Controls.Add(this.lbNom);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1264, 39);
            this.PanelTop.TabIndex = 2;
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
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(29, 13);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(42, 18);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Test";
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.BtModifyParam);
            this.panelFill.Controls.Add(this.btSave);
            this.panelFill.Controls.Add(this.lbPWD2);
            this.panelFill.Controls.Add(this.lbPWD1);
            this.panelFill.Controls.Add(this.lbMail);
            this.panelFill.Controls.Add(this.lbFirstName);
            this.panelFill.Controls.Add(this.lbName);
            this.panelFill.Controls.Add(this.tbPwd2);
            this.panelFill.Controls.Add(this.tbPwd1);
            this.panelFill.Controls.Add(this.tbMail);
            this.panelFill.Controls.Add(this.tbFirstName);
            this.panelFill.Controls.Add(this.tbName);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 39);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1264, 729);
            this.panelFill.TabIndex = 3;
            // 
            // tm
            // 
            this.tm.Interval = 1;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(1061, 68);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(191, 20);
            this.tbName.TabIndex = 0;
            this.tbName.Visible = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.ForeColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(1061, 103);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(191, 20);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Visible = false;
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMail.ForeColor = System.Drawing.Color.White;
            this.tbMail.Location = new System.Drawing.Point(1061, 137);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(191, 20);
            this.tbMail.TabIndex = 0;
            this.tbMail.Visible = false;
            // 
            // tbPwd1
            // 
            this.tbPwd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tbPwd1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPwd1.ForeColor = System.Drawing.Color.White;
            this.tbPwd1.Location = new System.Drawing.Point(1061, 165);
            this.tbPwd1.Name = "tbPwd1";
            this.tbPwd1.Size = new System.Drawing.Size(191, 20);
            this.tbPwd1.TabIndex = 0;
            this.tbPwd1.Visible = false;
            // 
            // tbPwd2
            // 
            this.tbPwd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tbPwd2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPwd2.ForeColor = System.Drawing.Color.White;
            this.tbPwd2.Location = new System.Drawing.Point(1061, 191);
            this.tbPwd2.Name = "tbPwd2";
            this.tbPwd2.Size = new System.Drawing.Size(191, 20);
            this.tbPwd2.TabIndex = 0;
            this.tbPwd2.Visible = false;
            this.tbPwd2.TextChanged += new System.EventHandler(this.tbPwd2_TextChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(944, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(62, 18);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            this.lbName.Visible = false;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(944, 105);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(98, 18);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "FirstName:";
            this.lbFirstName.Visible = false;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.ForeColor = System.Drawing.Color.White;
            this.lbMail.Location = new System.Drawing.Point(944, 139);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(65, 18);
            this.lbMail.TabIndex = 1;
            this.lbMail.Text = "E-Mail:";
            this.lbMail.Visible = false;
            // 
            // lbPWD1
            // 
            this.lbPWD1.AutoSize = true;
            this.lbPWD1.ForeColor = System.Drawing.Color.White;
            this.lbPWD1.Location = new System.Drawing.Point(944, 167);
            this.lbPWD1.Name = "lbPWD1";
            this.lbPWD1.Size = new System.Drawing.Size(92, 18);
            this.lbPWD1.TabIndex = 1;
            this.lbPWD1.Text = "Password:";
            this.lbPWD1.Visible = false;
            // 
            // lbPWD2
            // 
            this.lbPWD2.AutoSize = true;
            this.lbPWD2.ForeColor = System.Drawing.Color.White;
            this.lbPWD2.Location = new System.Drawing.Point(944, 193);
            this.lbPWD2.Name = "lbPWD2";
            this.lbPWD2.Size = new System.Drawing.Size(108, 18);
            this.lbPWD2.TabIndex = 1;
            this.lbPWD2.Text = "Vérification:";
            this.lbPWD2.Visible = false;
            // 
            // btSave
            // 
            this.btSave.ActiveBorderThickness = 1;
            this.btSave.ActiveCornerRadius = 20;
            this.btSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSave.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.btSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.btSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSave.BackgroundImage")));
            this.btSave.ButtonText = "Save";
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSave.IdleBorderThickness = 1;
            this.btSave.IdleCornerRadius = 20;
            this.btSave.IdleFillColor = System.Drawing.Color.White;
            this.btSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSave.Location = new System.Drawing.Point(1061, 245);
            this.btSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(191, 35);
            this.btSave.TabIndex = 2;
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSave.Visible = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // BtModifyParam
            // 
            this.BtModifyParam.ActiveBorderThickness = 1;
            this.BtModifyParam.ActiveCornerRadius = 20;
            this.BtModifyParam.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtModifyParam.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.BtModifyParam.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtModifyParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.BtModifyParam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtModifyParam.BackgroundImage")));
            this.BtModifyParam.ButtonText = "Modify Informations";
            this.BtModifyParam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtModifyParam.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtModifyParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtModifyParam.IdleBorderThickness = 1;
            this.BtModifyParam.IdleCornerRadius = 20;
            this.BtModifyParam.IdleFillColor = System.Drawing.Color.White;
            this.BtModifyParam.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtModifyParam.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtModifyParam.Location = new System.Drawing.Point(1061, 11);
            this.BtModifyParam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtModifyParam.Name = "BtModifyParam";
            this.BtModifyParam.Size = new System.Drawing.Size(191, 35);
            this.BtModifyParam.TabIndex = 2;
            this.BtModifyParam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtModifyParam.Click += new System.EventHandler(this.BtModifyParam_Click);
            // 
            // Form_Page_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1264, 801);
            this.Controls.Add(this.panelGauche);
            this.Controls.Add(this.panelFill);
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelHistorique.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btQuit)).EndInit();
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Panel panelGauche;
        private Bunifu.Framework.UI.BunifuImageButton btMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel PanelBot;
        private System.Windows.Forms.Panel PanelTop;
        private Bunifu.Framework.UI.BunifuImageButton btQuit;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNom;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.PictureBox pbLogoBig;
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.PictureBox BoxSettings;
        private System.Windows.Forms.Panel PanelSettings;
        private System.Windows.Forms.Panel PanelHistorique;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelManage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelFriends;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbFriends;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPwd2;
        private System.Windows.Forms.TextBox tbPwd1;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbPWD2;
        private System.Windows.Forms.Label lbPWD1;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbName;
        private Bunifu.Framework.UI.BunifuThinButton2 btSave;
        private Bunifu.Framework.UI.BunifuThinButton2 BtModifyParam;
    }
}