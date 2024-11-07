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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ExamenUnidad2
{
    public partial class Eclientes : Form
    {
        DataSet ds;
        public Eclientes()
        {
            InitializeComponent();
        }
        private void CargarDatosGrid(string comando)
        {
            connect dt = new connect();
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dgvEclientes.DataSource = ds.Tables[0];
            }
        }

        private void Eclientes_Load(object sender, EventArgs e)
        {
            CargarDatosGrid("SELECT * FROM Customers");

        }

        private void txtbxEclientes_TextChanged(object sender, EventArgs e)
        {
            CargarDatosGrid("SELECT * FROM Customers WHERE " + cmbEclientes.Text.Trim().Replace(" ", "") + " LIKE '%" + txtbxEclientes.Text.Trim() + "%'");
        }

        private void dgvEclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ActualizarDatos()
        {
            try
            {
                connect conexion = new connect();

                
                string query = "SELECT * FROM Customers";

                
                DataSet ds = conexion.Ejecutar(query);

                
                if (ds != null && ds.Tables.Count > 0)
                {

                    cmbEclientes.ResetText();
                    txtbxEclientes.Clear();
                    dgvEclientes.DataSource = ds.Tables[0];
                    dgvEclientes.Refresh(); 
                }
                else
                {

                    MessageBox.Show("No se pudieron cargar los datos de los clientes.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error al actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (dgvEclientes.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un cliente para eliminar.");
                    return;
                }

                string customerId = dgvEclientes.CurrentRow.Cells["CustomerID"].Value.ToString();

                DialogResult confirmResult = MessageBox.Show(
                    "Eliminar este cliente también borrará sus órdenes y detalles de órdenes relacionados. ¿Está seguro de que desea continuar?",
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
                            "DELETE FROM [Order Details] WHERE OrderID IN (SELECT OrderID FROM Orders WHERE CustomerID = @CustomerID)",
                            connection, transaction))
                        {
                            deleteOrderDetailsCmd.Parameters.AddWithValue("@CustomerID", customerId);
                            deleteOrderDetailsCmd.ExecuteNonQuery();
                        }

                        // 2. Elimina las órdenes del cliente
                        using (SqlCommand deleteOrdersCmd = new SqlCommand(
                            "DELETE FROM Orders WHERE CustomerID = @CustomerID",
                            connection, transaction))
                        {
                            deleteOrdersCmd.Parameters.AddWithValue("@CustomerID", customerId);
                            deleteOrdersCmd.ExecuteNonQuery();
                        }

                        // 3. Elimina al cliente
                        using (SqlCommand deleteCustomerCmd = new SqlCommand(
                            "DELETE FROM Customers WHERE CustomerID = @CustomerID",
                            connection, transaction))
                        {
                            deleteCustomerCmd.Parameters.AddWithValue("@CustomerID", customerId);
                            deleteCustomerCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Cliente y registros asociados eliminados exitosamente.");
                        ActualizarDatos(); 
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error al eliminar el cliente: {ex.Message}");
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EclientesAgregar eclientesAgregar = new EclientesAgregar();
            eclientesAgregar.Show();
        }

        private void dgvEclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvEclientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataTable selectedData = new DataTable();

                selectedData.Columns.Add("CustomerID");
                selectedData.Columns.Add("CompanyName");
                selectedData.Columns.Add("ContactName");
                selectedData.Columns.Add("ContactTitle");
                selectedData.Columns.Add("Address");
                selectedData.Columns.Add("City");
                selectedData.Columns.Add("Region");
                selectedData.Columns.Add("PostalCode");
                selectedData.Columns.Add("Country");
                selectedData.Columns.Add("Phone");
                selectedData.Columns.Add("Fax");

                // -------------------------------------------

                DataGridViewRow selectedRow = dgvEclientes.Rows[e.RowIndex];
                DataRow row = selectedData.NewRow();
                row["CustomerID"] = selectedRow.Cells["CustomerID"].Value.ToString();
                row["CompanyName"] = selectedRow.Cells["CompanyName"].Value.ToString();
                row["ContactName"] = selectedRow.Cells["ContactName"].Value.ToString();
                row["ContactTitle"] = selectedRow.Cells["ContactTitle"].Value.ToString();
                row["Address"] = selectedRow.Cells["Address"].Value.ToString();
                row["City"] = selectedRow.Cells["City"].Value.ToString();
                row["Region"] = selectedRow.Cells["Region"].Value?.ToString();
                row["PostalCode"] = selectedRow.Cells["PostalCode"].Value?.ToString();
                row["Country"] = selectedRow.Cells["Country"].Value.ToString();
                row["Phone"] = selectedRow.Cells["Phone"].Value.ToString();
                row["Fax"] = selectedRow.Cells["Fax"].Value?.ToString();
                selectedData.Rows.Add(row);

                EclientesEditar ece = new EclientesEditar(selectedData);
                ece.ShowDialog();
                ActualizarDatos();

            }
        }
    }
}
