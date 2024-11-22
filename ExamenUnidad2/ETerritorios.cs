using ClosedXML.Excel;
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
    public partial class ETerritorios : Form
    {
        public ETerritorios()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void CargarTerritorioempleados()
        {
            connect conexion = new connect();
            string consulta = "SELECT Employees.FirstName + ' ' + Employees.LastName AS EmployeeName,Territories.TerritoryDescription FROM EmployeeTerritories " +
                "JOIN Employees ON EmployeeTerritories.EmployeeID = Employees.EmployeeID " +
                "JOIN Territories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID";
            DataSet ds = conexion.Ejecutar(consulta);

            if (ds != null)
            {
                dgvETerritorios.DataSource = ds.Tables[0];
            }
        }
        public void CargarTerritorios()
        {
            connect conexion = new connect();
            string consulta = "SELECT " +
                "Territories.TerritoryID," +
                "Territories.TerritoryDescription," +
                "Region.RegionDescription " +
                "FROM Territories " +
                "JOIN Region ON Territories.RegionID = Region.RegionID;";
            DataSet ds = conexion.Ejecutar(consulta);

            if (ds != null)
            {
                dgvTerritorios.DataSource = ds.Tables[0];
            }
        }
        private void CargarRegion()
        {
            connect conexion = new connect();
            string consulta = "SELECT * FROM Region";
            DataSet ds = conexion.Ejecutar(consulta);

            if (ds != null)
            {
                dgvRegion.DataSource = ds.Tables[0];
            }
        }

        private void ETerritorios_Load(object sender, EventArgs e)
        {
            CargarRegion();
            CargarTerritorioempleados();
            CargarTerritorios();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnATE_Click(object sender, EventArgs e)
        {
            connect conexion = new connect();
            string query = "INSERT INTO EmployeeTerritories (EmployeeID, TerritoryID) VALUES (@EmployeeID, @TerritoryID)";

            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", txtidempleado.Text);
                cmd.Parameters.AddWithValue("@TerritoryID", txtidterritorio.Text);

                bool resultado = conexion.EjecutarComando(cmd);

                if (resultado)
                {
                    dgvETerritorios.Refresh();
                    MessageBox.Show("Territorio agregado exitosamente al empleado.");
                    CargarTerritorioempleados();

                }
                else
                {
                    MessageBox.Show("Error al agregar el territorio al empleado.");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnETE_Click(object sender, EventArgs e)
        {
            if (dgvETerritorios.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvETerritorios.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvETerritorios.Rows[selectedRowIndex];

                int employeeId = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
                string territoryId = selectedRow.Cells["TerritoryID"].Value.ToString();

                string consultaEliminar = "DELETE FROM EmployeeTerritories WHERE EmployeeID = @EmployeeID AND TerritoryID = @TerritoryID";

                try
                {
                    connect conexion = new connect();
                    using (SqlCommand cmd = new SqlCommand(consultaEliminar))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                        cmd.Parameters.AddWithValue("@TerritoryID", territoryId);

                        bool resultado = conexion.EjecutarComando(cmd);
                        if (resultado)
                        {
                            MessageBox.Show("Territorio eliminado exitosamente.");
                            CargarTerritorioempleados();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el territorio.");
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
                MessageBox.Show("Por favor selecciona una celda para eliminar el territorio.");
            }
        }

        private void btnAT_Click(object sender, EventArgs e)
        {
            ETerritoriosAgregar eTerritoriosAgregar = new ETerritoriosAgregar();
            eTerritoriosAgregar.Show();

        }

        private void btnET_Click(object sender, EventArgs e)
        {
            if (dgvTerritorios.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvTerritorios.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvETerritorios.Rows[selectedRowIndex];
                string territoryIdT = selectedRow.Cells["TerritoryID"].Value.ToString();

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este territorio?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {

                    string consulta = "DELETE FROM Territories WHERE TerritoryID = @TerritoryID";

                    try
                    {
                        connect conexion = new connect();
                        using (SqlCommand cmd = new SqlCommand(consulta))
                        {
                            cmd.Parameters.AddWithValue("@TerritoryID", territoryIdT);

                            bool exito = conexion.EjecutarComando(cmd);

                            if (exito)
                            {
                                MessageBox.Show("Territorio eliminado exitosamente.");
                                CargarTerritorios();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el territorio.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el territorio: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para eliminar el territorio.");
            }
        }

        private void btnAR_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT RegionID, RegionDescription FROM Region";
            string[] encabezados = { "RegionID", "RegionDescription" };
            ExportarTablaAExcel(query, "Regiones", "Regiones.xlsx", encabezados);
        }
    }
}
