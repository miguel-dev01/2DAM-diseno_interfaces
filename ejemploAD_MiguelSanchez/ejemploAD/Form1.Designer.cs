namespace ejemploAD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCargarDatosReader = new System.Windows.Forms.Button();
            this.btnCargarDatoAdapter = new System.Windows.Forms.Button();
            this.lstBoxZoo = new System.Windows.Forms.ListBox();
            this.lstBoxCiuidades = new System.Windows.Forms.ListBox();
            this.gBoxInsert = new System.Windows.Forms.GroupBox();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gBoxBorrar = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBoxInsert.SuspendLayout();
            this.gBoxBorrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(175, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCargarDatosReader
            // 
            this.btnCargarDatosReader.Location = new System.Drawing.Point(22, 207);
            this.btnCargarDatosReader.Name = "btnCargarDatosReader";
            this.btnCargarDatosReader.Size = new System.Drawing.Size(115, 38);
            this.btnCargarDatosReader.TabIndex = 1;
            this.btnCargarDatosReader.Text = "Cargar datos (reader)";
            this.btnCargarDatosReader.UseVisualStyleBackColor = true;
            this.btnCargarDatosReader.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnCargarDatoAdapter
            // 
            this.btnCargarDatoAdapter.Location = new System.Drawing.Point(143, 207);
            this.btnCargarDatoAdapter.Name = "btnCargarDatoAdapter";
            this.btnCargarDatoAdapter.Size = new System.Drawing.Size(107, 38);
            this.btnCargarDatoAdapter.TabIndex = 2;
            this.btnCargarDatoAdapter.Text = "Cargar datos (adapter)";
            this.btnCargarDatoAdapter.UseVisualStyleBackColor = true;
            this.btnCargarDatoAdapter.Click += new System.EventHandler(this.btnCargarDatoAdapter_Click);
            // 
            // lstBoxZoo
            // 
            this.lstBoxZoo.FormattingEnabled = true;
            this.lstBoxZoo.Location = new System.Drawing.Point(514, 17);
            this.lstBoxZoo.Name = "lstBoxZoo";
            this.lstBoxZoo.Size = new System.Drawing.Size(290, 160);
            this.lstBoxZoo.TabIndex = 3;
            // 
            // lstBoxCiuidades
            // 
            this.lstBoxCiuidades.FormattingEnabled = true;
            this.lstBoxCiuidades.Location = new System.Drawing.Point(217, 17);
            this.lstBoxCiuidades.Name = "lstBoxCiuidades";
            this.lstBoxCiuidades.Size = new System.Drawing.Size(273, 160);
            this.lstBoxCiuidades.TabIndex = 5;
            this.lstBoxCiuidades.SelectedIndexChanged += new System.EventHandler(this.lstBoxCiuidades_SelectedIndexChanged);
            // 
            // gBoxInsert
            // 
            this.gBoxInsert.Controls.Add(this.btnInsert);
            this.gBoxInsert.Controls.Add(this.txtInsert);
            this.gBoxInsert.Location = new System.Drawing.Point(22, 273);
            this.gBoxInsert.Name = "gBoxInsert";
            this.gBoxInsert.Size = new System.Drawing.Size(228, 163);
            this.gBoxInsert.TabIndex = 6;
            this.gBoxInsert.TabStop = false;
            this.gBoxInsert.Text = "Introducir datos:";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(15, 34);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(194, 20);
            this.txtInsert.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(68, 83);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gBoxBorrar
            // 
            this.gBoxBorrar.Controls.Add(this.btnBorrar);
            this.gBoxBorrar.Location = new System.Drawing.Point(514, 273);
            this.gBoxBorrar.Name = "gBoxBorrar";
            this.gBoxBorrar.Size = new System.Drawing.Size(228, 163);
            this.gBoxBorrar.TabIndex = 9;
            this.gBoxBorrar.TabStop = false;
            this.gBoxBorrar.Text = "Borrar registro:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(68, 83);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 461);
            this.Controls.Add(this.gBoxBorrar);
            this.Controls.Add(this.gBoxInsert);
            this.Controls.Add(this.lstBoxCiuidades);
            this.Controls.Add(this.lstBoxZoo);
            this.Controls.Add(this.btnCargarDatoAdapter);
            this.Controls.Add(this.btnCargarDatosReader);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Base de datos con WindowsForms(Miguel)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBoxInsert.ResumeLayout(false);
            this.gBoxInsert.PerformLayout();
            this.gBoxBorrar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCargarDatosReader;
        private System.Windows.Forms.Button btnCargarDatoAdapter;
        private System.Windows.Forms.ListBox lstBoxZoo;
        private System.Windows.Forms.ListBox lstBoxCiuidades;
        private System.Windows.Forms.GroupBox gBoxInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.GroupBox gBoxBorrar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

