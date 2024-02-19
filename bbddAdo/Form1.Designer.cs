namespace bbddAdo
{
    partial class inicio
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
            this.lblAccion = new System.Windows.Forms.Label();
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.btnRellenarCancelarPedido = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(59, 31);
            this.lblAccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(137, 18);
            this.lblAccion.TabIndex = 0;
            this.lblAccion.Text = "¿Que desea hacer?";
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.Location = new System.Drawing.Point(62, 92);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(241, 42);
            this.btnAgregarCuenta.TabIndex = 1;
            this.btnAgregarCuenta.Text = "Agregar cuenta";
            this.btnAgregarCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.BtnAgregarCuenta_Click);
            // 
            // btnRellenarCancelarPedido
            // 
            this.btnRellenarCancelarPedido.Location = new System.Drawing.Point(62, 155);
            this.btnRellenarCancelarPedido.Name = "btnRellenarCancelarPedido";
            this.btnRellenarCancelarPedido.Size = new System.Drawing.Size(286, 46);
            this.btnRellenarCancelarPedido.TabIndex = 2;
            this.btnRellenarCancelarPedido.Text = "Rellenar o cancelar pedido";
            this.btnRellenarCancelarPedido.UseVisualStyleBackColor = true;
            this.btnRellenarCancelarPedido.Click += new System.EventHandler(this.btnRellenarCancelarPedido_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(242, 267);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 354);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRellenarCancelarPedido);
            this.Controls.Add(this.btnAgregarCuenta);
            this.Controls.Add(this.lblAccion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "inicio";
            this.Text = "Inicio - Miguel Sanchez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.Button btnRellenarCancelarPedido;
        private System.Windows.Forms.Button btnSalir;
    }
}

