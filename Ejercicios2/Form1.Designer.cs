namespace Ejercicios2
{
    partial class FormEjercicios2
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
            this.lstBoxResult = new System.Windows.Forms.ListBox();
            this.lblIntroduceNumero = new System.Windows.Forms.Label();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblPrimo = new System.Windows.Forms.Label();
            this.txtNumeroRepetido = new System.Windows.Forms.TextBox();
            this.btnNumeroRepetido = new System.Windows.Forms.Button();
            this.lblNumeroRepetido = new System.Windows.Forms.Label();
            this.lblMostrarVecesNumero = new System.Windows.Forms.Label();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxResult
            // 
            this.lstBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lstBoxResult.FormattingEnabled = true;
            this.lstBoxResult.ItemHeight = 25;
            this.lstBoxResult.Location = new System.Drawing.Point(256, 38);
            this.lstBoxResult.Name = "lstBoxResult";
            this.lstBoxResult.Size = new System.Drawing.Size(190, 279);
            this.lstBoxResult.TabIndex = 0;
            // 
            // lblIntroduceNumero
            // 
            this.lblIntroduceNumero.AutoSize = true;
            this.lblIntroduceNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIntroduceNumero.Location = new System.Drawing.Point(32, 38);
            this.lblIntroduceNumero.Name = "lblIntroduceNumero";
            this.lblIntroduceNumero.Size = new System.Drawing.Size(197, 25);
            this.lblIntroduceNumero.TabIndex = 1;
            this.lblIntroduceNumero.Text = "Introduce un número:";
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(123, 102);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(106, 41);
            this.btnAniadir.TabIndex = 2;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNumero.Location = new System.Drawing.Point(37, 66);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(192, 30);
            this.txtNumero.TabIndex = 3;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMensaje.Location = new System.Drawing.Point(31, 328);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(142, 31);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "MENSAJE";
            this.lblMensaje.Visible = false;
            // 
            // lblPrimo
            // 
            this.lblPrimo.AutoSize = true;
            this.lblPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPrimo.Location = new System.Drawing.Point(31, 359);
            this.lblPrimo.Name = "lblPrimo";
            this.lblPrimo.Size = new System.Drawing.Size(99, 31);
            this.lblPrimo.TabIndex = 5;
            this.lblPrimo.Text = "Primo?";
            this.lblPrimo.Visible = false;
            // 
            // txtNumeroRepetido
            // 
            this.txtNumeroRepetido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNumeroRepetido.Location = new System.Drawing.Point(746, 66);
            this.txtNumeroRepetido.Name = "txtNumeroRepetido";
            this.txtNumeroRepetido.Size = new System.Drawing.Size(245, 30);
            this.txtNumeroRepetido.TabIndex = 8;
            // 
            // btnNumeroRepetido
            // 
            this.btnNumeroRepetido.Location = new System.Drawing.Point(877, 102);
            this.btnNumeroRepetido.Name = "btnNumeroRepetido";
            this.btnNumeroRepetido.Size = new System.Drawing.Size(114, 41);
            this.btnNumeroRepetido.TabIndex = 7;
            this.btnNumeroRepetido.Text = "Comprobar";
            this.btnNumeroRepetido.UseVisualStyleBackColor = true;
            this.btnNumeroRepetido.Click += new System.EventHandler(this.btnNumeroRepetido_Click);
            // 
            // lblNumeroRepetido
            // 
            this.lblNumeroRepetido.AutoSize = true;
            this.lblNumeroRepetido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNumeroRepetido.Location = new System.Drawing.Point(519, 38);
            this.lblNumeroRepetido.Name = "lblNumeroRepetido";
            this.lblNumeroRepetido.Size = new System.Drawing.Size(472, 25);
            this.lblNumeroRepetido.TabIndex = 6;
            this.lblNumeroRepetido.Text = "Introduce numero para saber las veces que se repite:";
            // 
            // lblMostrarVecesNumero
            // 
            this.lblMostrarVecesNumero.AutoSize = true;
            this.lblMostrarVecesNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMostrarVecesNumero.Location = new System.Drawing.Point(527, 150);
            this.lblMostrarVecesNumero.Name = "lblMostrarVecesNumero";
            this.lblMostrarVecesNumero.Size = new System.Drawing.Size(282, 31);
            this.lblMostrarVecesNumero.TabIndex = 9;
            this.lblMostrarVecesNumero.Text = "NUMERO REPETIDO";
            this.lblMostrarVecesNumero.Visible = false;
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnOperaciones.Location = new System.Drawing.Point(812, 303);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(192, 75);
            this.btnOperaciones.TabIndex = 10;
            this.btnOperaciones.Text = "Realizar operaciones";
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblOperaciones.Location = new System.Drawing.Point(519, 217);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(485, 83);
            this.lblOperaciones.TabIndex = 11;
            this.lblOperaciones.Text = "Pulsa en el siguiente botón para ordenar la lista de números de menor a mayor, ca" +
    "lcular la media y extraer el mayor y menor número de todos ellos:\r\n\r\n";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMedia.Location = new System.Drawing.Point(547, 317);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(75, 25);
            this.lblMedia.TabIndex = 12;
            this.lblMedia.Text = "MEDIA";
            this.lblMedia.Visible = false;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMenor.Location = new System.Drawing.Point(547, 395);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(85, 25);
            this.lblMenor.TabIndex = 13;
            this.lblMenor.Text = "MENOR";
            this.lblMenor.Visible = false;
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMayor.Location = new System.Drawing.Point(547, 353);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(85, 25);
            this.lblMayor.TabIndex = 14;
            this.lblMayor.Text = "MAYOR";
            this.lblMayor.Visible = false;
            // 
            // FormEjercicios2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.lblMostrarVecesNumero);
            this.Controls.Add(this.txtNumeroRepetido);
            this.Controls.Add(this.btnNumeroRepetido);
            this.Controls.Add(this.lblNumeroRepetido);
            this.Controls.Add(this.lblPrimo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.lblIntroduceNumero);
            this.Controls.Add(this.lstBoxResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEjercicios2";
            this.Text = "Ejercicios 2 - Miguel Sánchez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxResult;
        private System.Windows.Forms.Label lblIntroduceNumero;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblPrimo;
        private System.Windows.Forms.TextBox txtNumeroRepetido;
        private System.Windows.Forms.Button btnNumeroRepetido;
        private System.Windows.Forms.Label lblNumeroRepetido;
        private System.Windows.Forms.Label lblMostrarVecesNumero;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
    }
}

