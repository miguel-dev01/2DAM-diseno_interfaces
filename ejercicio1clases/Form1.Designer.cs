namespace ejercicio1clases
{
    partial class FormArticulos
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
            this.gBoxAltas = new System.Windows.Forms.GroupBox();
            this.btnCancelarAltas = new System.Windows.Forms.Button();
            this.cBoxCategoriaAltas = new System.Windows.Forms.ComboBox();
            this.lblMsgAltas = new System.Windows.Forms.Label();
            this.btnAceptarAltas = new System.Windows.Forms.Button();
            this.txtExistenciasAltas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioAltas = new System.Windows.Forms.TextBox();
            this.lblPrecioAltas = new System.Windows.Forms.Label();
            this.lblCategoriaAltas = new System.Windows.Forms.Label();
            this.txtNombreAltas = new System.Windows.Forms.TextBox();
            this.lblNombreAltas = new System.Windows.Forms.Label();
            this.txtCodigoAltas = new System.Windows.Forms.TextBox();
            this.lblCodigoAltas = new System.Windows.Forms.Label();
            this.btnCancelarConsultas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCódigoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarListadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxConsultas = new System.Windows.Forms.GroupBox();
            this.btnAceptarConsultas = new System.Windows.Forms.Button();
            this.txtNombreConsulta = new System.Windows.Forms.TextBox();
            this.txtCogidoConsulta = new System.Windows.Forms.TextBox();
            this.lblCodigoConsulta = new System.Windows.Forms.Label();
            this.lblNombreConsulta = new System.Windows.Forms.Label();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.lBoxListados = new System.Windows.Forms.ListBox();
            this.lblCategoriaListBox = new System.Windows.Forms.Label();
            this.cBoxCategoriasListBox = new System.Windows.Forms.ComboBox();
            this.gBoxPedido = new System.Windows.Forms.GroupBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.lblMensajePedido = new System.Windows.Forms.Label();
            this.btnAceptarPedido = new System.Windows.Forms.Button();
            this.txtCantidadPedido = new System.Windows.Forms.TextBox();
            this.lblCantidadPedido = new System.Windows.Forms.Label();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.lblMensajeAutor = new System.Windows.Forms.Label();
            this.gBoxAltas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gBoxConsultas.SuspendLayout();
            this.gBoxPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxAltas
            // 
            this.gBoxAltas.Controls.Add(this.btnCancelarAltas);
            this.gBoxAltas.Controls.Add(this.cBoxCategoriaAltas);
            this.gBoxAltas.Controls.Add(this.lblMsgAltas);
            this.gBoxAltas.Controls.Add(this.btnAceptarAltas);
            this.gBoxAltas.Controls.Add(this.txtExistenciasAltas);
            this.gBoxAltas.Controls.Add(this.label4);
            this.gBoxAltas.Controls.Add(this.txtPrecioAltas);
            this.gBoxAltas.Controls.Add(this.lblPrecioAltas);
            this.gBoxAltas.Controls.Add(this.lblCategoriaAltas);
            this.gBoxAltas.Controls.Add(this.txtNombreAltas);
            this.gBoxAltas.Controls.Add(this.lblNombreAltas);
            this.gBoxAltas.Controls.Add(this.txtCodigoAltas);
            this.gBoxAltas.Controls.Add(this.lblCodigoAltas);
            this.gBoxAltas.Location = new System.Drawing.Point(24, 137);
            this.gBoxAltas.Name = "gBoxAltas";
            this.gBoxAltas.Size = new System.Drawing.Size(460, 364);
            this.gBoxAltas.TabIndex = 0;
            this.gBoxAltas.TabStop = false;
            this.gBoxAltas.Text = "ALTAS";
            this.gBoxAltas.Visible = false;
            // 
            // btnCancelarAltas
            // 
            this.btnCancelarAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelarAltas.Location = new System.Drawing.Point(225, 215);
            this.btnCancelarAltas.Name = "btnCancelarAltas";
            this.btnCancelarAltas.Size = new System.Drawing.Size(110, 45);
            this.btnCancelarAltas.TabIndex = 14;
            this.btnCancelarAltas.Text = "Cancelar";
            this.btnCancelarAltas.UseVisualStyleBackColor = true;
            this.btnCancelarAltas.Click += new System.EventHandler(this.btnCancelarAltas_Click);
            // 
            // cBoxCategoriaAltas
            // 
            this.cBoxCategoriaAltas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategoriaAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cBoxCategoriaAltas.FormattingEnabled = true;
            this.cBoxCategoriaAltas.Location = new System.Drawing.Point(104, 98);
            this.cBoxCategoriaAltas.Name = "cBoxCategoriaAltas";
            this.cBoxCategoriaAltas.Size = new System.Drawing.Size(240, 28);
            this.cBoxCategoriaAltas.TabIndex = 2;
            // 
            // lblMsgAltas
            // 
            this.lblMsgAltas.AutoSize = true;
            this.lblMsgAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMsgAltas.Location = new System.Drawing.Point(16, 304);
            this.lblMsgAltas.Name = "lblMsgAltas";
            this.lblMsgAltas.Size = new System.Drawing.Size(69, 20);
            this.lblMsgAltas.TabIndex = 12;
            this.lblMsgAltas.Text = "Mensaje";
            this.lblMsgAltas.Visible = false;
            // 
            // btnAceptarAltas
            // 
            this.btnAceptarAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAceptarAltas.Location = new System.Drawing.Point(103, 215);
            this.btnAceptarAltas.Name = "btnAceptarAltas";
            this.btnAceptarAltas.Size = new System.Drawing.Size(116, 45);
            this.btnAceptarAltas.TabIndex = 10;
            this.btnAceptarAltas.Text = "Aceptar";
            this.btnAceptarAltas.UseVisualStyleBackColor = true;
            this.btnAceptarAltas.Click += new System.EventHandler(this.btnAceptarAltas_Click);
            // 
            // txtExistenciasAltas
            // 
            this.txtExistenciasAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtExistenciasAltas.Location = new System.Drawing.Point(104, 171);
            this.txtExistenciasAltas.Name = "txtExistenciasAltas";
            this.txtExistenciasAltas.Size = new System.Drawing.Size(240, 26);
            this.txtExistenciasAltas.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(5, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Existencias:";
            // 
            // txtPrecioAltas
            // 
            this.txtPrecioAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecioAltas.Location = new System.Drawing.Point(104, 136);
            this.txtPrecioAltas.Name = "txtPrecioAltas";
            this.txtPrecioAltas.Size = new System.Drawing.Size(240, 26);
            this.txtPrecioAltas.TabIndex = 7;
            // 
            // lblPrecioAltas
            // 
            this.lblPrecioAltas.AutoSize = true;
            this.lblPrecioAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrecioAltas.Location = new System.Drawing.Point(41, 139);
            this.lblPrecioAltas.Name = "lblPrecioAltas";
            this.lblPrecioAltas.Size = new System.Drawing.Size(57, 20);
            this.lblPrecioAltas.TabIndex = 6;
            this.lblPrecioAltas.Text = "Precio:";
            // 
            // lblCategoriaAltas
            // 
            this.lblCategoriaAltas.AutoSize = true;
            this.lblCategoriaAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategoriaAltas.Location = new System.Drawing.Point(16, 101);
            this.lblCategoriaAltas.Name = "lblCategoriaAltas";
            this.lblCategoriaAltas.Size = new System.Drawing.Size(82, 20);
            this.lblCategoriaAltas.TabIndex = 4;
            this.lblCategoriaAltas.Text = "Categoria:";
            // 
            // txtNombreAltas
            // 
            this.txtNombreAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreAltas.Location = new System.Drawing.Point(104, 66);
            this.txtNombreAltas.Name = "txtNombreAltas";
            this.txtNombreAltas.Size = new System.Drawing.Size(240, 26);
            this.txtNombreAltas.TabIndex = 3;
            // 
            // lblNombreAltas
            // 
            this.lblNombreAltas.AutoSize = true;
            this.lblNombreAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombreAltas.Location = new System.Drawing.Point(29, 69);
            this.lblNombreAltas.Name = "lblNombreAltas";
            this.lblNombreAltas.Size = new System.Drawing.Size(69, 20);
            this.lblNombreAltas.TabIndex = 2;
            this.lblNombreAltas.Text = "Nombre:";
            // 
            // txtCodigoAltas
            // 
            this.txtCodigoAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoAltas.Location = new System.Drawing.Point(104, 30);
            this.txtCodigoAltas.Name = "txtCodigoAltas";
            this.txtCodigoAltas.Size = new System.Drawing.Size(240, 26);
            this.txtCodigoAltas.TabIndex = 1;
            // 
            // lblCodigoAltas
            // 
            this.lblCodigoAltas.AutoSize = true;
            this.lblCodigoAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCodigoAltas.Location = new System.Drawing.Point(35, 33);
            this.lblCodigoAltas.Name = "lblCodigoAltas";
            this.lblCodigoAltas.Size = new System.Drawing.Size(63, 20);
            this.lblCodigoAltas.TabIndex = 0;
            this.lblCodigoAltas.Text = "Codigo:";
            // 
            // btnCancelarConsultas
            // 
            this.btnCancelarConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelarConsultas.Location = new System.Drawing.Point(362, 36);
            this.btnCancelarConsultas.Name = "btnCancelarConsultas";
            this.btnCancelarConsultas.Size = new System.Drawing.Size(76, 32);
            this.btnCancelarConsultas.TabIndex = 11;
            this.btnCancelarConsultas.Text = "Cancelar";
            this.btnCancelarConsultas.UseVisualStyleBackColor = true;
            this.btnCancelarConsultas.Click += new System.EventHandler(this.btnCancelarConsultas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.altasToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCódigoArticuloToolStripMenuItem,
            this.porNombreToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // porCódigoArticuloToolStripMenuItem
            // 
            this.porCódigoArticuloToolStripMenuItem.Name = "porCódigoArticuloToolStripMenuItem";
            this.porCódigoArticuloToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.porCódigoArticuloToolStripMenuItem.Text = "Por código articulo";
            this.porCódigoArticuloToolStripMenuItem.Click += new System.EventHandler(this.porCódigoArticuloToolStripMenuItem_Click);
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.porNombreToolStripMenuItem.Text = "Por nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porNombreToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimosToolStripMenuItem,
            this.porCategoriaToolStripMenuItem,
            this.todosToolStripMenuItem,
            this.cancelarListadosToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // minimosToolStripMenuItem
            // 
            this.minimosToolStripMenuItem.Name = "minimosToolStripMenuItem";
            this.minimosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.minimosToolStripMenuItem.Text = "Minimos";
            this.minimosToolStripMenuItem.Click += new System.EventHandler(this.minimosToolStripMenuItem_Click);
            // 
            // porCategoriaToolStripMenuItem
            // 
            this.porCategoriaToolStripMenuItem.Name = "porCategoriaToolStripMenuItem";
            this.porCategoriaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.porCategoriaToolStripMenuItem.Text = "Por categoria";
            this.porCategoriaToolStripMenuItem.Click += new System.EventHandler(this.porCategoriaToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // cancelarListadosToolStripMenuItem
            // 
            this.cancelarListadosToolStripMenuItem.Name = "cancelarListadosToolStripMenuItem";
            this.cancelarListadosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cancelarListadosToolStripMenuItem.Text = "Cancelar listados";
            this.cancelarListadosToolStripMenuItem.Click += new System.EventHandler(this.cancelarListadosToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // gBoxConsultas
            // 
            this.gBoxConsultas.Controls.Add(this.btnAceptarConsultas);
            this.gBoxConsultas.Controls.Add(this.txtNombreConsulta);
            this.gBoxConsultas.Controls.Add(this.btnCancelarConsultas);
            this.gBoxConsultas.Controls.Add(this.txtCogidoConsulta);
            this.gBoxConsultas.Controls.Add(this.lblCodigoConsulta);
            this.gBoxConsultas.Controls.Add(this.lblNombreConsulta);
            this.gBoxConsultas.Location = new System.Drawing.Point(24, 27);
            this.gBoxConsultas.Name = "gBoxConsultas";
            this.gBoxConsultas.Size = new System.Drawing.Size(460, 91);
            this.gBoxConsultas.TabIndex = 13;
            this.gBoxConsultas.TabStop = false;
            this.gBoxConsultas.Text = "CONSULTAS";
            this.gBoxConsultas.Visible = false;
            // 
            // btnAceptarConsultas
            // 
            this.btnAceptarConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAceptarConsultas.Location = new System.Drawing.Point(272, 36);
            this.btnAceptarConsultas.Name = "btnAceptarConsultas";
            this.btnAceptarConsultas.Size = new System.Drawing.Size(84, 32);
            this.btnAceptarConsultas.TabIndex = 13;
            this.btnAceptarConsultas.Text = "Aceptar";
            this.btnAceptarConsultas.UseVisualStyleBackColor = true;
            this.btnAceptarConsultas.Click += new System.EventHandler(this.btnAceptarConsultas_Click);
            // 
            // txtNombreConsulta
            // 
            this.txtNombreConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombreConsulta.Location = new System.Drawing.Point(98, 41);
            this.txtNombreConsulta.Name = "txtNombreConsulta";
            this.txtNombreConsulta.Size = new System.Drawing.Size(168, 23);
            this.txtNombreConsulta.TabIndex = 7;
            this.txtNombreConsulta.Visible = false;
            // 
            // txtCogidoConsulta
            // 
            this.txtCogidoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCogidoConsulta.Location = new System.Drawing.Point(98, 41);
            this.txtCogidoConsulta.Name = "txtCogidoConsulta";
            this.txtCogidoConsulta.Size = new System.Drawing.Size(168, 23);
            this.txtCogidoConsulta.TabIndex = 5;
            this.txtCogidoConsulta.Visible = false;
            // 
            // lblCodigoConsulta
            // 
            this.lblCodigoConsulta.AutoSize = true;
            this.lblCodigoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigoConsulta.Location = new System.Drawing.Point(29, 44);
            this.lblCodigoConsulta.Name = "lblCodigoConsulta";
            this.lblCodigoConsulta.Size = new System.Drawing.Size(56, 17);
            this.lblCodigoConsulta.TabIndex = 4;
            this.lblCodigoConsulta.Text = "Codigo:";
            this.lblCodigoConsulta.Visible = false;
            // 
            // lblNombreConsulta
            // 
            this.lblNombreConsulta.AutoSize = true;
            this.lblNombreConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombreConsulta.Location = new System.Drawing.Point(30, 44);
            this.lblNombreConsulta.Name = "lblNombreConsulta";
            this.lblNombreConsulta.Size = new System.Drawing.Size(62, 17);
            this.lblNombreConsulta.TabIndex = 6;
            this.lblNombreConsulta.Text = "Nombre:";
            this.lblNombreConsulta.Visible = false;
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConsultas.Location = new System.Drawing.Point(502, 37);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(84, 17);
            this.lblConsultas.TabIndex = 14;
            this.lblConsultas.Text = "lblConsultas";
            this.lblConsultas.Visible = false;
            // 
            // lBoxListados
            // 
            this.lBoxListados.FormattingEnabled = true;
            this.lBoxListados.Location = new System.Drawing.Point(505, 146);
            this.lBoxListados.Name = "lBoxListados";
            this.lBoxListados.Size = new System.Drawing.Size(504, 355);
            this.lBoxListados.TabIndex = 15;
            this.lBoxListados.Visible = false;
            // 
            // lblCategoriaListBox
            // 
            this.lblCategoriaListBox.AutoSize = true;
            this.lblCategoriaListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCategoriaListBox.Location = new System.Drawing.Point(505, 120);
            this.lblCategoriaListBox.Name = "lblCategoriaListBox";
            this.lblCategoriaListBox.Size = new System.Drawing.Size(117, 17);
            this.lblCategoriaListBox.TabIndex = 14;
            this.lblCategoriaListBox.Text = "Escoja categoria:";
            this.lblCategoriaListBox.Visible = false;
            // 
            // cBoxCategoriasListBox
            // 
            this.cBoxCategoriasListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategoriasListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cBoxCategoriasListBox.FormattingEnabled = true;
            this.cBoxCategoriasListBox.Location = new System.Drawing.Point(628, 116);
            this.cBoxCategoriasListBox.Name = "cBoxCategoriasListBox";
            this.cBoxCategoriasListBox.Size = new System.Drawing.Size(114, 24);
            this.cBoxCategoriasListBox.TabIndex = 16;
            this.cBoxCategoriasListBox.Visible = false;
            this.cBoxCategoriasListBox.SelectedIndexChanged += new System.EventHandler(this.cBoxCategoriasListBox_SelectedIndexChanged);
            // 
            // gBoxPedido
            // 
            this.gBoxPedido.Controls.Add(this.btnCancelarPedido);
            this.gBoxPedido.Controls.Add(this.lblMensajePedido);
            this.gBoxPedido.Controls.Add(this.btnAceptarPedido);
            this.gBoxPedido.Controls.Add(this.txtCantidadPedido);
            this.gBoxPedido.Controls.Add(this.lblCantidadPedido);
            this.gBoxPedido.Controls.Add(this.txtCodigoPedido);
            this.gBoxPedido.Controls.Add(this.lblCodigoPedido);
            this.gBoxPedido.Location = new System.Drawing.Point(505, 27);
            this.gBoxPedido.Name = "gBoxPedido";
            this.gBoxPedido.Size = new System.Drawing.Size(504, 474);
            this.gBoxPedido.TabIndex = 15;
            this.gBoxPedido.TabStop = false;
            this.gBoxPedido.Text = "PEDIDOS";
            this.gBoxPedido.Visible = false;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelarPedido.Location = new System.Drawing.Point(263, 109);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(100, 44);
            this.btnCancelarPedido.TabIndex = 14;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // lblMensajePedido
            // 
            this.lblMensajePedido.AutoSize = true;
            this.lblMensajePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMensajePedido.Location = new System.Drawing.Point(29, 198);
            this.lblMensajePedido.Name = "lblMensajePedido";
            this.lblMensajePedido.Size = new System.Drawing.Size(69, 20);
            this.lblMensajePedido.TabIndex = 12;
            this.lblMensajePedido.Text = "Mensaje";
            this.lblMensajePedido.Visible = false;
            // 
            // btnAceptarPedido
            // 
            this.btnAceptarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAceptarPedido.Location = new System.Drawing.Point(151, 109);
            this.btnAceptarPedido.Name = "btnAceptarPedido";
            this.btnAceptarPedido.Size = new System.Drawing.Size(106, 44);
            this.btnAceptarPedido.TabIndex = 10;
            this.btnAceptarPedido.Text = "Aceptar";
            this.btnAceptarPedido.UseVisualStyleBackColor = true;
            this.btnAceptarPedido.Click += new System.EventHandler(this.btnAceptarPedido_Click);
            // 
            // txtCantidadPedido
            // 
            this.txtCantidadPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCantidadPedido.Location = new System.Drawing.Point(123, 70);
            this.txtCantidadPedido.Name = "txtCantidadPedido";
            this.txtCantidadPedido.Size = new System.Drawing.Size(240, 26);
            this.txtCantidadPedido.TabIndex = 3;
            // 
            // lblCantidadPedido
            // 
            this.lblCantidadPedido.AutoSize = true;
            this.lblCantidadPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCantidadPedido.Location = new System.Drawing.Point(40, 70);
            this.lblCantidadPedido.Name = "lblCantidadPedido";
            this.lblCantidadPedido.Size = new System.Drawing.Size(77, 20);
            this.lblCantidadPedido.TabIndex = 2;
            this.lblCantidadPedido.Text = "Cantidad:";
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigoPedido.Location = new System.Drawing.Point(123, 38);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(240, 26);
            this.txtCodigoPedido.TabIndex = 1;
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCodigoPedido.Location = new System.Drawing.Point(54, 38);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(63, 20);
            this.lblCodigoPedido.TabIndex = 0;
            this.lblCodigoPedido.Text = "Codigo:";
            // 
            // lblMensajeAutor
            // 
            this.lblMensajeAutor.AutoSize = true;
            this.lblMensajeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMensajeAutor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMensajeAutor.Location = new System.Drawing.Point(38, 513);
            this.lblMensajeAutor.Name = "lblMensajeAutor";
            this.lblMensajeAutor.Size = new System.Drawing.Size(368, 31);
            this.lblMensajeAutor.TabIndex = 17;
            this.lblMensajeAutor.Text = "MIGUEL SANCHEZ GARCIA";
            this.lblMensajeAutor.Visible = false;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 573);
            this.Controls.Add(this.lblMensajeAutor);
            this.Controls.Add(this.gBoxPedido);
            this.Controls.Add(this.cBoxCategoriasListBox);
            this.Controls.Add(this.lblCategoriaListBox);
            this.Controls.Add(this.lBoxListados);
            this.Controls.Add(this.lblConsultas);
            this.Controls.Add(this.gBoxConsultas);
            this.Controls.Add(this.gBoxAltas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormArticulos";
            this.Text = "Articulos - Miguel Sanchez";
            this.gBoxAltas.ResumeLayout(false);
            this.gBoxAltas.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBoxConsultas.ResumeLayout(false);
            this.gBoxConsultas.PerformLayout();
            this.gBoxPedido.ResumeLayout(false);
            this.gBoxPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxAltas;
        private System.Windows.Forms.TextBox txtCodigoAltas;
        private System.Windows.Forms.Label lblCodigoAltas;
        private System.Windows.Forms.Label lblMsgAltas;
        private System.Windows.Forms.Button btnCancelarConsultas;
        private System.Windows.Forms.Button btnAceptarAltas;
        private System.Windows.Forms.TextBox txtExistenciasAltas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioAltas;
        private System.Windows.Forms.Label lblPrecioAltas;
        private System.Windows.Forms.Label lblCategoriaAltas;
        private System.Windows.Forms.TextBox txtNombreAltas;
        private System.Windows.Forms.Label lblNombreAltas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCódigoArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBoxCategoriaAltas;
        private System.Windows.Forms.GroupBox gBoxConsultas;
        private System.Windows.Forms.TextBox txtNombreConsulta;
        private System.Windows.Forms.Label lblNombreConsulta;
        private System.Windows.Forms.TextBox txtCogidoConsulta;
        private System.Windows.Forms.Label lblCodigoConsulta;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.ListBox lBoxListados;
        private System.Windows.Forms.Button btnAceptarConsultas;
        private System.Windows.Forms.Button btnCancelarAltas;
        private System.Windows.Forms.Label lblCategoriaListBox;
        private System.Windows.Forms.ComboBox cBoxCategoriasListBox;
        private System.Windows.Forms.GroupBox gBoxPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnAceptarPedido;
        private System.Windows.Forms.TextBox txtCantidadPedido;
        private System.Windows.Forms.Label lblCantidadPedido;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.Label lblMensajePedido;
        private System.Windows.Forms.ToolStripMenuItem cancelarListadosToolStripMenuItem;
        private System.Windows.Forms.Label lblMensajeAutor;
    }
}

