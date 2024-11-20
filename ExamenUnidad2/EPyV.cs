﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            if (global.EmployeeID != 0)
            {
                // Configuración para empleados
                btnEliminarOrden.Visible = false;
                btnAgregarOrden.Visible = false;
                btnAgregarProductos.Visible = false;
                btnAgregarCate.Visible = false;
                btnCateBorrar.Visible = false;
                btnCateEditar.Visible = false;
                dgvPyV.ReadOnly = true; // Solo lectura para el DataGridView
                this.Text = "Vista Empleado - PyV";
            }
            else
            {
                // Configuración para administradores
                this.Text = "Vista Admin - PyV";
            }
            //Categorias
            connect conexion = new connect();
            string consulta = "SELECT * FROM Categories";
            DataSet ds = conexion.Ejecutar(consulta);

            if (ds != null)
            {
                dgvCategorias.DataSource = ds.Tables[0];
            }
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
        {
            try
            {
                connect conexion = new connect();

                string customerID = txtCustomerID.Text;
                int employeeID = global.EmployeeID;
                DateTime orderDate = dtpOrderDate.Value;
                DateTime requiredDate = dtpRD.Value;
                object shippedDate = chbxSD.Checked ? (object)DBNull.Value : dtpSD.Value;
                int shipVia = (rbShipVia1.Checked) ? 1 : (rbShipVia2.Checked) ? 2 : 3;
                decimal freight = decimal.Parse(txtFreight2.Text);

                string query = "INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) " +
                               "VALUES (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry)";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                    cmd.Parameters.AddWithValue("@RequiredDate", requiredDate);
                    cmd.Parameters.AddWithValue("@ShippedDate", shippedDate);
                    cmd.Parameters.AddWithValue("@ShipVia", shipVia);
                    cmd.Parameters.AddWithValue("@Freight", freight);
                    cmd.Parameters.AddWithValue("@ShipName", txtbxShipName.Text);
                    cmd.Parameters.AddWithValue("@ShipAddress", txtbxShipAddress.Text);
                    cmd.Parameters.AddWithValue("@ShipCity", txtbxShipCity.Text);
                    cmd.Parameters.AddWithValue("@ShipRegion", chbxSR.Checked ? (object)DBNull.Value : txtbxShipRegion.Text);
                    cmd.Parameters.AddWithValue("@ShipPostalCode", CHBXcp.Checked ? (object)DBNull.Value : txtboxShipCP.Text);
                    cmd.Parameters.AddWithValue("@ShipCountry", txtbxShipCountry.Text);


                    bool resultado = conexion.EjecutarComando(cmd);
                    if (resultado)
                    {
                        MessageBox.Show("Orden agregada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la orden.");
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
        private void ActualizarDatosOrderdetails()
        {
            connect conexion = new connect();
            string consulta = "SELECT * FROM [Order Details]";
            DataSet ds = conexion.Ejecutar(consulta);

            if (ds != null)
            {
                dgvBuscarOrden.DataSource = ds.Tables[0];
            }
        }
        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                connect conexion = new connect();
                int orderId = int.Parse(txtbxOrderID.Text);
                int productId = int.Parse(txtProductID.Text);

                decimal originalUnitPrice = decimal.Parse(txtUnitPrice.Text.Replace("$", "").Trim());

                int quantity = int.Parse(txtQuantity.Text);
                decimal discount = decimal.Parse(txtDiscount.Text);
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text.Replace("$", "").Trim());
                decimal discountPercentage = decimal.Parse(txtDiscount.Text);

                decimal priceWithDiscount = unitPrice * (1 - discount);

                if (discount < 0 || discount > 1)
                {
                    MessageBox.Show("Por favor, ingrese un descuento válido entre 0 y 100.", "Descuento no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal discountedUnitPrice = originalUnitPrice * (1 - discountPercentage);

                string query = "INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount) " +
                               "VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@UnitPrice", discountedUnitPrice);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Discount", discount);

                    bool resultado = conexion.EjecutarComando(cmd);

                    if (resultado)
                    {
                        MessageBox.Show("Detalle de la orden agregado exitosamente.");
                        ActualizarDatosOrderdetails();

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

        private void dgvPyV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de los campos, opcional pero recomendado
                if (string.IsNullOrWhiteSpace(txtCateNam.Text) || string.IsNullOrWhiteSpace(txtCateDes.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                connect conexion = new connect();

                // Construcción de la consulta SQL de inserción
                string query = @"
    INSERT INTO Categories (CategoryName, Description) 
    VALUES (@CategoryName, @Description)";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    // Asignación de parámetros
                    cmd.Parameters.AddWithValue("@CategoryName", txtCateNam.Text);
                    cmd.Parameters.AddWithValue("@Description", txtCateDes.Text);

                    // Ejecución del comando
                    if (conexion.EjecutarComando(cmd))
                    {
                        MessageBox.Show("Categoría agregada exitosamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la categoría.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnCateBorrar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una categoría para eliminar.");
                return;
            }

            // Obtener el ID de la categoría seleccionada
            string categoryId = dgvCategorias.CurrentRow.Cells["CategoryID"].Value.ToString();

            // Confirmación del usuario
            DialogResult confirmResult = MessageBox.Show(
                "Eliminar esta categoría también puede afectar otros registros relacionados. ¿Está seguro de que desea continuar?",
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
                    // Eliminar los productos relacionados con la categoría, si aplica
                    using (SqlCommand deleteProductsCmd = new SqlCommand(
                        "DELETE FROM Products WHERE CategoryID = @CategoryID",
                        connection, transaction))
                    {
                        deleteProductsCmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        deleteProductsCmd.ExecuteNonQuery();
                    }

                    // Eliminar la categoría
                    using (SqlCommand deleteCategoryCmd = new SqlCommand(
                        "DELETE FROM Categories WHERE CategoryID = @CategoryID",
                        connection, transaction))
                    {
                        deleteCategoryCmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        deleteCategoryCmd.ExecuteNonQuery();
                    }

                    // Confirmar transacción
                    transaction.Commit();
                    MessageBox.Show("Categoría y registros asociados eliminados exitosamente.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Revertir la transacción en caso de error
                    transaction.Rollback();
                    MessageBox.Show($"Error al eliminar la categoría: {ex.Message}");
                }
            }
        }

        private void btnCateEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                // Crear un DataTable para almacenar la fila seleccionada
                DataTable selectedData = new DataTable();
                selectedData.Columns.Add("CategoryID", typeof(int));
                selectedData.Columns.Add("CategoryName", typeof(string));
                selectedData.Columns.Add("Description", typeof(string));

                // Obtener los datos de la fila seleccionada
                DataGridViewRow selectedRow = dgvCategorias.SelectedRows[0];
                DataRow row = selectedData.NewRow();
                row["CategoryID"] = Convert.ToInt32(selectedRow.Cells["CategoryID"].Value);
                row["CategoryName"] = selectedRow.Cells["CategoryName"].Value.ToString();
                row["Description"] = selectedRow.Cells["Description"].Value?.ToString() ?? string.Empty;

                selectedData.Rows.Add(row);

                // Abre la ventana de edición y pasa los datos
                EcategoriasEditar editarForm = new EcategoriasEditar(selectedData);
                editarForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría para editar.");
            }
        }
    }
}
