using compra_interactiva.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace compra_interactiva
{
    public partial class Form : System.Windows.Forms.Form
    {
        public string directorioTrabajo = Environment.CurrentDirectory;


        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            cBoxMetodoPago.Items.Add("Tarjeta");
            cBoxMetodoPago.Items.Add("PayPal");
            cBoxMetodoPago.Items.Add("Bizum");

            lBoxPerifericos.Items.Add("Disco duro adicional (75€)");
            lBoxPerifericos.Items.Add("Impresora (90€)");
            lBoxPerifericos.Items.Add("Antena (50€)");

            // primera imagen inicial de RadioButton
            picBoxEquipo.Image = Resources.pc;

            // imagenes del checkBoxs
            picBoxEquipoOficina1.Image = Resources.contestador;
            picBoxEquipoOficina1.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxEquipoOficina1.Visible = false;

            picBoxEquipoOficina2.Image = Resources.calculadora;
            picBoxEquipoOficina2.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxEquipoOficina2.Size = new Size(150, 150);
            picBoxEquipoOficina2.Visible = false;

            picBoxEquipoOficina3.Image = Resources.fotocopiadora;
            picBoxEquipoOficina3.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxEquipoOficina3.Size = new Size(150, 150);
            picBoxEquipoOficina3.Visible = false;

        }

        private void rBtnPC_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPC.Checked)
            {
                picBoxEquipo.Image = Resources.pc;
            }
        }

        private void rBtnMacintosh_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMacintosh.Checked)
            {
                picBoxEquipo.Image = Resources.macintosh;
            }
        }

        private void rBtnPortatil_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPortatil.Checked)
            {
                picBoxEquipo.Image = Resources.portatil;
            }
        }

        private void chBoxContestador_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxContestador.Checked)
            {
                picBoxEquipoOficina1.Visible = true;
            } 
            else
            {
                picBoxEquipoOficina1.Visible = false;
            }

        }

        private void chBoxCalculadora_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxCalculadora.Checked)
            {
                picBoxEquipoOficina2.Visible = true;
            } 
            else 
            {
                picBoxEquipoOficina2.Visible = false;
            }
        }

        private void chBoxFotocopiadora_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxFotocopiadora.Checked)
            {
                picBoxEquipoOficina3.Visible = true;
            }
            else
            {
                picBoxEquipoOficina3.Visible = false;
            }
        }

        private void cBoxMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBoxMetodoPago.SelectedIndex)
            {
                case 0:
                    picBoxMetodoPago.Image = Resources.efectivo;
                    break;
                case 1:
                    picBoxMetodoPago.Image = Resources.paypal;
                    break;
                case 2:
                    picBoxMetodoPago.Image = Resources.bizum;
                    break;
            }
        }

        private void lBoxPerifericos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lBoxPerifericos.SelectedIndex)
            {
                case 0:
                    picBoxPerifericos.Image = Resources.discoDuro;
                    break;
                case 1:
                    picBoxPerifericos.Image = Resources.impresora;
                    break;
                case 2:
                    picBoxPerifericos.Image = Resources.antena;
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            double sumaTotalProductos = 0;
            // Obtener la información seleccionada
            string equipoSeleccionado = "";
            if (rBtnPC.Checked)
            {
                equipoSeleccionado = "PC (700€)";
                sumaTotalProductos += 700;
            }
            else if (rBtnMacintosh.Checked)
            {
                equipoSeleccionado = "Macintosh (1000€)";
                sumaTotalProductos += 1000;
            }
            else if (rBtnPortatil.Checked)
            {
                equipoSeleccionado = "Portátil (500€)";
                sumaTotalProductos += 500;
            }

            List<string> equipoOficinaSelecciondo = new List<string>();
            if (chBoxContestador.Checked)
            {
                equipoOficinaSelecciondo.Add("Contestador (50€)");
                sumaTotalProductos += 50;
            }
            if (chBoxCalculadora.Checked)
            {
                equipoOficinaSelecciondo.Add("Calculadora (20€)");
                sumaTotalProductos += 20;
            }
            if (chBoxFotocopiadora.Checked)
            {
                equipoOficinaSelecciondo.Add("Fotocopiadora (100€)");
                sumaTotalProductos += 100;
            }

            string equipoOficinaSeleccionado = "";
            int indiceSeleccionadoOficina = lBoxPerifericos.SelectedIndex;
            if (indiceSeleccionadoOficina == 0)
            {
                equipoOficinaSeleccionado = "Disco duro adicional (75€)";
                sumaTotalProductos += 75;
            }
            else if (indiceSeleccionadoOficina == 1)
            {
                equipoOficinaSeleccionado = "Impresora (90€)";
                sumaTotalProductos += 90;
            }
            else if (indiceSeleccionadoOficina == 2)
            {
                equipoOficinaSeleccionado = "Antena (50€)";
                sumaTotalProductos += 50;
            }

            string metodoPagoSeleccionado = cBoxMetodoPago.SelectedItem?.ToString() ?? "Sin método de pago seleccionado";

            StringBuilder mensajePresupuesto = new StringBuilder();
            mensajePresupuesto.AppendLine($"Equipo Seleccionado: {equipoSeleccionado}");

            mensajePresupuesto.AppendLine("Equipo de oficina seleccionados:");
            foreach (var equipoOficina in equipoOficinaSelecciondo)
            {
                mensajePresupuesto.AppendLine($"- {equipoOficina}");
            }

            mensajePresupuesto.AppendLine($"Periférico seleccionado: {equipoOficinaSeleccionado}");

            mensajePresupuesto.AppendLine($"Método de Pago: {metodoPagoSeleccionado}");

            mensajePresupuesto.AppendLine($"Precio total productos: {sumaTotalProductos} €");

            MessageBox.Show(mensajePresupuesto.ToString(), "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
