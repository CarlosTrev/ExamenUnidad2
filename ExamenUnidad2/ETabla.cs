
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
            if (e.RowIndex >= 0)
            {

                DataTable selectedData = new DataTable();

                // Definir las columnas de selectedData según las columnas de la tabla Employees (o las que necesites)
                selectedData.Columns.Add("EmployeeID");
                selectedData.Columns.Add("LastName");
                selectedData.Columns.Add("FirstName");
                selectedData.Columns.Add("Title");
                selectedData.Columns.Add("BirthDate");
                selectedData.Columns.Add("HireDate");
                selectedData.Columns.Add("Address");
                selectedData.Columns.Add("City");
                selectedData.Columns.Add("Region");
                selectedData.Columns.Add("PostalCode");
                selectedData.Columns.Add("Country");
                selectedData.Columns.Add("HomePhone");
                selectedData.Columns.Add("Extension");
                selectedData.Columns.Add("Notes");
                selectedData.Columns.Add("ReportsTo");

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvEmpleados.Rows[e.RowIndex];
                DataRow row = selectedData.NewRow();

                // Rellenar el DataRow con los valores de la fila seleccionada
                row["EmployeeID"] = selectedRow.Cells["EmployeeID"].Value.ToString();
                row["LastName"] = selectedRow.Cells["LastName"].Value.ToString();
                row["FirstName"] = selectedRow.Cells["FirstName"].Value.ToString();
                row["Title"] = selectedRow.Cells["Title"].Value.ToString();
                row["BirthDate"] = selectedRow.Cells["BirthDate"].Value.ToString();
                row["HireDate"] = selectedRow.Cells["HireDate"].Value.ToString();
                row["Address"] = selectedRow.Cells["Address"].Value.ToString();
                row["City"] = selectedRow.Cells["City"].Value.ToString();
                row["Region"] = selectedRow.Cells["Region"].Value?.ToString();
                row["PostalCode"] = selectedRow.Cells["PostalCode"].Value?.ToString();
                row["Country"] = selectedRow.Cells["Country"].Value.ToString();
                row["HomePhone"] = selectedRow.Cells["HomePhone"].Value.ToString();
                row["Extension"] = selectedRow.Cells["Extension"].Value?.ToString();
                row["Notes"] = selectedRow.Cells["Notes"].Value?.ToString();
                row["ReportsTo"] = selectedRow.Cells["ReportsTo"].Value?.ToString();

                selectedData.Rows.Add(row);

                // Abrir la ventana de edición con los datos de la fila seleccionada
                EempleadosEditar ece = new EempleadosEditar(selectedData);
                ece.ShowDialog();
                CargarDatosGrid("SELECT * FROM Employees");
            }
        }

        private void Empleadotabla_Load(object sender, EventArgs e)
        {
            if (global.EmployeeID == 0)
            {
                CargarDatosGrid("SELECT * FROM Employees");
                this.Text = "Vista Admin - Empleados";
                if (dgvEmpleados.Columns.Contains("Editar"))
                {
                    dgvEmpleados.Columns["Editar"].Visible = true;
                }
            }
            else
            {
                CargarDatosGrid("SELECT * FROM Employees WHERE EmployeeID = " + global.EmployeeID);
                this.Text = "Vista Empleado - Tus datos";
                if (dgvEmpleados.Columns.Contains("Editar"))
                {
                    dgvEmpleados.Columns["Editar"].Visible = false;
                }
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
