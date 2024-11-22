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
using ClosedXML.Excel;

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

            if (global.EmployeeID != 0)
            {
                // Configuración para empleados
                button1.Visible = false;
                button2.Visible = false;
                btnEditar.Visible = false;
                this.Text = "Vista Empleado - Shipper";
            }
            else
            {
                this.Text = "Vista Admin - Shipper";
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                // Crear un DataTable para almacenar la fila seleccionada
                DataTable selectedData = new DataTable();
                selectedData.Columns.Add("ShipperID", typeof(int));
                selectedData.Columns.Add("CompanyName", typeof(string));
                selectedData.Columns.Add("Phone", typeof(string));

                // Obtener los datos de la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DataRow row = selectedData.NewRow();
                row["ShipperID"] = Convert.ToInt32(selectedRow.Cells["ShipperID"].Value);
                row["CompanyName"] = selectedRow.Cells["CompanyName"].Value.ToString();
                row["Phone"] = selectedRow.Cells["Phone"].Value?.ToString() ?? string.Empty;

                selectedData.Rows.Add(row);

                // Abre la ventana de edición y pasa los datos
                EeditarShip editarForm = new EeditarShip(selectedData);
                editarForm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GradicaShippers gradicaShippers = new GradicaShippers();
            gradicaShippers.ShowDialog();
        }

        private void ExportarTablaAExcel(string query, string nombreHoja, string nombreArchivo, string[] encabezados)
        {
            connect conexion = new connect();
            DataSet ds = conexion.Ejecutar(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Guardar archivo de Excel";
                    saveFileDialog.FileName = nombreArchivo;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (var workbook = new XLWorkbook())
                            {
                                var worksheet = workbook.Worksheets.Add(nombreHoja);

                                // Agregar encabezados
                                for (int i = 0; i < encabezados.Length; i++)
                                {
                                    worksheet.Cell(1, i + 1).Value = encabezados[i];
                                }

                                // Agregar datos
                                int fila = 2;
                                foreach (DataRow row in ds.Tables[0].Rows)
                                {
                                    for (int i = 0; i < encabezados.Length; i++)
                                    {
                                        // Si el índice está fuera del rango, coloca vacío
                                        var valor = i < row.ItemArray.Length ? row[i] : DBNull.Value;
                                        worksheet.Cell(fila, i + 1).Value = valor == DBNull.Value ? "0" : valor.ToString();
                                    }
                                    fila++;
                                }

                                workbook.SaveAs(saveFileDialog.FileName);
                                MessageBox.Show("Archivo exportado exitosamente a: " + saveFileDialog.FileName);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT ShipperID, CompanyName, Phone FROM Shippers";
            string[] encabezados = { "ShipperID", "CompanyName", "Phone" };
            ExportarTablaAExcel(query, "Transportistas", "Transportistas.xlsx", encabezados);
        }
    }
}
