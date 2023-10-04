namespace proyectoArea
{
    partial class Menu
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
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.lblAreas = new System.Windows.Forms.Label();
            this.lblFunciones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblAdivinar = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblIntroduceMenu = new System.Windows.Forms.Label();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCalculadora.Location = new System.Drawing.Point(61, 26);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(138, 25);
            this.lblCalculadora.TabIndex = 0;
            this.lblCalculadora.Text = "1. Calculadora";
            // 
            // lblAreas
            // 
            this.lblAreas.AutoSize = true;
            this.lblAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAreas.Location = new System.Drawing.Point(61, 77);
            this.lblAreas.Name = "lblAreas";
            this.lblAreas.Size = new System.Drawing.Size(85, 25);
            this.lblAreas.TabIndex = 1;
            this.lblAreas.Text = "2. Areas";
            // 
            // lblFunciones
            // 
            this.lblFunciones.AutoSize = true;
            this.lblFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFunciones.Location = new System.Drawing.Point(61, 128);
            this.lblFunciones.Name = "lblFunciones";
            this.lblFunciones.Size = new System.Drawing.Size(124, 25);
            this.lblFunciones.TabIndex = 2;
            this.lblFunciones.Text = "3. Funciones";
            this.lblFunciones.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSalir);
            this.panel1.Controls.Add(this.lblAviso);
            this.panel1.Controls.Add(this.lblAdivinar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.lblIntroduceMenu);
            this.panel1.Controls.Add(this.txtMenu);
            this.panel1.Controls.Add(this.lblFunciones);
            this.panel1.Controls.Add(this.lblAreas);
            this.panel1.Controls.Add(this.lblCalculadora);
            this.panel1.Location = new System.Drawing.Point(67, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 392);
            this.panel1.TabIndex = 3;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSalir.Location = new System.Drawing.Point(378, 77);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(72, 25);
            this.lblSalir.TabIndex = 8;
            this.lblSalir.Text = "5. Salir";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAviso.Location = new System.Drawing.Point(212, 334);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(35, 15);
            this.lblAviso.TabIndex = 7;
            this.lblAviso.Text = "aviso";
            this.lblAviso.Visible = false;
            // 
            // lblAdivinar
            // 
            this.lblAdivinar.AutoSize = true;
            this.lblAdivinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAdivinar.Location = new System.Drawing.Point(378, 26);
            this.lblAdivinar.Name = "lblAdivinar";
            this.lblAdivinar.Size = new System.Drawing.Size(104, 25);
            this.lblAdivinar.TabIndex = 6;
            this.lblAdivinar.Text = "4. Adivinar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAceptar.Location = new System.Drawing.Point(215, 269);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAceptar.Size = new System.Drawing.Size(187, 49);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIntroduceMenu
            // 
            this.lblIntroduceMenu.AutoSize = true;
            this.lblIntroduceMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIntroduceMenu.Location = new System.Drawing.Point(212, 203);
            this.lblIntroduceMenu.Name = "lblIntroduceMenu";
            this.lblIntroduceMenu.Size = new System.Drawing.Size(110, 17);
            this.lblIntroduceMenu.TabIndex = 4;
            this.lblIntroduceMenu.Text = "Introduce menu:";
            // 
            // txtMenu
            // 
            this.txtMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMenu.Location = new System.Drawing.Point(215, 223);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(187, 30);
            this.txtMenu.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 447);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menú principal - Miguel Sánchez";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Label lblAreas;
        private System.Windows.Forms.Label lblFunciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label lblIntroduceMenu;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAdivinar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblSalir;
    }
}