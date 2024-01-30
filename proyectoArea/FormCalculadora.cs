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
    public partial class FormCalculadora : System.Windows.Forms.Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Operacion(sender, e, '-');
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Operacion(sender, e, '+');
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Operacion(sender, e, '*');
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Operacion(sender, e, '/');
        }

        private void Operacion(object sender, EventArgs e, char operador)
        {
            lblResultado.Visible = true;
            lblResultado.BackColor = Color.Aqua;
            if (txtNumero2.Text == "0" && operador == '/')
            {
                lblResultado.Text = "El divisor no puede ser 0";
                return;
            }
            if (Int32.TryParse(txtNumero1.Text, out int numero1) &&
                Int32.TryParse(txtNumero2.Text, out int numero2))
            {
                int result = 0;
                switch (operador)
                {
                    case '+':
                        result = numero1 + numero2;
                        break;
                    case '-':
                        result = numero1 - numero2;
                        break;
                    case '*':
                        result = numero1 * numero2;
                        break;
                    case '/':
                        result = numero1 / numero2;
                        break;
                }
                lblResultado.Text = "El resultado es: " + Convert.ToString(result);
            }
            else
            {
                lblResultado.Text = "No se ha podido realizar la operación";
                lblResultado.BackColor = Color.Red;
            }
        }
    }
}
