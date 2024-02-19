namespace ejemploSqliteBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dGridProductos = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            productBindingSource1 = new BindingSource(components);
            dGridCategoria = new DataGridView();
            categoryIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            btnGuardar = new Button();
            lblProducto = new Label();
            lblCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)dGridProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dGridProductos
            // 
            dGridProductos.AutoGenerateColumns = false;
            dGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridProductos.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            dGridProductos.DataSource = productBindingSource;
            dGridProductos.Location = new Point(343, 44);
            dGridProductos.Name = "dGridProductos";
            dGridProductos.RowTemplate.Height = 25;
            dGridProductos.Size = new Size(235, 331);
            dGridProductos.TabIndex = 0;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Product);
            // 
            // dGridCategoria
            // 
            dGridCategoria.AutoGenerateColumns = false;
            dGridCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridCategoria.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1 });
            dGridCategoria.DataSource = categoryBindingSource;
            dGridCategoria.Location = new Point(37, 44);
            dGridCategoria.Name = "dGridCategoria";
            dGridCategoria.RowTemplate.Height = 25;
            dGridCategoria.Size = new Size(247, 331);
            dGridCategoria.TabIndex = 1;
            dGridCategoria.SelectionChanged += dGridCategoria_SelectionChanged;
            // 
            // categoryIdDataGridViewTextBoxColumn1
            // 
            categoryIdDataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn1.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn1.Name = "categoryIdDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(240, 399);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 45);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducto.Location = new Point(343, 9);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(93, 28);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.Location = new Point(37, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(97, 28);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 474);
            Controls.Add(lblCategoria);
            Controls.Add(lblProducto);
            Controls.Add(btnGuardar);
            Controls.Add(dGridCategoria);
            Controls.Add(dGridProductos);
            Name = "Form1";
            Text = "Productos y categorias";
            ((System.ComponentModel.ISupportInitialize)dGridProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGridCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGridProductos;
        private DataGridView dGridCategoria;
        private Button btnGuardar;
        private Label lblProducto;
        private Label lblCategoria;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private BindingSource categoryBindingSource;
        private BindingSource productBindingSource1;
    }
}