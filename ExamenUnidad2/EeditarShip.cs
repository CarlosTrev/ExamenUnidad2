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
    public partial class EeditarShip : Form
    {
        public EeditarShip(DataTable categoriaData)
        {
            InitializeComponent();
            dataGridView1.DataSource = categoriaData;
        }

        private void EeditarShip_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect conexion = new connect();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // Ignorar la fila nueva

                string query = @"
                            UPDATE Shippers 
                            SET CompanyName = @CompanyName, 
                                Phone = @Phone 
                            WHERE ShipperID = @ShipperID";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    // Asignar parámetros con los valores de las celdas
                    cmd.Parameters.AddWithValue("@CompanyName", row.Cells["CompanyName"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Phone",
                        string.IsNullOrWhiteSpace(row.Cells["Phone"].Value?.ToString()) ? (object)DBNull.Value : row.Cells["Phone"].Value.ToString());
                    cmd.Parameters.AddWithValue("@ShipperID", row.Cells["ShipperID"].Value.ToString());

                    // Ejecutar el comando
                    conexion.EjecutarComando(cmd);
                }
            }

            MessageBox.Show("Shippers actualizados exitosamente.");
            this.Close(); // Cerrar la ventana después de guardar
        }
    }
}
