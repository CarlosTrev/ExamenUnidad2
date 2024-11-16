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
    public partial class EproveedoresEditar : Form
    {
        public EproveedoresEditar(int supplierId, string companyName, string contactName, string contactTitle,
                            string address, string city, string region, string postalCode, string country,
                            string phone, string fax, string homePage)
        {
            InitializeComponent();

            // Asignar los valores a los controles del formulario
            txtBoxCSupID.Text = supplierId.ToString();
            txtBoxCN.Text = companyName;
            txtBoxCtN.Text = contactName;
            txtBoxCtT.Text = contactTitle;
            txtBoxCad.Text = address;
            txtBoxCci.Text = city;
            txtBoxCRe.Text = region;
            txtBoxCpo.Text = postalCode;
            txtBoxCco.Text = country;
            txtBoxCph.Text = phone;
            txtBoxCFa.Text = fax;
            txtBoxCHP.Text = homePage;
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del formulario
                int supplierId = Convert.ToInt32(txtBoxCSupID.Text);
                string companyName = txtBoxCN.Text;
                string contactName = txtBoxCtN.Text;
                string contactTitle = txtBoxCtT.Text;
                string address = txtBoxCad.Text;
                string city = txtBoxCci.Text;
                string region = txtBoxCRe.Text;
                string postalCode = txtBoxCpo.Text;
                string country = txtBoxCco.Text;
                string phone = txtBoxCph.Text;
                string fax = txtBoxCFa.Text;
                string homePage = txtBoxCHP.Text;

                connect conexion = new connect();

                // Construcción de la consulta SQL de actualización
                string query = @"
        UPDATE Suppliers
        SET CompanyName = @CompanyName,
            ContactName = @ContactName,
            ContactTitle = @ContactTitle,
            Address = @Address,
            City = @City,
            Region = @Region,
            PostalCode = @PostalCode,
            Country = @Country,
            Phone = @Phone,
            Fax = @Fax,
            HomePage = @HomePage
        WHERE SupplierID = @SupplierID";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    // Asignación de parámetros
                    cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                    cmd.Parameters.AddWithValue("@CompanyName", companyName);
                    cmd.Parameters.AddWithValue("@ContactName", contactName);
                    cmd.Parameters.AddWithValue("@ContactTitle", contactTitle);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@Region", region);
                    cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Fax", fax);
                    cmd.Parameters.AddWithValue("@HomePage", homePage);

                    if (conexion.EjecutarComando(cmd))
                    {
                        MessageBox.Show("Proveedor actualizado exitosamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el proveedor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        
    }
        //
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
