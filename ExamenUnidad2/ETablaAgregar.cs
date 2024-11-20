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

                    string consultaID = "SELECT MAX(EmployeeID) FROM Employees";
                    int nuevoEmployeeID = 1; 
                    using (SqlDataReader reader = conexion.EjecutarDataReader(consultaID))
                    {
                        if (reader != null && reader.Read())
                        {
                            nuevoEmployeeID =  reader.GetInt32(0) + 1;
                        }
                    }
                nuevoEmployeeID = int.Parse(textBox1.Text);
                    string query = "INSERT INTO Employees " +
                                   "(EmployeeID, FirstName, LastName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath) " +
                                   "VALUES (@EmployeeID, @FirstName, @LastName, @Title, @TitleOfCourtesy, @BirthDate, @HireDate, @Address, @City, @Region, @PostalCode, @Country, @HomePhone, @Extension, @Photo, @Notes, @ReportsTo, @PhotoPath)";

                    
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        
                        cmd.Parameters.AddWithValue("@EmployeeID", nuevoEmployeeID);
                        cmd.Parameters.AddWithValue("@FirstName", txtFN.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLN.Text.Trim());
                    cmd.Parameters.AddWithValue("@Title", cmbTitle.SelectedItem != null ? cmbTitle.SelectedItem.ToString() : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@TitleOfCourtesy", (rbtn1.Checked ? "Dr." : rbtn2.Checked ? "Mr." : rbtn3.Checked ? "Mrs." : DBNull.Value));
                        cmd.Parameters.AddWithValue("@BirthDate", dtpBD.Value.Date);
                        cmd.Parameters.AddWithValue("@HireDate", dtpHD.Value.Date);
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(txtAddress.Text) ? DBNull.Value : (object)txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@City", string.IsNullOrEmpty(txtCity.Text) ? DBNull.Value : (object)txtCity.Text.Trim());
                        cmd.Parameters.AddWithValue("@Region", string.IsNullOrEmpty(txtRegion.Text) ? DBNull.Value : (object)txtRegion.Text.Trim());
                        cmd.Parameters.AddWithValue("@PostalCode", string.IsNullOrEmpty(txtCP.Text) ? DBNull.Value : (object)txtCP.Text.Trim());
                        cmd.Parameters.AddWithValue("@Country", string.IsNullOrEmpty(txtCountry.Text) ? DBNull.Value : (object)txtCountry.Text.Trim());
                        cmd.Parameters.AddWithValue("@HomePhone", string.IsNullOrEmpty(txtHomePhone.Text) ? DBNull.Value : (object)txtHomePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Extension", string.IsNullOrEmpty(txtExtension.Text) ? DBNull.Value : (object)txtExtension.Text.Trim());
                        cmd.Parameters.AddWithValue("@Photo", DBNull.Value); 
                    cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(txtNotes.Text) ? DBNull.Value : (object)txtNotes.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReportsTo", string.IsNullOrEmpty(cmbRT.SelectedItem?.ToString()) ? (object)DBNull.Value : (int?)Convert.ToInt32(cmbRT.SelectedItem.ToString())); // Cambiado a int?
                    cmd.Parameters.AddWithValue("@PhotoPath", DBNull.Value); 
                        

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
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Error en la base de datos: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error general: " + ex.Message);
                }
            

        }

    }
}
