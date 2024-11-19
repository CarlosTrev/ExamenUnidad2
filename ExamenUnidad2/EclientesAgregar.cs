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
    public partial class EclientesAgregar : Form
    {
        public EclientesAgregar()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxFax.Checked)
            {
                txtbxFax.Enabled = false;
            }
            else
            {
                txtbxFax.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxRegion.Checked)
            {
                txtbxRegion.Enabled = false;
            }
            else
            {
                txtbxRegion.Enabled = true;
            }
        }

        private void EclientesAgregar_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void chboxCP_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxCP.Checked)
            {
                txtbxCP.Enabled = false;
            }
            else
            {
                txtbxCP.Enabled = true;
            }
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            try
            {
                connect conexion = new connect();
                string nombreCompleto = txtbNC.Text.Trim().ToUpper();
                string customerId = nombreCompleto.Split(' ')[0].Substring(0, 3) + nombreCompleto.Split(' ')[1].Substring(0, 2);


                string query = "INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Country, Phone, Region, PostalCode, Fax) " +
                               "VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Country, @Phone, @Region, @PostalCode, @Fax)";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    cmd.Parameters.AddWithValue("@CompanyName", txtbNC.Text);
                    cmd.Parameters.AddWithValue("@ContactName", txtbNCon.Text);
                    cmd.Parameters.AddWithValue("@ContactTitle", cmbbxTitulo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Address", txtbxDireccion.Text);
                    cmd.Parameters.AddWithValue("@City", txtbxCiudad.Text);
                    cmd.Parameters.AddWithValue("@Country", txtbxPais.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtbxTelefono.Text);

                    cmd.Parameters.AddWithValue("@Region", string.IsNullOrEmpty(txtbxRegion.Text) ? (object)DBNull.Value : txtbxRegion.Text);
                    cmd.Parameters.AddWithValue("@PostalCode", string.IsNullOrEmpty(txtbxCP.Text) ? (object)DBNull.Value : txtbxCP.Text);
                    cmd.Parameters.AddWithValue("@Fax", string.IsNullOrEmpty(txtbxFax.Text) ? (object)DBNull.Value : txtbxFax.Text);

                    bool resultado = conexion.EjecutarComando(cmd);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente agregado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el cliente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerarCustomerID(string nombre, string otroNombre)
        {
            string customerID = (nombre.Length >= 3 ? nombre.Substring(0, 3) : nombre) +
                                (otroNombre.Length >= 2 ? otroNombre.Substring(0, 2) : otroNombre);
            return customerID.ToUpper();
        }
    }
}
