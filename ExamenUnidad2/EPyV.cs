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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using OxyPlot.Axes;
using ClosedXML.Excel;

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


                string query = @"SELECT o.OrderID, c.ContactName AS CustomerName, e.FirstName + ' ' + e.LastName AS EmployeeName, s.CompanyName AS ShipperName, " +
                "o.OrderDate, o.RequiredDate, o.ShippedDate, o.Freight, o.ShipName, o.ShipAddress, o.ShipCity, o.ShipRegion, o.ShipPostalCode, " +
                "o.ShipCountry FROM Orders o " +
                "LEFT JOIN Customers c ON o.CustomerID = c.CustomerID " +
                "LEFT JOIN Employees e ON o.EmployeeID = e.EmployeeID " +
                "LEFT JOIN Shippers s ON o.ShipVia = s.ShipperID";


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
            CargarClientes();
            connect conexion = new connect();
            string consultaProductos = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products";
            DataSet dsProductos = conexion.Ejecutar(consultaProductos);
            dvgCarrito.AllowUserToAddRows = false;

            if (dsProductos != null)
            {
                dvgProductosDis.DataSource = dsProductos.Tables[0];
            }

            // Configurar DataGridView del carrito
            dvgCarrito.Columns.Add("ProductID", "ProductID");
            dvgCarrito.Columns.Add("ProductName", "Nombre del Producto");
            dvgCarrito.Columns.Add("UnitPrice", "Precio Unitario");
            dvgCarrito.Columns.Add("Quantity", "Cantidad");

            dtpOrderDate.Value = DateTime.Now;
            dtpRequiredDate.Value = DateTime.Now.AddDays(7); // Fecha requerida = 7 días después
            dtpShippedDate.Value = DateTime.Now; // Opcional, puede dejarse vacío (NULL)



            if (global.EmployeeID != 0)
            {
                // Configuración para empleados
                btnEliminarOrden.Visible = false;
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
            CargarDatosGrid("SELECT o.OrderID, c.ContactName AS CustomerName, e.FirstName + ' ' + e.LastName AS EmployeeName, s.CompanyName AS ShipperName, " +
                "o.OrderDate, o.RequiredDate, o.ShippedDate, o.Freight, o.ShipName, o.ShipAddress, o.ShipCity, o.ShipRegion, o.ShipPostalCode, " +
                "o.ShipCountry FROM Orders o LEFT JOIN Customers c ON o.CustomerID = c.CustomerID " +
                "LEFT JOIN Employees e ON o.EmployeeID = e.EmployeeID " +
                "LEFT JOIN Shippers s ON o.ShipVia = s.ShipperID WHERE " + cmbbxPyV.Text.Trim().Replace(" ", "") + " LIKE '%" + txtbxPyV.Text.Trim() + "%'");

        }

        private void tbcntrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatosPyV();
            cmbbxPyV.SelectedItem = 0;
            txtbxPyV.Clear();

            connect conexion = new connect();
            string query = @"
        SELECT YEAR(OrderDate) AS OrderYear, COUNT(OrderID) AS OrderCount
        FROM Orders
        GROUP BY YEAR(OrderDate)
        ORDER BY OrderYear";

            DataSet ds = conexion.Ejecutar(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                var plotModel = new PlotModel { Title = "Órdenes por Año" };

                // Crear una serie de barras para el gráfico
                var series = new BarSeries
                {
                    ItemsSource = ds.Tables[0].Rows.Cast<DataRow>()
                                    .Select(r => new BarItem
                                    {
                                        Value = Convert.ToDouble(r["OrderCount"]) // El valor de las órdenes por año
                                    }).ToList(),
                    LabelPlacement = LabelPlacement.Outside,
                    LabelFormatString = "{0}"
                };

                plotModel.Series.Add(series);

                // Crear el eje X con los años (como categorías)
                var yearAxis = new CategoryAxis
                {
                    Position = AxisPosition.Bottom,
                    Key = "CountAxis",
                    ItemsSource = ds.Tables[0].Rows.Cast<DataRow>()
                        .Select(r => r["OrderCount"].ToString()).ToList() // Los valores de los años
                };

                plotModel.Axes.Add(yearAxis);

                // Crear el eje Y con categorías de valores (números de órdenes)
                var countAxis = new CategoryAxis
                {
                    Position = AxisPosition.Left,
                    Key = "YearAxis",
                    ItemsSource = ds.Tables[0].Rows.Cast<DataRow>()
                        .Select(r => r["OrderYear"].ToString()).ToList() // Las cantidades de órdenes como categorías
                };

                plotModel.Axes.Add(countAxis);

                // Establecer el modelo de la gráfica en el control PlotView
                plotView1.Model = plotModel; // plotView1 es el nombre de tu control PlotView.
            }
            else
            {
                MessageBox.Show("No se encontraron órdenes en la base de datos.");
            }
        }

        private void tbcntrl_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarClientes()
        {
            connect conexion = new connect();
            string consultaClientes = "SELECT CustomerID, CompanyName FROM Customers";
            DataSet dsClientes = conexion.Ejecutar(consultaClientes);

            if (dsClientes != null)
            {
                cmbCustomerID.DataSource = dsClientes.Tables[0];
                cmbCustomerID.DisplayMember = "ContactName"; // Texto visible (nombre del cliente)
                cmbCustomerID.ValueMember = "CustomerID";
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
            string query = "SELECT od.OrderID, p.ProductName, od.UnitPrice, od.Quantity, od.Discount " +
                "FROM [Order Details] od " +
                "INNER JOIN Products p ON od.ProductID = p.ProductID " +
                "WHERE od.OrderID = @OrderID";

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

                    string query = "SELECT ProductName, od.UnitPrice FROM[Order Details] od LEFT JOIN Products p ON od.ProductID = p.ProductID WHERE od.ProductID = @ProductID";


                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);

                        using (SqlDataReader reader = conexion.EjecutarConsulta(cmd))
                        {
                            // Verificar si se obtuvo el resultado
                            if (reader != null && reader.Read())
                            {
                                string productName = reader.GetString(reader.GetOrdinal("ProductName"));
                                decimal unitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice"));
                                lblproducto.Text = $"{productName}";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, ShipVia, Freight FROM Orders";
            string[] encabezados = { "OrderID", "CustomerID", "EmployeeID", "OrderDate", "ShipVia", "Freight" };
            ExportarTablaAExcel(query, "Órdenes", "Ordenes.xlsx", encabezados);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT CategoryID, CategoryName, Description FROM Categories";
            string[] encabezados = { "CategoryID", "CategoryName", "Description" };
            ExportarTablaAExcel(query, "Categorías", "Categorias.xlsx", encabezados);
        }

        private bool ValidarStock(int productId, int cantidadSolicitada)
        {
            // Obtener el stock disponible para el producto
            string consultaStock = "SELECT UnitsInStock FROM Products WHERE ProductID = @ProductID";

            using (SqlConnection conexion = new connect().Conexion())
            {
                if (conexion == null) return false;

                SqlCommand cmd = new SqlCommand(consultaStock, conexion);
                cmd.Parameters.AddWithValue("@ProductID", productId);

                // Ejecutar la consulta y obtener el valor de UnitsInStock
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int stockDisponible = Convert.ToInt32(result);
                    // Si la cantidad solicitada es mayor que el stock, no se permite agregar el producto
                    if (cantidadSolicitada > stockDisponible)
                    {
                        MessageBox.Show("La cantidad solicitada excede el stock disponible.");
                        return false;
                    }
                }
            }

            return true; // Si todo está bien, el producto se puede agregar
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dvgProductosDis.SelectedRows.Count > 0 && int.TryParse(textBox1.Text, out int cantidad))
            {
                DataGridViewRow filaSeleccionada = dvgProductosDis.SelectedRows[0];
                int productId = Convert.ToInt32(filaSeleccionada.Cells["ProductID"].Value);
                string productName = filaSeleccionada.Cells["ProductName"].Value.ToString();
                decimal unitPrice = Convert.ToDecimal(filaSeleccionada.Cells["UnitPrice"].Value);

                // Validar que la cantidad no supere el stock disponible
                if (ValidarCantidadEnCarrito(productId, cantidad))
                {
                    // Si la validación pasa, agregamos el producto al carrito
                    dvgCarrito.Rows.Add(
                        productId,
                        productName,
                        unitPrice,
                        cantidad
                    );
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto y especifica una cantidad válida.");
            }
        }

        private bool ValidarCantidadEnCarrito(int productId, int cantidadSolicitada)
        {
            // Primero, obtenemos el stock disponible para este producto
            string consultaStock = "SELECT UnitsInStock FROM Products WHERE ProductID = @ProductID";

            int stockDisponible = 0;
            using (SqlConnection conexion = new connect().Conexion())
            {
                if (conexion == null) return false;

                SqlCommand cmd = new SqlCommand(consultaStock, conexion);
                cmd.Parameters.AddWithValue("@ProductID", productId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    stockDisponible = Convert.ToInt32(result);
                }
            }

            // Ahora, debemos sumar las cantidades de este producto en el carrito
            int cantidadEnCarrito = 0;
            foreach (DataGridViewRow row in dvgCarrito.Rows)
            {
                if (Convert.ToInt32(row.Cells["ProductID"].Value) == productId)
                {
                    cantidadEnCarrito += Convert.ToInt32(row.Cells["Quantity"].Value);
                }
            }

            // Verificamos si la cantidad solicitada, sumada con la cantidad en el carrito, excede el stock disponible
            if (cantidadEnCarrito + cantidadSolicitada > stockDisponible)
            {
                MessageBox.Show($"No puedes agregar más unidades de este producto. El stock disponible es {stockDisponible}.");
                return false; // No se puede agregar más
            }

            return true; // Se puede agregar
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (dvgCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            connect conexion = new connect();
            using (SqlConnection connection = conexion.Conexion())
            {
                if (connection == null) return;
                decimal freight = CalcularFreight(txtShipCountry.Text, rb1.Checked ? 1 : rb2.Checked ? 2 : 3);

                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Insertar orden
                    string queryOrden = "INSERT INTO Orders (CustomerID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) " +
                                        "VALUES (@CustomerID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry); " +
                                        "SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdOrden = new SqlCommand(queryOrden, connection, transaction);
                    cmdOrden.Parameters.AddWithValue("@CustomerID", cmbCustomerID.SelectedValue);
                    cmdOrden.Parameters.AddWithValue("@OrderDate", dtpOrderDate.Value);
                    cmdOrden.Parameters.AddWithValue("@RequiredDate", dtpRequiredDate.Value);
                    cmdOrden.Parameters.AddWithValue("@ShippedDate", dtpShippedDate.Value);
                    cmdOrden.Parameters.AddWithValue("@ShipVia", rb1.Checked ? 1 : rb2.Checked ? 2 : 3);
                    cmdOrden.Parameters.AddWithValue("@Freight", freight);
                    cmdOrden.Parameters.AddWithValue("@ShipName", string.IsNullOrEmpty(txtShipName.Text) ? cmbCustomerID.Text : txtShipName.Text);
                    cmdOrden.Parameters.AddWithValue("@ShipAddress", txtShipAddress.Text);
                    cmdOrden.Parameters.AddWithValue("@ShipCity", txtShipCity.Text);
                    cmdOrden.Parameters.AddWithValue("@ShipRegion", txtShipRegion.Text);
                    cmdOrden.Parameters.AddWithValue("@ShipPostalCode", txtShipPostalCode.Text);
                    cmdOrden.Parameters.AddWithValue("@ShipCountry", txtShipCountry.Text);

                    int orderId = Convert.ToInt32(cmdOrden.ExecuteScalar());

                    // Insertar detalles de orden
                    foreach (DataGridViewRow row in dvgCarrito.Rows)
                    {
                        if (row.Cells["ProductID"].Value != null) // Asegúrate de que ProductID tiene un valor
                        {
                            string queryDetalle = "INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity) " +
                                                  "VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity)";
                            SqlCommand cmdDetalle = new SqlCommand(queryDetalle, connection, transaction);
                            cmdDetalle.Parameters.AddWithValue("@OrderID", orderId);
                            cmdDetalle.Parameters.AddWithValue("@ProductID", row.Cells["ProductID"].Value);  // Verifica que ProductID esté en la celda correcta
                            cmdDetalle.Parameters.AddWithValue("@UnitPrice", row.Cells["UnitPrice"].Value);
                            cmdDetalle.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value);

                            cmdDetalle.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Orden registrada con éxito.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error al registrar la orden: {ex.Message}");
                }
            }
        }

        private decimal CalcularFreight(string shipCountry, int shipVia)
        {
            decimal freight = 0;

            // Ejemplo de tarifas según país y transportista
            if (shipCountry == "USA")
            {
                freight = shipVia == 1 ? 25 : shipVia == 2 ? 20 : 30;
            }
            else if (shipCountry == "Canada")
            {
                freight = shipVia == 1 ? 30 : shipVia == 2 ? 25 : 35;
            }
            else
            {
                freight = shipVia == 1 ? 40 : shipVia == 2 ? 35 : 50;
            }

            return freight;
        }

        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerId = cmbCustomerID.SelectedValue.ToString();
            connect conexion = new connect();
            string consultaDireccion = $"SELECT Address, City, Region, PostalCode, Country FROM Customers WHERE CustomerID = '{customerId}'";
            DataSet dsDireccion = conexion.Ejecutar(consultaDireccion);

            if (dsDireccion != null && dsDireccion.Tables[0].Rows.Count > 0)
            {
                DataRow row = dsDireccion.Tables[0].Rows[0];
                txtShipAddress.Text = row["Address"].ToString();
                txtShipCity.Text = row["City"].ToString();
                txtShipRegion.Text = row["Region"].ToString();
                txtShipPostalCode.Text = row["PostalCode"].ToString();
                txtShipCountry.Text = row["Country"].ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dvgCarrito.Rows.Clear(); // Elimina todas las filas del carrito (DataGridView)
        }

        private void dvgProductosDis_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda editada es la de la cantidad
            if (e.ColumnIndex == dvgCarrito.Columns["Quantity"].Index)
            {
                int cantidadNueva = Convert.ToInt32(dvgCarrito.Rows[e.RowIndex].Cells["Quantity"].Value);
                int productId = Convert.ToInt32(dvgCarrito.Rows[e.RowIndex].Cells["ProductID"].Value);
                decimal unitPrice = Convert.ToDecimal(dvgCarrito.Rows[e.RowIndex].Cells["UnitPrice"].Value);

                // Verificar si la nueva cantidad supera el stock
                if (!ValidarCantidadEnCarrito(productId, cantidadNueva))
                {
                    MessageBox.Show("La cantidad solicitada excede el stock disponible.");
                    return; // No actualizamos el valor si la cantidad es inválida
                }

                // Actualizar el precio total en el carrito
                dvgCarrito.Rows[e.RowIndex].Cells["TotalPrice"].Value = cantidadNueva * unitPrice;
            }
        }
    }
}
