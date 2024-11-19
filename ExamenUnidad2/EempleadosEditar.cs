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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenUnidad2
{
    public partial class EempleadosEditar : Form
    {
        private DataTable selectedData;
        public EempleadosEditar(DataTable empleadoData)
        {
            InitializeComponent();
            dgEmpleadosEditar.DataSource = empleadoData; // Cargar los datos en el DataGridView
        }

        // Guardar cambios realizados en el DataGridView
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        // Cancelar los cambios y cerrar la ventana
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Simplemente cerramos la ventana sin hacer cambios
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            connect conexion = new connect();

            foreach (DataGridViewRow row in dgEmpleadosEditar.Rows)
            {
                if (row.IsNewRow) continue;

                string query = "UPDATE Employees SET " +
                               "LastName = @LastName, " +
                               "FirstName = @FirstName, " +
                               "Title = @Title, " +
                               "BirthDate = @BirthDate, " +
                               "HireDate = @HireDate, " +
                               "Address = @Address, " +
                               "City = @City, " +
                               "Region = @Region, " +
                               "PostalCode = @PostalCode, " +
                               "Country = @Country, " +
                               "HomePhone = @HomePhone, " +
                               "Extension = @Extension, " +
                               "Notes = @Notes, " +
                               "ReportsTo = @ReportsTo " +
                               "WHERE EmployeeID = @EmployeeID";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    // Asignar parámetros con los valores de las celdas
                    cmd.Parameters.AddWithValue("@LastName", row.Cells["LastName"].Value.ToString());
                    cmd.Parameters.AddWithValue("@FirstName", row.Cells["FirstName"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Title", row.Cells["Title"].Value.ToString());
                    cmd.Parameters.AddWithValue("@BirthDate", row.Cells["BirthDate"].Value);
                    cmd.Parameters.AddWithValue("@HireDate", row.Cells["HireDate"].Value);
                    cmd.Parameters.AddWithValue("@Address", row.Cells["Address"].Value.ToString());
                    cmd.Parameters.AddWithValue("@City", row.Cells["City"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Region", row.Cells["Region"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@PostalCode", row.Cells["PostalCode"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@Country", row.Cells["Country"].Value.ToString());
                    cmd.Parameters.AddWithValue("@HomePhone", row.Cells["HomePhone"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Extension", row.Cells["Extension"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@Notes", row.Cells["Notes"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@ReportsTo", row.Cells["ReportsTo"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@EmployeeID", row.Cells["EmployeeID"].Value.ToString());

                    // Ejecutar el comando
                    conexion.EjecutarComando(cmd);
                }
            }

            MessageBox.Show("Cambios guardados exitosamente.");
            this.Close(); // Cerrar la ventana después de guardar
        }
    }

}
