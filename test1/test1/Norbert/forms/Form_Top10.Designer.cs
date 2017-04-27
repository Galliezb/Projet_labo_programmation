namespace test1.Norbert.forms
{
    partial class Form_Top10
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Battlerite");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("League of Legends");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Counter Strike GO");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Dota2");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Overwatch");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Heavy Metal Machine");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Paladin");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Hearthstone");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Orion Prelude");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("BattleBorn");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Top10));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(5);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "Battlerite";
            treeNode11.Text = "Battlerite";
            treeNode12.Name = "League of Legends";
            treeNode12.Text = "League of Legends";
            treeNode13.Name = "Counter Strike GO";
            treeNode13.Text = "Counter Strike GO";
            treeNode14.Name = "Dota2";
            treeNode14.Text = "Dota2";
            treeNode15.Name = "Overwatch";
            treeNode15.Text = "Overwatch";
            treeNode16.Name = "Heavy Metal Machine";
            treeNode16.Text = "Heavy Metal Machine";
            treeNode17.Name = "Paladin";
            treeNode17.Text = "Paladin";
            treeNode18.Name = "Hearthstone";
            treeNode18.Text = "Hearthstone";
            treeNode19.Name = "Orion Prelude";
            treeNode19.Text = "Orion Prelude";
            treeNode20.Name = "BattleBorn";
            treeNode20.Text = "BattleBorn";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(248, 768);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.axShockwaveFlash1);
            this.panel1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(245, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 768);
            this.panel1.TabIndex = 1;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.ForeColor = System.Drawing.Color.White;
            this.tbDescription.Location = new System.Drawing.Point(15, 582);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(731, 155);
            this.tbDescription.TabIndex = 1;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(15, 42);
            this.axShockwaveFlash1.Margin = new System.Windows.Forms.Padding(5);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(731, 466);
            this.axShockwaveFlash1.TabIndex = 0;
            this.axShockwaveFlash1.Tag = "TESTTAG";
            this.axShockwaveFlash1.Visible = false;
            // 
            // Form_Top10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1005, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Top10";
            this.Text = "Form_Create_Organization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.TextBox tbDescription;
    }
}