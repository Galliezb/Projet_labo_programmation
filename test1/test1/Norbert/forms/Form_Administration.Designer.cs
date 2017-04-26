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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Add a User to DB");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Update Informations");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Change Own Informations");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Show Informations");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Promote User");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Add Administrator");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "AddUser";
            treeNode1.Text = "Add a User to DB";
            treeNode2.Name = "UpdateInfo";
            treeNode2.Text = "Update Informations";
            treeNode3.Name = "ChangeSettings";
            treeNode3.Text = "Change Own Informations";
            treeNode4.Name = "ShowInfo";
            treeNode4.Text = "Show Informations";
            treeNode5.Name = "Promote";
            treeNode5.Text = "Promote User";
            treeNode6.Name = "AddAdmin";
            treeNode6.Text = "Add Administrator";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(212, 1024);
            this.treeView1.TabIndex = 1;
            // 
            // Form_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1436, 1024);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Administration";
            this.Text = "Form_Administration";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
    }
}