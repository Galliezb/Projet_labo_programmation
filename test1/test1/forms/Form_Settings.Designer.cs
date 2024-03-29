﻿namespace test1
{
    partial class Form_Settings
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Language");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("User Parameters");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelUserParam = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.lbPWD2 = new System.Windows.Forms.Label();
            this.lbPWD1 = new System.Windows.Forms.Label();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbPwd2 = new System.Windows.Forms.TextBox();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.tbPwd1 = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.panelUserParam.SuspendLayout();
            this.panelLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Language";
            treeNode1.Text = "Language";
            treeNode2.Name = "UserParam";
            treeNode2.Text = "User Parameters";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(206, 703);
            this.treeView1.TabIndex = 15;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelUserParam
            // 
            this.panelUserParam.Controls.Add(this.btSave);
            this.panelUserParam.Controls.Add(this.lbPWD2);
            this.panelUserParam.Controls.Add(this.lbPWD1);
            this.panelUserParam.Controls.Add(this.lbPseudo);
            this.panelUserParam.Controls.Add(this.lbMail);
            this.panelUserParam.Controls.Add(this.lbFirstName);
            this.panelUserParam.Controls.Add(this.lbName);
            this.panelUserParam.Controls.Add(this.tbPwd2);
            this.panelUserParam.Controls.Add(this.tbPseudo);
            this.panelUserParam.Controls.Add(this.tbPwd1);
            this.panelUserParam.Controls.Add(this.tbMail);
            this.panelUserParam.Controls.Add(this.tbFirstName);
            this.panelUserParam.Controls.Add(this.tbName);
            this.panelUserParam.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUserParam.Location = new System.Drawing.Point(206, 3);
            this.panelUserParam.Name = "panelUserParam";
            this.panelUserParam.Size = new System.Drawing.Size(783, 726);
            this.panelUserParam.TabIndex = 16;
            this.panelUserParam.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUserParam_Paint);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(48, 308);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(169, 48);
            this.btSave.TabIndex = 27;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbPWD2
            // 
            this.lbPWD2.AutoSize = true;
            this.lbPWD2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPWD2.ForeColor = System.Drawing.Color.White;
            this.lbPWD2.Location = new System.Drawing.Point(2, 216);
            this.lbPWD2.Name = "lbPWD2";
            this.lbPWD2.Size = new System.Drawing.Size(100, 20);
            this.lbPWD2.TabIndex = 21;
            this.lbPWD2.Text = "Vérification:";
            // 
            // lbPWD1
            // 
            this.lbPWD1.AutoSize = true;
            this.lbPWD1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPWD1.ForeColor = System.Drawing.Color.White;
            this.lbPWD1.Location = new System.Drawing.Point(2, 190);
            this.lbPWD1.Name = "lbPWD1";
            this.lbPWD1.Size = new System.Drawing.Size(82, 20);
            this.lbPWD1.TabIndex = 22;
            this.lbPWD1.Text = "Password:";
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudo.ForeColor = System.Drawing.Color.White;
            this.lbPseudo.Location = new System.Drawing.Point(3, 46);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(66, 20);
            this.lbPseudo.TabIndex = 23;
            this.lbPseudo.Text = "Pseudo:";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.ForeColor = System.Drawing.Color.White;
            this.lbMail.Location = new System.Drawing.Point(2, 149);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(64, 20);
            this.lbMail.TabIndex = 24;
            this.lbMail.Text = "E-Mail:";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(3, 113);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(93, 20);
            this.lbFirstName.TabIndex = 25;
            this.lbFirstName.Text = "FirstName:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(2, 80);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(57, 20);
            this.lbName.TabIndex = 26;
            this.lbName.Text = "Name:";
            // 
            // tbPwd2
            // 
            this.tbPwd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPwd2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPwd2.ForeColor = System.Drawing.Color.White;
            this.tbPwd2.Location = new System.Drawing.Point(114, 214);
            this.tbPwd2.Name = "tbPwd2";
            this.tbPwd2.Size = new System.Drawing.Size(118, 27);
            this.tbPwd2.TabIndex = 15;
            // 
            // tbPseudo
            // 
            this.tbPseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPseudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPseudo.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPseudo.ForeColor = System.Drawing.Color.White;
            this.tbPseudo.Location = new System.Drawing.Point(115, 44);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(118, 27);
            this.tbPseudo.TabIndex = 16;
            // 
            // tbPwd1
            // 
            this.tbPwd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPwd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPwd1.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.tbPwd1.ForeColor = System.Drawing.Color.White;
            this.tbPwd1.Location = new System.Drawing.Point(114, 188);
            this.tbPwd1.Name = "tbPwd1";
            this.tbPwd1.Size = new System.Drawing.Size(118, 27);
            this.tbPwd1.TabIndex = 17;
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMail.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.tbMail.ForeColor = System.Drawing.Color.White;
            this.tbMail.Location = new System.Drawing.Point(114, 147);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(118, 27);
            this.tbMail.TabIndex = 18;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirstName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(114, 113);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(118, 27);
            this.tbFirstName.TabIndex = 19;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(114, 78);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(118, 27);
            this.tbName.TabIndex = 20;
            // 
            // panelLanguage
            // 
            this.panelLanguage.Controls.Add(this.cbLanguage);
            this.panelLanguage.Location = new System.Drawing.Point(206, 0);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(783, 729);
            this.panelLanguage.TabIndex = 17;
            this.panelLanguage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLanguage_Paint);
            // 
            // cbLanguage
            // 
            this.cbLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLanguage.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguage.ForeColor = System.Drawing.Color.White;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "Français",
            "English"});
            this.cbLanguage.Location = new System.Drawing.Point(48, 47);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(194, 28);
            this.cbLanguage.TabIndex = 0;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(989, 703);
            this.Controls.Add(this.panelUserParam);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panelLanguage);
            this.Name = "Form_Settings";
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.panelUserParam.ResumeLayout(false);
            this.panelUserParam.PerformLayout();
            this.panelLanguage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panelUserParam;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbPWD2;
        private System.Windows.Forms.Label lbPWD1;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbPwd2;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.TextBox tbPwd1;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.ComboBox cbLanguage;
    }
}