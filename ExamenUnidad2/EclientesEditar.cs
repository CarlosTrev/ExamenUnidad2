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
    public partial class EclientesEditar : Form{
        public EclientesEditar(DataTable data)
        {
            InitializeComponent();
            dgvClientesEditar.DataSource = data;
        }

        private void EclientesEditar_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            connect conexion = new connect();

            foreach (DataGridViewRow row in dgvClientesEditar.Rows)
            {
                if (row.IsNewRow) continue;

                string query = "UPDATE Customers SET " +
                               "CompanyName = @CompanyName, " +
                               "ContactName = @ContactName, " +
                               "ContactTitle = @ContactTitle, " +
                               "Address = @Address, " +
                               "City = @City, " +
                               "Region = @Region, " +
                               "PostalCode = @PostalCode, " +
                               "Country = @Country, " +
                               "Phone = @Phone, " +
                               "Fax = @Fax " +
                               "WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@CompanyName", row.Cells["CompanyName"].Value.ToString());
                    cmd.Parameters.AddWithValue("@ContactName", row.Cells["ContactName"].Value.ToString());
                    cmd.Parameters.AddWithValue("@ContactTitle", row.Cells["ContactTitle"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Address", row.Cells["Address"].Value.ToString());
                    cmd.Parameters.AddWithValue("@City", row.Cells["City"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Region", row.Cells["Region"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@PostalCode", row.Cells["PostalCode"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@Country", row.Cells["Country"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Phone", row.Cells["Phone"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Fax", row.Cells["Fax"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@CustomerID", row.Cells["CustomerID"].Value.ToString());

                    conexion.EjecutarComando(cmd);
                }
            }
            MessageBox.Show("Cambios guardados exitosamente.");
            this.Close();
        }


    }
}
