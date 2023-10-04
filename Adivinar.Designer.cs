namespace proyectoArea
{
    partial class FormAdivinar
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAdivinar = new System.Windows.Forms.Button();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblMostrarIntentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNumero.Location = new System.Drawing.Point(93, 56);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(302, 25);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Introduce un número del 1 al 100:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNumero.Location = new System.Drawing.Point(98, 84);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(270, 30);
            this.txtNumero.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblResultado.Location = new System.Drawing.Point(93, 267);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(99, 25);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // btnAdivinar
            // 
            this.btnAdivinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdivinar.Location = new System.Drawing.Point(98, 138);
            this.btnAdivinar.Name = "btnAdivinar";
            this.btnAdivinar.Size = new System.Drawing.Size(187, 49);
            this.btnAdivinar.TabIndex = 6;
            this.btnAdivinar.Text = "ADIVINAR";
            this.btnAdivinar.UseVisualStyleBackColor = true;
            this.btnAdivinar.Click += new System.EventHandler(this.btnAdivinar_Click);
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIntentos.Location = new System.Drawing.Point(572, 56);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(87, 25);
            this.lblIntentos.TabIndex = 7;
            this.lblIntentos.Text = "Intentos:";
            // 
            // lblMostrarIntentos
            // 
            this.lblMostrarIntentos.AutoSize = true;
            this.lblMostrarIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMostrarIntentos.Location = new System.Drawing.Point(572, 89);
            this.lblMostrarIntentos.Name = "lblMostrarIntentos";
            this.lblMostrarIntentos.Size = new System.Drawing.Size(151, 25);
            this.lblMostrarIntentos.TabIndex = 8;
            this.lblMostrarIntentos.Text = "Mostrar intentos";
            this.lblMostrarIntentos.Visible = false;
            // 
            // FormAdivinar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.lblMostrarIntentos);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.btnAdivinar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAdivinar";
            this.Text = "Adivinar - Miguel Sánchez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAdivinar;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblMostrarIntentos;
    }
}