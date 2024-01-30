using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenMiguelDiseñoInterfacesCajero
{
    public partial class FormCajero : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        int intentos = 3;

        public FormCajero()
        {
            InitializeComponent();
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            gBoxAltasCliente.Visible = false;
        }

        private void AltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxAltasCliente.Visible = true;
        }

        private void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (Regex.IsMatch(txtDniCliente.Text, @"\d{8}[A-Z]{1}") && txtDniCliente.Text.Length <= 9)
            {
                cliente.DniCli = txtDniCliente.Text;
            }
            else
            {
                MessageBox.Show("DNI no valido.", "ERROR");
                return;
            }

            if (Regex.IsMatch(txtNombreCliente.Text, @"[a-zA-ZñÑüÜáéíóúÁÉÍÓÚ]\s*"))
            {
                cliente.NombreCli = txtNombreCliente.Text;
            }
            else
            {
                MessageBox.Show("Nombre no valido", "ERROR");
                return;
            }

            if (Int32.TryParse(txtClaveCliente.Text, out int clave) && txtClaveCliente.Text.Length == 4)
            {
                cliente.ClaveCli = clave;
            }
            else
            {
                MessageBox.Show("Clave no valida", "ERROR");
                return;
            }

            if (Int32.TryParse(txtSaldoCliente.Text, out int saldo) && saldo >= 0)
            {
                cliente.SaldoClie = saldo;
            }
            else
            {
                MessageBox.Show("Saldo no valido", "ERROR");
                return;
            }
            cliente.BloqueoCli = false;
            clientes.Add(cliente);
            MessageBox.Show("Cliente " + cliente.NombreCli + " añadido exitosamente.");
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxConsultas.Visible = true;
            gBoxBloquearDesbloquear.Visible = false;
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            gBoxConsultas.Visible = false;
            lblDniConsulta.Visible = false;
            chkBoxBloqueoConsulta.Visible = false;
            lblSaldoConsulta.Visible = false;
        }

        private void btnAceptarConsulta_Click(object sender, EventArgs e)
        {
            bool clienteEncontrado = false;
            foreach (var cliente in clientes)
            {
                if (cliente.NombreCli == txtNombreClienteConsulta.Text)
                {
                    clienteEncontrado = true;
                    lblDniConsulta.Visible = true;
                    lblDniConsulta.Text = "DNI: " + cliente.DniCli;

                    chkBoxBloqueoConsulta.Visible = true;
                    chkBoxBloqueoConsulta.Enabled = false;
                    if (cliente.BloqueoCli)
                    {
                        chkBoxBloqueoConsulta.Checked = true;
                    }
                    else
                    {
                        chkBoxBloqueoConsulta.Checked = false;
                    }

                    lblSaldoConsulta.Visible = true;
                    lblSaldoConsulta.Text = "Saldo: " + cliente.SaldoClie.ToString();
                }
            }
            if (!clienteEncontrado)
            {
                MessageBox.Show("Cuenta no encontrada", "404");
                lblDniConsulta.Text = "";
                lblSaldoConsulta.Text = "";
                chkBoxBloqueoConsulta.Visible = false;
            }
        }

        private void CajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxFormularioCajero.Visible = true;
        }

        private void btnCancelarFormCajero_Click(object sender, EventArgs e)
        {
            gBoxFormularioCajero.Visible = false;
        }

        private void btnAceptarFormCajero_Click(object sender, EventArgs e)
        {
            bool cuentaEncontrada = false;
            // bool contraseñaCorrecta = false;
            bool cuentaBloqueada = false;
            //int intentos = 3;
            // Cliente clientePassw = new Cliente();
            foreach (var cliente in clientes)
            {
                if (txtDniCajero.Text == cliente.DniCli)
                {
                    cuentaEncontrada = true;
                    if (txtClaveCajero.Text == cliente.ClaveCli.ToString())
                    {
                        // contraseñaCorrecta = true;
                        // clientePassw = cliente;
                        Cajero cajero = new Cajero();
                        intentos = 3;
                        cajero.Show();
                    }
                    else
                    {
                        if (intentos == 0)
                        {
                            MessageBox.Show("Se han agotados todos los intentos. Tu cuenta se bloqueará");
                            cliente.BloqueoCli = true;
                            break;
                        }
                        intentos--;
                        MessageBox.Show("La contraseña no es correcta. Tienes " + intentos + " intentos");
                    }
                }
            }
            if (cuentaBloqueada)
            {
                MessageBox.Show("La cuenta esta bloqueada");
                return;
            }
            if (!cuentaEncontrada)
            {
                MessageBox.Show("No existe cuenta con el DNI introducido");
                return;
            }
            //if (!contraseñaCorrecta)
            //{
            //    intentos--;
            //    if (intentos == 0)
            //    {
            //        MessageBox.Show("Se han agotados todos los intentos. Tu cuenta se bloqueará");
            //        clientePassw.BloqueoCli = true;
            //        return;
            //    }
            //    MessageBox.Show("La contraseña no es correcta. Tienes " + intentos + " intentos");
            //}
        }

        private void bLOQUEARDESBLOQUEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxBloquearDesbloquear.Visible = true;
        }

        private void btnAceptarBloDes_Click(object sender, EventArgs e)
        {
            bool cuentaEncontrada = false;
            foreach (var cliente in clientes)
            {
                if (txtDniBloDes.Text == cliente.DniCli)
                {
                    cuentaEncontrada = true;
                    if (txtClaveBloDes.Text == cliente.ClaveCli.ToString())
                    {
                        if (cliente.BloqueoCli)
                        {
                            btnDesBlo.Visible = true;
                            btnDesBlo.Text = "Desbloquear";
                            cliente.BloqueoCli = false;
                        }
                        if (!cliente.BloqueoCli)
                        {
                            btnDesBlo.Visible = true;
                            btnDesBlo.Text = "Bloquear";
                            cliente.BloqueoCli = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no es correcta");
                    }
                }
            }
            if (!cuentaEncontrada)
            {
                MessageBox.Show("No existe cuenta con el DNI introducido");
                return;
            }
        }
    }
}
