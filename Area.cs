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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblResultado.BackColor = Color.Aqua;
            if (Int32.TryParse(txtBase.Text, out int vBase)
                && Int32.TryParse(txtAltura.Text, out int altura))
            {
                if (rbtnTriangulo.Checked)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Area: " + Convert.ToString(vBase * altura / 2);
                    return;
                }
                if (rbtnRectangulo.Checked || (rbtnCuadrado.Checked && vBase == altura))
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Area: " + Convert.ToString(vBase * altura)
                        + "\nPerímetro: " + Convert.ToString((vBase*2) + (altura*2));
                }
                else
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "La base y altura no corresponden a \nningun cuadrado.";
                }
            }
            else
            {
                lblResultado.BackColor = Color.Red;
                lblResultado.Text = "Hay un valor erróneo";
            }
        }
    }
}
