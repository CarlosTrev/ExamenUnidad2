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

                // Consulta con solo campos obligatorios
                string query = "INSERT INTO Employees ([LastName], [FirstName], [Title]) " +
                    "VALUES (@LastName, @FirstName, @Title)";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    // Proveer valores a los campos obligatorios
                    cmd.Parameters.AddWithValue("@LastName", "Charlie"); // Obligatorio
                    cmd.Parameters.AddWithValue("@FirstName", "Juan"); // Obligatorio

                    cmd.Parameters.AddWithValue("@Title", "Smash Bros");

                    // Ejecutar comando
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
