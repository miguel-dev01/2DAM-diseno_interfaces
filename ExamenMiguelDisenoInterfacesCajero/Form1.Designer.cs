namespace ExamenMiguelDiseñoInterfacesCajero
{
    partial class FormCajero
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLOQUEARDESBLOQUEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxAltasCliente = new System.Windows.Forms.GroupBox();
            this.btnAceptarAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.txtSaldoCliente = new System.Windows.Forms.TextBox();
            this.lblSaldoCliente = new System.Windows.Forms.Label();
            this.txtClaveCliente = new System.Windows.Forms.TextBox();
            this.lblClaveCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.gBoxFormularioCajero = new System.Windows.Forms.GroupBox();
            this.txtClaveCajero = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnAceptarFormCajero = new System.Windows.Forms.Button();
            this.btnCancelarFormCajero = new System.Windows.Forms.Button();
            this.txtDniCajero = new System.Windows.Forms.TextBox();
            this.lblDniClienteCajero = new System.Windows.Forms.Label();
            this.gBoxConsultas = new System.Windows.Forms.GroupBox();
            this.chkBoxBloqueoConsulta = new System.Windows.Forms.CheckBox();
            this.lblSaldoConsulta = new System.Windows.Forms.Label();
            this.lblDniConsulta = new System.Windows.Forms.Label();
            this.btnAceptarConsulta = new System.Windows.Forms.Button();
            this.btnCancelarConsulta = new System.Windows.Forms.Button();
            this.txtNombreClienteConsulta = new System.Windows.Forms.TextBox();
            this.lblNombreClienteConsulta = new System.Windows.Forms.Label();
            this.gBoxBloquearDesbloquear = new System.Windows.Forms.GroupBox();
            this.txtClaveBloDes = new System.Windows.Forms.TextBox();
            this.lblClaveBloDes = new System.Windows.Forms.Label();
            this.btnAceptarBloDes = new System.Windows.Forms.Button();
            this.btnCancelarBloDes = new System.Windows.Forms.Button();
            this.txtDniBloDes = new System.Windows.Forms.TextBox();
            this.lblDniBloDes = new System.Windows.Forms.Label();
            this.btnDesBlo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gBoxAltasCliente.SuspendLayout();
            this.gBoxFormularioCajero.SuspendLayout();
            this.gBoxConsultas.SuspendLayout();
            this.gBoxBloquearDesbloquear.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClienteToolStripMenuItem,
            this.CajeroToolStripMenuItem,
            this.TarjetaToolStripMenuItem,
            this.CerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ClienteToolStripMenuItem
            // 
            this.ClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaToolStripMenuItem,
            this.ConsultaToolStripMenuItem});
            this.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem";
            this.ClienteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ClienteToolStripMenuItem.Text = "CLIENTE";
            // 
            // AltaToolStripMenuItem
            // 
            this.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem";
            this.AltaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AltaToolStripMenuItem.Text = "ALTA";
            this.AltaToolStripMenuItem.Click += new System.EventHandler(this.AltaToolStripMenuItem_Click);
            // 
            // ConsultaToolStripMenuItem
            // 
            this.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem";
            this.ConsultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ConsultaToolStripMenuItem.Text = "CONSULTA";
            this.ConsultaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaToolStripMenuItem_Click);
            // 
            // CajeroToolStripMenuItem
            // 
            this.CajeroToolStripMenuItem.Name = "CajeroToolStripMenuItem";
            this.CajeroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.CajeroToolStripMenuItem.Text = "CAJERO";
            this.CajeroToolStripMenuItem.Click += new System.EventHandler(this.CajeroToolStripMenuItem_Click);
            // 
            // TarjetaToolStripMenuItem
            // 
            this.TarjetaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bLOQUEARDESBLOQUEARToolStripMenuItem});
            this.TarjetaToolStripMenuItem.Name = "TarjetaToolStripMenuItem";
            this.TarjetaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.TarjetaToolStripMenuItem.Text = "TARJETA";
            // 
            // bLOQUEARDESBLOQUEARToolStripMenuItem
            // 
            this.bLOQUEARDESBLOQUEARToolStripMenuItem.Name = "bLOQUEARDESBLOQUEARToolStripMenuItem";
            this.bLOQUEARDESBLOQUEARToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.bLOQUEARDESBLOQUEARToolStripMenuItem.Text = "BLOQUEAR/DESBLOQUEAR";
            this.bLOQUEARDESBLOQUEARToolStripMenuItem.Click += new System.EventHandler(this.bLOQUEARDESBLOQUEARToolStripMenuItem_Click);
            // 
            // CerrarToolStripMenuItem
            // 
            this.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem";
            this.CerrarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.CerrarToolStripMenuItem.Text = "CERRAR";
            this.CerrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarToolStripMenuItem_Click);
            // 
            // gBoxAltasCliente
            // 
            this.gBoxAltasCliente.Controls.Add(this.btnAceptarAlta);
            this.gBoxAltasCliente.Controls.Add(this.btnCancelarAlta);
            this.gBoxAltasCliente.Controls.Add(this.txtSaldoCliente);
            this.gBoxAltasCliente.Controls.Add(this.lblSaldoCliente);
            this.gBoxAltasCliente.Controls.Add(this.txtClaveCliente);
            this.gBoxAltasCliente.Controls.Add(this.lblClaveCliente);
            this.gBoxAltasCliente.Controls.Add(this.txtNombreCliente);
            this.gBoxAltasCliente.Controls.Add(this.lblNombreCliente);
            this.gBoxAltasCliente.Controls.Add(this.txtDniCliente);
            this.gBoxAltasCliente.Controls.Add(this.lblDniCliente);
            this.gBoxAltasCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gBoxAltasCliente.Location = new System.Drawing.Point(12, 40);
            this.gBoxAltasCliente.Name = "gBoxAltasCliente";
            this.gBoxAltasCliente.Size = new System.Drawing.Size(369, 431);
            this.gBoxAltasCliente.TabIndex = 1;
            this.gBoxAltasCliente.TabStop = false;
            this.gBoxAltasCliente.Text = "ALTAS";
            this.gBoxAltasCliente.Visible = false;
            // 
            // btnAceptarAlta
            // 
            this.btnAceptarAlta.Location = new System.Drawing.Point(192, 363);
            this.btnAceptarAlta.Name = "btnAceptarAlta";
            this.btnAceptarAlta.Size = new System.Drawing.Size(123, 48);
            this.btnAceptarAlta.TabIndex = 8;
            this.btnAceptarAlta.Text = "ACEPTAR";
            this.btnAceptarAlta.UseVisualStyleBackColor = true;
            this.btnAceptarAlta.Click += new System.EventHandler(this.btnAceptarAlta_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(21, 363);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(123, 48);
            this.btnCancelarAlta.TabIndex = 2;
            this.btnCancelarAlta.Text = "CANCELAR";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // txtSaldoCliente
            // 
            this.txtSaldoCliente.Location = new System.Drawing.Point(21, 315);
            this.txtSaldoCliente.Name = "txtSaldoCliente";
            this.txtSaldoCliente.Size = new System.Drawing.Size(310, 24);
            this.txtSaldoCliente.TabIndex = 7;
            // 
            // lblSaldoCliente
            // 
            this.lblSaldoCliente.AutoSize = true;
            this.lblSaldoCliente.Location = new System.Drawing.Point(18, 281);
            this.lblSaldoCliente.Name = "lblSaldoCliente";
            this.lblSaldoCliente.Size = new System.Drawing.Size(119, 18);
            this.lblSaldoCliente.TabIndex = 6;
            this.lblSaldoCliente.Text = "Saldo del cliente:";
            // 
            // txtClaveCliente
            // 
            this.txtClaveCliente.Location = new System.Drawing.Point(21, 228);
            this.txtClaveCliente.Name = "txtClaveCliente";
            this.txtClaveCliente.Size = new System.Drawing.Size(310, 24);
            this.txtClaveCliente.TabIndex = 5;
            // 
            // lblClaveCliente
            // 
            this.lblClaveCliente.AutoSize = true;
            this.lblClaveCliente.Location = new System.Drawing.Point(18, 194);
            this.lblClaveCliente.Name = "lblClaveCliente";
            this.lblClaveCliente.Size = new System.Drawing.Size(111, 18);
            this.lblClaveCliente.TabIndex = 4;
            this.lblClaveCliente.Text = "Introduce clave:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(21, 143);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(310, 24);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(18, 109);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(135, 18);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre del cliente:";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(21, 66);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(310, 24);
            this.txtDniCliente.TabIndex = 1;
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(18, 32);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(106, 18);
            this.lblDniCliente.TabIndex = 0;
            this.lblDniCliente.Text = "DNI del cliente:";
            // 
            // gBoxFormularioCajero
            // 
            this.gBoxFormularioCajero.Controls.Add(this.txtClaveCajero);
            this.gBoxFormularioCajero.Controls.Add(this.lblClave);
            this.gBoxFormularioCajero.Controls.Add(this.btnAceptarFormCajero);
            this.gBoxFormularioCajero.Controls.Add(this.btnCancelarFormCajero);
            this.gBoxFormularioCajero.Controls.Add(this.txtDniCajero);
            this.gBoxFormularioCajero.Controls.Add(this.lblDniClienteCajero);
            this.gBoxFormularioCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gBoxFormularioCajero.Location = new System.Drawing.Point(834, 40);
            this.gBoxFormularioCajero.Name = "gBoxFormularioCajero";
            this.gBoxFormularioCajero.Size = new System.Drawing.Size(369, 431);
            this.gBoxFormularioCajero.TabIndex = 12;
            this.gBoxFormularioCajero.TabStop = false;
            this.gBoxFormularioCajero.Text = "Acceso cajero";
            this.gBoxFormularioCajero.Visible = false;
            // 
            // txtClaveCajero
            // 
            this.txtClaveCajero.Location = new System.Drawing.Point(24, 143);
            this.txtClaveCajero.Name = "txtClaveCajero";
            this.txtClaveCajero.PasswordChar = '*';
            this.txtClaveCajero.Size = new System.Drawing.Size(310, 24);
            this.txtClaveCajero.TabIndex = 10;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(21, 109);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(114, 18);
            this.lblClave.TabIndex = 9;
            this.lblClave.Text = "Introduce Clave:";
            // 
            // btnAceptarFormCajero
            // 
            this.btnAceptarFormCajero.Location = new System.Drawing.Point(202, 194);
            this.btnAceptarFormCajero.Name = "btnAceptarFormCajero";
            this.btnAceptarFormCajero.Size = new System.Drawing.Size(123, 48);
            this.btnAceptarFormCajero.TabIndex = 8;
            this.btnAceptarFormCajero.Text = "ACEPTAR";
            this.btnAceptarFormCajero.UseVisualStyleBackColor = true;
            this.btnAceptarFormCajero.Click += new System.EventHandler(this.btnAceptarFormCajero_Click);
            // 
            // btnCancelarFormCajero
            // 
            this.btnCancelarFormCajero.Location = new System.Drawing.Point(31, 194);
            this.btnCancelarFormCajero.Name = "btnCancelarFormCajero";
            this.btnCancelarFormCajero.Size = new System.Drawing.Size(123, 48);
            this.btnCancelarFormCajero.TabIndex = 2;
            this.btnCancelarFormCajero.Text = "CANCELAR";
            this.btnCancelarFormCajero.UseVisualStyleBackColor = true;
            this.btnCancelarFormCajero.Click += new System.EventHandler(this.btnCancelarFormCajero_Click);
            // 
            // txtDniCajero
            // 
            this.txtDniCajero.Location = new System.Drawing.Point(21, 66);
            this.txtDniCajero.Name = "txtDniCajero";
            this.txtDniCajero.Size = new System.Drawing.Size(310, 24);
            this.txtDniCajero.TabIndex = 3;
            // 
            // lblDniClienteCajero
            // 
            this.lblDniClienteCajero.AutoSize = true;
            this.lblDniClienteCajero.Location = new System.Drawing.Point(18, 32);
            this.lblDniClienteCajero.Name = "lblDniClienteCajero";
            this.lblDniClienteCajero.Size = new System.Drawing.Size(102, 18);
            this.lblDniClienteCajero.TabIndex = 2;
            this.lblDniClienteCajero.Text = "Introduce DNI:";
            // 
            // gBoxConsultas
            // 
            this.gBoxConsultas.Controls.Add(this.chkBoxBloqueoConsulta);
            this.gBoxConsultas.Controls.Add(this.lblSaldoConsulta);
            this.gBoxConsultas.Controls.Add(this.lblDniConsulta);
            this.gBoxConsultas.Controls.Add(this.btnAceptarConsulta);
            this.gBoxConsultas.Controls.Add(this.btnCancelarConsulta);
            this.gBoxConsultas.Controls.Add(this.txtNombreClienteConsulta);
            this.gBoxConsultas.Controls.Add(this.lblNombreClienteConsulta);
            this.gBoxConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gBoxConsultas.Location = new System.Drawing.Point(420, 40);
            this.gBoxConsultas.Name = "gBoxConsultas";
            this.gBoxConsultas.Size = new System.Drawing.Size(369, 431);
            this.gBoxConsultas.TabIndex = 9;
            this.gBoxConsultas.TabStop = false;
            this.gBoxConsultas.Text = "CONSULTAS";
            this.gBoxConsultas.Visible = false;
            // 
            // chkBoxBloqueoConsulta
            // 
            this.chkBoxBloqueoConsulta.AutoSize = true;
            this.chkBoxBloqueoConsulta.Location = new System.Drawing.Point(21, 277);
            this.chkBoxBloqueoConsulta.Name = "chkBoxBloqueoConsulta";
            this.chkBoxBloqueoConsulta.Size = new System.Drawing.Size(82, 22);
            this.chkBoxBloqueoConsulta.TabIndex = 11;
            this.chkBoxBloqueoConsulta.Text = "Bloqueo";
            this.chkBoxBloqueoConsulta.UseVisualStyleBackColor = true;
            this.chkBoxBloqueoConsulta.Visible = false;
            // 
            // lblSaldoConsulta
            // 
            this.lblSaldoConsulta.AutoSize = true;
            this.lblSaldoConsulta.Location = new System.Drawing.Point(18, 234);
            this.lblSaldoConsulta.Name = "lblSaldoConsulta";
            this.lblSaldoConsulta.Size = new System.Drawing.Size(44, 18);
            this.lblSaldoConsulta.TabIndex = 10;
            this.lblSaldoConsulta.Text = "saldo";
            this.lblSaldoConsulta.Visible = false;
            // 
            // lblDniConsulta
            // 
            this.lblDniConsulta.AutoSize = true;
            this.lblDniConsulta.Location = new System.Drawing.Point(18, 194);
            this.lblDniConsulta.Name = "lblDniConsulta";
            this.lblDniConsulta.Size = new System.Drawing.Size(72, 18);
            this.lblDniConsulta.TabIndex = 9;
            this.lblDniConsulta.Text = "dniCliente";
            this.lblDniConsulta.Visible = false;
            // 
            // btnAceptarConsulta
            // 
            this.btnAceptarConsulta.Location = new System.Drawing.Point(192, 109);
            this.btnAceptarConsulta.Name = "btnAceptarConsulta";
            this.btnAceptarConsulta.Size = new System.Drawing.Size(123, 48);
            this.btnAceptarConsulta.TabIndex = 8;
            this.btnAceptarConsulta.Text = "ACEPTAR";
            this.btnAceptarConsulta.UseVisualStyleBackColor = true;
            this.btnAceptarConsulta.Click += new System.EventHandler(this.btnAceptarConsulta_Click);
            // 
            // btnCancelarConsulta
            // 
            this.btnCancelarConsulta.Location = new System.Drawing.Point(21, 109);
            this.btnCancelarConsulta.Name = "btnCancelarConsulta";
            this.btnCancelarConsulta.Size = new System.Drawing.Size(123, 48);
            this.btnCancelarConsulta.TabIndex = 2;
            this.btnCancelarConsulta.Text = "CANCELAR";
            this.btnCancelarConsulta.UseVisualStyleBackColor = true;
            this.btnCancelarConsulta.Click += new System.EventHandler(this.btnCancelarConsulta_Click);
            // 
            // txtNombreClienteConsulta
            // 
            this.txtNombreClienteConsulta.Location = new System.Drawing.Point(21, 66);
            this.txtNombreClienteConsulta.Name = "txtNombreClienteConsulta";
            this.txtNombreClienteConsulta.Size = new System.Drawing.Size(310, 24);
            this.txtNombreClienteConsulta.TabIndex = 3;
            // 
            // lblNombreClienteConsulta
            // 
            this.lblNombreClienteConsulta.AutoSize = true;
            this.lblNombreClienteConsulta.Location = new System.Drawing.Point(18, 32);
            this.lblNombreClienteConsulta.Name = "lblNombreClienteConsulta";
            this.lblNombreClienteConsulta.Size = new System.Drawing.Size(135, 18);
            this.lblNombreClienteConsulta.TabIndex = 2;
            this.lblNombreClienteConsulta.Text = "Nombre del cliente:";
            // 
            // gBoxBloquearDesbloquear
            // 
            this.gBoxBloquearDesbloquear.Controls.Add(this.btnDesBlo);
            this.gBoxBloquearDesbloquear.Controls.Add(this.txtClaveBloDes);
            this.gBoxBloquearDesbloquear.Controls.Add(this.lblClaveBloDes);
            this.gBoxBloquearDesbloquear.Controls.Add(this.btnAceptarBloDes);
            this.gBoxBloquearDesbloquear.Controls.Add(this.btnCancelarBloDes);
            this.gBoxBloquearDesbloquear.Controls.Add(this.txtDniBloDes);
            this.gBoxBloquearDesbloquear.Controls.Add(this.lblDniBloDes);
            this.gBoxBloquearDesbloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gBoxBloquearDesbloquear.Location = new System.Drawing.Point(420, 40);
            this.gBoxBloquearDesbloquear.Name = "gBoxBloquearDesbloquear";
            this.gBoxBloquearDesbloquear.Size = new System.Drawing.Size(369, 431);
            this.gBoxBloquearDesbloquear.TabIndex = 13;
            this.gBoxBloquearDesbloquear.TabStop = false;
            this.gBoxBloquearDesbloquear.Text = "Bloquear/Desbloquear";
            this.gBoxBloquearDesbloquear.Visible = false;
            // 
            // txtClaveBloDes
            // 
            this.txtClaveBloDes.Location = new System.Drawing.Point(24, 143);
            this.txtClaveBloDes.Name = "txtClaveBloDes";
            this.txtClaveBloDes.PasswordChar = '*';
            this.txtClaveBloDes.Size = new System.Drawing.Size(310, 24);
            this.txtClaveBloDes.TabIndex = 10;
            // 
            // lblClaveBloDes
            // 
            this.lblClaveBloDes.AutoSize = true;
            this.lblClaveBloDes.Location = new System.Drawing.Point(21, 109);
            this.lblClaveBloDes.Name = "lblClaveBloDes";
            this.lblClaveBloDes.Size = new System.Drawing.Size(114, 18);
            this.lblClaveBloDes.TabIndex = 9;
            this.lblClaveBloDes.Text = "Introduce Clave:";
            // 
            // btnAceptarBloDes
            // 
            this.btnAceptarBloDes.Location = new System.Drawing.Point(202, 194);
            this.btnAceptarBloDes.Name = "btnAceptarBloDes";
            this.btnAceptarBloDes.Size = new System.Drawing.Size(123, 48);
            this.btnAceptarBloDes.TabIndex = 8;
            this.btnAceptarBloDes.Text = "ACEPTAR";
            this.btnAceptarBloDes.UseVisualStyleBackColor = true;
            this.btnAceptarBloDes.Click += new System.EventHandler(this.btnAceptarBloDes_Click);
            // 
            // btnCancelarBloDes
            // 
            this.btnCancelarBloDes.Location = new System.Drawing.Point(31, 194);
            this.btnCancelarBloDes.Name = "btnCancelarBloDes";
            this.btnCancelarBloDes.Size = new System.Drawing.Size(123, 48);
            this.btnCancelarBloDes.TabIndex = 2;
            this.btnCancelarBloDes.Text = "CANCELAR";
            this.btnCancelarBloDes.UseVisualStyleBackColor = true;
            // 
            // txtDniBloDes
            // 
            this.txtDniBloDes.Location = new System.Drawing.Point(21, 66);
            this.txtDniBloDes.Name = "txtDniBloDes";
            this.txtDniBloDes.Size = new System.Drawing.Size(310, 24);
            this.txtDniBloDes.TabIndex = 3;
            // 
            // lblDniBloDes
            // 
            this.lblDniBloDes.AutoSize = true;
            this.lblDniBloDes.Location = new System.Drawing.Point(18, 32);
            this.lblDniBloDes.Name = "lblDniBloDes";
            this.lblDniBloDes.Size = new System.Drawing.Size(102, 18);
            this.lblDniBloDes.TabIndex = 2;
            this.lblDniBloDes.Text = "Introduce DNI:";
            // 
            // btnDesBlo
            // 
            this.btnDesBlo.Location = new System.Drawing.Point(109, 281);
            this.btnDesBlo.Name = "btnDesBlo";
            this.btnDesBlo.Size = new System.Drawing.Size(123, 48);
            this.btnDesBlo.TabIndex = 11;
            this.btnDesBlo.Text = "Bloquear";
            this.btnDesBlo.UseVisualStyleBackColor = true;
            this.btnDesBlo.Visible = false;
            // 
            // FormCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 511);
            this.Controls.Add(this.gBoxBloquearDesbloquear);
            this.Controls.Add(this.gBoxFormularioCajero);
            this.Controls.Add(this.gBoxConsultas);
            this.Controls.Add(this.gBoxAltasCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCajero";
            this.Text = "Cajero automatico de banco - Miguel Sanchez Garcia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBoxAltasCliente.ResumeLayout(false);
            this.gBoxAltasCliente.PerformLayout();
            this.gBoxFormularioCajero.ResumeLayout(false);
            this.gBoxFormularioCajero.PerformLayout();
            this.gBoxConsultas.ResumeLayout(false);
            this.gBoxConsultas.PerformLayout();
            this.gBoxBloquearDesbloquear.ResumeLayout(false);
            this.gBoxBloquearDesbloquear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLOQUEARDESBLOQUEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxAltasCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.TextBox txtSaldoCliente;
        private System.Windows.Forms.Label lblSaldoCliente;
        private System.Windows.Forms.TextBox txtClaveCliente;
        private System.Windows.Forms.Label lblClaveCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Button btnAceptarAlta;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.GroupBox gBoxConsultas;
        private System.Windows.Forms.Button btnAceptarConsulta;
        private System.Windows.Forms.Button btnCancelarConsulta;
        private System.Windows.Forms.TextBox txtNombreClienteConsulta;
        private System.Windows.Forms.Label lblNombreClienteConsulta;
        private System.Windows.Forms.Label lblDniConsulta;
        private System.Windows.Forms.Label lblSaldoConsulta;
        private System.Windows.Forms.CheckBox chkBoxBloqueoConsulta;
        private System.Windows.Forms.GroupBox gBoxFormularioCajero;
        private System.Windows.Forms.Button btnAceptarFormCajero;
        private System.Windows.Forms.Button btnCancelarFormCajero;
        private System.Windows.Forms.TextBox txtDniCajero;
        private System.Windows.Forms.Label lblDniClienteCajero;
        private System.Windows.Forms.TextBox txtClaveCajero;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.GroupBox gBoxBloquearDesbloquear;
        private System.Windows.Forms.TextBox txtClaveBloDes;
        private System.Windows.Forms.Label lblClaveBloDes;
        private System.Windows.Forms.Button btnAceptarBloDes;
        private System.Windows.Forms.Button btnCancelarBloDes;
        private System.Windows.Forms.TextBox txtDniBloDes;
        private System.Windows.Forms.Label lblDniBloDes;
        private System.Windows.Forms.Button btnDesBlo;
    }
}

