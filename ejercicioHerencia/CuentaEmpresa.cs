using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioHerencia
{
    internal class CuentaEmpresa : Cuenta
    {
        private long interes;
        private double credito;
        private int mesesCredito;
        private double topeCredito;

        public CuentaEmpresa() {}

        public CuentaEmpresa(long interes, double credito, int mesesCredito, double topeCredito, 
            string titular, string dni, double saldo) : base(titular, dni, saldo)
        {
            this.interes = interes;
            this.credito = credito;
            this.mesesCredito = mesesCredito;
            this.topeCredito = topeCredito;
        }

        public long Interes { get => interes; set => interes = value; }
        public double Credito { get => credito; set => credito = value; }
        public int MesesCredito { get => mesesCredito; set => mesesCredito = value; }
        public double TopeCredito { get => topeCredito; set => topeCredito = value; }

        public override void Reintegro(double importe)
        {
            if (Saldo < importe)
            {
                CalcularCredito(importe - Saldo);
                Saldo = 0;
            }
            else
            {
                Saldo -= (long)importe;
            }
        }

        private void CalcularCredito(double diferencia)
        {
            if (credito + diferencia <= topeCredito)
            {
                credito += diferencia;
                MessageBox.Show($"Cálculo de crédito realizado correctamente. Crédito actual: {credito}");
            }
            else
            {
                double sobrante = (credito + diferencia) - topeCredito;
                credito = topeCredito;
                MessageBox.Show($"Crédito máximo alcanzado. Se ha añadido {sobrante} al saldo.");
                Saldo += sobrante;
            }
        }

        public void MostrarCredito(int mesesCredito)
        {
            double cuotaMensual = (credito + (credito * interes) / 100) / mesesCredito;
            MessageBox.Show($"Crédito: {credito}\nInterés: {interes}\nCuota Mensual: {cuotaMensual}");
        }

        public override string ToString()
        {
            return $"Número de cuenta: {Numero}\nTitular: {Titular}\nDNI: {Dni}\nSaldo: {Saldo}" +
                $"\nInterés: {interes}\nCrédito: {credito}\nMeses de Crédito: {mesesCredito}\nTope de Crédito: {topeCredito}";
        }

    }
}
