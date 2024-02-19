using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBDDdisenio
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string conexionString;

        public Form1()
        {
            InitializeComponent();
            conexionString = Properties.Settings.Default.ZooBDConnectionString;
            connection = new SqlConnection(conexionString);
        }

        private void zooBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zooBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooBDDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'zooBDDataSet.AnimalZoo' Puede moverla o quitarla según sea necesario.
            this.animalZooTableAdapter.Fill(this.zooBDDataSet.AnimalZoo);
            // TODO: esta línea de código carga datos en la tabla 'zooBDDataSet.AnimalZoo' Puede moverla o quitarla según sea necesario.
            this.animalZooTableAdapter.Fill(this.zooBDDataSet.AnimalZoo);
            // TODO: esta línea de código carga datos en la tabla 'zooBDDataSet.Animal' Puede moverla o quitarla según sea necesario.
            this.animalTableAdapter.Fill(this.zooBDDataSet.Animal);
            // TODO: esta línea de código carga datos en la tabla 'zooBDDataSet.Animal' Puede moverla o quitarla según sea necesario.
            this.animalTableAdapter.Fill(this.zooBDDataSet.Animal);
            // TODO: esta línea de código carga datos en la tabla 'zooBDDataSet.Zoo' Puede moverla o quitarla según sea necesario.
            this.zooTableAdapter.Fill(this.zooBDDataSet.Zoo);
            consultaUnionTablas();
        }

        private void zooBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            consultaUnionTablas();
        }

        private void consultaUnionTablas()
        {
            string consulta = "select * from Animal a Inner Join AnimalZoo az on a.Id=az.animalId where az.zooId = @zooId";
            SqlCommand command = new SqlCommand(consulta, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            using (dataAdapter)
            {
                command.Parameters.AddWithValue("@zooId", txtId.Text);
                DataTable animalTabla = new DataTable();
                dataAdapter.Fill(animalTabla);
                animalZooDataGridView.Columns.Clear();
                animalZooDataGridView.DataSource = animalTabla;
                animalZooDataGridView.Columns["id"].Visible = false;
                animalZooDataGridView.Columns["id1"].Visible = false;
                animalZooDataGridView.Columns["zooID"].Visible = false;
                animalZooDataGridView.Columns["AnimalID"].Visible = false;
                animalZooDataGridView.Columns[0].HeaderText = "Animales";
                animalZooDataGridView.Refresh();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO AnimalZoo VALUES (@ZooId, @AnimalId)";
            SqlCommand command = new SqlCommand(consulta, connection);
            connection.Open();

            command.Parameters.AddWithValue("@ZooId", txtId.Text);
            command.Parameters.AddWithValue("AnimalId", animalDataGridView.SelectedCells[0].Value);

            command.ExecuteScalar();
            connection.Close();
        }
    }
}
