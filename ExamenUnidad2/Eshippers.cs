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

namespace ExamenUnidad2
{
    public partial class Eshippers : Form
    {
        public Eshippers()
        {
            InitializeComponent();
        }

        private void CargarShippers()
        {
            connect conexion = new connect();
            string consulta = "SELECT * FROM Shippers";
            DataSet ds = conexion.Ejecutar(consulta);

            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Eshippers_Load(object sender, EventArgs e)
        {
            connect conexion = new connect();
            string consulta = "SELECT * FROM Shippers";
            DataSet ds = conexion.Ejecutar(consulta);

            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect conexion = new connect();
            string query = "INSERT INTO Shippers (CompanyName, Phone) VALUES (@CompanyName, @Phone)";

            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@CompanyName", textBox1.Text);
                cmd.Parameters.AddWithValue("@Phone", textBox2.Text);

                bool resultado = conexion.EjecutarComando(cmd);

                if (resultado)
                {
                    dataGridView1.Refresh();
                    MessageBox.Show("Shipper agregado exitosamente.");
                    CargarShippers(); // Método para recargar los datos de la tabla
                }
                else
                {
                    MessageBox.Show("Error al agregar el Shipper.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                int shipperId = Convert.ToInt32(selectedRow.Cells["ShipperID"].Value);

                string consultaEliminar = "DELETE FROM Shippers WHERE ShipperID = @ShipperID";

                try
                {
                    connect conexion = new connect();
                    using (SqlCommand cmd = new SqlCommand(consultaEliminar))
                    {
                        cmd.Parameters.AddWithValue("@ShipperID", shipperId);

                        bool resultado = conexion.EjecutarComando(cmd);
                        if (resultado)
                        {
                            MessageBox.Show("Shipper eliminado exitosamente.");
                            CargarShippers(); // Método para recargar la tabla con los datos actualizados
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el Shipper.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una celda para eliminar el Shipper.");
            }
        }
    }
}
