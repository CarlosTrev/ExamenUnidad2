using Apriliados;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenUnidad2
{
    public partial class InicioSesion : Form
    {
        public List<int> idinicio = new List<int>();
        DataSet ds; 
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombreUsuario = txtbxUsuario.Text.Trim();
            string contrasena = txtbxContra.Text.Trim();

            if (VerificarInicioSesion(nombreUsuario, contrasena))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                AccesosEmpleado ae = new AccesosEmpleado();
                ae.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool VerificarInicioSesion(string nombreUsuario, string contrasena)
        {
            connect conexion = new connect();
            string consulta = "SELECT EmployeeID FROM Employees WHERE FirstName like '" + txtbxUsuario.Text.Trim() + "%'";

            DataSet ds = conexion.Ejecutar(consulta);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Obtener el ID del empleado
                int employeeId = (int)ds.Tables[0].Rows[0]["EmployeeID"];

                // Crear la contraseña esperada (4 veces)
                string contrasenaEsperada = employeeId.ToString() + employeeId.ToString() + employeeId.ToString() + employeeId.ToString();


                // Comparar la contraseña ingresada con la esperada
                idinicio.Add(employeeId);
                return contrasena == contrasenaEsperada;
            }
            return false; // No se encontró el empleado
        }



    }
}
