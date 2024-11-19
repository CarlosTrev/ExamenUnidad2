
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExamenUnidad2.global;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenUnidad2
{
    public partial class ETabla : Form
    {
        DataSet ds;
        public ETabla()
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
            if (global.EmployeeID == 0)
            {
                CargarDatosGrid("SELECT * FROM Employees");
                HacerEditable(true);
                lbleditar.Text = "Pulse dos veces en la celda para editar";
            }
            else
            {
                CargarDatosGrid("SELECT * FROM Employees WHERE EmployeeID = " + global.EmployeeID);
                HacerEditable(false);
            }
        }
        private void HacerEditable(bool editable)
        {
            foreach (DataGridViewColumn columna in dgvEmpleados.Columns)
            {
                columna.ReadOnly = !editable;
            }
        }
    }
}
