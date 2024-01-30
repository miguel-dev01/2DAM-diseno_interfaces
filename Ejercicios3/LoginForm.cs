using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios3
{
    public partial class LoginForm : Form
    {
        private String[,] arrayUsuarios = new String[4, 2];
        int contadorIntentos = 3;
        public LoginForm()
        {
            InitializeComponent();
            initArrayUsuarios();
        }

        // Metodo que rellena el array de usuarios al inicio del programa
        private void initArrayUsuarios()
        {
            arrayUsuarios[0, 0] = "prueba";
            arrayUsuarios[0, 1] = "1234";

            arrayUsuarios[1, 0] = "Maria Contreras";
            arrayUsuarios[1, 1] = "maria1234";

            arrayUsuarios[2, 0] = "Alejandro Sanchez";
            arrayUsuarios[2, 1] = "alex1234";

            arrayUsuarios[3, 0] = "Angel Sanchez";
            arrayUsuarios[3, 1] = "angel1234";
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Boolean coincidencia = false;
            for (int i = 0; i < arrayUsuarios.GetLength(0); i++)
            {
                if (arrayUsuarios[i, 0] == txtNombreUsuario.Text 
                    && arrayUsuarios[i, 1] == txtContraseña.Text)
                {
                    coincidencia = true;
                    break;
                }
            }
            if (coincidencia)
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                contadorIntentos--;
                if (contadorIntentos == 0)
                {
                    this.Close();
                }
                lblIntentos.Text = "Intentos: " + contadorIntentos;
            }
        }
    }
}
