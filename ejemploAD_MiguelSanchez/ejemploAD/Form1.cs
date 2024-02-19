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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.CodeDom.Compiler;

// Ejemplo de acceso a datos en SQLServer con C#
namespace ejemploAD
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.Conexion;
            connection = new SqlConnection(connectionString);
            showZoos();
        }

        private void showData2()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Animal";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos");
                    }
                }
                connection.Close();
            }
        }

        private void loadAnimals()
        {
            string query = "select * from Animal a Inner Join AnimalZoo az on a.Id = az.animalId where az.ZooId=@zooId";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            command.Parameters.AddWithValue("@zooId", lstBoxCiuidades.SelectedValue);

            DataTable table = new DataTable();
            adapter.Fill(table);

            lstBoxZoo.DisplayMember = "Nombre";
            lstBoxZoo.ValueMember = "Id";

            lstBoxZoo.DataSource = table.DefaultView;
            connection.Close();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            // showData();
        }

        private void btnCargarDatoAdapter_Click(object sender, EventArgs e)
        {
            showData2();
        }

        private void showZoos()
        {
            // connection.Open();
            string query = "SELECT * FROM Zoo";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            lstBoxCiuidades.DisplayMember = "Ubicación";
            lstBoxCiuidades.ValueMember = "Id";

            lstBoxCiuidades.DataSource = table.DefaultView;
            connection.Close();
        }

        private void lstBoxCiuidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAnimals();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtInsert.Text == "")
            {
                return;
            }
            connection.Open();
            string consulta = "Insert into Zoo values (@Ubicacion)";
            SqlCommand miCommand = new SqlCommand(consulta, connection);
            miCommand.Parameters.AddWithValue("@Ubicacion", txtInsert.Text);
            miCommand.ExecuteScalar();
            showZoos();
            connection.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string consulta = "Delete from Zoo where id = @ZooId";
            SqlCommand miCommand = new SqlCommand(consulta, connection);
            miCommand.Parameters.AddWithValue("@ZooId", lstBoxCiuidades.SelectedValue);
            miCommand.ExecuteScalar();
            showZoos();
            connection.Close();
        }
    }
}
