using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_calculadora
{
    public partial class FormCalculadora : Form
    {
        private bool activado = false;
        private double operando1 = 0;
        private bool cambioOperando = false;
        private char operadorActual = ' ';

        public FormCalculadora()
        {
            InitializeComponent();
            txtCalculadora.Text = "0";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (!activado)
            {
                activado = true;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn0.Enabled = false;
                btnMultiplicar.Enabled = false;
                btnSumar.Enabled = false;
                btnRestar.Enabled = false;
                btnSumarRestar.Enabled = false;
                btnDividir.Enabled = false;
                btnComa.Enabled = false;
                btnIgual.Enabled = false;
                btnC.Enabled = false;
                btnOff.Text = "ON";
            }
            else
            {
                activado = false;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btn0.Enabled = true;
                btnMultiplicar.Enabled = true;
                btnSumar.Enabled = true;
                btnRestar.Enabled = true;
                btnSumarRestar.Enabled = true;
                btnDividir.Enabled = true;
                btnComa.Enabled = true;
                btnIgual.Enabled = true;
                btnC.Enabled = true;
                btnOff.Text = "OFF";
            }
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            bool contiene_coma = txtCalculadora.Text.Contains(",");
            if (!contiene_coma)
            {
                txtCalculadora.Text += ",";
            }
        }

        private void btnSumarRestar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCalculadora.Text, out double valor))
            {
                valor = -valor;
                txtCalculadora.Text = valor.ToString();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AgregarNumero(btn.Text);
        }

        private void AgregarNumero(string numero)
        {
            if (txtCalculadora.Text == "0" || cambioOperando)
            {
                txtCalculadora.Text = numero;
                cambioOperando = false;
            }
            else
            {
                txtCalculadora.Text += numero;
            }
        }

        // Botones de las operaciones
        private void btnSumar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RealizarOperacion(btn.Text[0]);
        }

        private void RealizarOperacion(char operacion)
        {
            operadorActual = operacion;
            operando1 = double.Parse(txtCalculadora.Text);
            cambioOperando = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!cambioOperando)
            {
                double operando2 = double.Parse(txtCalculadora.Text);
                RealizarCalculo(operando2);
            }
        }

        private void RealizarCalculo(double operando2)
        {
            switch (operadorActual)
            {
                case '+':
                    txtCalculadora.Text = (operando1 + operando2).ToString();
                    break;
                case '-':
                    txtCalculadora.Text = (operando1 - operando2).ToString();
                    break;
                case '*':
                    txtCalculadora.Text = (operando1 * operando2).ToString();
                    break;
                case '/':
                    if (operando2 != 0)
                    {
                        txtCalculadora.Text = (operando1 / operando2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre cero", "ERROR");
                        LimpiarCalculadora();
                    }
                    break;
            }
            cambioOperando = true;
        }

        private void LimpiarCalculadora()
        {
            txtCalculadora.Text = "0";
            operando1 = 0;
            cambioOperando = false;
            operadorActual = ' ';
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text = "0";
            operando1 = 0;
            cambioOperando = false;
            operadorActual = ' ';
        }
    }
}