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
    public partial class EPyV : Form
    {
        DataSet ds;
        public EPyV()
        {
            InitializeComponent();
        }
        private void CargarDatosGrid(string comando)
        {
            connect dt = new connect();
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dgvPyV.DataSource = ds.Tables[0];
            }
        }
        public void ActualizarDatosPyV()
        {
            try
            {
                connect conexion = new connect();


                string query = "SELECT * FROM Orders";


                DataSet ds = conexion.Ejecutar(query);


                if (ds != null && ds.Tables.Count > 0)
                {

                    cmbbxPyV.ResetText();
                    txtbxPyV.Clear();
                    dgvPyV.DataSource = ds.Tables[0];
                    dgvPyV.Refresh();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxPyV.Enabled = true;
        }

        private void EPyV_Load(object sender, EventArgs e)
        {
            ActualizarDatosPyV();
        }

        private void dgvPyV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int orderId = Convert.ToInt32(dgvPyV.Rows[e.RowIndex].Cells["OrderID"].Value);

                    connect conexion = new connect();
                    string query = "SELECT * FROM [Order Details] WHERE OrderID = @OrderID";

                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderId);

                        using (SqlDataReader reader = conexion.EjecutarConsulta(cmd))
                        {
                            if (reader != null && reader.HasRows)
                            {
                                StringBuilder messageText = new StringBuilder();
                                messageText.AppendLine($"OrderID: {orderId}"); // Muestra OrderID solo una vez
                                messageText.AppendLine();// Agrega una línea en blanco entre registros

                                while (reader.Read())
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        // Evita repetir el OrderID en los resultados
                                        if (reader.GetName(i) != "OrderID")
                                        {
                                            messageText.AppendLine($"{reader.GetName(i)}: {reader[i]}");
                                        }
                                    }
                                    messageText.AppendLine();
                                }

                                MessageBox.Show(messageText.ToString(), "Resultados de la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron resultados para el OrderID especificado.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una celda válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void dgvPyV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {

            {
                if (dgvPyV.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona una orden para eliminar.");
                    return;
                }

                string orderid = dgvPyV.CurrentRow.Cells["OrderID"].Value.ToString();

                DialogResult confirmResult = MessageBox.Show(
                    "Eliminar esta orden también borrará sus wqdetalles de órdenes relacionados. ¿Está seguro de que desea continuar?",
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
                        // 1. Elimina los detalles de órdenes del cliente
                        using (SqlCommand deleteOrderDetailsCmd = new SqlCommand(
                            "DELETE FROM [Order Details] WHERE OrderID = " + orderid,
                            connection, transaction))
                        {
                            deleteOrderDetailsCmd.ExecuteNonQuery();
                        }

                        // 2. Elimina las órdenes del cliente
                        using (SqlCommand deleteOrdersCmd = new SqlCommand(
                            "DELETE FROM Orders WHERE OrderID = " + orderid,
                            connection, transaction))
                        {
                            deleteOrdersCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Ordenes y registros asociados eliminados exitosamente.");
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

        private void txtbxPyV_TextChanged(object sender, EventArgs e)
        {
            CargarDatosGrid("SELECT * FROM Orders WHERE " + cmbbxPyV.Text.Trim().Replace(" ", "") + " LIKE '%" + txtbxPyV.Text.Trim() + "%'");

        }

        private void tbcntrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatosPyV();
            cmbbxPyV.SelectedItem = 0;
            txtbxPyV.Clear();
        }

        private void tbcntrl_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        { }





        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBXcp.Checked)
            {
                txtboxShipCP.Enabled = false;
            }
            else
            {
                txtboxShipCP.Enabled = true;
            }
        }

        private void chbxSD_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSD.Checked)
            {
                dtpSD.Enabled = false;
            }
            else
            {
                dtpSD.Enabled = true;
            }
        }

        private void chbxSR_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSR.Checked)
            {
                txtbxShipRegion.Enabled = false;
            }
            else
            {
                txtbxShipRegion.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = int.Parse(txtbxOrderID.Text);
                BuscarOrderDetailsPorID(orderId);

                txtProductID.Enabled = true;
                txtDiscount.Enabled = true;
                txtQuantity.Enabled = true;
                btnAgregarProductos.Enabled = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: El formato del OrderID no es válido. Por favor ingrese un número entero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void BuscarOrderDetailsPorID(int orderId)
        {
            string query = "SELECT * FROM [Order Details] WHERE OrderID = @OrderID";

            connect conexion = new connect();

            try
            {
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                SqlDataReader reader = conexion.EjecutarConsulta(cmd);

                // Verificamos si hay resultados
                if (reader != null && reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvBuscarOrden.DataSource = dt;

                    lblResulConsulta.Text = "Resultados encontrados:";
                }
                else
                {
                    lblResulConsulta.Text = "No se encontraron resultados para el OrderID: " + orderId;
                    dgvBuscarOrden.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                connect conexion = new connect();
                int orderId = int.Parse(txtbxOrderID.Text);
                int productId = int.Parse(txtProductID.Text);
                string unitPriceString = txtUnitPrice.Text;
                unitPriceString = unitPriceString.Replace("$", "").Replace(",", "").Trim();
                decimal unitPrice = decimal.Parse(unitPriceString);
                int quantity = int.Parse(txtQuantity.Text);
                decimal discount = decimal.Parse(txtDiscount.Text);
                
                decimal priceWithDiscount = unitPrice * (1 - discount);

                // Insertar el detalle de la orden con el UnitPrice ajustado por el descuento
                string queryInsert = "INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount) " +
                                     "VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)";

                using (SqlCommand cmdInsert = new SqlCommand(queryInsert))
                {
                    cmdInsert.Parameters.AddWithValue("@OrderID", orderId);
                    cmdInsert.Parameters.AddWithValue("@ProductID", productId);
                    cmdInsert.Parameters.AddWithValue("@UnitPrice", priceWithDiscount); // Usar el precio con descuento
                    cmdInsert.Parameters.AddWithValue("@Quantity", quantity);
                    cmdInsert.Parameters.AddWithValue("@Discount", discount);

                    bool resultado = conexion.EjecutarComando(cmdInsert);

                    if (resultado)
                    {
                        MessageBox.Show("Detalle de la orden agregado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el detalle de la orden.");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: Por favor asegúrese de que todos los valores sean válidos. " + ex.Message, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(txtProductID.Text))
                {
                    try
                    {
                    connect conexion = new connect();
                        int productId = int.Parse(txtProductID.Text); 

                        string query = "SELECT UnitPrice FROM Products WHERE ProductID = @ProductID";

                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", productId);

                            using (SqlDataReader reader = conexion.EjecutarConsulta(cmd))
                            {
                                // Verificar si se obtuvo el resultado
                                if (reader != null && reader.Read())
                                {
                                    decimal unitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice"));
                                    txtUnitPrice.Text = unitPrice.ToString("C"); 
                                }
                                else
                                {
                                    txtUnitPrice.Clear();
                                    MessageBox.Show("Producto no encontrado.");
                                }
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        txtUnitPrice.Clear();
                        MessageBox.Show("Por favor, ingrese un ProductID válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el precio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtUnitPrice.Clear();
                }
            

        }
    }
}
