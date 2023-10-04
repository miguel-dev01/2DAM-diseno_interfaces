using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoArea
{
    public partial class FormAdivinar : Form
    {
        int numeroAleatorio;
        int oportunidades = 7;
        public FormAdivinar()
        {
            InitializeComponent();
            Random random = new Random();
            numeroAleatorio = random.Next(0, 100);
        }

        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = true;
            lblMostrarIntentos.Visible = true;
            if (Int32.TryParse(txtNumero.Text, out int numero))
            {
                if (numero == numeroAleatorio)
                {
                    foreach (Control control in Controls)
                    {
                        control.Visible = false;
                    }
                    lblResultado.Visible = true;
                    lblResultado.Text = "¡Has acertado!\nCierra esta ventana para volver a jugar";
                    lblResultado.BackColor = Color.Green;
                }
                else
                {
                    oportunidades--;
                    lblMostrarIntentos.Text = Convert.ToString(oportunidades);
                    lblResultado.Text = "No has acertado el número :(";
                    lblResultado.BackColor = Color.Red;
                    txtNumero.Text = "";
                    if (oportunidades == 0)
                    {
                        foreach (Control control in Controls)
                        {
                            control.Visible = false;
                        }
                        lblResultado.Visible = true;
                        lblResultado.BackColor = Color.Red;
                        lblResultado.Text = "Has agotado todos los intentos.\nEl numero aleatorio era: " + numeroAleatorio;
                    }
                }
            }
            else
            {
                lblResultado.BackColor = Color.Red;
                lblResultado.Text = "Valor no valido.";
            }
        }
    }
}
