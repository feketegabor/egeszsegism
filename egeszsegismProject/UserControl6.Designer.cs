namespace egeszsegismProject
{
    partial class UserControl6
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl6));
            this.feladatTipusTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feladatTipusTablaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.feladatTipusTablaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.feladatTipusTablaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.feladatFajtaListaTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.feladatTipusTablaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feladatTipusTablaBindingNavigator)).BeginInit();
            this.feladatTipusTablaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feladatTipusTablaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feladatFajtaListaTablaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // feladatTipusTablaBindingSource
            // 
            this.feladatTipusTablaBindingSource.DataSource = typeof(egeszsegismProject.FeladatTipusTabla);
            // 
            // feladatTipusTablaBindingNavigator
            // 
            this.feladatTipusTablaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.feladatTipusTablaBindingNavigator.BindingSource = this.feladatTipusTablaBindingSource;
            this.feladatTipusTablaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.feladatTipusTablaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.feladatTipusTablaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.feladatTipusTablaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.feladatTipusTablaBindingNavigatorSaveItem});
            this.feladatTipusTablaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.feladatTipusTablaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.feladatTipusTablaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.feladatTipusTablaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.feladatTipusTablaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.feladatTipusTablaBindingNavigator.Name = "feladatTipusTablaBindingNavigator";
            this.feladatTipusTablaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.feladatTipusTablaBindingNavigator.Size = new System.Drawing.Size(818, 27);
            this.feladatTipusTablaBindingNavigator.TabIndex = 0;
            this.feladatTipusTablaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // feladatTipusTablaBindingNavigatorSaveItem
            // 
            this.feladatTipusTablaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.feladatTipusTablaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("feladatTipusTablaBindingNavigatorSaveItem.Image")));
            this.feladatTipusTablaBindingNavigatorSaveItem.Name = "feladatTipusTablaBindingNavigatorSaveItem";
            this.feladatTipusTablaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.feladatTipusTablaBindingNavigatorSaveItem.Text = "Save Data";
            this.feladatTipusTablaBindingNavigatorSaveItem.Click += new System.EventHandler(this.feladatTipusTablaBindingNavigatorSaveItem_Click);
            // 
            // feladatTipusTablaDataGridView
            // 
            this.feladatTipusTablaDataGridView.AutoGenerateColumns = false;
            this.feladatTipusTablaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feladatTipusTablaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.feladatTipusTablaDataGridView.DataSource = this.feladatTipusTablaBindingSource;
            this.feladatTipusTablaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feladatTipusTablaDataGridView.Location = new System.Drawing.Point(0, 27);
            this.feladatTipusTablaDataGridView.Name = "feladatTipusTablaDataGridView";
            this.feladatTipusTablaDataGridView.RowHeadersWidth = 51;
            this.feladatTipusTablaDataGridView.RowTemplate.Height = 24;
            this.feladatTipusTablaDataGridView.Size = new System.Drawing.Size(818, 694);
            this.feladatTipusTablaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FeladatFajtaFK";
            this.dataGridViewTextBoxColumn2.DataSource = this.feladatFajtaListaTablaBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "FeladatFajta";
            this.dataGridViewTextBoxColumn2.HeaderText = "FeladatFajtaFK";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            this.dataGridViewTextBoxColumn2.Width = 132;
            // 
            // feladatFajtaListaTablaBindingSource
            // 
            this.feladatFajtaListaTablaBindingSource.DataSource = typeof(egeszsegismProject.FeladatFajtaListaTabla);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FeladatTipus";
            this.dataGridViewTextBoxColumn3.HeaderText = "FeladatTipus";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // UserControl6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.feladatTipusTablaDataGridView);
            this.Controls.Add(this.feladatTipusTablaBindingNavigator);
            this.Name = "UserControl6";
            this.Size = new System.Drawing.Size(818, 721);
            ((System.ComponentModel.ISupportInitialize)(this.feladatTipusTablaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feladatTipusTablaBindingNavigator)).EndInit();
            this.feladatTipusTablaBindingNavigator.ResumeLayout(false);
            this.feladatTipusTablaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feladatTipusTablaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feladatFajtaListaTablaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource feladatTipusTablaBindingSource;
        private System.Windows.Forms.BindingNavigator feladatTipusTablaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton feladatTipusTablaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView feladatTipusTablaDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource feladatFajtaListaTablaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
