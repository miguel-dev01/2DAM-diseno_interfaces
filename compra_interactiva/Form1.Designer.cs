namespace compra_interactiva
{
    partial class Form
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
            this.lblTituloCompraInteractiva = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxEquipo = new System.Windows.Forms.GroupBox();
            this.rBtnPortatil = new System.Windows.Forms.RadioButton();
            this.rBtnMacintosh = new System.Windows.Forms.RadioButton();
            this.rBtnPC = new System.Windows.Forms.RadioButton();
            this.gBoxEquipoOficina = new System.Windows.Forms.GroupBox();
            this.chBoxFotocopiadora = new System.Windows.Forms.CheckBox();
            this.chBoxCalculadora = new System.Windows.Forms.CheckBox();
            this.chBoxContestador = new System.Windows.Forms.CheckBox();
            this.lblPerifericos = new System.Windows.Forms.Label();
            this.lBoxPerifericos = new System.Windows.Forms.ListBox();
            this.cBoxMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picBoxEquipo = new System.Windows.Forms.PictureBox();
            this.picBoxPerifericos = new System.Windows.Forms.PictureBox();
            this.picBoxMetodoPago = new System.Windows.Forms.PictureBox();
            this.picBoxEquipoOficina3 = new System.Windows.Forms.PictureBox();
            this.picBoxEquipoOficina2 = new System.Windows.Forms.PictureBox();
            this.picBoxEquipoOficina1 = new System.Windows.Forms.PictureBox();
            this.gBoxEquipo.SuspendLayout();
            this.gBoxEquipoOficina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPerifericos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMetodoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEquipoOficina3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEquipoOficina2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEquipoOficina1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCompraInteractiva
            // 
            this.lblTituloCompraInteractiva.AutoSize = true;
            this.lblTituloCompraInteractiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblTituloCompraInteractiva.Location = new System.Drawing.Point(12, 19);
            this.lblTituloCompraInteractiva.Name = "lblTituloCompraInteractiva";
            this.lblTituloCompraInteractiva.Size = new System.Drawing.Size(280, 29);
            this.lblTituloCompraInteractiva.TabIndex = 0;
            this.lblTituloCompraInteractiva.Text = "COMPRA INTERACTIVA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actualice su oficina comprando los productos que necesite\r\ncon casillas de verifi" +
    "cación, botones de opción y cuadros de lista.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label2.Location = new System.Drawing.Point(515, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRODUCTOS PEDIDOS";
            // 
            // gBoxEquipo
            // 
            this.gBoxEquipo.Controls.Add(this.rBtnPortatil);
            this.gBoxEquipo.Controls.Add(this.rBtnMacintosh);
            this.gBoxEquipo.Controls.Add(this.rBtnPC);
            this.gBoxEquipo.Location = new System.Drawing.Point(17, 177);
            this.gBoxEquipo.Name = "gBoxEquipo";
            this.gBoxEquipo.Size = new System.Drawing.Size(212, 156);
            this.gBoxEquipo.TabIndex = 3;
            this.gBoxEquipo.TabStop = false;
            this.gBoxEquipo.Text = "Equipo (necesario)";
            // 
            // rBtnPortatil
            // 
            this.rBtnPortatil.AutoSize = true;
            this.rBtnPortatil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnPortatil.Location = new System.Drawing.Point(16, 106);
            this.rBtnPortatil.Name = "rBtnPortatil";
            this.rBtnPortatil.Size = new System.Drawing.Size(126, 24);
            this.rBtnPortatil.TabIndex = 10;
            this.rBtnPortatil.TabStop = true;
            this.rBtnPortatil.Text = "Portátil (500€)";
            this.rBtnPortatil.UseVisualStyleBackColor = true;
            this.rBtnPortatil.CheckedChanged += new System.EventHandler(this.rBtnPortatil_CheckedChanged);
            // 
            // rBtnMacintosh
            // 
            this.rBtnMacintosh.AutoSize = true;
            this.rBtnMacintosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnMacintosh.Location = new System.Drawing.Point(16, 69);
            this.rBtnMacintosh.Name = "rBtnMacintosh";
            this.rBtnMacintosh.Size = new System.Drawing.Size(159, 24);
            this.rBtnMacintosh.TabIndex = 9;
            this.rBtnMacintosh.TabStop = true;
            this.rBtnMacintosh.Text = "Macintosh (1000€)";
            this.rBtnMacintosh.UseVisualStyleBackColor = true;
            this.rBtnMacintosh.CheckedChanged += new System.EventHandler(this.rBtnMacintosh_CheckedChanged);
            // 
            // rBtnPC
            // 
            this.rBtnPC.AutoSize = true;
            this.rBtnPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnPC.Location = new System.Drawing.Point(16, 33);
            this.rBtnPC.Name = "rBtnPC";
            this.rBtnPC.Size = new System.Drawing.Size(98, 24);
            this.rBtnPC.TabIndex = 8;
            this.rBtnPC.TabStop = true;
            this.rBtnPC.Text = "PC (700€)";
            this.rBtnPC.UseVisualStyleBackColor = true;
            this.rBtnPC.CheckedChanged += new System.EventHandler(this.rBtnPC_CheckedChanged);
            // 
            // gBoxEquipoOficina
            // 
            this.gBoxEquipoOficina.Controls.Add(this.chBoxFotocopiadora);
            this.gBoxEquipoOficina.Controls.Add(this.chBoxCalculadora);
            this.gBoxEquipoOficina.Controls.Add(this.chBoxContestador);
            this.gBoxEquipoOficina.Location = new System.Drawing.Point(17, 359);
            this.gBoxEquipoOficina.Name = "gBoxEquipoOficina";
            this.gBoxEquipoOficina.Size = new System.Drawing.Size(212, 156);
            this.gBoxEquipoOficina.TabIndex = 4;
            this.gBoxEquipoOficina.TabStop = false;
            this.gBoxEquipoOficina.Text = "Equipo de oficina (0-3)";
            // 
            // chBoxFotocopiadora
            // 
            this.chBoxFotocopiadora.AutoSize = true;
            this.chBoxFotocopiadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chBoxFotocopiadora.Location = new System.Drawing.Point(16, 111);
            this.chBoxFotocopiadora.Name = "chBoxFotocopiadora";
            this.chBoxFotocopiadora.Size = new System.Drawing.Size(181, 24);
            this.chBoxFotocopiadora.TabIndex = 10;
            this.chBoxFotocopiadora.Text = "Fotocopiadora (100€)";
            this.chBoxFotocopiadora.UseVisualStyleBackColor = true;
            this.chBoxFotocopiadora.CheckedChanged += new System.EventHandler(this.chBoxFotocopiadora_CheckedChanged);
            // 
            // chBoxCalculadora
            // 
            this.chBoxCalculadora.AutoSize = true;
            this.chBoxCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chBoxCalculadora.Location = new System.Drawing.Point(16, 73);
            this.chBoxCalculadora.Name = "chBoxCalculadora";
            this.chBoxCalculadora.Size = new System.Drawing.Size(153, 24);
            this.chBoxCalculadora.TabIndex = 9;
            this.chBoxCalculadora.Text = "Calculadora (20€)";
            this.chBoxCalculadora.UseVisualStyleBackColor = true;
            this.chBoxCalculadora.CheckedChanged += new System.EventHandler(this.chBoxCalculadora_CheckedChanged);
            // 
            // chBoxContestador
            // 
            this.chBoxContestador.AutoSize = true;
            this.chBoxContestador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chBoxContestador.Location = new System.Drawing.Point(16, 35);
            this.chBoxContestador.Name = "chBoxContestador";
            this.chBoxContestador.Size = new System.Drawing.Size(157, 24);
            this.chBoxContestador.TabIndex = 8;
            this.chBoxContestador.Text = "Contestador (50€)";
            this.chBoxContestador.UseVisualStyleBackColor = true;
            this.chBoxContestador.CheckedChanged += new System.EventHandler(this.chBoxContestador_CheckedChanged);
            // 
            // lblPerifericos
            // 
            this.lblPerifericos.AutoSize = true;
            this.lblPerifericos.Location = new System.Drawing.Point(263, 177);
            this.lblPerifericos.Name = "lblPerifericos";
            this.lblPerifericos.Size = new System.Drawing.Size(105, 13);
            this.lblPerifericos.TabIndex = 5;
            this.lblPerifericos.Text = "Periféricos (solo uno)";
            // 
            // lBoxPerifericos
            // 
            this.lBoxPerifericos.FormattingEnabled = true;
            this.lBoxPerifericos.Location = new System.Drawing.Point(266, 200);
            this.lBoxPerifericos.Name = "lBoxPerifericos";
            this.lBoxPerifericos.Size = new System.Drawing.Size(198, 147);
            this.lBoxPerifericos.TabIndex = 6;
            this.lBoxPerifericos.SelectedIndexChanged += new System.EventHandler(this.lBoxPerifericos_SelectedIndexChanged);
            // 
            // cBoxMetodoPago
            // 
            this.cBoxMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cBoxMetodoPago.FormattingEnabled = true;
            this.cBoxMetodoPago.Location = new System.Drawing.Point(266, 385);
            this.cBoxMetodoPago.Name = "cBoxMetodoPago";
            this.cBoxMetodoPago.Size = new System.Drawing.Size(198, 24);
            this.cBoxMetodoPago.TabIndex = 7;
            this.cBoxMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cBoxMetodoPago_SelectedIndexChanged);
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Location = new System.Drawing.Point(306, 443);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(97, 41);
            this.btnPresupuesto.TabIndex = 8;
            this.btnPresupuesto.Text = "Presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(293, 499);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 60);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picBoxEquipo
            // 
            this.picBoxEquipo.Location = new System.Drawing.Point(495, 189);
            this.picBoxEquipo.Name = "picBoxEquipo";
            this.picBoxEquipo.Size = new System.Drawing.Size(113, 107);
            this.picBoxEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEquipo.TabIndex = 10;
            this.picBoxEquipo.TabStop = false;
            // 
            // picBoxPerifericos
            // 
            this.picBoxPerifericos.Location = new System.Drawing.Point(495, 324);
            this.picBoxPerifericos.Name = "picBoxPerifericos";
            this.picBoxPerifericos.Size = new System.Drawing.Size(113, 107);
            this.picBoxPerifericos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPerifericos.TabIndex = 11;
            this.picBoxPerifericos.TabStop = false;
            // 
            // picBoxMetodoPago
            // 
            this.picBoxMetodoPago.Location = new System.Drawing.Point(495, 461);
            this.picBoxMetodoPago.Name = "picBoxMetodoPago";
            this.picBoxMetodoPago.Size = new System.Drawing.Size(113, 107);
            this.picBoxMetodoPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMetodoPago.TabIndex = 12;
            this.picBoxMetodoPago.TabStop = false;
            // 
            // picBoxEquipoOficina3
            // 
            this.picBoxEquipoOficina3.Location = new System.Drawing.Point(682, 461);
            this.picBoxEquipoOficina3.Name = "picBoxEquipoOficina3";
            this.picBoxEquipoOficina3.Size = new System.Drawing.Size(113, 107);
            this.picBoxEquipoOficina3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEquipoOficina3.TabIndex = 15;
            this.picBoxEquipoOficina3.TabStop = false;
            // 
            // picBoxEquipoOficina2
            // 
            this.picBoxEquipoOficina2.Location = new System.Drawing.Point(682, 302);
            this.picBoxEquipoOficina2.Name = "picBoxEquipoOficina2";
            this.picBoxEquipoOficina2.Size = new System.Drawing.Size(113, 107);
            this.picBoxEquipoOficina2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEquipoOficina2.TabIndex = 14;
            this.picBoxEquipoOficina2.TabStop = false;
            // 
            // picBoxEquipoOficina1
            // 
            this.picBoxEquipoOficina1.Location = new System.Drawing.Point(682, 189);
            this.picBoxEquipoOficina1.Name = "picBoxEquipoOficina1";
            this.picBoxEquipoOficina1.Size = new System.Drawing.Size(113, 107);
            this.picBoxEquipoOficina1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEquipoOficina1.TabIndex = 13;
            this.picBoxEquipoOficina1.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 625);
            this.Controls.Add(this.picBoxEquipoOficina3);
            this.Controls.Add(this.picBoxEquipoOficina2);
            this.Controls.Add(this.picBoxEquipoOficina1);
            this.Controls.Add(this.picBoxMetodoPago);
            this.Controls.Add(this.picBoxPerifericos);
            this.Controls.Add(this.picBoxEquipo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPresupuesto);
            this.Controls.Add(this.cBoxMetodoPago);
            this.Controls.Add(this.lBoxPerifericos);
            this.Controls.Add(this.lblPerifericos);
            this.Controls.Add(this.gBoxEquipoOficina);
            this.Controls.Add(this.gBoxEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloCompraInteractiva);
            this.Name = "Form";
            this.Text = "Tienda electrónica - Miguel Sanchez";
            this.Load += new System.EventHandler(this.Form_Load);
            this.gBoxEquipo.ResumeLayout(false);
            this.gBoxEquipo.PerformLayout();
            this.gBoxEquipoOficina.ResumeLayout(false);
            this.gBoxEquipoOficina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPerifericos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMetodoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEquipoOficina3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEquipoOficina2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEquipoOficina1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCompraInteractiva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBoxEquipo;
        private System.Windows.Forms.GroupBox gBoxEquipoOficina;
        private System.Windows.Forms.Label lblPerifericos;
        private System.Windows.Forms.ListBox lBoxPerifericos;
        private System.Windows.Forms.ComboBox cBoxMetodoPago;
        private System.Windows.Forms.RadioButton rBtnPortatil;
        private System.Windows.Forms.RadioButton rBtnMacintosh;
        private System.Windows.Forms.RadioButton rBtnPC;
        private System.Windows.Forms.CheckBox chBoxFotocopiadora;
        private System.Windows.Forms.CheckBox chBoxCalculadora;
        private System.Windows.Forms.CheckBox chBoxContestador;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picBoxEquipo;
        private System.Windows.Forms.PictureBox picBoxPerifericos;
        private System.Windows.Forms.PictureBox picBoxMetodoPago;
        private System.Windows.Forms.PictureBox picBoxEquipoOficina3;
        private System.Windows.Forms.PictureBox picBoxEquipoOficina2;
        private System.Windows.Forms.PictureBox picBoxEquipoOficina1;
    }
}

