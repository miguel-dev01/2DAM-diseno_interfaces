namespace Ejercicios3
{
    partial class LoginForm
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNombreUsuario.Location = new System.Drawing.Point(65, 74);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(266, 25);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Introduce nombre de usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(70, 102);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(238, 30);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtContraseña.Location = new System.Drawing.Point(70, 177);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(238, 30);
            this.txtContraseña.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblContraseña.Location = new System.Drawing.Point(65, 149);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(201, 25);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Introduce contraseña:";
            // 
            // btnAcceder
            // 
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAcceder.Location = new System.Drawing.Point(175, 238);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(133, 47);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIntentos.Location = new System.Drawing.Point(424, 107);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(161, 25);
            this.lblIntentos.TabIndex = 5;
            this.lblIntentos.Text = "Tienes 3 intentos";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Name = "LoginForm";
            this.Text = "Login - Miguel Sanchez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label lblIntentos;
    }
}

