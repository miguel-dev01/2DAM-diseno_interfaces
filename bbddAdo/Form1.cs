using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bbddAdo
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            Form frm = new FormCuentaPedido();
            frm.Show();
        }

        private void btnRellenarCancelarPedido_Click(object sender, EventArgs e)
        {
            Form frm = new FormRellenarCancelarPedido();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
