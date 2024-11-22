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
////
namespace ExamenUnidad2
{
    public partial class EproductoEditar : Form
    {
        public EproductoEditar(int productId, string productName, string supplierName, string categoryName,
                          string quantityPerUnit, decimal unitPrice, short unitsInStock,
                          short unitsOnOrder, short reorderLevel, bool discontinued)
        {
            InitializeComponent();
            // Rellena los campos con los datos recibidos
            txtPrID.Text = productId.ToString();
            txtBoxPN.Text = productName;
            txtBoxPSu.Text = supplierName.ToString();
            txtBoxPCa.Text = categoryName.ToString();
            txtBoxPQu.Text = quantityPerUnit;
            txtBoxPUn.Text = unitPrice.ToString("F2");
            txtBoxPSt.Text = unitsInStock.ToString();
            txtBoxPOr.Text = unitsOnOrder.ToString();
            txtBoxPReo.Text = reorderLevel.ToString();
            cBoxDis.SelectedItem = discontinued ? "0" : "1";
        }

        private void EproductoEditar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del formulario
                int productId = Convert.ToInt32(txtPrID.Text);
                string productName = txtBoxPN.Text;
                string supplierName = txtBoxPSu.Text; // Nombre del proveedor
                string categoryName = txtBoxPCa.Text; // Nombre de la categoría
                string quantityPerUnit = txtBoxPQu.Text;
                decimal unitPrice = decimal.Parse(txtBoxPUn.Text);
                short unitsInStock = short.Parse(txtBoxPSt.Text);
                short unitsOnOrder = string.IsNullOrWhiteSpace(txtBoxPOr.Text) ? (short)0 : short.Parse(txtBoxPOr.Text);
                short reorderLevel = string.IsNullOrWhiteSpace(txtBoxPReo.Text) ? (short)0 : short.Parse(txtBoxPReo.Text);
                bool discontinued = cBoxDis.SelectedItem.ToString() == "1";

                connect conexion = new connect();

                // Obtener SupplierID y CategoryID según los nombres
                string supplierQuery = "SELECT SupplierID FROM Suppliers WHERE CompanyName = @SupplierName";
                string categoryQuery = "SELECT CategoryID FROM Categories WHERE CategoryName = @CategoryName";

                int supplierId;
                int categoryId;

                using (SqlCommand supplierCmd = new SqlCommand(supplierQuery))
                {
                    supplierCmd.Parameters.AddWithValue("@SupplierName", supplierName);
                    using (SqlDataReader reader = conexion.EjecutarConsulta(supplierCmd))
                    {
                        if (reader != null && reader.Read())
                        {
                            supplierId = reader.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el proveedor especificado.");
                            return;
                        }
                    }
                }

                using (SqlCommand categoryCmd = new SqlCommand(categoryQuery))
                {
                    categoryCmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    using (SqlDataReader reader = conexion.EjecutarConsulta(categoryCmd))
                    {
                        if (reader != null && reader.Read())
                        {
                            categoryId = reader.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la categoría especificada.");
                            return;
                        }
                    }
                }

                // Construcción de la consulta SQL de actualización
                string query = @"
        UPDATE Products
        SET ProductName = @ProductName,
            SupplierID = @SupplierID,
            CategoryID = @CategoryID,
            QuantityPerUnit = @QuantityPerUnit,
            UnitPrice = @UnitPrice,
            UnitsInStock = @UnitsInStock,
            UnitsOnOrder = @UnitsOnOrder,
            ReorderLevel = @ReorderLevel,
            Discontinued = @Discontinued
        WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    // Asignación de parámetros
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierId); // ID obtenido del nombre
                    cmd.Parameters.AddWithValue("@CategoryID", categoryId); // ID obtenido del nombre
                    cmd.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@UnitsInStock", unitsInStock);
                    cmd.Parameters.AddWithValue("@UnitsOnOrder", unitsOnOrder == 0 ? (object)DBNull.Value : unitsOnOrder);
                    cmd.Parameters.AddWithValue("@ReorderLevel", reorderLevel == 0 ? (object)DBNull.Value : reorderLevel);
                    cmd.Parameters.AddWithValue("@Discontinued", discontinued);

                    // Ejecutar el comando
                    if (conexion.EjecutarComando(cmd))
                    {
                        MessageBox.Show("Producto actualizado exitosamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
