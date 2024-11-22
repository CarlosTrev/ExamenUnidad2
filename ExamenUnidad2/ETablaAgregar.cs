using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenUnidad2
{
    public partial class ETablaAgregar : Form
    {
        public ETablaAgregar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ETablaAgregar_Load(object sender, EventArgs e)
        {

        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpBD_ValueChanged(object sender, EventArgs e)
        {
            dtpHD.MinDate = dtpBD.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect conexion = new connect();

                string query = @"
INSERT INTO Employees (FirstName, LastName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo)
VALUES (@FirstName, @LastName, @Title, @TitleOfCourtesy, @BirthDate, @HireDate, @Address, @City, @Region, @PostalCode, @Country, @HomePhone, @Extension, @Notes, @ReportsTo)";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    // Asignar parámetros desde los controles
                    cmd.Parameters.AddWithValue("@FirstName", string.IsNullOrEmpty(txtFN.Text) ? (object)DBNull.Value : txtFN.Text);
                    cmd.Parameters.AddWithValue("@LastName", string.IsNullOrEmpty(txtLN.Text) ? (object)DBNull.Value : txtLN.Text);

                    // Obtener el título desde el ComboBox
                    cmd.Parameters.AddWithValue("@Title", cmbTitle.SelectedItem != null ? cmbTitle.SelectedItem.ToString() : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@TitleOfCourtesy", comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : (object)DBNull.Value);

                    // Fechas
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBD.Value);
                    cmd.Parameters.AddWithValue("@HireDate", dtpHD.Value);

                    // Datos opcionales
                    cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text);
                    cmd.Parameters.AddWithValue("@City", string.IsNullOrEmpty(txtCity.Text) ? (object)DBNull.Value : txtCity.Text);
                    cmd.Parameters.AddWithValue("@Region", string.IsNullOrEmpty(txtRegion.Text) ? (object)DBNull.Value : txtRegion.Text);
                    cmd.Parameters.AddWithValue("@PostalCode", string.IsNullOrEmpty(txtCP.Text) ? (object)DBNull.Value : txtCP.Text);
                    cmd.Parameters.AddWithValue("@Country", string.IsNullOrEmpty(txtCountry.Text) ? (object)DBNull.Value : txtCountry.Text);
                    cmd.Parameters.AddWithValue("@HomePhone", string.IsNullOrEmpty(txtHomePhone.Text) ? (object)DBNull.Value : txtHomePhone.Text);
                    cmd.Parameters.AddWithValue("@Extension", string.IsNullOrEmpty(txtExtension.Text) ? (object)DBNull.Value : txtExtension.Text);
                    cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(txtNotes.Text) ? (object)DBNull.Value : txtNotes.Text);

                    // Obtener el ReportsTo desde el ComboBox
                    if (cmbRT.SelectedItem != null)
                    {
                        // Suponiendo que el ComboBox contiene IDs como valores seleccionados
                        cmd.Parameters.AddWithValue("@ReportsTo", Convert.ToInt32(cmbRT.SelectedItem));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ReportsTo", DBNull.Value);
                    }

                    // Ejecutar el comando
                    bool resultado = conexion.EjecutarComando(cmd);

                    if (resultado)
                    {
                        MessageBox.Show("Empleado agregado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el empleado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
