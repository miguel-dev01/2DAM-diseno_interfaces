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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
            if (txtMenu.Text == "1")
            {
                FormCalculadora calculadora = new FormCalculadora();
                calculadora.Show();
            }
            else if (txtMenu.Text == "2")
            {
                Area area = new Area();
                area.Show();
            }
            else if (txtMenu.Text == "3")
            {
                Funciones funciones = new Funciones();
                funciones.Show();
            }
            else if (txtMenu.Text == "4")
            {
                FormAdivinar adivinar = new FormAdivinar();
                adivinar.Show();
            }
            else if (txtMenu.Text == "5")
            {
                this.Close();
            }
            else
            {
                lblAviso.Visible = true;
                lblAviso.Text = "No corresponde a ningún menu";
            }
        }
    }
}
