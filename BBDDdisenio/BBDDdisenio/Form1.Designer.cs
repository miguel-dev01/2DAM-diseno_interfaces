namespace BBDDdisenio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblId;
            System.Windows.Forms.Label lblUbicacion;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zooBDDataSet = new BBDDdisenio.ZooBDDataSet();
            this.zooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zooTableAdapter = new BBDDdisenio.ZooBDDataSetTableAdapters.ZooTableAdapter();
            this.tableAdapterManager = new BBDDdisenio.ZooBDDataSetTableAdapters.TableAdapterManager();
            this.animalTableAdapter = new BBDDdisenio.ZooBDDataSetTableAdapters.AnimalTableAdapter();
            this.animalZooTableAdapter = new BBDDdisenio.ZooBDDataSetTableAdapters.AnimalZooTableAdapter();
            this.zooBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.zooBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalZooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalZooDataGridView = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            lblId = new System.Windows.Forms.Label();
            lblUbicacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooBindingNavigator)).BeginInit();
            this.zooBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalZooBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalZooDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(36, 41);
            lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(19, 13);
            lblId.TabIndex = 1;
            lblId.Text = "Id:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new System.Drawing.Point(36, 64);
            lblUbicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new System.Drawing.Size(58, 13);
            lblUbicacion.TabIndex = 3;
            lblUbicacion.Text = "Ubicación:";
            // 
            // zooBDDataSet
            // 
            this.zooBDDataSet.DataSetName = "ZooBDDataSet";
            this.zooBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zooBindingSource
            // 
            this.zooBindingSource.DataMember = "Zoo";
            this.zooBindingSource.DataSource = this.zooBDDataSet;
            // 
            // zooTableAdapter
            // 
            this.zooTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.AnimalZooTableAdapter = this.animalZooTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BBDDdisenio.ZooBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZooTableAdapter = this.zooTableAdapter;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // animalZooTableAdapter
            // 
            this.animalZooTableAdapter.ClearBeforeFill = true;
            // 
            // zooBindingNavigator
            // 
            this.zooBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zooBindingNavigator.BindingSource = this.zooBindingSource;
            this.zooBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zooBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zooBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.zooBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zooBindingNavigatorSaveItem});
            this.zooBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zooBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zooBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zooBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zooBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zooBindingNavigator.Name = "zooBindingNavigator";
            this.zooBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zooBindingNavigator.Size = new System.Drawing.Size(667, 27);
            this.zooBindingNavigator.TabIndex = 0;
            this.zooBindingNavigator.Text = "bindingNavigator1";
            this.zooBindingNavigator.RefreshItems += new System.EventHandler(this.zooBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.bindingNavigatorPositionItem_TextChanged);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // zooBindingNavigatorSaveItem
            // 
            this.zooBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zooBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zooBindingNavigatorSaveItem.Image")));
            this.zooBindingNavigatorSaveItem.Name = "zooBindingNavigatorSaveItem";
            this.zooBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.zooBindingNavigatorSaveItem.Text = "Guardar datos";
            this.zooBindingNavigatorSaveItem.Click += new System.EventHandler(this.zooBindingNavigatorSaveItem_Click);
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zooBindingSource, "Id", true));
            this.txtId.Location = new System.Drawing.Point(94, 39);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zooBindingSource, "Ubicación", true));
            this.txtUbicacion.Location = new System.Drawing.Point(94, 61);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(154, 20);
            this.txtUbicacion.TabIndex = 4;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.zooBDDataSet;
            // 
            // animalDataGridView
            // 
            this.animalDataGridView.AutoGenerateColumns = false;
            this.animalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.animalDataGridView.DataSource = this.animalBindingSource;
            this.animalDataGridView.Location = new System.Drawing.Point(280, 39);
            this.animalDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.animalDataGridView.Name = "animalDataGridView";
            this.animalDataGridView.RowHeadersWidth = 51;
            this.animalDataGridView.RowTemplate.Height = 24;
            this.animalDataGridView.Size = new System.Drawing.Size(351, 249);
            this.animalDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // animalZooBindingSource
            // 
            this.animalZooBindingSource.DataMember = "AnimalZoo";
            this.animalZooBindingSource.DataSource = this.zooBDDataSet;
            // 
            // animalZooDataGridView
            // 
            this.animalZooDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalZooDataGridView.Location = new System.Drawing.Point(23, 100);
            this.animalZooDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.animalZooDataGridView.Name = "animalZooDataGridView";
            this.animalZooDataGridView.RowHeadersWidth = 51;
            this.animalZooDataGridView.RowTemplate.Height = 24;
            this.animalZooDataGridView.Size = new System.Drawing.Size(225, 188);
            this.animalZooDataGridView.TabIndex = 6;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnInsertar.Location = new System.Drawing.Point(237, 332);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(161, 48);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 422);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.animalZooDataGridView);
            this.Controls.Add(this.animalDataGridView);
            this.Controls.Add(lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(lblUbicacion);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.zooBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooBindingNavigator)).EndInit();
            this.zooBindingNavigator.ResumeLayout(false);
            this.zooBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalZooBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalZooDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooBDDataSet zooBDDataSet;
        private System.Windows.Forms.BindingSource zooBindingSource;
        private ZooBDDataSetTableAdapters.ZooTableAdapter zooTableAdapter;
        private ZooBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zooBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zooBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUbicacion;
        private ZooBDDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.DataGridView animalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ZooBDDataSetTableAdapters.AnimalZooTableAdapter animalZooTableAdapter;
        private System.Windows.Forms.BindingSource animalZooBindingSource;
        private System.Windows.Forms.DataGridView animalZooDataGridView;
        private System.Windows.Forms.Button btnInsertar;
    }
}

