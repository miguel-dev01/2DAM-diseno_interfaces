using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1clases
{
    public partial class FormArticulos : Form
    {
        public static Articulo articulo = new Articulo();
        List<Articulo> articulos = new List<Articulo>();
        public FormArticulos()
        {
            InitializeComponent();
            inicializarListBoxCategorias();
        }

        private void inicializarListBoxCategorias()
        {
            foreach (var categoria in articulo.CategoriaArticulo)
            {
                cBoxCategoriaAltas.Items.Add(categoria);
                cBoxCategoriasListBox.Items.Add(categoria);
            }
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxAltas.Visible = true;
            txtCodigoAltas.Enabled = false;
        }

        private void btnAceptarAltas_Click(object sender, EventArgs e)
        {
            lblMsgAltas.Visible = false;
            if (Decimal.TryParse(txtPrecioAltas.Text, out decimal precio) && 
                Int32.TryParse(txtExistenciasAltas.Text, out int existencia))
            {
                articulo = new Articulo(txtNombreAltas.Text, cBoxCategoriaAltas.Text,
                    precio, existencia);
                txtCodigoAltas.Text = articulo.CodigoArticulo.ToString();
                articulos.Add(articulo);
                lblMsgAltas.Visible = true;
                lblMsgAltas.Text = "Articulo añadido exitosamente";
            }
            else
            {
                lblMsgAltas.Visible = true;
                lblMsgAltas.Text = "El campo precio y de existencias no deben \ncontener caracteres alfabeticos.";
            }
        }

        private void btnCancelarAltas_Click(object sender, EventArgs e)
        {
            gBoxAltas.Visible = false;
        }

        private void btnAceptarConsultas_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCogidoConsulta.Text) && Int32.TryParse(txtCogidoConsulta.Text, out int codigo))
            {
                bool articuloEncontrado = false;
                foreach (var articulo in articulos)
                {
                    if (codigo == articulo.CodigoArticulo)
                    {
                        articuloEncontrado = true;
                        lblConsultas.Visible = true;
                        lblConsultas.Text = articulo.ToString();
                        break;
                    }
                }
                if (!articuloEncontrado)
                {
                    lblConsultas.Visible = true;
                    lblConsultas.Text = "No se ha encontrado el artículo con ese código";
                }
            }
            else
            {
                lblConsultas.Visible = true;
                lblConsultas.Text = "El campo 'Código' solo permite recibir numeros";
            }

            if (!string.IsNullOrEmpty(txtNombreConsulta.Text))
            {
                bool articuloEncontrado = false;
                foreach (var articulo in articulos)
                {
                    if (txtNombreConsulta.Text == articulo.NombreArticulo)
                    {
                        articuloEncontrado = true;
                        lblConsultas.Visible = true;
                        lblConsultas.Text = articulo.ToString();
                        break;
                    }
                }
                if (!articuloEncontrado)
                {
                    lblConsultas.Visible = true;
                    lblConsultas.Text = "No se ha encontrado el artículo con ese nombre";
                }
            }
        }

        private void porCódigoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNombreConsulta.Visible = false;
            txtNombreConsulta.Visible = false;
            txtNombreConsulta.Text = "";
            gBoxConsultas.Visible = true;
            lblCodigoConsulta.Visible = true;
            txtCogidoConsulta.Visible = true;
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblCodigoConsulta.Visible = false;
            txtCogidoConsulta.Visible = false;
            txtCogidoConsulta.Text = "";
            gBoxConsultas.Visible = true;
            lblNombreConsulta.Visible = true;
            txtNombreConsulta.Visible = true;

        }

        private void btnCancelarConsultas_Click(object sender, EventArgs e)
        {
            gBoxConsultas.Visible = false;
            lblConsultas.Visible = false;
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lBoxListados.Visible = true;
            lBoxListados.Items.Clear();
            lblCategoriaListBox.Visible = false;
            cBoxCategoriasListBox.Visible = false;
            gBoxPedido.Visible = false;
            if (articulos.Count == 0)
            {
                lBoxListados.Items.Add("No hay artículos añadidos aún.");
            }
            else
            {
                foreach (var articulo in articulos)
                {
                    lBoxListados.Items.Add(articulo.ToString());
                }
            }
        }

        private void minimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lBoxListados.Visible = true;
            lBoxListados.Items.Clear();
            lblCategoriaListBox.Visible = false;
            cBoxCategoriasListBox.Visible = false;
            gBoxPedido.Visible = false;

            if (articulos.Count == 0)
            {
                lBoxListados.Items.Add("No hay artículos añadidos aún.");
            }
            else
            {
                bool articulosMinimosEncontrados = false;
                foreach (var articulo in articulos)
                {
                    if (articulo.ExistenciasArticulo < 10)
                    {
                        articulosMinimosEncontrados = true;
                        lBoxListados.Items.Add(articulo.ToString());
                    }
                }
                if (!articulosMinimosEncontrados)
                {
                    lBoxListados.Items.Add("No hay artículos con existencias menores a 10.");
                }
            }
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lBoxListados.Visible = true;
            lBoxListados.Items.Clear();
            lblCategoriaListBox.Visible = true;
            cBoxCategoriasListBox.Visible = true;
            gBoxPedido.Visible = false;
        }

        private void cBoxCategoriasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBoxListados.Items.Clear();
            if (articulos.Count == 0)
            {
                lBoxListados.Items.Add("No hay artículos añadidos aún.");
            }
            else
            {
                bool articulosEncontrados = false;
                foreach (var articulo in articulos)
                {
                    string categoriaSeleccionada = cBoxCategoriasListBox.Text;
                    if (string.Equals(articulo.Categoria, categoriaSeleccionada))
                    {
                        lBoxListados.Items.Add(articulo.ToString());
                        articulosEncontrados = true;
                    }
                }
                if (!articulosEncontrados)
                {
                    lBoxListados.Items.Add("No se encontraron artículos en esa categoría.");
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxPedido.Visible = true;
            lBoxListados.Visible = false;
            lblMensajePedido.Visible = false;
        }

        private void btnAceptarPedido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoPedido.Text) || string.IsNullOrEmpty(txtCantidadPedido.Text))
            {
                lblMensajePedido.Visible = true;
                lblMensajePedido.Text = "Se deben completar los dos campos.";
            }
            else
            {
                if (Int32.TryParse(txtCodigoPedido.Text, out int codigo) &&
                    Int32.TryParse(txtCantidadPedido.Text, out int cantidad))
                {
                    Pedido(codigo, cantidad);
                }
                else
                {
                    lblMensajePedido.Visible = true;
                    lblMensajePedido.Text = "El código y la cantidad solo permiten números";
                }
            }
        }

        private void Pedido(int codigo, int cantidad)
        {
            lblMensajePedido.Visible = false;
            if (articulos.Count == 0)
            {
                lblMensajePedido.Visible = true;
                lblMensajePedido.Text = "No hay articulos dados de alta.";
            } 
            else
            {
                foreach (var articulo in articulos)
                {
                    if (codigo == articulo.CodigoArticulo)
                    {
                        articulo.actualizarExistencias(cantidad);
                    }
                    else
                    {
                        lblMensajePedido.Visible = true;
                        lblMensajePedido.Text = "El articulo escogido no existe.";
                    }
                }
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            gBoxPedido.Visible = false;
        }

        private void cancelarListadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lBoxListados.Visible = false;
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMensajeAutor.Visible = true;
        }
    }
}
