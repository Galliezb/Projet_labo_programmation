﻿namespace test1 {
    partial class Form_Administration {
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
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Add User to DB");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Update Informations");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Change Your Informations");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Show Informations");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Promote an User");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Add an Administrator");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.panelUpdateInfo = new System.Windows.Forms.Panel();
            this.cbbItems = new System.Windows.Forms.ComboBox();
            this.lbChooseItem = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.lbPwd = new System.Windows.Forms.Label();
            this.cbbSelectType = new System.Windows.Forms.ComboBox();
            this.lbSelectType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameUser = new System.Windows.Forms.TextBox();
            this.lbNameUser = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.panelChangeInfo = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelAddUser.SuspendLayout();
            this.panelUpdateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode31.Name = "AddUser";
            treeNode31.Text = "Add User to DB";
            treeNode32.Name = "UpdateInfo";
            treeNode32.Text = "Update Informations";
            treeNode33.Name = "ChangeSelfInfo";
            treeNode33.Text = "Change Your Informations";
            treeNode34.Name = "ShowInfo";
            treeNode34.Text = "Show Informations";
            treeNode35.Name = "PromUser";
            treeNode35.Text = "Promote an User";
            treeNode36.Name = "AddAdmin";
            treeNode36.Text = "Add an Administrator";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36});
            this.treeView1.Size = new System.Drawing.Size(258, 768);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.comboBox1);
            this.panelAddUser.Controls.Add(this.tbFirstName);
            this.panelAddUser.Controls.Add(this.rtbDesc);
            this.panelAddUser.Controls.Add(this.lbDesc);
            this.panelAddUser.Controls.Add(this.lbLanguage);
            this.panelAddUser.Controls.Add(this.lbFirstName);
            this.panelAddUser.Controls.Add(this.tbPseudo);
            this.panelAddUser.Controls.Add(this.lbPseudo);
            this.panelAddUser.Controls.Add(this.tbMail);
            this.panelAddUser.Controls.Add(this.lbMail);
            this.panelAddUser.Controls.Add(this.textBox1);
            this.panelAddUser.Controls.Add(this.label1);
            this.panelAddUser.Controls.Add(this.tbPwd);
            this.panelAddUser.Controls.Add(this.lbPwd);
            this.panelAddUser.Controls.Add(this.cbbSelectType);
            this.panelAddUser.Controls.Add(this.lbSelectType);
            this.panelAddUser.Controls.Add(this.label2);
            this.panelAddUser.Controls.Add(this.tbNameUser);
            this.panelAddUser.Controls.Add(this.lbNameUser);
            this.panelAddUser.Controls.Add(this.btSubmit);
            this.panelAddUser.Location = new System.Drawing.Point(255, 0);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(751, 795);
            this.panelAddUser.TabIndex = 4;
            this.panelAddUser.Visible = false;
            // 
            // panelUpdateInfo
            // 
            this.panelUpdateInfo.Controls.Add(this.cbbItems);
            this.panelUpdateInfo.Controls.Add(this.lbChooseItem);
            this.panelUpdateInfo.Location = new System.Drawing.Point(258, 0);
            this.panelUpdateInfo.Name = "panelUpdateInfo";
            this.panelUpdateInfo.Size = new System.Drawing.Size(748, 795);
            this.panelUpdateInfo.TabIndex = 44;
            this.panelUpdateInfo.Visible = false;
            // 
            // cbbItems
            // 
            this.cbbItems.FormattingEnabled = true;
            this.cbbItems.Items.AddRange(new object[] {
            "Player",
            "Organiser",
            "Administrator",
            "Tournament",
            "Organisation"});
            this.cbbItems.Location = new System.Drawing.Point(383, 36);
            this.cbbItems.Name = "cbbItems";
            this.cbbItems.Size = new System.Drawing.Size(232, 28);
            this.cbbItems.TabIndex = 1;
            // 
            // lbChooseItem
            // 
            this.lbChooseItem.AutoSize = true;
            this.lbChooseItem.Location = new System.Drawing.Point(48, 39);
            this.lbChooseItem.Name = "lbChooseItem";
            this.lbChooseItem.Size = new System.Drawing.Size(134, 20);
            this.lbChooseItem.TabIndex = 0;
            this.lbChooseItem.Text = "Choose the type :";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbFirstName.ForeColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(383, 180);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(232, 27);
            this.tbFirstName.TabIndex = 38;
            // 
            // rtbDesc
            // 
            this.rtbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.rtbDesc.ForeColor = System.Drawing.Color.White;
            this.rtbDesc.Location = new System.Drawing.Point(383, 502);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(232, 96);
            this.rtbDesc.TabIndex = 42;
            this.rtbDesc.Text = "";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(86, 505);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(101, 20);
            this.lbDesc.TabIndex = 41;
            this.lbDesc.Text = "Description :";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(89, 427);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(96, 20);
            this.lbLanguage.TabIndex = 39;
            this.lbLanguage.Text = "Language : ";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(86, 183);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(94, 20);
            this.lbFirstName.TabIndex = 37;
            this.lbFirstName.Text = "Firstname :";
            // 
            // tbPseudo
            // 
            this.tbPseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPseudo.ForeColor = System.Drawing.Color.White;
            this.tbPseudo.Location = new System.Drawing.Point(383, 326);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(232, 27);
            this.tbPseudo.TabIndex = 36;
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Location = new System.Drawing.Point(86, 329);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(74, 20);
            this.lbPseudo.TabIndex = 35;
            this.lbPseudo.Text = "Pseudo : ";
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbMail.ForeColor = System.Drawing.Color.White;
            this.tbMail.Location = new System.Drawing.Point(383, 375);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(232, 27);
            this.tbMail.TabIndex = 34;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(89, 378);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(51, 20);
            this.lbMail.TabIndex = 33;
            this.lbMail.Text = "Mail :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(383, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 27);
            this.textBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Confirm :";
            // 
            // tbPwd
            // 
            this.tbPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPwd.ForeColor = System.Drawing.Color.White;
            this.tbPwd.Location = new System.Drawing.Point(383, 226);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(232, 27);
            this.tbPwd.TabIndex = 28;
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.Location = new System.Drawing.Point(86, 235);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(86, 20);
            this.lbPwd.TabIndex = 27;
            this.lbPwd.Text = "Password :";
            // 
            // cbbSelectType
            // 
            this.cbbSelectType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.cbbSelectType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSelectType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSelectType.ForeColor = System.Drawing.Color.White;
            this.cbbSelectType.FormattingEnabled = true;
            this.cbbSelectType.Items.AddRange(new object[] {
            "Administrator",
            "Organizer",
            "User"});
            this.cbbSelectType.Location = new System.Drawing.Point(383, 82);
            this.cbbSelectType.Name = "cbbSelectType";
            this.cbbSelectType.Size = new System.Drawing.Size(232, 28);
            this.cbbSelectType.TabIndex = 26;
            // 
            // lbSelectType
            // 
            this.lbSelectType.AutoSize = true;
            this.lbSelectType.Location = new System.Drawing.Point(86, 85);
            this.lbSelectType.Name = "lbSelectType";
            this.lbSelectType.Size = new System.Drawing.Size(243, 20);
            this.lbSelectType.TabIndex = 25;
            this.lbSelectType.Text = "Select the type of the new user : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Enter the required informations : ";
            // 
            // tbNameUser
            // 
            this.tbNameUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbNameUser.ForeColor = System.Drawing.Color.White;
            this.tbNameUser.Location = new System.Drawing.Point(383, 135);
            this.tbNameUser.Name = "tbNameUser";
            this.tbNameUser.Size = new System.Drawing.Size(232, 27);
            this.tbNameUser.TabIndex = 23;
            // 
            // lbNameUser
            // 
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Location = new System.Drawing.Point(86, 138);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(61, 20);
            this.lbNameUser.TabIndex = 22;
            this.lbNameUser.Text = "Name :";
            // 
            // btSubmit
            // 
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Location = new System.Drawing.Point(312, 685);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(99, 32);
            this.btSubmit.TabIndex = 43;
            this.btSubmit.Text = "SUBMIT";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // panelChangeInfo
            // 
            this.panelChangeInfo.Location = new System.Drawing.Point(258, 0);
            this.panelChangeInfo.Name = "panelChangeInfo";
            this.panelChangeInfo.Size = new System.Drawing.Size(748, 780);
            this.panelChangeInfo.TabIndex = 45;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Français",
            "English"});
            this.comboBox1.Location = new System.Drawing.Point(383, 424);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 28);
            this.comboBox1.TabIndex = 44;
            // 
            // Form_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1005, 768);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panelAddUser);
            this.Controls.Add(this.panelChangeInfo);
            this.Controls.Add(this.panelUpdateInfo);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Administration";
            this.Text = "Form_Administration";
            this.Load += new System.EventHandler(this.Form_Administration_Load);
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.panelUpdateInfo.ResumeLayout(false);
            this.panelUpdateInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label lbPwd;
        private System.Windows.Forms.ComboBox cbbSelectType;
        private System.Windows.Forms.Label lbSelectType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameUser;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Panel panelUpdateInfo;
        private System.Windows.Forms.ComboBox cbbItems;
        private System.Windows.Forms.Label lbChooseItem;
        private System.Windows.Forms.Panel panelChangeInfo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}