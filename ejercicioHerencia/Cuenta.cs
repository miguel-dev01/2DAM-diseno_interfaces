using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioHerencia
{
    internal class Cuenta
    {
        private static int ultimoNumeroCuenta;
        private int numero;
        private string titular;
        private string dni;
        private double saldo;

        public Cuenta() { }
        public Cuenta(string titular, string dni, double saldo)
        {
            ultimoNumeroCuenta++;
            this.Numero = ultimoNumeroCuenta;
            this.Titular = titular;
            this.Dni = dni;
            this.Saldo = saldo;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Titular { get => titular; set => titular = value; }
        public string Dni { get => dni; set => dni = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public virtual void Reintegro(double importe)
        {
            if (Saldo <= 0 || importe > Saldo)
            {
                MessageBox.Show($"No es posible realizar el reintegro\nNo hay suficiente saldo en la cuenta\nSaldo actual: {Saldo}");
                return;
            }
            Saldo -= importe;
            MessageBox.Show($"Reintegro realizado correctamente\nSaldo actual: {Saldo}");
        }

        public void Ingreso(double importe)
        {
            if (importe < 0) {
                MessageBox.Show("No se pueden introducir numeros negativos para el ingreso");
                return;
            }
            Saldo += importe;
            MessageBox.Show($"Ingreso realizado correctamente\nSaldo actual: {Saldo}");
        }

        public override string ToString()
        {
            return $"Número de cuenta: {numero}\nTitular: {titular}\nDNI: {dni}\nSaldo: {saldo}";
        }
    }
}
