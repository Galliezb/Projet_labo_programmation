namespace test1.Norbert
{
    partial class Form_Accueil
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
            this.btSettings = new System.Windows.Forms.Button();
            this.btRecords = new System.Windows.Forms.Button();
            this.btFriendList = new System.Windows.Forms.Button();
            this.btManageTeam = new System.Windows.Forms.Button();
            this.btTop10 = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSettings
            // 
            this.btSettings.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSettings.Location = new System.Drawing.Point(78, 60);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(167, 40);
            this.btSettings.TabIndex = 0;
            this.btSettings.Text = "Setttings";
            this.btSettings.UseVisualStyleBackColor = true;
            // 
            // btRecords
            // 
            this.btRecords.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecords.Location = new System.Drawing.Point(78, 115);
            this.btRecords.Name = "btRecords";
            this.btRecords.Size = new System.Drawing.Size(167, 40);
            this.btRecords.TabIndex = 0;
            this.btRecords.Text = "Records";
            this.btRecords.UseVisualStyleBackColor = true;
            // 
            // btFriendList
            // 
            this.btFriendList.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFriendList.Location = new System.Drawing.Point(78, 170);
            this.btFriendList.Name = "btFriendList";
            this.btFriendList.Size = new System.Drawing.Size(167, 40);
            this.btFriendList.TabIndex = 0;
            this.btFriendList.Text = "FriendList";
            this.btFriendList.UseVisualStyleBackColor = true;
            // 
            // btManageTeam
            // 
            this.btManageTeam.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManageTeam.Location = new System.Drawing.Point(78, 225);
            this.btManageTeam.Name = "btManageTeam";
            this.btManageTeam.Size = new System.Drawing.Size(167, 40);
            this.btManageTeam.TabIndex = 0;
            this.btManageTeam.Text = "Manage Team";
            this.btManageTeam.UseVisualStyleBackColor = true;
            // 
            // btTop10
            // 
            this.btTop10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTop10.Location = new System.Drawing.Point(78, 280);
            this.btTop10.Name = "btTop10";
            this.btTop10.Size = new System.Drawing.Size(167, 40);
            this.btTop10.TabIndex = 0;
            this.btTop10.Text = "Top 10";
            this.btTop10.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(13, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 18);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "texte";
            // 
            // Form_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 401);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btTop10);
            this.Controls.Add(this.btManageTeam);
            this.Controls.Add(this.btFriendList);
            this.Controls.Add(this.btRecords);
            this.Controls.Add(this.btSettings);
            this.Name = "Form_Accueil";
            this.Text = "Form_Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btRecords;
        private System.Windows.Forms.Button btFriendList;
        private System.Windows.Forms.Button btManageTeam;
        private System.Windows.Forms.Button btTop10;
        private System.Windows.Forms.Label lbName;
    }
}