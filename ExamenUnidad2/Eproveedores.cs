using OxyPlot.Series;
using OxyPlot;
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
using OxyPlot.Axes;
using ClosedXML.Excel;

namespace ExamenUnidad2
{
    public partial class Eproveedores : Form
    {
        DataSet ds;
        public Eproveedores()
        {
            InitializeComponent();
        }
        private void CargarDatosGrid(string comando)
        {
            connect dt = new connect();
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dgCProvee.DataSource = ds.Tables[0];
            }
        }

        public void ActualizarDatosPyV()
        {
            try
            {
                connect conexion = new connect();


                string query = "SELECT * FROM Suppliers";


                DataSet ds = conexion.Ejecutar(query);


                if (ds != null && ds.Tables.Count > 0)
                {

                    cboxProvee.ResetText();
                    txtBoxProvee.Clear();
                    dgCProvee.DataSource = ds.Tables[0];
                    dgCProvee.Refresh();
                }
                else
                {

                    MessageBox.Show("No se pudieron cargar los datos de las ordenes.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error al actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eproveedores_Load(object sender, EventArgs e)
        {
            ActualizarDatosPyV();

            this.Text = global.EmployeeID == 0 ? "Vista Admin - Proveedores" : "Vista Empleado - Proveedores";

            if (global.EmployeeID != 0)
            {
                dgCProvee.ReadOnly = true;
            }

            if (global.EmployeeID != 0)
            {
                // Ocultar o deshabilitar botones para empleados
                butAgregar.Visible = false; // Oculta el botón de agregar
                btnBorrar.Visible = false;  // Oculta el botón de borrar
                btnEditar.Visible = false;  // Oculta el botón de editar

            }
        }

        private void cboxProvee_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxProvee.Enabled = true;
        }

        private void txtBoxProvee_TextChanged(object sender, EventArgs e)
        {
            CargarDatosGrid("SELECT * FROM Suppliers WHERE " + cboxProvee.Text.Trim().Replace(" ", "") + " LIKE '%" + txtBoxProvee.Text.Trim() + "%'");
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de los campos, opcional pero recomendado
                //if (string.IsNullOrWhiteSpace(txtBoxCompanyName.Text) || string.IsNullOrWhiteSpace(txtBoxContactName.Text) ||
                //  string.IsNullOrWhiteSpace(txtBoxContactTitle.Text) || string.IsNullOrWhiteSpace(txtBoxAddress.Text))
                //{
                //  MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                //return;
                //}

                connect conexion = new connect();

                // Construcción de la consulta SQL de inserción
                string query = @"
                INSERT INTO Suppliers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage) 
                VALUES (@CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax, @HomePage)";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    // Asignación de parámetros
                    cmd.Parameters.AddWithValue("@CompanyName", txtBoxCN.Text);
                    cmd.Parameters.AddWithValue("@ContactName", txtBoxCtN.Text);
                    cmd.Parameters.AddWithValue("@ContactTitle", txtBoxCtT.Text);
                    cmd.Parameters.AddWithValue("@Address", txtBoxCad.Text);
                    cmd.Parameters.AddWithValue("@City", txtBoxCci.Text);
                    cmd.Parameters.AddWithValue("@Region", string.IsNullOrWhiteSpace(txtBoxCRe.Text) ? (object)DBNull.Value : txtBoxCRe.Text);
                    cmd.Parameters.AddWithValue("@PostalCode", string.IsNullOrWhiteSpace(txtBoxCpo.Text) ? (object)DBNull.Value : txtBoxCpo.Text);
                    cmd.Parameters.AddWithValue("@Country", txtBoxCco.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtBoxCph.Text);
                    cmd.Parameters.AddWithValue("@Fax", string.IsNullOrWhiteSpace(txtBoxCFa.Text) ? (object)DBNull.Value : txtBoxCFa.Text);
                    cmd.Parameters.AddWithValue("@HomePage", string.IsNullOrWhiteSpace(txtBoxCHP.Text) ? (object)DBNull.Value : txtBoxCHP.Text);

                    // Ejecución del comando
                    if (conexion.EjecutarComando(cmd))
                    {
                        MessageBox.Show("Proveedor agregado exitosamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el proveedor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgCProvee.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un proveedor para eliminar.");
                return;
            }

            // Obtén el SupplierID de la fila seleccionada
            string supplierId = dgCProvee.CurrentRow.Cells["SupplierID"].Value.ToString();

            // Confirmación del usuario
            DialogResult confirmResult = MessageBox.Show(
                "Esto eliminará el proveedor. ¿Está seguro de que desea continuar?",
                "Confirmación de eliminación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Cancel)
            {
                return;
            }

            connect conexion = new connect();

            using (SqlConnection connection = conexion.Conexion())
            {
                if (connection == null) return;

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Elimina el registro del proveedor
                    using (SqlCommand deleteSupplierCmd = new SqlCommand(
                        "DELETE FROM Suppliers WHERE SupplierID = " + supplierId,
                        connection, transaction))
                    {
                        deleteSupplierCmd.ExecuteNonQuery();
                    }

                    // Confirma la transacción
                    transaction.Commit();
                    MessageBox.Show("Proveedor eliminado exitosamente.");
                    ActualizarDatosPyV(); // Actualiza los datos en el DataGridView o interfaz
                }
                catch (Exception ex)
                {
                    // Revertir en caso de error
                    transaction.Rollback();
                    MessageBox.Show($"Error al eliminar el proveedor: {ex.Message}");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgCProvee.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                // Obtén los datos de la fila seleccionada
                int supplierId = Convert.ToInt32(dgCProvee.SelectedRows[0].Cells["SupplierID"].Value);
                string companyName = dgCProvee.SelectedRows[0].Cells["CompanyName"].Value.ToString();
                string contactName = dgCProvee.SelectedRows[0].Cells["ContactName"].Value.ToString();
                string contactTitle = dgCProvee.SelectedRows[0].Cells["ContactTitle"].Value.ToString();
                string address = dgCProvee.SelectedRows[0].Cells["Address"].Value.ToString();
                string city = dgCProvee.SelectedRows[0].Cells["City"].Value.ToString();
                string region = dgCProvee.SelectedRows[0].Cells["Region"].Value.ToString();
                string postalCode = dgCProvee.SelectedRows[0].Cells["PostalCode"].Value.ToString();
                string country = dgCProvee.SelectedRows[0].Cells["Country"].Value.ToString();
                string phone = dgCProvee.SelectedRows[0].Cells["Phone"].Value.ToString();
                string fax = dgCProvee.SelectedRows[0].Cells["Fax"].Value.ToString();
                string homePage = dgCProvee.SelectedRows[0].Cells["HomePage"].Value.ToString();

                // Abre la ventana de edición y pasa los datos
                EproveedoresEditar editarForm = new EproveedoresEditar(supplierId, companyName, contactName, contactTitle,
                                                                  address, city, region, postalCode, country, phone, fax, homePage);
                editarForm.ShowDialog();

                // Actualiza el DataGridView después de la edición
                ActualizarDatosPyV(); // Método para recargar los datos
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor para editar.");
            }
        }

        private void tbControlProvee_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect conexion = new connect();
            string query = @"
        SELECT Suppliers.CompanyName, COUNT(Products.ProductID) AS ProductCount
        FROM Suppliers
        LEFT JOIN Products ON Suppliers.SupplierID = Products.SupplierID
        GROUP BY Suppliers.CompanyName";

            DataSet ds = conexion.Ejecutar(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                var plotModel = new PlotModel { Title = "Productos por Proveedor" };
                var series = new BarSeries();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    series.Items.Add(new BarItem { Value = Convert.ToDouble(row["ProductCount"]) });
                }

                plotModel.Series.Add(series);
                plotView1.Model = plotModel;
            }
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
            string query = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Country FROM Suppliers";
            string[] encabezados = { "SupplierID", "CompanyName", "ContactName", "ContactTitle", "Address", "City", "Country" };
            ExportarTablaAExcel(query, "Proveedores", "Proveedores.xlsx", encabezados);
        }
    }
}
