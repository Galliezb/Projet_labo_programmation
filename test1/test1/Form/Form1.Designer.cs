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
            this.pNews = new System.Windows.Forms.Panel();
            this.lbNews = new System.Windows.Forms.Label();
            this.pIdentification = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIdentification = new System.Windows.Forms.Label();
            this.bIdentification = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCreate = new System.Windows.Forms.Button();
            this.tbCreatePwd = new System.Windows.Forms.TextBox();
            this.tbCreateLogin = new System.Windows.Forms.TextBox();
            this.lbCreate = new System.Windows.Forms.Label();
            this.pIdentification.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNews
            // 
            this.pNews.Location = new System.Drawing.Point(20, 57);
            this.pNews.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pNews.Name = "pNews";
            this.pNews.Size = new System.Drawing.Size(844, 731);
            this.pNews.TabIndex = 0;
            // 
            // lbNews
            // 
            this.lbNews.AutoSize = true;
            this.lbNews.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNews.Location = new System.Drawing.Point(382, 24);
            this.lbNews.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNews.Name = "lbNews";
            this.lbNews.Size = new System.Drawing.Size(52, 18);
            this.lbNews.TabIndex = 1;
            this.lbNews.Text = "News";
            // 
            // pIdentification
            // 
            this.pIdentification.Controls.Add(this.lbIdentification);
            this.pIdentification.Controls.Add(this.tbPwd);
            this.pIdentification.Controls.Add(this.tbLogin);
            this.pIdentification.Controls.Add(this.bIdentification);
            this.pIdentification.Location = new System.Drawing.Point(874, 57);
            this.pIdentification.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pIdentification.Name = "pIdentification";
            this.pIdentification.Size = new System.Drawing.Size(353, 203);
            this.pIdentification.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(874, 644);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 147);
            this.button1.TabIndex = 3;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
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
            // lbIdentification
            // 
            this.lbIdentification.AutoSize = true;
            this.lbIdentification.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentification.Location = new System.Drawing.Point(113, 13);
            this.lbIdentification.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbIdentification.Name = "lbIdentification";
            this.lbIdentification.Size = new System.Drawing.Size(118, 18);
            this.lbIdentification.TabIndex = 5;
            this.lbIdentification.Text = "Identification";
            // 
            // bIdentification
            // 
            this.bIdentification.Location = new System.Drawing.Point(18, 132);
            this.bIdentification.Name = "bIdentification";
            this.bIdentification.Size = new System.Drawing.Size(321, 33);
            this.bIdentification.TabIndex = 0;
            this.bIdentification.Text = "Send";
            this.bIdentification.UseVisualStyleBackColor = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(18, 43);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(321, 27);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "Login";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(18, 87);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(321, 27);
            this.tbPwd.TabIndex = 2;
            this.tbPwd.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bCreate);
            this.panel1.Controls.Add(this.tbCreatePwd);
            this.panel1.Controls.Add(this.tbCreateLogin);
            this.panel1.Controls.Add(this.lbCreate);
            this.panel1.Location = new System.Drawing.Point(874, 350);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 214);
            this.panel1.TabIndex = 10;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(20, 152);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(321, 33);
            this.bCreate.TabIndex = 9;
            this.bCreate.Text = "Send";
            this.bCreate.UseVisualStyleBackColor = true;
            // 
            // tbCreatePwd
            // 
            this.tbCreatePwd.Location = new System.Drawing.Point(20, 103);
            this.tbCreatePwd.Name = "tbCreatePwd";
            this.tbCreatePwd.Size = new System.Drawing.Size(321, 27);
            this.tbCreatePwd.TabIndex = 8;
            this.tbCreatePwd.Text = "Password";
            // 
            // tbCreateLogin
            // 
            this.tbCreateLogin.Location = new System.Drawing.Point(20, 57);
            this.tbCreateLogin.Name = "tbCreateLogin";
            this.tbCreateLogin.Size = new System.Drawing.Size(321, 27);
            this.tbCreateLogin.TabIndex = 7;
            this.tbCreateLogin.Text = "Login";
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreate.Location = new System.Drawing.Point(117, 20);
            this.lbCreate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(132, 18);
            this.lbCreate.TabIndex = 6;
            this.lbCreate.Text = "Create Account";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 804);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pIdentification);
            this.Controls.Add(this.lbNews);
            this.Controls.Add(this.pNews);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormStart";
            this.Text = "Tournoi Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pIdentification.ResumeLayout(false);
            this.pIdentification.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pNews;
        private System.Windows.Forms.Label lbNews;
        private System.Windows.Forms.Panel pIdentification;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIdentification;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button bIdentification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.TextBox tbCreatePwd;
        private System.Windows.Forms.TextBox tbCreateLogin;
        private System.Windows.Forms.Label lbCreate;
    }
}

