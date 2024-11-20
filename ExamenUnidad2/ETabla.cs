
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
using static ExamenUnidad2.global;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenUnidad2
{
    public partial class ETabla : Form
    {
        DataSet ds;
        public ETabla()
        {
            InitializeComponent();
        }
        private void CargarDatosGrid(string comando)
        {
            connect dt = new connect();
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataTable selectedData = new DataTable();

                // Definir las columnas de selectedData según las columnas de la tabla Employees (o las que necesites)
                selectedData.Columns.Add("EmployeeID");
                selectedData.Columns.Add("LastName");
                selectedData.Columns.Add("FirstName");
                selectedData.Columns.Add("Title");
                selectedData.Columns.Add("BirthDate");
                selectedData.Columns.Add("HireDate");
                selectedData.Columns.Add("Address");
                selectedData.Columns.Add("City");
                selectedData.Columns.Add("Region");
                selectedData.Columns.Add("PostalCode");
                selectedData.Columns.Add("Country");
                selectedData.Columns.Add("HomePhone");
                selectedData.Columns.Add("Extension");
                selectedData.Columns.Add("Notes");
                selectedData.Columns.Add("ReportsTo");

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvEmpleados.Rows[e.RowIndex];
                DataRow row = selectedData.NewRow();

                // Rellenar el DataRow con los valores de la fila seleccionada
                row["EmployeeID"] = selectedRow.Cells["EmployeeID"].Value.ToString();
                row["LastName"] = selectedRow.Cells["LastName"].Value.ToString();
                row["FirstName"] = selectedRow.Cells["FirstName"].Value.ToString();
                row["Title"] = selectedRow.Cells["Title"].Value.ToString();
                row["BirthDate"] = selectedRow.Cells["BirthDate"].Value.ToString();
                row["HireDate"] = selectedRow.Cells["HireDate"].Value.ToString();
                row["Address"] = selectedRow.Cells["Address"].Value.ToString();
                row["City"] = selectedRow.Cells["City"].Value.ToString();
                row["Region"] = selectedRow.Cells["Region"].Value?.ToString();
                row["PostalCode"] = selectedRow.Cells["PostalCode"].Value?.ToString();
                row["Country"] = selectedRow.Cells["Country"].Value.ToString();
                row["HomePhone"] = selectedRow.Cells["HomePhone"].Value.ToString();
                row["Extension"] = selectedRow.Cells["Extension"].Value?.ToString();
                row["Notes"] = selectedRow.Cells["Notes"].Value?.ToString();
                row["ReportsTo"] = selectedRow.Cells["ReportsTo"].Value?.ToString();

                selectedData.Rows.Add(row);

                // Abrir la ventana de edición con los datos de la fila seleccionada
                EempleadosEditar ece = new EempleadosEditar(selectedData);
                ece.ShowDialog();
                CargarDatosGrid("SELECT * FROM Employees");
            }
        }

        private void Empleadotabla_Load(object sender, EventArgs e)
        {
            if (global.EmployeeID == 0)
            {
                CargarDatosGrid("SELECT * FROM Employees");
                this.Text = "Vista Admin - Empleados";
                if (dgvEmpleados.Columns.Contains("Editar"))
                {
                    dgvEmpleados.Columns["Editar"].Visible = true;
                }
            }
            else
            {
                CargarDatosGrid("SELECT * FROM Employees WHERE EmployeeID = " + global.EmployeeID);
                this.Text = "Vista Empleado - Tus datos";
                if (dgvEmpleados.Columns.Contains("Editar"))
                {
                    dgvEmpleados.Columns["Editar"].Visible = false;
                }
                btnAgregarEmpleado.Enabled = false;
                btnAgregarEmpleado.Visible = false;
                btnEliminarEmpleado.Enabled = false;
                btnEliminarEmpleado.Visible = false;

            }
        }
        private void HacerEditable(bool editable)
        {
            foreach (DataGridViewColumn columna in dgvEmpleados.Columns)
            {
                columna.ReadOnly = !editable;
            }
        }

        private void btnTerritorios_Click(object sender, EventArgs e)
        {
            ETerritorios eTerritorios = new ETerritorios();
            eTerritorios.Show();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvEmpleados.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvEmpleados.Rows[selectedRowIndex];
                int employeeId = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);

                DialogResult resultado = MessageBox.Show(
                    "Este empleado y todos sus territorios asociados serán eliminados, y sus órdenes tendrán 'NULL' en el campo de EmployeeID. ¿Estás seguro de que deseas continuar?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        connect conexion = new connect();

                        string consultaActualizarOrders = "UPDATE Orders SET EmployeeID = NULL WHERE EmployeeID = @EmployeeID";
                        using (SqlCommand cmdActualizarOrders = new SqlCommand(consultaActualizarOrders))
                        {
                            cmdActualizarOrders.Parameters.AddWithValue("@EmployeeID", employeeId);
                            conexion.EjecutarComando(cmdActualizarOrders);
                        }

                        string consultaEliminarTerritorios = "DELETE FROM EmployeeTerritories WHERE EmployeeID = @EmployeeID";
                        using (SqlCommand cmdTerritorios = new SqlCommand(consultaEliminarTerritorios))
                        {
                            cmdTerritorios.Parameters.AddWithValue("@EmployeeID", employeeId);
                            conexion.EjecutarComando(cmdTerritorios);
                        }

                        string consultaEliminarEmpleado = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                        using (SqlCommand cmdEmpleado = new SqlCommand(consultaEliminarEmpleado))
                        {
                            cmdEmpleado.Parameters.AddWithValue("@EmployeeID", employeeId);
                            bool exito = conexion.EjecutarComando(cmdEmpleado);

                            if (exito)
                            {
                                MessageBox.Show("Empleado, sus territorios y referencias en órdenes fueron eliminados exitosamente.");
                                CargarDatosGrid("SELECT * FROM Employees");
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el empleado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el empleado y sus territorios: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para eliminar al empleado, sus territorios y referencias en órdenes.");
            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            ETablaAgregar eTablaAgregar = new ETablaAgregar();
            eTablaAgregar.Show();
        }
    }
}
