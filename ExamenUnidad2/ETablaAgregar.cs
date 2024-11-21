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

                    string query = "INSERT INTO Employees ([LastName], [FirstName], [Title], [TitleOfCourtesy],[BirthDate], " +
                    "[HireDate], [Address], [City], [Region],[PostalCode], [Country], [HomePhone]," +
                    "[Extension],[Photo], [Notes], [ReportsTo], [PhotoPath]) +" +
                    /////////////////////
                    "VALUES (@LastName, @FirstName, @Title, @TitleOfCourtesy, @BirthDate," +
                    "@HireDate, @Address, @City, @Region, @PostalCode, @Country, @HomePhone," +
                    "@Extension, @Photo, @Notes, @ReportsTo, @PhotoPath)";

                    
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                    cmd.Parameters.AddWithValue("@LastName", "One");
                    cmd.Parameters.AddWithValue("@FirstName", "Charlie");
                    cmd.Parameters.AddWithValue("@Title", DBNull.Value);
                    cmd.Parameters.AddWithValue("@TitleOfCourtesy", (DBNull.Value));
                        cmd.Parameters.AddWithValue("@BirthDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@HireDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Address", DBNull.Value);
                        cmd.Parameters.AddWithValue("@City", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Region", DBNull.Value);
                        cmd.Parameters.AddWithValue("@PostalCode", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Country", DBNull.Value);
                        cmd.Parameters.AddWithValue("@HomePhone", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Extension", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Photo", DBNull.Value); 
                    cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ReportsTo", DBNull.Value);
                    cmd.Parameters.AddWithValue("@PhotoPath", DBNull.Value); 
                        

                        bool resultado = conexion.EjecutarComando   (cmd);

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
