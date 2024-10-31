using Apriliados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenUnidad2
{
    public partial class Empleadotabla : Form
    {
        DataSet ds;
        public Empleadotabla()
        {
            InitializeComponent();
        }
        private void CargarDatosGrid(string comando)
        {
            connect dt = new connect();
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Empleadotabla_Load(object sender, EventArgs e)
        {
            CargarDatosGrid("SELECT\r\n      [LastName]\r\n      ,[FirstName]\r\n      ,[Title]\r\n      ,[TitleOfCourtesy]\r\n      ,[City]\r\n      ,[Region]\r\n      ,[Country]\r\n      ,[HomePhone]\r\n      ,[Extension]\r\n      ,[Photo]\r\n      ,[Notes]\r\n  FROM Employees");
        }
    }
}
