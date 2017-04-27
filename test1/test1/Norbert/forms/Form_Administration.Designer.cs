namespace test1.Norbert.forms
{
    partial class Form_Administration
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Add User to DB");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Update Informations");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Change Your Informations");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Show Informations");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Promote an User");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Add an Administrator");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.tbRecDate = new System.Windows.Forms.TextBox();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.tbBirthDay = new System.Windows.Forms.TextBox();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbRecDate = new System.Windows.Forms.Label();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
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
            this.panelUpdateInfo = new System.Windows.Forms.Panel();
            this.lbChooseItem = new System.Windows.Forms.Label();
            this.cbbItems = new System.Windows.Forms.ComboBox();
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
            treeNode1.Name = "AddUser";
            treeNode1.Text = "Add User to DB";
            treeNode2.Name = "UpdateInfo";
            treeNode2.Text = "Update Informations";
            treeNode3.Name = "ChangeSelfInfo";
            treeNode3.Text = "Change Your Informations";
            treeNode4.Name = "ShowInfo";
            treeNode4.Text = "Show Informations";
            treeNode5.Name = "PromUser";
            treeNode5.Text = "Promote an User";
            treeNode6.Name = "AddAdmin";
            treeNode6.Text = "Add an Administrator";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(258, 768);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.panelUpdateInfo);
            this.panelAddUser.Controls.Add(this.tbRecDate);
            this.panelAddUser.Controls.Add(this.rtbDesc);
            this.panelAddUser.Controls.Add(this.lbDesc);
            this.panelAddUser.Controls.Add(this.tbBirthDay);
            this.panelAddUser.Controls.Add(this.lbBirthday);
            this.panelAddUser.Controls.Add(this.lbRecDate);
            this.panelAddUser.Controls.Add(this.tbPseudo);
            this.panelAddUser.Controls.Add(this.lbPseudo);
            this.panelAddUser.Controls.Add(this.tbMail);
            this.panelAddUser.Controls.Add(this.lbMail);
            this.panelAddUser.Controls.Add(this.tbId);
            this.panelAddUser.Controls.Add(this.lbId);
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
            this.panelAddUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAddUser.Location = new System.Drawing.Point(264, 0);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(741, 768);
            this.panelAddUser.TabIndex = 4;
            this.panelAddUser.Visible = false;
            // 
            // tbRecDate
            // 
            this.tbRecDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbRecDate.Location = new System.Drawing.Point(383, 435);
            this.tbRecDate.Name = "tbRecDate";
            this.tbRecDate.Size = new System.Drawing.Size(232, 27);
            this.tbRecDate.TabIndex = 38;
            // 
            // rtbDesc
            // 
            this.rtbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.rtbDesc.Location = new System.Drawing.Point(383, 535);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(232, 96);
            this.rtbDesc.TabIndex = 42;
            this.rtbDesc.Text = "";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(86, 535);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(101, 20);
            this.lbDesc.TabIndex = 41;
            this.lbDesc.Text = "Description :";
            // 
            // tbBirthDay
            // 
            this.tbBirthDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbBirthDay.Location = new System.Drawing.Point(383, 485);
            this.tbBirthDay.Name = "tbBirthDay";
            this.tbBirthDay.Size = new System.Drawing.Size(232, 27);
            this.tbBirthDay.TabIndex = 40;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(86, 485);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(91, 20);
            this.lbBirthday.TabIndex = 39;
            this.lbBirthday.Text = "BirthDay : ";
            // 
            // lbRecDate
            // 
            this.lbRecDate.AutoSize = true;
            this.lbRecDate.Location = new System.Drawing.Point(86, 435);
            this.lbRecDate.Name = "lbRecDate";
            this.lbRecDate.Size = new System.Drawing.Size(107, 20);
            this.lbRecDate.TabIndex = 37;
            this.lbRecDate.Text = "Record Date :";
            // 
            // tbPseudo
            // 
            this.tbPseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPseudo.Location = new System.Drawing.Point(383, 385);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(232, 27);
            this.tbPseudo.TabIndex = 36;
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Location = new System.Drawing.Point(86, 385);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(74, 20);
            this.lbPseudo.TabIndex = 35;
            this.lbPseudo.Text = "Pseudo : ";
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbMail.Location = new System.Drawing.Point(383, 335);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(232, 27);
            this.tbMail.TabIndex = 34;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(86, 335);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(51, 20);
            this.lbMail.TabIndex = 33;
            this.lbMail.Text = "Mail :";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbId.Location = new System.Drawing.Point(383, 285);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(232, 27);
            this.tbId.TabIndex = 32;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(86, 285);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(33, 20);
            this.lbId.TabIndex = 31;
            this.lbId.Text = "Id :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.textBox1.Location = new System.Drawing.Point(383, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 27);
            this.textBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Confirm :";
            // 
            // tbPwd
            // 
            this.tbPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPwd.Location = new System.Drawing.Point(383, 185);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(232, 27);
            this.tbPwd.TabIndex = 28;
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.Location = new System.Drawing.Point(86, 185);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(86, 20);
            this.lbPwd.TabIndex = 27;
            this.lbPwd.Text = "Password :";
            // 
            // cbbSelectType
            // 
            this.cbbSelectType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.cbbSelectType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSelectType.FormattingEnabled = true;
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
            this.tbNameUser.Location = new System.Drawing.Point(383, 135);
            this.tbNameUser.Name = "tbNameUser";
            this.tbNameUser.Size = new System.Drawing.Size(232, 27);
            this.tbNameUser.TabIndex = 23;
            // 
            // lbNameUser
            // 
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Location = new System.Drawing.Point(86, 135);
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
            // 
            // panelUpdateInfo
            // 
            this.panelUpdateInfo.Controls.Add(this.cbbItems);
            this.panelUpdateInfo.Controls.Add(this.lbChooseItem);
            this.panelUpdateInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUpdateInfo.Location = new System.Drawing.Point(0, 0);
            this.panelUpdateInfo.Name = "panelUpdateInfo";
            this.panelUpdateInfo.Size = new System.Drawing.Size(741, 768);
            this.panelUpdateInfo.TabIndex = 44;
            this.panelUpdateInfo.Visible = false;
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
            // Form_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1005, 768);
            this.Controls.Add(this.panelAddUser);
            this.Controls.Add(this.treeView1);
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
        private System.Windows.Forms.TextBox tbRecDate;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.TextBox tbBirthDay;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbRecDate;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
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
        private System.Windows.Forms.Label lbChooseItem;
        private System.Windows.Forms.ComboBox cbbItems;
    }
}