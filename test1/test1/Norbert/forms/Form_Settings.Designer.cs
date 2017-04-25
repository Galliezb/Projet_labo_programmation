namespace test1.Norbert.forms
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
            this.panelSettings = new System.Windows.Forms.Panel();
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
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Language";
            treeNode1.Text = "Language";
            treeNode2.Name = "UserParam";
            treeNode2.Text = "User Parameters";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(98, 401);
            this.treeView1.TabIndex = 15;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.btSave);
            this.panelSettings.Controls.Add(this.lbPWD2);
            this.panelSettings.Controls.Add(this.lbPWD1);
            this.panelSettings.Controls.Add(this.lbPseudo);
            this.panelSettings.Controls.Add(this.lbMail);
            this.panelSettings.Controls.Add(this.lbFirstName);
            this.panelSettings.Controls.Add(this.lbName);
            this.panelSettings.Controls.Add(this.tbPwd2);
            this.panelSettings.Controls.Add(this.tbPseudo);
            this.panelSettings.Controls.Add(this.tbPwd1);
            this.panelSettings.Controls.Add(this.tbMail);
            this.panelSettings.Controls.Add(this.tbFirstName);
            this.panelSettings.Controls.Add(this.tbName);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSettings.Location = new System.Drawing.Point(98, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(236, 401);
            this.panelSettings.TabIndex = 16;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(48, 308);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(169, 48);
            this.btSave.TabIndex = 27;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // lbPWD2
            // 
            this.lbPWD2.AutoSize = true;
            this.lbPWD2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPWD2.ForeColor = System.Drawing.Color.Black;
            this.lbPWD2.Location = new System.Drawing.Point(2, 216);
            this.lbPWD2.Name = "lbPWD2";
            this.lbPWD2.Size = new System.Drawing.Size(108, 18);
            this.lbPWD2.TabIndex = 21;
            this.lbPWD2.Text = "Vérification:";
            this.lbPWD2.Visible = false;
            // 
            // lbPWD1
            // 
            this.lbPWD1.AutoSize = true;
            this.lbPWD1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPWD1.ForeColor = System.Drawing.Color.Black;
            this.lbPWD1.Location = new System.Drawing.Point(2, 190);
            this.lbPWD1.Name = "lbPWD1";
            this.lbPWD1.Size = new System.Drawing.Size(92, 18);
            this.lbPWD1.TabIndex = 22;
            this.lbPWD1.Text = "Password:";
            this.lbPWD1.Visible = false;
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudo.ForeColor = System.Drawing.Color.Black;
            this.lbPseudo.Location = new System.Drawing.Point(3, 46);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(74, 18);
            this.lbPseudo.TabIndex = 23;
            this.lbPseudo.Text = "Pseudo:";
            this.lbPseudo.Visible = false;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.ForeColor = System.Drawing.Color.Black;
            this.lbMail.Location = new System.Drawing.Point(2, 149);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(65, 18);
            this.lbMail.TabIndex = 24;
            this.lbMail.Text = "E-Mail:";
            this.lbMail.Visible = false;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.ForeColor = System.Drawing.Color.Black;
            this.lbFirstName.Location = new System.Drawing.Point(3, 113);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(98, 18);
            this.lbFirstName.TabIndex = 25;
            this.lbFirstName.Text = "FirstName:";
            this.lbFirstName.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(2, 80);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(62, 18);
            this.lbName.TabIndex = 26;
            this.lbName.Text = "Name:";
            this.lbName.Visible = false;
            // 
            // tbPwd2
            // 
            this.tbPwd2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbPwd2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPwd2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPwd2.ForeColor = System.Drawing.Color.Black;
            this.tbPwd2.Location = new System.Drawing.Point(114, 214);
            this.tbPwd2.Name = "tbPwd2";
            this.tbPwd2.Size = new System.Drawing.Size(118, 20);
            this.tbPwd2.TabIndex = 15;
            this.tbPwd2.Visible = false;
            // 
            // tbPseudo
            // 
            this.tbPseudo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbPseudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPseudo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPseudo.ForeColor = System.Drawing.Color.Black;
            this.tbPseudo.Location = new System.Drawing.Point(115, 44);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(118, 20);
            this.tbPseudo.TabIndex = 16;
            this.tbPseudo.Visible = false;
            // 
            // tbPwd1
            // 
            this.tbPwd1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbPwd1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPwd1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPwd1.ForeColor = System.Drawing.Color.Black;
            this.tbPwd1.Location = new System.Drawing.Point(114, 188);
            this.tbPwd1.Name = "tbPwd1";
            this.tbPwd1.Size = new System.Drawing.Size(118, 20);
            this.tbPwd1.TabIndex = 17;
            this.tbPwd1.Visible = false;
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.ForeColor = System.Drawing.Color.Black;
            this.tbMail.Location = new System.Drawing.Point(114, 147);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(118, 20);
            this.tbMail.TabIndex = 18;
            this.tbMail.Visible = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.Location = new System.Drawing.Point(114, 113);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(118, 20);
            this.tbFirstName.TabIndex = 19;
            this.tbFirstName.Visible = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(114, 78);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(118, 20);
            this.tbName.TabIndex = 20;
            this.tbName.Visible = false;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 401);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.treeView1);
            this.Name = "Form_Settings";
            this.Text = "Form_Settings";
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panelSettings;
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
    }
}