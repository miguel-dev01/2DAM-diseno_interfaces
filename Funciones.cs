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
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            lblResulFactorial.Visible = true;
            lblResulFactorial.BackColor = Color.Aqua;
            if (Int32.TryParse(txtFactorial.Text, out int numero) && numero <= 15 && numero >= 0)
            {
                lblResulFactorial.Text = "Resultado factorial:\n" + 
                    Convert.ToString(CalcularFactorial(numero));
            }
            else
            {
                lblResulFactorial.BackColor = Color.Red;
                lblResulFactorial.Text = "Valor no válido";
            }

        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            lblResultFibonacci.Visible = true;
            lblResultFibonacci.BackColor = Color.Aqua;
            if (Int32.TryParse(txtFibonacci.Text, out int numero))
            {
                lblResultFibonacci.Text = "Número de Fibonacci:\n" + 
                    Convert.ToString(CalcularFibonacci(numero));
            }
            else
            {
                lblResultFibonacci.BackColor = Color.Red;
                lblResultFibonacci.Text = "Valor no válido";
            }
        }

        private static long CalcularFactorial(long numero)
        {
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * CalcularFactorial(numero - 1);
            }
        }

        private static int CalcularFibonacci(int numero)
        {
            if (numero <= 1)
            {
                return numero;
            }
            else
            {
                return CalcularFibonacci(numero - 1) + CalcularFibonacci(numero - 2);
            }
        }
    }
}
