namespace proyectoArea
{
    partial class Area
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblFigura = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gboxTipoFigura = new System.Windows.Forms.GroupBox();
            this.rbtnCuadrado = new System.Windows.Forms.RadioButton();
            this.rbtnRectangulo = new System.Windows.Forms.RadioButton();
            this.rbtnTriangulo = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gboxTipoFigura.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBase.Location = new System.Drawing.Point(143, 89);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(265, 29);
            this.txtBase.TabIndex = 0;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBase.Location = new System.Drawing.Point(137, 55);
            this.lblBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(159, 24);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Introduce la base:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAltura.Location = new System.Drawing.Point(137, 166);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(163, 24);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Introduce la altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtAltura.Location = new System.Drawing.Point(143, 199);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(265, 29);
            this.txtAltura.TabIndex = 2;
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFigura.Location = new System.Drawing.Point(137, 270);
            this.lblFigura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(207, 24);
            this.lblFigura.TabIndex = 5;
            this.lblFigura.Text = "Introduce tipo de figura:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCalcular.Location = new System.Drawing.Point(143, 455);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(267, 66);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gboxTipoFigura
            // 
            this.gboxTipoFigura.Controls.Add(this.rbtnCuadrado);
            this.gboxTipoFigura.Controls.Add(this.rbtnRectangulo);
            this.gboxTipoFigura.Controls.Add(this.rbtnTriangulo);
            this.gboxTipoFigura.Location = new System.Drawing.Point(143, 303);
            this.gboxTipoFigura.Margin = new System.Windows.Forms.Padding(4);
            this.gboxTipoFigura.Name = "gboxTipoFigura";
            this.gboxTipoFigura.Padding = new System.Windows.Forms.Padding(4);
            this.gboxTipoFigura.Size = new System.Drawing.Size(267, 123);
            this.gboxTipoFigura.TabIndex = 8;
            this.gboxTipoFigura.TabStop = false;
            this.gboxTipoFigura.Text = "Tipos";
            // 
            // rbtnCuadrado
            // 
            this.rbtnCuadrado.AutoSize = true;
            this.rbtnCuadrado.Location = new System.Drawing.Point(9, 84);
            this.rbtnCuadrado.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCuadrado.Name = "rbtnCuadrado";
            this.rbtnCuadrado.Size = new System.Drawing.Size(88, 21);
            this.rbtnCuadrado.TabIndex = 2;
            this.rbtnCuadrado.TabStop = true;
            this.rbtnCuadrado.Text = "Cuadrado";
            this.rbtnCuadrado.UseVisualStyleBackColor = true;
            // 
            // rbtnRectangulo
            // 
            this.rbtnRectangulo.AutoSize = true;
            this.rbtnRectangulo.Location = new System.Drawing.Point(9, 54);
            this.rbtnRectangulo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnRectangulo.Name = "rbtnRectangulo";
            this.rbtnRectangulo.Size = new System.Drawing.Size(98, 21);
            this.rbtnRectangulo.TabIndex = 1;
            this.rbtnRectangulo.TabStop = true;
            this.rbtnRectangulo.Text = "Rectángulo";
            this.rbtnRectangulo.UseVisualStyleBackColor = true;
            // 
            // rbtnTriangulo
            // 
            this.rbtnTriangulo.AutoSize = true;
            this.rbtnTriangulo.Location = new System.Drawing.Point(9, 25);
            this.rbtnTriangulo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnTriangulo.Name = "rbtnTriangulo";
            this.rbtnTriangulo.Size = new System.Drawing.Size(86, 21);
            this.rbtnTriangulo.TabIndex = 0;
            this.rbtnTriangulo.TabStop = true;
            this.rbtnTriangulo.Text = "Triangulo";
            this.rbtnTriangulo.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblResultado.Location = new System.Drawing.Point(589, 340);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(137, 31);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gboxTipoFigura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtBase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Area";
            this.Text = "Areas - Miguel Sánchez";
            this.gboxTipoFigura.ResumeLayout(false);
            this.gboxTipoFigura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gboxTipoFigura;
        private System.Windows.Forms.RadioButton rbtnCuadrado;
        private System.Windows.Forms.RadioButton rbtnRectangulo;
        private System.Windows.Forms.RadioButton rbtnTriangulo;
        private System.Windows.Forms.Label lblResultado;
    }
}