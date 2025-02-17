﻿using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using ClosedXML.Excel;

namespace ExamenUnidad2
{
    public partial class Eproductos : Form
    {
        DataSet ds;
        public Eproductos()
        {
            InitializeComponent();
        }
        private void CargarDatosGrid(string comando)
        {
            connect dt = new connect();
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dgCPr.DataSource = ds.Tables[0];
            }
        }

        public void ActualizarDatosPyV()
        {
            try
            {
                connect conexion = new connect();


                string query = "SELECT p.ProductID, p.ProductName, " +
                    "s.CompanyName AS SupplierName, " +
                    "c.CategoryName AS CategoryName, " +
                    "p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued " +
                    "FROM Products p " +
                    "INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID " +
                    "INNER JOIN Categories c ON p.CategoryID = c.CategoryID";


                DataSet ds = conexion.Ejecutar(query);


                if (ds != null && ds.Tables.Count > 0)
                {

                    cboxPr.ResetText();
                    txtBoxPr.Clear();
                    dgCPr.DataSource = ds.Tables[0];
                    dgCPr.Refresh();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Eproductos_Load(object sender, EventArgs e)
        {
            ActualizarDatosPyV();

            if (global.EmployeeID != 0)
            {
                // Configuración para empleados
                butAgregar.Visible = false;
                btnBorrar.Visible = false;
                btnEditar.Visible = false;
                dgCPr.ReadOnly = true; // Solo lectura para el DataGridView
                this.Text = "Vista Empleado - Productos";
            }
            else
            {
                // Configuración para administradores
                this.Text = "Vista Admin - Productos";
            }
        }

        private void cboxPr_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxPr.Enabled = true;
        }

        private void txtBoxPr_TextChanged(object sender, EventArgs e)
        {
            CargarDatosGrid("SELECT p.ProductID, p.ProductName, " +
                "s.CompanyName AS SupplierName, " +
                "c.CategoryName AS CategoryName, " +
                "p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued " +
                "FROM Products p " +
                "INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID " +
                "INNER JOIN Categories c ON p.CategoryID = c.CategoryID WHERE " + cboxPr.Text.Trim().Replace(" ", "") + " LIKE '%" + txtBoxPr.Text.Trim() + "%'");
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de los campos, opcional pero recomendado
                //if (string.IsNullOrWhiteSpace(txtBoxPN.Text) || string.IsNullOrWhiteSpace(txtBoxPSu.Text) ||
                //  string.IsNullOrWhiteSpace(txtBoxPCa.Text) || string.IsNullOrWhiteSpace(txtBoxPQu.Text) ||
                //  string.IsNullOrWhiteSpace(txtBoxPUn.Text))
                //{
                //  MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                //return;
                //}

                // Captura el valor del ComboBox para el campo Discontinued
                int discontinued = (cBoxDis.SelectedItem.ToString() == "Yes") ? 1 : 0;

                connect conexion = new connect();

                // Construcción de la consulta SQL de inserción
                string query = "INSERT INTO Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) " +
                               "VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)";



                using (SqlCommand cmd = new SqlCommand(query))
                {
                    // Asignación de parámetros
                    cmd.Parameters.AddWithValue("@ProductName", txtBoxPN.Text);
                    cmd.Parameters.AddWithValue("@SupplierID", int.Parse(txtBoxPSu.Text));
                    cmd.Parameters.AddWithValue("@CategoryID", int.Parse(txtBoxPCa.Text));
                    cmd.Parameters.AddWithValue("@QuantityPerUnit", txtBoxPQu.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", decimal.Parse(txtBoxPUn.Text));
                    cmd.Parameters.AddWithValue("@UnitsInStock", int.Parse(txtBoxPSt.Text));
                    cmd.Parameters.AddWithValue("@UnitsOnOrder", string.IsNullOrWhiteSpace(txtBoxPOr.Text) ? (object)DBNull.Value : int.Parse(txtBoxPOr.Text));
                    cmd.Parameters.AddWithValue("@ReorderLevel", string.IsNullOrWhiteSpace(txtBoxPReo.Text) ? (object)DBNull.Value : int.Parse(txtBoxPReo.Text));
                    cmd.Parameters.AddWithValue("@Discontinued", discontinued);

                    if (conexion.EjecutarComando(cmd))
                    {
                        MessageBox.Show("Producto agregado exitosamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }

        private void txtBoxPQu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            {
                if (dgCPr.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona una orden para eliminar.");
                    return;
                }

                string productid = dgCPr.CurrentRow.Cells["ProductID"].Value.ToString();

                DialogResult confirmResult = MessageBox.Show(
                    "Esto eliminara el producto. ¿Está seguro de que desea continuar?",
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

                        // 1. Elimina las órdenes del cliente
                        using (SqlCommand deleteOrdersCmd = new SqlCommand(
                            "DELETE FROM Products WHERE ProductID = " + productid,
                            connection, transaction))
                        {
                            deleteOrdersCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Producto eliminado exitosamente.");
                        ActualizarDatosPyV();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error al eliminar la orden: {ex.Message}");
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgCPr.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                // Obtén los datos de la fila seleccionada
                int productId = Convert.ToInt32(dgCPr.SelectedRows[0].Cells["ProductID"].Value);
                string productName = dgCPr.SelectedRows[0].Cells["ProductName"].Value.ToString();
                string supplierName = dgCPr.SelectedRows[0].Cells["SupplierName"].Value.ToString();
                string categoryName = dgCPr.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                string quantityPerUnit = dgCPr.SelectedRows[0].Cells["QuantityPerUnit"].Value.ToString();
                decimal unitPrice = Convert.ToDecimal(dgCPr.SelectedRows[0].Cells["UnitPrice"].Value);
                short unitsInStock = Convert.ToInt16(dgCPr.SelectedRows[0].Cells["UnitsInStock"].Value);
                short unitsOnOrder = Convert.ToInt16(dgCPr.SelectedRows[0].Cells["UnitsOnOrder"].Value);
                short reorderLevel = Convert.ToInt16(dgCPr.SelectedRows[0].Cells["ReorderLevel"].Value);
                bool discontinued = Convert.ToBoolean(dgCPr.SelectedRows[0].Cells["Discontinued"].Value);

                // Abre la ventana de edición y pasa los datos
                EproductoEditar editarForm = new EproductoEditar(productId, productName, supplierName, categoryName,
                                                                       quantityPerUnit, unitPrice, unitsInStock,
                                                                       unitsOnOrder, reorderLevel, discontinued);
                editarForm.ShowDialog();

                // Actualiza el DataGridView después de la edición
                ActualizarDatosPyV(); // Método para recargar los datos
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para editar.");
            }
        }

        private void tbControlP_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect conexion = new connect();
            string query = @"
        SELECT ProductName, ISNULL(UnitsInStock, 0) AS UnitsInStock
        FROM Products";

            DataSet ds = conexion.Ejecutar(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                var plotModel = new PlotModel { Title = "Stock por Producto" };
                var series = new BarSeries();

                // Agregar solo los productos con stock mayor a 0
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    double stock = Convert.ToDouble(row["UnitsInStock"]);
                    if (stock > 0) // Solo productos con stock mayor a 0
                    {
                        series.Items.Add(new BarItem { Value = stock });
                    }
                }

                // Si no se encuentra ningún producto con stock, mostrar mensaje de advertencia
                if (series.Items.Count == 0)
                {
                    MessageBox.Show("No hay productos con stock disponible.");
                    return;
                }

                plotModel.Series.Add(series);
                plotModel.Axes.Add(new CategoryAxis
                {
                    Position = AxisPosition.Left,
                    Key = "ProductAxis",
                    ItemsSource = ds.Tables[0].Rows.Cast<DataRow>().Where(r => Convert.ToDouble(r["UnitsInStock"]) > 0)
                        .Select(r => r["ProductName"].ToString()).ToList()
                });

                plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
                plotView1.Model = plotModel; // plotView1 es el nombre de tu control PlotView.
            }
            else
            {
                MessageBox.Show("No se encontraron productos en la base de datos.");
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
                string query = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock FROM Products";
                string[] encabezados = { "ProductID", "ProductName", "SupplierID", "CategoryID", "QuantityPerUnit", "UnitPrice", "UnitsInStock" };
                ExportarTablaAExcel(query, "Productos", "Productos.xlsx", encabezados);
            
        }
    }

}
