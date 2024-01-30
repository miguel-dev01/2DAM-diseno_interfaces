using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios2
{
    public partial class FormEjercicios2 : Form
    {
        private int[] numeros = new int[10];
        private int posicionNumero = 0;

        public FormEjercicios2()
        {
            InitializeComponent();
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
            lblPrimo.Visible = false;
            if (Int32.TryParse(txtNumero.Text, out int numero) && numero >= 1)
            {
                if (posicionNumero < this.numeros.Length)
                {
                    this.numeros[posicionNumero] = numero;
                    posicionNumero++;
                    lstBoxResult.Items.Add(txtNumero.Text);
                    lblPrimo.Visible = true;
                    lblPrimo.BackColor = Color.Azure;
                    lblPrimo.Text = this.esPrimo(numero);
                }
                else
                {
                    lblMensaje.Visible = true;
                    lblMensaje.BackColor = Color.Yellow;
                    lblMensaje.Text = "No se pueden añadir más de "
                        + this.numeros.Length + " elementos a la lista.";
                }
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.BackColor = Color.Red;
                lblMensaje.Text = "Sólo se aceptan caracteres numericos.\n" +
                    "Y no deben ser numeros negativos";
            }
        }

	// Metodo para saber si un numero es primo o no
        private String esPrimo(int numero)
        {
            if (numero <= 1)
            {
                return "El numero " + numero + " no es primo.";
            }
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return "El numero " + numero + " no es primo.";
                }
            }
            return "El numero " + numero + " es primo.";
        }

        private void btnNumeroRepetido_Click(object sender, EventArgs e)
        {
            lblMostrarVecesNumero.Visible = false;
            if (lstBoxResult.Items.Count == 0)
            {
                lblMostrarVecesNumero.Visible = true;
                lblMostrarVecesNumero.Text = "No hay números en la lista";
            }
            else
            {
                if (Int32.TryParse(txtNumeroRepetido.Text, out int numero) && numero >= 1)
                {
                    int repeticion = 0;
                    for (int i = 0; i < this.numeros.Length; i++)
                    {
                        if (this.numeros[i] == numero)
                        {
                            repeticion++;
                        }
                    }
                    lblMostrarVecesNumero.Visible = true;
                    lblMostrarVecesNumero.BackColor = Color.AliceBlue;
                    if (repeticion == 0)
                    {
                        lblMostrarVecesNumero.Text = "No hay coincidencias del numero " + numero;
                    }
                    else
                    {
                        lblMostrarVecesNumero.Text = "El numero " + numero + " se repite " +
                            Convert.ToString(repeticion) + " veces.";
                    }
                }
                else
                {
                    lblMostrarVecesNumero.Visible = true;
                    lblMostrarVecesNumero.BackColor = Color.Red;
                    lblMostrarVecesNumero.Text = "Valor o caracter introducido no válido.";
                }
            }
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            lstBoxResult.Items.Clear();
            int[] numerosOrdenados = ordenacionBurbuja();
            lstBoxResult.Items.AddRange(numerosOrdenados.Where(n => n != 0).Select(n => n.ToString()).ToArray());
            lblMedia.Visible = true;
            lblMedia.BackColor = Color.RoyalBlue;
            lblMedia.Text = "Media: " + Convert.ToString(this.numeros.Sum() / lstBoxResult.Items.Count);
            lblMayor.Visible = true;
            lblMayor.BackColor = Color.Aquamarine;
            lblMayor.Text = "Mayor: " + Convert.ToString(numerosOrdenados.Max());
            lblMenor.Visible = true;
            lblMenor.BackColor = Color.Coral;
            lblMenor.Text = "Menor: " + lstBoxResult.Items[0].ToString();
        }

	// Metodo para ordenar un array de enteros, con algoritmo de la burbuja
        private int[] ordenacionBurbuja()
        {
            int[] arregloOrdenado = this.numeros;
            int aux;
            for (int i = 0; i < arregloOrdenado.Length - 1; i++)
            {
                for (int j = 0; j < arregloOrdenado.Length - i - 1; j++)
                {
                    if (arregloOrdenado[j] > arregloOrdenado[j + 1])
                    {
                        aux = arregloOrdenado[j];
                        arregloOrdenado[j] = arregloOrdenado[j + 1];
                        arregloOrdenado[j + 1] = aux;
                    }
                }
            }
            return arregloOrdenado;
        }
    }
}
