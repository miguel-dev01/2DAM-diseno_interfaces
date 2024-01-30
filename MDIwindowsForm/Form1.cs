using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIwindowsForm
{
    public partial class FormPadre : Form
    {
        private int numDocumento = 1;

        public FormPadre()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHijo formularioHijo = new FormHijo();

            formularioHijo.MdiParent = this;
            formularioHijo.Text += " " + numDocumento++.ToString();

            formularioHijo.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FormHijo formularioHijo = new FormHijo();
                    formularioHijo.MdiParent = this;
                    filePath = openFileDialog.FileName;
                    formularioHijo.Text = openFileDialog.SafeFileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    formularioHijo.Show();

                    RichTextBox rtbDocumento = (RichTextBox)formularioHijo.ActiveControl;
                    rtbDocumento.Text = fileContent;

                    formularioHijo.DocumentoNuevo = false;
                    formularioHijo.Ruta = filePath;
                }
            }
        }

        private void guardarcomoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }

            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;
                    writer.Write(rtbDocumento.Text);
                }
            }
            hijoActivo.Ruta = saveFileDialog.FileName;
            hijoActivo.Text = Path.GetFileName(saveFileDialog.FileName);
            hijoActivo.DocumentoNuevo = false;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }

            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;

            if (hijoActivo.DocumentoNuevo)
            {
                GuardarComo(hijoActivo);
            }
            else
            {
                Guardar(hijoActivo);
            }
        }

        private void Guardar(FormHijo formulario)
        {
            RichTextBox rtbDocumento = (RichTextBox)formulario.ActiveControl;
            using (StreamWriter writer = new StreamWriter(formulario.Ruta))
            {
                writer.Write(rtbDocumento.Text);
            }
        }

        private void GuardarComo(FormHijo formulario)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    RichTextBox rtbDocumento = (RichTextBox)formulario.ActiveControl;
                    writer.Write(rtbDocumento.Text);
                }
            }

            formulario.DocumentoNuevo = false;
            formulario.Ruta = saveFileDialog.FileName;
            formulario.Text = Path.GetFileName(saveFileDialog.FileName);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Metodo para comprobar si ha habido cambios en un formulario con respecto de su fichero.txt
        private bool checkContentFormFile(FormHijo form)
        {
            RichTextBox rtbDocumento = (RichTextBox)form.ActiveControl;
            if (rtbDocumento.TextLength == 0) { return false; }
            if (form.Ruta == "") { return true; }

            string fileContent = string.Empty;
            using (StreamReader reader = new StreamReader(form.Ruta))
            {
                fileContent = reader.ReadToEnd();
            }

            if (rtbDocumento.Text != fileContent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;
            RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;

            rtbDocumento.Copy();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;
            RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;

            rtbDocumento.Undo();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;
            RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;

            rtbDocumento.Redo();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;
            RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;

            rtbDocumento.Cut();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;
            RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;

            rtbDocumento.Paste();
        }

        private void seleccionartodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;
            RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;

            rtbDocumento.SelectAll();
        }

        private void colorTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;
            RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;
            // Verificar si hay algo seleccionado en RichTextBox
            if (rtbDocumento.SelectionLength > 0)
            {
                // Aplicar el color solo al texto seleccionado
                colorDialog1.ShowDialog();
                rtbDocumento.SelectionColor = colorDialog1.Color;
            }
        }

        private void colorFondoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;
            RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;
            if (rtbDocumento.SelectionLength > 0)
            {
                colorDialog1.ShowDialog();
                rtbDocumento.SelectionBackColor = colorDialog1.Color;
            }
        }

        private void colorDeFondoDeFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;
            RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;
            colorDialog1.ShowDialog();
            rtbDocumento.BackColor = colorDialog1.Color;
        }

        private void formatoDelTextofuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            FormHijo hijoActivo = (FormHijo)ActiveMdiChild;
            RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;
            fontDialog1.ShowDialog();
            rtbDocumento.Font = fontDialog1.Font;
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("REALIZADO POR MIGUEL SANCHEZ GARCIA", "Diseño de interfaces 2DAM");
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void FormPadre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }

            Form[] hijosActivos = this.MdiChildren;
            foreach (FormHijo hijoActivo in hijosActivos.Cast<FormHijo>())
            {
                if (checkContentFormFile(hijoActivo))
                {
                    DialogResult result = MessageBox.Show("Hay documentos que se han modificado y " +
                        "no han guardado sus datos.\n¿Desea guardarlos y salir?",
                        hijoActivo.Text + " sin guardar", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        if (hijoActivo.Ruta == "")
                        {
                            GuardarComo(hijoActivo);
                        }
                        else
                        {
                            using (StreamWriter writer = new StreamWriter(hijoActivo.Ruta))
                            {
                                RichTextBox rtbDocumento = (RichTextBox)hijoActivo.ActiveControl;
                                writer.Write(rtbDocumento.Text);
                            }
                        }
                        hijoActivo.Close();
                    }
                    else if (result == DialogResult.No)
                    {
                        hijoActivo.Close();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Evitar que el formulario se cierra si hace click en cancelar
                        e.Cancel = true;
                    }
                }
                else
                {
                    hijoActivo.Close();
                }
            }
        }
    }
}
