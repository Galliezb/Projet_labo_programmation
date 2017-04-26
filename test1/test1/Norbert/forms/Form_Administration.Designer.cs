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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Add User to DB");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Update Informations");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Change Your Informations");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Show Informations");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Promote an User");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Add an Administrator");
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.lbNameUser = new System.Windows.Forms.Label();
            this.tbNameUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSelectType = new System.Windows.Forms.Label();
            this.cbbSelectType = new System.Windows.Forms.ComboBox();
            this.lbPwd = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.lbRecDate = new System.Windows.Forms.Label();
            this.tbRecDate = new System.Windows.Forms.TextBox();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.tbBirthDay = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lbDesc = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.panelAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.btSubmit);
            this.panelAddUser.Controls.Add(this.rtbDesc);
            this.panelAddUser.Controls.Add(this.lbDesc);
            this.panelAddUser.Controls.Add(this.tbBirthDay);
            this.panelAddUser.Controls.Add(this.lbBirthday);
            this.panelAddUser.Controls.Add(this.tbRecDate);
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
            this.panelAddUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAddUser.Location = new System.Drawing.Point(255, 0);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(750, 768);
            this.panelAddUser.TabIndex = 2;
            // 
            // lbNameUser
            // 
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Location = new System.Drawing.Point(92, 130);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(61, 20);
            this.lbNameUser.TabIndex = 0;
            this.lbNameUser.Text = "Name :";
            // 
            // tbNameUser
            // 
            this.tbNameUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbNameUser.Location = new System.Drawing.Point(389, 130);
            this.tbNameUser.Name = "tbNameUser";
            this.tbNameUser.Size = new System.Drawing.Size(232, 27);
            this.tbNameUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the required informations : ";
            // 
            // lbSelectType
            // 
            this.lbSelectType.AutoSize = true;
            this.lbSelectType.Location = new System.Drawing.Point(92, 80);
            this.lbSelectType.Name = "lbSelectType";
            this.lbSelectType.Size = new System.Drawing.Size(243, 20);
            this.lbSelectType.TabIndex = 3;
            this.lbSelectType.Text = "Select the type of the new user : ";
            // 
            // cbbSelectType
            // 
            this.cbbSelectType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.cbbSelectType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSelectType.FormattingEnabled = true;
            this.cbbSelectType.Location = new System.Drawing.Point(389, 77);
            this.cbbSelectType.Name = "cbbSelectType";
            this.cbbSelectType.Size = new System.Drawing.Size(232, 28);
            this.cbbSelectType.TabIndex = 4;
            this.cbbSelectType.SelectedIndexChanged += new System.EventHandler(this.cbbSelectType_SelectedIndexChanged);
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.Location = new System.Drawing.Point(92, 180);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(86, 20);
            this.lbPwd.TabIndex = 5;
            this.lbPwd.Text = "Password :";
            // 
            // tbPwd
            // 
            this.tbPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPwd.Location = new System.Drawing.Point(389, 180);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(232, 27);
            this.tbPwd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Confirm :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.textBox1.Location = new System.Drawing.Point(389, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 27);
            this.textBox1.TabIndex = 8;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(92, 280);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(33, 20);
            this.lbId.TabIndex = 9;
            this.lbId.Text = "Id :";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbId.Location = new System.Drawing.Point(389, 280);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(232, 27);
            this.tbId.TabIndex = 10;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(92, 330);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(51, 20);
            this.lbMail.TabIndex = 11;
            this.lbMail.Text = "Mail :";
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbMail.Location = new System.Drawing.Point(389, 330);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(232, 27);
            this.tbMail.TabIndex = 12;
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Location = new System.Drawing.Point(92, 380);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(74, 20);
            this.lbPseudo.TabIndex = 13;
            this.lbPseudo.Text = "Pseudo : ";
            // 
            // tbPseudo
            // 
            this.tbPseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPseudo.Location = new System.Drawing.Point(389, 380);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(232, 27);
            this.tbPseudo.TabIndex = 14;
            // 
            // lbRecDate
            // 
            this.lbRecDate.AutoSize = true;
            this.lbRecDate.Location = new System.Drawing.Point(92, 430);
            this.lbRecDate.Name = "lbRecDate";
            this.lbRecDate.Size = new System.Drawing.Size(107, 20);
            this.lbRecDate.TabIndex = 15;
            this.lbRecDate.Text = "Record Date :";
            // 
            // tbRecDate
            // 
            this.tbRecDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbRecDate.Location = new System.Drawing.Point(389, 430);
            this.tbRecDate.Name = "tbRecDate";
            this.tbRecDate.Size = new System.Drawing.Size(232, 27);
            this.tbRecDate.TabIndex = 16;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(92, 480);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(91, 20);
            this.lbBirthday.TabIndex = 17;
            this.lbBirthday.Text = "BirthDay : ";
            // 
            // tbBirthDay
            // 
            this.tbBirthDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbBirthDay.Location = new System.Drawing.Point(389, 480);
            this.tbBirthDay.Name = "tbBirthDay";
            this.tbBirthDay.Size = new System.Drawing.Size(232, 27);
            this.tbBirthDay.TabIndex = 18;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "AddUser";
            treeNode7.Text = "Add User to DB";
            treeNode8.Name = "UpdateInfo";
            treeNode8.Text = "Update Informations";
            treeNode9.Name = "ChangeSelfInfo";
            treeNode9.Text = "Change Your Informations";
            treeNode10.Name = "ShowInfo";
            treeNode10.Text = "Show Informations";
            treeNode11.Name = "PromUser";
            treeNode11.Text = "Promote an User";
            treeNode12.Name = "AddAdmin";
            treeNode12.Text = "Add an Administrator";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(249, 375);
            this.treeView1.TabIndex = 3;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(92, 530);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(101, 20);
            this.lbDesc.TabIndex = 19;
            this.lbDesc.Text = "Description :";
            // 
            // rtbDesc
            // 
            this.rtbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.rtbDesc.Location = new System.Drawing.Point(389, 530);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(232, 96);
            this.rtbDesc.TabIndex = 20;
            this.rtbDesc.Text = "";
            // 
            // btSubmit
            // 
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Location = new System.Drawing.Point(318, 680);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(99, 32);
            this.btSubmit.TabIndex = 21;
            this.btSubmit.Text = "SUBMIT";
            this.btSubmit.UseVisualStyleBackColor = true;
            // 
            // Form_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1005, 768);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panelAddUser);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Administration";
            this.Text = "Form_Administration";
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label lbPwd;
        private System.Windows.Forms.ComboBox cbbSelectType;
        private System.Windows.Forms.Label lbSelectType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameUser;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.TextBox tbBirthDay;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.TextBox tbRecDate;
        private System.Windows.Forms.Label lbRecDate;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lbDesc;
    }
}