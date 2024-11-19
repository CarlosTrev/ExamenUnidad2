
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static ExamenUnidad2.global;

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
                Eacceso ae = new Eacceso();
                ae.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
            txtbxUsuario.Clear();
            txtbxContra.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool VerificarInicioSesion(string nombreUsuario, string contrasena)
        {
            if (string.Equals(nombreUsuario, "Admin", StringComparison.OrdinalIgnoreCase) && contrasena == "0000")
            {
                global.EmployeeID = 0;
                return true;  // Inicia sesión como administrador
            }
            connect conexion = new connect();
            string consulta = "SELECT EmployeeID FROM Employees WHERE FirstName like '" + txtbxUsuario.Text.Trim() + "%'";

            using (SqlDataReader reader = conexion.EjecutarDataReader(consulta))
            {
                if (reader != null && reader.Read())
                {
                    int employeeId = reader.GetInt32(0); // Obtiene el EmployeeID
                    global.EmployeeID = employeeId;


                    // Crear la contraseña esperada (4 veces el ID del empleado)
                    string contrasenaEsperada = employeeId.ToString() + employeeId.ToString() + employeeId.ToString() + employeeId.ToString();

                    return contrasena == contrasenaEsperada;
                }
            }

            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
