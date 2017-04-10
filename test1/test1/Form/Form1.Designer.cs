namespace test1 {
    partial class FormStart {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.bEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pCreate = new System.Windows.Forms.Panel();
            this.bCreate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbVerifPwd = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbCreatePwd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbCreateLogin = new System.Windows.Forms.TextBox();
            this.lbCreate = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pIdentification = new System.Windows.Forms.Panel();
            this.panelTbPwd = new System.Windows.Forms.Panel();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.panelTbLog = new System.Windows.Forms.Panel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbIdentification = new System.Windows.Forms.Label();
            this.bIdentification = new System.Windows.Forms.Button();
            this.pCreate.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pIdentification.SuspendLayout();
            this.panelTbPwd.SuspendLayout();
            this.panelTbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // bEnter
            // 
            this.bEnter.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnter.Location = new System.Drawing.Point(23, 601);
            this.bEnter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(245, 147);
            this.bEnter.TabIndex = 3;
            this.bEnter.Text = "ENTER";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1388, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // pCreate
            // 
            this.pCreate.Controls.Add(this.bCreate);
            this.pCreate.Controls.Add(this.panel4);
            this.pCreate.Controls.Add(this.panel3);
            this.pCreate.Controls.Add(this.panel2);
            this.pCreate.Controls.Add(this.lbCreate);
            this.pCreate.Location = new System.Drawing.Point(7, 307);
            this.pCreate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pCreate.Name = "pCreate";
            this.pCreate.Size = new System.Drawing.Size(276, 286);
            this.pCreate.TabIndex = 10;
            // 
            // bCreate
            // 
            this.bCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCreate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bCreate.Location = new System.Drawing.Point(16, 196);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(245, 33);
            this.bCreate.TabIndex = 8;
            this.bCreate.Text = "Send";
            this.bCreate.UseVisualStyleBackColor = false;
            this.bCreate.MouseLeave += new System.EventHandler(this.bCreate_MouseLeave);
            this.bCreate.MouseHover += new System.EventHandler(this.bCreate_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tbVerifPwd);
            this.panel4.Location = new System.Drawing.Point(16, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 30);
            this.panel4.TabIndex = 8;
            // 
            // tbVerifPwd
            // 
            this.tbVerifPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.tbVerifPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVerifPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(164)))));
            this.tbVerifPwd.Location = new System.Drawing.Point(5, 5);
            this.tbVerifPwd.Margin = new System.Windows.Forms.Padding(5);
            this.tbVerifPwd.Name = "tbVerifPwd";
            this.tbVerifPwd.Size = new System.Drawing.Size(235, 20);
            this.tbVerifPwd.TabIndex = 1;
            this.tbVerifPwd.Text = "Password";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tbCreatePwd);
            this.panel3.Location = new System.Drawing.Point(16, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 30);
            this.panel3.TabIndex = 8;
            // 
            // tbCreatePwd
            // 
            this.tbCreatePwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.tbCreatePwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCreatePwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(164)))));
            this.tbCreatePwd.Location = new System.Drawing.Point(5, 5);
            this.tbCreatePwd.Margin = new System.Windows.Forms.Padding(5);
            this.tbCreatePwd.Name = "tbCreatePwd";
            this.tbCreatePwd.Size = new System.Drawing.Size(235, 20);
            this.tbCreatePwd.TabIndex = 1;
            this.tbCreatePwd.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbCreateLogin);
            this.panel2.Location = new System.Drawing.Point(16, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 30);
            this.panel2.TabIndex = 7;
            // 
            // tbCreateLogin
            // 
            this.tbCreateLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.tbCreateLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCreateLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(164)))));
            this.tbCreateLogin.Location = new System.Drawing.Point(5, 5);
            this.tbCreateLogin.Margin = new System.Windows.Forms.Padding(5);
            this.tbCreateLogin.Name = "tbCreateLogin";
            this.tbCreateLogin.Size = new System.Drawing.Size(235, 20);
            this.tbCreateLogin.TabIndex = 1;
            this.tbCreateLogin.Text = "Login";
            // 
            // lbCreate
            // 
            this.lbCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCreate.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreate.ForeColor = System.Drawing.Color.Black;
            this.lbCreate.Image = ((System.Drawing.Image)(resources.GetObject("lbCreate.Image")));
            this.lbCreate.Location = new System.Drawing.Point(41, 0);
            this.lbCreate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(191, 40);
            this.lbCreate.TabIndex = 8;
            this.lbCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pIdentification);
            this.panel1.Controls.Add(this.pCreate);
            this.panel1.Controls.Add(this.bEnter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(958, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 804);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pIdentification
            // 
            this.pIdentification.Controls.Add(this.panelTbPwd);
            this.pIdentification.Controls.Add(this.panelTbLog);
            this.pIdentification.Controls.Add(this.lbIdentification);
            this.pIdentification.Controls.Add(this.bIdentification);
            this.pIdentification.Location = new System.Drawing.Point(7, 96);
            this.pIdentification.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pIdentification.Name = "pIdentification";
            this.pIdentification.Size = new System.Drawing.Size(276, 203);
            this.pIdentification.TabIndex = 3;
            // 
            // panelTbPwd
            // 
            this.panelTbPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panelTbPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTbPwd.Controls.Add(this.tbPwd);
            this.panelTbPwd.Location = new System.Drawing.Point(16, 87);
            this.panelTbPwd.Name = "panelTbPwd";
            this.panelTbPwd.Size = new System.Drawing.Size(245, 30);
            this.panelTbPwd.TabIndex = 7;
            // 
            // tbPwd
            // 
            this.tbPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.tbPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(164)))));
            this.tbPwd.Location = new System.Drawing.Point(5, 5);
            this.tbPwd.Margin = new System.Windows.Forms.Padding(5);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(235, 20);
            this.tbPwd.TabIndex = 1;
            this.tbPwd.Text = "Password";
            // 
            // panelTbLog
            // 
            this.panelTbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panelTbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTbLog.Controls.Add(this.tbLogin);
            this.panelTbLog.Location = new System.Drawing.Point(16, 51);
            this.panelTbLog.Name = "panelTbLog";
            this.panelTbLog.Size = new System.Drawing.Size(245, 30);
            this.panelTbLog.TabIndex = 6;
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(164)))));
            this.tbLogin.Location = new System.Drawing.Point(5, 5);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(5);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(235, 20);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "Login";
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // lbIdentification
            // 
            this.lbIdentification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIdentification.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentification.ForeColor = System.Drawing.Color.Black;
            this.lbIdentification.Image = ((System.Drawing.Image)(resources.GetObject("lbIdentification.Image")));
            this.lbIdentification.Location = new System.Drawing.Point(41, 0);
            this.lbIdentification.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbIdentification.Name = "lbIdentification";
            this.lbIdentification.Size = new System.Drawing.Size(191, 40);
            this.lbIdentification.TabIndex = 5;
            this.lbIdentification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbIdentification.Click += new System.EventHandler(this.lbIdentification_Click);
            // 
            // bIdentification
            // 
            this.bIdentification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bIdentification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bIdentification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bIdentification.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIdentification.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bIdentification.Location = new System.Drawing.Point(16, 123);
            this.bIdentification.Name = "bIdentification";
            this.bIdentification.Size = new System.Drawing.Size(245, 33);
            this.bIdentification.TabIndex = 0;
            this.bIdentification.Text = "Send";
            this.bIdentification.UseVisualStyleBackColor = false;
            this.bIdentification.MouseLeave += new System.EventHandler(this.bIdentification_MouseLeave);
            this.bIdentification.MouseHover += new System.EventHandler(this.bIdentification_MouseHover);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 804);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStart";
            this.Text = "Tournament Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pCreate.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pIdentification.ResumeLayout(false);
            this.panelTbPwd.ResumeLayout(false);
            this.panelTbPwd.PerformLayout();
            this.panelTbLog.ResumeLayout(false);
            this.panelTbLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pCreate;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pIdentification;
        private System.Windows.Forms.Label lbIdentification;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button bIdentification;
        private System.Windows.Forms.Panel panelTbLog;
        private System.Windows.Forms.Panel panelTbPwd;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbCreateLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbCreatePwd;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbVerifPwd;
    }
}

