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

namespace MDIwindowsForm
{
    public partial class FormHijo : Form
    {
        private bool documentoNuevo = true; // Si es un documento nuevo, entrara al guardar como, sino, entra a guardar
        private string ruta = string.Empty;

        public FormHijo()
        {
            InitializeComponent();
        }

        public bool DocumentoNuevo { get => documentoNuevo; set => documentoNuevo = value; }
        public string Ruta { get => ruta; set => ruta = value; }
    }
}
