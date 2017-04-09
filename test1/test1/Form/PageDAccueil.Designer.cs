namespace test1
{
    partial class PageDAccueil
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
            this.BtModifyParam = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPwd1 = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbPwd2 = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbPWD1 = new System.Windows.Forms.Label();
            this.lbPWD2 = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtModifyParam
            // 
            this.BtModifyParam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtModifyParam.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtModifyParam.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtModifyParam.Location = new System.Drawing.Point(1012, 65);
            this.BtModifyParam.Name = "BtModifyParam";
            this.BtModifyParam.Size = new System.Drawing.Size(218, 58);
            this.BtModifyParam.TabIndex = 0;
            this.BtModifyParam.Text = "Modifier Paramètres";
            this.BtModifyParam.UseVisualStyleBackColor = true;
            this.BtModifyParam.Click += new System.EventHandler(this.BtModifyParam_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(1012, 185);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(196, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Visible = false;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbPwd1
            // 
            this.tbPwd1.Location = new System.Drawing.Point(1012, 291);
            this.tbPwd1.Name = "tbPwd1";
            this.tbPwd1.Size = new System.Drawing.Size(196, 20);
            this.tbPwd1.TabIndex = 2;
            this.tbPwd1.Visible = false;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(1012, 255);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(196, 20);
            this.tbMail.TabIndex = 3;
            this.tbMail.Visible = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(1012, 220);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(196, 20);
            this.tbFirstName.TabIndex = 4;
            this.tbFirstName.Visible = false;
            // 
            // tbPwd2
            // 
            this.tbPwd2.Location = new System.Drawing.Point(1012, 317);
            this.tbPwd2.Name = "tbPwd2";
            this.tbPwd2.Size = new System.Drawing.Size(196, 20);
            this.tbPwd2.TabIndex = 5;
            this.tbPwd2.Visible = false;
            // 
            // btSave
            // 
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(1012, 396);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(218, 58);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Sauvegarder";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(821, 188);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(62, 18);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name:";
            this.lbName.Visible = false;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(821, 223);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(98, 18);
            this.lbFirstName.TabIndex = 8;
            this.lbFirstName.Text = "FirstName:";
            this.lbFirstName.Visible = false;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(821, 258);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(67, 18);
            this.lbMail.TabIndex = 9;
            this.lbMail.Text = "E-mail:";
            this.lbMail.Visible = false;
            // 
            // lbPWD1
            // 
            this.lbPWD1.AutoSize = true;
            this.lbPWD1.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbPWD1.Location = new System.Drawing.Point(821, 294);
            this.lbPWD1.Name = "lbPWD1";
            this.lbPWD1.Size = new System.Drawing.Size(92, 18);
            this.lbPWD1.TabIndex = 10;
            this.lbPWD1.Text = "Password:";
            this.lbPWD1.Visible = false;
            // 
            // lbPWD2
            // 
            this.lbPWD2.AutoSize = true;
            this.lbPWD2.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbPWD2.Location = new System.Drawing.Point(821, 320);
            this.lbPWD2.Name = "lbPWD2";
            this.lbPWD2.Size = new System.Drawing.Size(108, 18);
            this.lbPWD2.TabIndex = 11;
            this.lbPWD2.Text = "Vérification:";
            this.lbPWD2.Visible = false;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.Color.White;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(107, 23);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(58, 24);
            this.lbNom.TabIndex = 12;
            this.lbNom.Text = "NOM";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblb.Location = new System.Drawing.Point(12, 23);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(89, 24);
            this.lblb.TabIndex = 13;
            this.lblb.Text = "Bonjour ";
            // 
            // PageDAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 801);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbPWD2);
            this.Controls.Add(this.lbPWD1);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbPwd2);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbPwd1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.BtModifyParam);
            this.Name = "PageDAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageDAccueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtModifyParam;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPwd1;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbPwd2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbPWD1;
        private System.Windows.Forms.Label lbPWD2;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lblb;
    }
}