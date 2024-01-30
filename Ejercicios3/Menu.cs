using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ejercicios3.Menu;
using TextBox = System.Windows.Forms.TextBox;

namespace Ejercicios3
{
    public partial class Menu : Form
    {
        private Alumno[] arrayAlumnos = new Alumno[3];
        private int posicionArray = 0;
        public Menu()
        {
            InitializeComponent();
        }

        public struct Alumno
        {
            public int codAlumno;
            public String nomAlum;
            public String apellAlum;
            public long telfAlum;
            public String emailAlum;
            public String cursoAlum;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            lblInfoMenu.Visible = false;
            gBoxAltas.Visible = false;
            gBoxConsultas.Visible = false;
            gBoxOrdenacionListar.Visible = false;
            if (txtOpcionMenu.Text == "1")
            {
                gBoxAltas.Visible = true;
            }
            else if (txtOpcionMenu.Text == "2")
            {
                gBoxConsultas.Visible = true;
            }
            else if (txtOpcionMenu.Text == "3")
            {
                gBoxOrdenacionListar.Visible = true;
            }
            else if (txtOpcionMenu.Text == "4")
            {
                this.Close();
            }
            else
            {
                lblInfoMenu.Visible = true;
                lblInfoMenu.Text = "La opcion que has introducido\nno corresponde a ningun menu\nni acción";
            }
        }

        public void setAlumnos(Alumno objetoAlumno)
        {
            if (objetoAlumno.nomAlum != "" && objetoAlumno.apellAlum != "")
            {
                if (posicionArray < this.arrayAlumnos.Length)
                {
                    arrayAlumnos[posicionArray] = objetoAlumno;
                    arrayAlumnos[posicionArray].codAlumno = posicionArray;
                    lblInfo.Visible = true;
                    lblInfo.Text = "Datos del alumno " + arrayAlumnos[posicionArray].nomAlum +
                        " introducido correctamente";
                    posicionArray++;
                    // Las siguientes dos lineas son para limpiar los campos del formulario
                    TextBox[] camposFormulario = { txtNombreAlum, txtApellidosAlum, 
                        txtEmailAlum, txtCursoAlum, txtTelfAlum };
                    limpiarFormulario(camposFormulario);
                }
                else
                {
                    lblInfo.Visible = true;
                    lblInfo.Text = "No es posible introducir más alumnos";
                }
            }
            else
            {
                lblInfo.Visible = true;
                lblInfo.Text = "Debes establecer minimo el nombre y los apellidos del alumno";
            }
        }

        private void BtnAceptarDatosAlumno_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtTelfAlum.Text, out long telefono))
            {
                lblInfo.Visible = true;
                lblInfo.Text = "Número de teléfono debe formarse solo por números";
                return;
            }
            for (int i = 0; i < arrayAlumnos.Length; i++)
            {
                if (txtNombreAlum.Text == arrayAlumnos[i].nomAlum)
                {
                    lblInfo.Visible = true;
                    lblInfo.Text = "No se puede repetir el mismo nombre";
                    return;
                }
            }
            Alumno alumno = new Alumno {
                nomAlum = txtNombreAlum.Text,
                apellAlum = txtApellidosAlum.Text,
                telfAlum = telefono,
                emailAlum = txtEmailAlum.Text,
                cursoAlum = txtCursoAlum.Text
            };
            setAlumnos(alumno);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayAlumnos.Length; i++)
            {
                if (txtAlumnoBuscar.Text == arrayAlumnos[i].nomAlum)
                {
                    lblInforAlum.Visible = true;
                    lblInforAlum.Text = "ID: " + arrayAlumnos[i].codAlumno
                        + "\nNombre: " + arrayAlumnos[i].nomAlum
                        + "\nApellidos: " + arrayAlumnos[i].apellAlum
                        + "\nTeléfono: " + arrayAlumnos[i].telfAlum
                        + "\nEmail: " + arrayAlumnos[i].emailAlum
                        + "\nCurso: " + arrayAlumnos[i].cursoAlum;
                    return;
                }
                else
                {
                    lblInforAlum.Visible = true;
                    lblInforAlum.Text = "No se ha encontrado al alumno";
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (posicionArray == 0)
            {
                lblOrdenado.Visible = true;
                lblOrdenado.Text = "No es posible realizar la ordenacion.\nNo se han dado de alta alumnos";
                return;
            }

            for (int i = 0; i < posicionArray - 1; i++)
            {
                for (int j = 0; j < posicionArray - i - 1; j++)
                {
                    if (string.Compare(arrayAlumnos[j].apellAlum, arrayAlumnos[j + 1].apellAlum) > 0)
                    {
                        Alumno aux = arrayAlumnos[j];
                        arrayAlumnos[j] = arrayAlumnos[j + 1];
                        arrayAlumnos[j + 1] = aux;
                    }
                }
            }
            lblOrdenado.Visible = true;
            lblOrdenado.Text = "Ordenación completada exitosamente";
            btnListarAlumnos.Visible = true;
        }

        private void btnListarAlumnos_Click(object sender, EventArgs e)
        {
            lblInfoAlumnosOrdenados.Visible = true;
            lblInfoAlumnosOrdenados.Text = "";
            for (int i = 0; i < posicionArray; i++)
            {
                lblInfoAlumnosOrdenados.Text += "Código: " + arrayAlumnos[i].codAlumno + "\n";
                lblInfoAlumnosOrdenados.Text += "Nombre: " + arrayAlumnos[i].nomAlum + "\n";
                lblInfoAlumnosOrdenados.Text += "Apellidos: " + arrayAlumnos[i].apellAlum + "\n";
                lblInfoAlumnosOrdenados.Text += "Teléfono: " + arrayAlumnos[i].telfAlum + "\n";
                lblInfoAlumnosOrdenados.Text += "Email: " + arrayAlumnos[i].emailAlum + "\n";
                lblInfoAlumnosOrdenados.Text += "Curso: " + arrayAlumnos[i].cursoAlum + "\n";
                lblInfoAlumnosOrdenados.Text += "------------------------------\n";
            }
        }

        private void limpiarFormulario(TextBox[] formulariosTxt)
        {
            foreach (TextBox formulario in formulariosTxt)
            {
                formulario.Clear();
            }
        }
    }
}
