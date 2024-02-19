namespace bbddAdo
{
    partial class FormCuentaPedido
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
            this.gBoxAgregarCuenta = new System.Windows.Forms.GroupBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.txtIdentificadorCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblIdentificadorCliente = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.gBoxCrearPedido = new System.Windows.Forms.GroupBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.btnCrearPedido = new System.Windows.Forms.Button();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.lblCantidadPedido = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnOtherAccount = new System.Windows.Forms.Button();
            this.gBoxAgregarCuenta.SuspendLayout();
            this.gBoxCrearPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxAgregarCuenta
            // 
            this.gBoxAgregarCuenta.Controls.Add(this.btnCrearCuenta);
            this.gBoxAgregarCuenta.Controls.Add(this.txtIdentificadorCliente);
            this.gBoxAgregarCuenta.Controls.Add(this.txtNombreCliente);
            this.gBoxAgregarCuenta.Controls.Add(this.lblIdentificadorCliente);
            this.gBoxAgregarCuenta.Controls.Add(this.labelNombreCliente);
            this.gBoxAgregarCuenta.Location = new System.Drawing.Point(56, 44);
            this.gBoxAgregarCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxAgregarCuenta.Name = "gBoxAgregarCuenta";
            this.gBoxAgregarCuenta.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxAgregarCuenta.Size = new System.Drawing.Size(956, 159);
            this.gBoxAgregarCuenta.TabIndex = 0;
            this.gBoxAgregarCuenta.TabStop = false;
            this.gBoxAgregarCuenta.Text = "Agregar cuenta";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCrearCuenta.Location = new System.Drawing.Point(704, 50);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(197, 52);
            this.btnCrearCuenta.TabIndex = 4;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtIdentificadorCliente
            // 
            this.txtIdentificadorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdentificadorCliente.Location = new System.Drawing.Point(219, 92);
            this.txtIdentificadorCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificadorCliente.Name = "txtIdentificadorCliente";
            this.txtIdentificadorCliente.Size = new System.Drawing.Size(436, 24);
            this.txtIdentificadorCliente.TabIndex = 3;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNombreCliente.Location = new System.Drawing.Point(219, 33);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(436, 24);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // lblIdentificadorCliente
            // 
            this.lblIdentificadorCliente.AutoSize = true;
            this.lblIdentificadorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIdentificadorCliente.Location = new System.Drawing.Point(31, 96);
            this.lblIdentificadorCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificadorCliente.Name = "lblIdentificadorCliente";
            this.lblIdentificadorCliente.Size = new System.Drawing.Size(137, 18);
            this.lblIdentificadorCliente.TabIndex = 1;
            this.lblIdentificadorCliente.Text = "Identificador cliente:";
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelNombreCliente.Location = new System.Drawing.Point(31, 37);
            this.labelNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(135, 18);
            this.labelNombreCliente.TabIndex = 0;
            this.labelNombreCliente.Text = "Nombre del cliente:";
            // 
            // gBoxCrearPedido
            // 
            this.gBoxCrearPedido.Controls.Add(this.dtpOrderDate);
            this.gBoxCrearPedido.Controls.Add(this.numOrderAmount);
            this.gBoxCrearPedido.Controls.Add(this.btnCrearPedido);
            this.gBoxCrearPedido.Controls.Add(this.lblFechaPedido);
            this.gBoxCrearPedido.Controls.Add(this.lblCantidadPedido);
            this.gBoxCrearPedido.Location = new System.Drawing.Point(56, 244);
            this.gBoxCrearPedido.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxCrearPedido.Name = "gBoxCrearPedido";
            this.gBoxCrearPedido.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxCrearPedido.Size = new System.Drawing.Size(956, 159);
            this.gBoxCrearPedido.TabIndex = 5;
            this.gBoxCrearPedido.TabStop = false;
            this.gBoxCrearPedido.Text = "Crear pedido";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(219, 92);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(199, 23);
            this.dtpOrderDate.TabIndex = 7;
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Location = new System.Drawing.Point(219, 39);
            this.numOrderAmount.Margin = new System.Windows.Forms.Padding(4);
            this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(199, 23);
            this.numOrderAmount.TabIndex = 6;
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCrearPedido.Location = new System.Drawing.Point(704, 58);
            this.btnCrearPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(197, 52);
            this.btnCrearPedido.TabIndex = 4;
            this.btnCrearPedido.Text = "Realizar pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFechaPedido.Location = new System.Drawing.Point(31, 92);
            this.lblFechaPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(124, 18);
            this.lblFechaPedido.TabIndex = 1;
            this.lblFechaPedido.Text = "Fecha del pedido:";
            // 
            // lblCantidadPedido
            // 
            this.lblCantidadPedido.AutoSize = true;
            this.lblCantidadPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCantidadPedido.Location = new System.Drawing.Point(31, 37);
            this.lblCantidadPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadPedido.Name = "lblCantidadPedido";
            this.lblCantidadPedido.Size = new System.Drawing.Size(138, 18);
            this.lblCantidadPedido.TabIndex = 0;
            this.lblCantidadPedido.Text = "Cantidad de pedido:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFinalizar.Location = new System.Drawing.Point(172, 436);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(238, 64);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnAddFinish_Click);
            // 
            // btnOtherAccount
            // 
            this.btnOtherAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOtherAccount.Location = new System.Drawing.Point(607, 436);
            this.btnOtherAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnOtherAccount.Name = "btnOtherAccount";
            this.btnOtherAccount.Size = new System.Drawing.Size(238, 64);
            this.btnOtherAccount.TabIndex = 7;
            this.btnOtherAccount.Text = "Agregar otra cuenta";
            this.btnOtherAccount.UseVisualStyleBackColor = true;
            this.btnOtherAccount.Click += new System.EventHandler(this.btnAddAnotherAccount_Click);
            // 
            // FormCuentaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 547);
            this.Controls.Add(this.btnOtherAccount);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gBoxCrearPedido);
            this.Controls.Add(this.gBoxAgregarCuenta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCuentaPedido";
            this.Text = "Cuenta y pedidos nuevos - Miguel Sanchez";
            this.gBoxAgregarCuenta.ResumeLayout(false);
            this.gBoxAgregarCuenta.PerformLayout();
            this.gBoxCrearPedido.ResumeLayout(false);
            this.gBoxCrearPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxAgregarCuenta;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox txtIdentificadorCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblIdentificadorCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.GroupBox gBoxCrearPedido;
        private System.Windows.Forms.Button btnCrearPedido;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.Label lblCantidadPedido;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnOtherAccount;
    }
}