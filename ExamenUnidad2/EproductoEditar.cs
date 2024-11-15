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
//
namespace ExamenUnidad2
{
    public partial class EproductoEditar : Form
    {
        public EproductoEditar(int productId, string productName, int supplierId, int categoryId,
                          string quantityPerUnit, decimal unitPrice, short unitsInStock,
                          short unitsOnOrder, short reorderLevel, bool discontinued)
        {
            InitializeComponent();
            // Rellena los campos con los datos recibidos
            txtPrID.Text = productId.ToString();
            txtBoxPN.Text = productName;
            txtBoxPSu.Text = supplierId.ToString();
            txtBoxPCa.Text = categoryId.ToString();
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
                int supplierId = Convert.ToInt32(txtBoxPSu.Text);
                int categoryId = Convert.ToInt32(txtBoxPCa.Text);
                string quantityPerUnit = txtBoxPQu.Text;
                decimal unitPrice = Convert.ToDecimal(txtBoxPUn.Text);
                short unitsInStock = Convert.ToInt16(txtBoxPSt.Text);
                short unitsOnOrder = Convert.ToInt16(txtBoxPOr.Text);
                short reorderLevel = Convert.ToInt16(txtBoxPReo.Text);
                int discontinued = cBoxDis.SelectedItem.ToString() == "1" ? 1 : 0;

                connect conexion = new connect();


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
                    cmd.Parameters.AddWithValue("@ProductID", int.Parse(txtPrID.Text)); // Campo para el ID del producto
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
