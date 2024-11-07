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
                if (cmbbxTitulo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un título de contacto para el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connect conexion = new connect();

                string query = "INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Country, Phone";

                
                if (chbxRegion.Checked || !string.IsNullOrEmpty(txtbxRegion.Text)) query += ", Region";
                if (chboxCP.Checked || !string.IsNullOrEmpty(txtbxCP.Text)) query += ", PostalCode";
                if (chbxFax.Checked || !string.IsNullOrEmpty(txtbxFax.Text)) query += ", Fax";
                query += ") VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Country, @Phone";

                if (chbxRegion.Checked || !string.IsNullOrEmpty(txtbxRegion.Text)) query += ", @Region";
                if (chboxCP.Checked || !string.IsNullOrEmpty(txtbxCP.Text)) query += ", @PostalCode";
                if (chbxFax.Checked || !string.IsNullOrEmpty(txtbxFax.Text)) query += ", @Fax";
                query += ")";

                using (SqlCommand cmd = new SqlCommand(query))
                {

                    cmd.Parameters.AddWithValue("@CustomerID", mtxtbCID.Text); 
                    cmd.Parameters.AddWithValue("@CompanyName", txtbNC.Text);
                    cmd.Parameters.AddWithValue("@ContactName", txtbNCon.Text);
                    cmd.Parameters.AddWithValue("@ContactTitle", cmbbxTitulo.SelectedItem.ToString()); 
                    cmd.Parameters.AddWithValue("@Address", txtbxDireccion.Text);
                    cmd.Parameters.AddWithValue("@City", txtbxCiudad.Text);
                    cmd.Parameters.AddWithValue("@Country", txtbxPais.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtbxTelefono.Text);


                    cmd.Parameters.AddWithValue("@Region", chbxRegion.Checked || string.IsNullOrEmpty(txtbxRegion.Text) ? (object)DBNull.Value : txtbxRegion.Text);
                    cmd.Parameters.AddWithValue("@PostalCode", chboxCP.Checked || string.IsNullOrEmpty(txtbxCP.Text) ? (object)DBNull.Value : txtbxCP.Text);
                    cmd.Parameters.AddWithValue("@Fax", chbxFax.Checked || string.IsNullOrEmpty(txtbxFax.Text) ? (object)DBNull.Value : txtbxFax.Text);

                    if (conexion.EjecutarComando(cmd))
                    {
                        MessageBox.Show("Cliente agregado exitosamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el cliente.");
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
