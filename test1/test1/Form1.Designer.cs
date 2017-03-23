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
            System.Windows.Forms.Label idTournoiLabel;
            this.csharp_projectDataSet = new test1.csharp_projectDataSet();
            this.tournoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournoiTableAdapter = new test1.csharp_projectDataSetTableAdapters.TournoiTableAdapter();
            this.tableAdapterManager = new test1.csharp_projectDataSetTableAdapters.TableAdapterManager();
            this.tournoiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tournoiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTournoiTextBox = new System.Windows.Forms.TextBox();
            idTournoiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.csharp_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournoiBindingNavigator)).BeginInit();
            this.tournoiBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // csharp_projectDataSet
            // 
            this.csharp_projectDataSet.DataSetName = "csharp_projectDataSet";
            this.csharp_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tournoiBindingSource
            // 
            this.tournoiBindingSource.DataMember = "Tournoi";
            this.tournoiBindingSource.DataSource = this.csharp_projectDataSet;
            // 
            // tournoiTableAdapter
            // 
            this.tournoiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OptionTableAdapter = null;
            this.tableAdapterManager.OrganisationTableAdapter = null;
            this.tableAdapterManager.TournoiTableAdapter = this.tournoiTableAdapter;
            this.tableAdapterManager.UpdateOrder = test1.csharp_projectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // tournoiBindingNavigator
            // 
            this.tournoiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tournoiBindingNavigator.BindingSource = this.tournoiBindingSource;
            this.tournoiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tournoiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tournoiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tournoiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tournoiBindingNavigatorSaveItem});
            this.tournoiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tournoiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tournoiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tournoiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tournoiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tournoiBindingNavigator.Name = "tournoiBindingNavigator";
            this.tournoiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tournoiBindingNavigator.Size = new System.Drawing.Size(889, 27);
            this.tournoiBindingNavigator.TabIndex = 0;
            this.tournoiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tournoiBindingNavigatorSaveItem
            // 
            this.tournoiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tournoiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tournoiBindingNavigatorSaveItem.Image")));
            this.tournoiBindingNavigatorSaveItem.Name = "tournoiBindingNavigatorSaveItem";
            this.tournoiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tournoiBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.tournoiBindingNavigatorSaveItem.Click += new System.EventHandler(this.tournoiBindingNavigatorSaveItem_Click);
            // 
            // idTournoiLabel
            // 
            idTournoiLabel.AutoSize = true;
            idTournoiLabel.Location = new System.Drawing.Point(157, 139);
            idTournoiLabel.Name = "idTournoiLabel";
            idTournoiLabel.Size = new System.Drawing.Size(76, 17);
            idTournoiLabel.TabIndex = 1;
            idTournoiLabel.Text = "id Tournoi:";
            // 
            // idTournoiTextBox
            // 
            this.idTournoiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tournoiBindingSource, "idTournoi", true));
            this.idTournoiTextBox.Location = new System.Drawing.Point(239, 136);
            this.idTournoiTextBox.Name = "idTournoiTextBox";
            this.idTournoiTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTournoiTextBox.TabIndex = 2;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 667);
            this.Controls.Add(idTournoiLabel);
            this.Controls.Add(this.idTournoiTextBox);
            this.Controls.Add(this.tournoiBindingNavigator);
            this.Name = "FormStart";
            this.Text = "Tournoi Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.csharp_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournoiBindingNavigator)).EndInit();
            this.tournoiBindingNavigator.ResumeLayout(false);
            this.tournoiBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private csharp_projectDataSet csharp_projectDataSet;
        private System.Windows.Forms.BindingSource tournoiBindingSource;
        private csharp_projectDataSetTableAdapters.TournoiTableAdapter tournoiTableAdapter;
        private csharp_projectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tournoiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tournoiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTournoiTextBox;
    }
}

