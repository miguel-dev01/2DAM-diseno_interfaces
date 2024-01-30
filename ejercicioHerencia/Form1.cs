using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioHerencia
{
    public partial class FormCuentaBancaria : Form
    {
        List<Cuenta> cuentasList = new List<Cuenta>();
        Cuenta cuenta = new Cuenta();
        CuentaEmpresa cuentaEmpresa = new CuentaEmpresa();
        private Boolean seleccionConsultaNumCuenta = false;
        public FormCuentaBancaria()
        {
            InitializeComponent();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxAltas.Visible = true;
            rBtnCuentaParticular.Checked = true;
        }

        private void btnCancelarAltas_Click(object sender, EventArgs e)
        {
            gBoxAltas.Visible = false;
        }

        private void btnAceptarAltas_Click(object sender, EventArgs e)
        {
            lblInfoAltas.Visible = false;
            if (rBtnCuentaParticular.Checked)
            {
                if (Double.TryParse(txtSaldo.Text, out double saldo))
                {
                    cuenta = new Cuenta(txtTitular.Text, txtDni.Text, saldo);
                    txtNumCuentaAltas.Text = cuenta.Numero.ToString();
                    cuentasList.Add(cuenta);
                    lblInfoAltas.Visible = true;
                    lblInfoAltas.Text = "Cuenta añadida exitosamente";
                }
                else
                {
                    lblInfoAltas.Visible = true;
                    lblInfoAltas.Text = "El campo saldo solo permite numeros.";
                }
            }
            if (rBtnCuentaEmpresa.Checked)
            {
                if (Double.TryParse(txtSaldo.Text, out double saldo) && 
                    long.TryParse(txtInteresAlta.Text, out long interes) && 
                    Double.TryParse(txtCreditoAltas.Text, out double credito) && 
                    Int32.TryParse(txtMesesCreditoAltas.Text, out int mesesCredito) &&
                    Double.TryParse(txtTopeCreditoAltas.Text, out double topeCredito))
                {
                    cuentaEmpresa = new CuentaEmpresa(interes, credito, mesesCredito, topeCredito,
                        txtTitular.Text, txtDni.Text, saldo);
                    txtNumCuentaAltas.Text = cuentaEmpresa.Numero.ToString();
                    cuentasList.Add(cuentaEmpresa);
                    lblInfoAltas.Visible = true;
                    lblInfoAltas.Text = "Cuenta añadida exitosamente";
                }
                else
                {
                    MessageBox.Show("Los campos de 'Saldo', 'Interes', 'Credito', 'Meses credito' y 'Tope credito' " +
                        "solo permiten recibir numeros enteros");
                }
            }
        }

        private void porNumeroDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionConsultaNumCuenta = true;
            gBoxConsultas.Visible = true;
            lblDniConsulta.Visible = false;
            txtDniConsulta.Visible = false;
            lblNumCuentaConsulta.Visible = true;
            txtNumeroConsulta.Visible = true;
            txtDniConsulta.Text = "";
        }

        private void porDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionConsultaNumCuenta = false;
            gBoxConsultas.Visible = true;
            lblDniConsulta.Visible = true;
            txtDniConsulta.Visible = true;
            lblNumCuentaConsulta.Visible = false;
            txtNumeroConsulta.Visible = false;
            txtNumeroConsulta.Text = "";
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            gBoxConsultas.Visible = false;
        }

        private void btnAceptarConsulta_Click(object sender, EventArgs e)
        {
            if (seleccionConsultaNumCuenta)
            {
                if (!string.IsNullOrEmpty(txtNumeroConsulta.Text))
                {
                    if (Int32.TryParse(txtNumeroConsulta.Text, out int numeroCuenta))
                    {
                        bool cuentaEncontrada = false;
                        foreach (var cuenta in cuentasList)
                        {
                            if (numeroCuenta == cuenta.Numero)
                            {
                                cuentaEncontrada = true;
                                CuentaEmpresa cuentaEmpresa = cuenta as CuentaEmpresa;
                                if (cuentaEmpresa != null)
                                {
                                    cuentaEncontrada = true;
                                    MessageBox.Show("CUENTA EMPRESA:\n" + cuentaEmpresa.ToString(), "Consulta por número de cuenta");
                                    break;
                                }
                                MessageBox.Show(cuenta.ToString(), "Consulta por número de cuenta");
                                break;
                            }
                        }
                        if (!cuentaEncontrada)
                        {
                            MessageBox.Show("No se ha encontrado ninguna cuenta asociada a ese código", "Consulta por número de cuenta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'Numero' solo permite recibir enteros", "Consulta por número de cuenta");
                    }
                }
                else
                {
                    MessageBox.Show("El campo 'Numero' no puede estar vacío", "Consulta por número de cuenta");
                }
            }

            if (!seleccionConsultaNumCuenta)
            {
                if (!string.IsNullOrEmpty(txtDniConsulta.Text))
                {
                    bool cuentaEncontrada = false;
                    foreach (var cuenta in cuentasList)
                    {
                        if (txtDniConsulta.Text == cuenta.Dni)
                        {
                            cuentaEncontrada = true;
                            CuentaEmpresa cuentaEmpresa = cuenta as CuentaEmpresa;
                            if (cuentaEmpresa != null)
                            {
                                cuentaEncontrada = true;
                                MessageBox.Show("CUENTA EMPRESA:\n" + cuentaEmpresa.ToString(), "Consulta por número de cuenta");
                                break;
                            }
                            MessageBox.Show(cuenta.ToString(), "Consulta por DNI");
                            break;
                        }
                    }
                    if (!cuentaEncontrada)
                    {
                        MessageBox.Show("No se ha encontrado ninguna cuenta asociada a ese DNI", "Consulta por DNI");
                    }
                }
                else
                {
                    MessageBox.Show("El campo 'DNI' no puede estar vacío", "Consulta por DNI");
                }
            }
        }

        private void reintegrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxReintegros.Visible = true;
            gBoxTransferencias.Visible = false;
        }

        private void btnCancelarReintegro_Click(object sender, EventArgs e)
        {
            gBoxReintegros.Visible = false;
            lblResultadoReintegro.Visible = false;
            lblResultadoReintegro.Text = "";
            txtNumCuentaReintegro.Text = "";
            txtImporteReintegro.Text = "";
        }

        private void btnAceptarReintegro_Click(object sender, EventArgs e)
        {
            lblResultadoReintegro.Visible = false;
            if (Int32.TryParse(txtNumCuentaReintegro.Text, out int numeroCuenta) &&
                Double.TryParse(txtImporteReintegro.Text, out double importe))
            {
                bool cuentaEncontrada = false;
                foreach (var cuenta in cuentasList)
                {
                    if (numeroCuenta == cuenta.Numero)
                    {
                        cuentaEncontrada = true;
                        cuenta.Reintegro(importe);
                        break;
                    }
                }
                if (!cuentaEncontrada)
                {
                    lblResultadoReintegro.Visible = true;
                    lblResultadoReintegro.Text = "No existe ninguna cuenta asociada a ese numero de cuenta";
                }
            }
            else
            {
                lblResultadoReintegro.Visible = true;
                lblResultadoReintegro.Text = "Los campos de 'Numero cuenta' e 'Importe' deben tener valor \ny solo permiten enteros";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gBoxIngresos.Visible = true;
            gBoxTransferencias.Visible = false;
        }

        private void btnCancelarIngreso_Click(object sender, EventArgs e)
        {
            gBoxIngresos.Visible = false;
            txtImporteIngreso.Text = "";
            txtNumCuentaIngreso.Text = "";
            lblResultadoIngreso.Visible = false;
        }

        private void btnAceptarIngreso_Click(object sender, EventArgs e)
        {
            lblResultadoIngreso.Visible = false;
            if (Int32.TryParse(txtNumCuentaIngreso.Text, out int numeroCuenta) &&
                Double.TryParse(txtImporteIngreso.Text, out double importe))
            {
                bool cuentaEncontrada = false;
                foreach (var cuenta in cuentasList)
                {
                    if (numeroCuenta == cuenta.Numero)
                    {
                        cuentaEncontrada = true;
                        cuenta.Ingreso(importe);
                        break;
                    }
                }
                if (!cuentaEncontrada)
                {
                    lblResultadoIngreso.Visible = true;
                    lblResultadoIngreso.Text = "No existe ninguna cuenta asociada a ese numero de cuenta";
                }
            }
            else
            {
                lblResultadoIngreso.Visible = true;
                lblResultadoIngreso.Text = "Los campos de 'Numero cuenta' e 'Importe' deben tener valor \ny solo permiten enteros";
            }
        }

        private void realizarTransferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxTransferencias.Visible = true;
        }

        private void btnCancelarTrans_Click(object sender, EventArgs e)
        {
            gBoxTransferencias.Visible = false;
            txtImporteTrans.Text = "";
            txtNumCuentaDestinoTrans.Text = "";
            txtNumCuentaOrigenTrans.Text = "";
        }

        private void btnEnviarTrans_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtNumCuentaOrigenTrans.Text, out int numCuentaOrigen) &&
                Int32.TryParse(txtNumCuentaDestinoTrans.Text, out int numCuentaDestino) &&
                Int32.TryParse(txtImporteTrans.Text, out int importe))
            {
                if (numCuentaOrigen == numCuentaDestino)
                {
                    MessageBox.Show("Mismos números de cuenta y de destino");
                    return;
                }
                bool cuentaOrigenEncontrada = false;
                bool cuentaDestinoEncontrada = false;
                foreach (var cuenta in cuentasList)
                {
                    if (cuenta.Numero == numCuentaOrigen)
                    {
                        cuentaOrigenEncontrada = true;
                        if (cuenta.Saldo >= importe)
                        {
                            cuenta.Saldo -= importe;
                            foreach (var cuentaDestino in cuentasList)
                            {
                                if (cuentaDestino.Numero == numCuentaDestino)
                                {
                                    cuentaDestinoEncontrada = true;
                                    cuentaDestino.Saldo += importe;
                                    MessageBox.Show($"Transferencia realizada correctamente" +
                                        $"\nSaldo actual cuenta origen: {cuenta.Saldo}\nSaldo actual cuenta destino: {cuentaDestino.Saldo}");
                                    break;
                                }
                            }
                            if (!cuentaDestinoEncontrada)
                            {
                                MessageBox.Show("Cuenta de destino no encontrada");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Saldo insuficiente en la cuenta de origen");
                        }
                        break;
                    }
                }
                if (!cuentaOrigenEncontrada)
                {
                    MessageBox.Show("Cuenta de origen no encontrada");
                }
            }
            else
            {
                MessageBox.Show("Los campos de 'Cuenta de origen', 'Cuenta de destino' e 'Importe' solo permiten enteros");
            }
        }

        private void rBtnCuentaEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCuentaEmpresa.Checked)
            {
                txtCreditoAltas.ReadOnly = false;
                txtInteresAlta.ReadOnly = false;
                txtMesesCreditoAltas.ReadOnly = false;
                txtTopeCreditoAltas.ReadOnly = false;
            }
        }

        private void rBtnCuentaParticular_CheckedChanged(object sender, EventArgs e)
        {
            txtCreditoAltas.ReadOnly = true;
            txtInteresAlta.ReadOnly = true;
            txtMesesCreditoAltas.ReadOnly = true;
            txtTopeCreditoAltas.ReadOnly = true;
            txtCreditoAltas.Text = "";
            txtInteresAlta.Text = "";
            txtMesesCreditoAltas.Text = "";
            txtTopeCreditoAltas.Text = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AUTOR: MIGUEL SANCHEZ GARCIA");
        }

        private void concederCreditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxConcederCredito.Visible = true;
            txtNumCuentaConcederCreditos.Text = "";
            txtImporteCreditos.Text = "";
        }

        private void btnCancelarCreditos_Click(object sender, EventArgs e)
        {
            gBoxConcederCredito.Visible = false;
        }

        private void btnConcederCredito_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtNumCuentaConcederCreditos.Text, out int numeroCuenta) &&
                Double.TryParse(txtImporteCreditos.Text, out double importe))
            {
                bool cuentaEncontrada = false;
                foreach (var cuenta in cuentasList)
                {
                    if (numeroCuenta == cuenta.Numero)
                    {
                        if (cuenta.GetType() == typeof(CuentaEmpresa))
                        {
                            cuentaEncontrada = true;
                            cuentaEmpresa.Reintegro(importe);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No es posible conceder credito a una cuenta que no es de empresa");
                            return;
                        }
                    }
                }
                if (!cuentaEncontrada)
                {
                    MessageBox.Show("No existe ninguna cuenta asociada a ese número de cuenta");
                }
            }
            else
            {
                MessageBox.Show("Los campos de 'Numero cuenta' e 'Importe' deben tener valor y solo permiten enteros");
            }
        }

        private void mostrarCreditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxMostrarCreditos.Visible = true;
        }

        private void btnCancelarMostrarCredito_Click(object sender, EventArgs e)
        {
            gBoxMostrarCreditos.Visible = false;
            txtNumCuentaMostrarCredito.Text = "";
        }

        private void btnMostrarCredito_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtNumCuentaMostrarCredito.Text, out int numeroCuenta) &&
                Int32.TryParse(txtMesesCreditoMostrar.Text, out int mesesCredito))
            {
                bool cuentaEncontrada = false;
                foreach (var cuenta in cuentasList)
                {
                    if (numeroCuenta == cuenta.Numero)
                    {
                        if (cuenta.GetType() == typeof(CuentaEmpresa))
                        {
                            cuentaEncontrada = true;
                            cuentaEmpresa.MostrarCredito(mesesCredito);
                            break;
                        }
                    }
                }
                if (!cuentaEncontrada)
                {
                    MessageBox.Show("Cuenta de EMPRESA no encontrada");
                }
            }
            else
            {
                MessageBox.Show("El campo 'Numero' y 'Meses credito' solo permite recibir enteros");
            }
        }
    }
}
