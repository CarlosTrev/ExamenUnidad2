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
    public partial class EcategoriasEditar : Form
    {
        public EcategoriasEditar(DataTable categoriaData)
        {
            InitializeComponent();

            dataGridView1.DataSource = categoriaData;
        }

        private void btnCateEditar_Click(object sender, EventArgs e)
        {
            connect conexion = new connect();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string query = @"
            UPDATE Categories 
            SET CategoryName = @CategoryName, 
                Description = @Description 
            WHERE CategoryID = @CategoryID";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    // Asignar parámetros con los valores de las celdas
                    cmd.Parameters.AddWithValue("@CategoryName", row.Cells["CategoryName"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Description",
                        string.IsNullOrWhiteSpace(row.Cells["Description"].Value?.ToString()) ? (object)DBNull.Value : row.Cells["Description"].Value.ToString());
                    cmd.Parameters.AddWithValue("@CategoryID", row.Cells["CategoryID"].Value.ToString());

                    // Ejecutar el comando
                    conexion.EjecutarComando(cmd);
                }
            }

            MessageBox.Show("Categorías actualizadas exitosamente.");
            this.Close(); // Cerrar la ventana después de guardar
        }
    }
}
