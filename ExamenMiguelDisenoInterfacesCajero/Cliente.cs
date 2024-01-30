using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMiguelDiseñoInterfacesCajero
{
    public class Cliente
    {
        private string dniCli;
        private string nombreCli;
        private bool bloqueoCli; // tarjeta
        private int claveCli;
        private double saldoClie;

        public Cliente() { }

        public Cliente(string dniCli, string nombreCli, bool bloqueoCli, int claveCli, double saldoCli)
        {
            this.DniCli = dniCli;
            this.NombreCli = nombreCli;
            this.BloqueoCli = bloqueoCli;
            this.ClaveCli = claveCli;
            this.SaldoClie = saldoCli;
        }

        public string DniCli { get => dniCli; set => dniCli = value; }
        public string NombreCli { get => nombreCli; set => nombreCli = value; }
        public bool BloqueoCli { get => bloqueoCli; set => bloqueoCli = value; }
        public int ClaveCli { get => claveCli; set => claveCli = value; }
        public double SaldoClie { get => saldoClie; set => saldoClie = value; }

        //public String toString()
        //{

        //}
    }
}
