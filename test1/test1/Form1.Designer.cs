namespace test1 {
    partial class Form1 {
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hide = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.testpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.hide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 427);
            this.panel1.TabIndex = 1;
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.Transparent;
            this.hide.Dock = System.Windows.Forms.DockStyle.Top;
            this.hide.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.hide.FlatAppearance.BorderSize = 2;
            this.hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide.ForeColor = System.Drawing.Color.White;
            this.hide.Location = new System.Drawing.Point(0, 0);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(62, 103);
            this.hide.TabIndex = 0;
            this.hide.Text = "H\r\nI\r\nD\r\nE";
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 83);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(400, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 70);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // testpanel
            // 
            this.testpanel.BackColor = System.Drawing.Color.Teal;
            this.testpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.testpanel.Location = new System.Drawing.Point(62, 83);
            this.testpanel.Name = "testpanel";
            this.testpanel.Size = new System.Drawing.Size(937, 100);
            this.testpanel.TabIndex = 4;
            this.testpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.testpanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 510);
            this.Controls.Add(this.testpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel testpanel;
    }
}

