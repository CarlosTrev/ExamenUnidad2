using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ExamenUnidad2
{
    public partial class Eclientes : Form
    {
        DataSet ds;
        public Eclientes()
        {
            InitializeComponent();
        }
        private void CargarDatosGrid(string comando)
        {
            connect dt = new connect();
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dgvEclientes.DataSource = ds.Tables[0];
            }
        }

        private void Eclientes_Load(object sender, EventArgs e)
        {
            CargarDatosGrid("SELECT * FROM Customers");

        }

        private void txtbxEclientes_TextChanged(object sender, EventArgs e)
        {
            CargarDatosGrid("SELECT * FROM Customers WHERE " + cmbEclientes.Text.Trim().Replace(" ", "") + " LIKE '%" + txtbxEclientes.Text.Trim() + "%'");
        }

        private void dgvEclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataTable selectedData = new DataTable();

                selectedData.Columns.Add("CustomerID");
                selectedData.Columns.Add("CompanyName");
                selectedData.Columns.Add("ContactName");
                selectedData.Columns.Add("ContactTitle");
                selectedData.Columns.Add("Address");
                selectedData.Columns.Add("City");
                selectedData.Columns.Add("Region");
                selectedData.Columns.Add("PostalCode");
                selectedData.Columns.Add("Country");
                selectedData.Columns.Add("Phone");
                selectedData.Columns.Add("Fax");

                // -------------------------------------------

                DataGridViewRow selectedRow = dgvEclientes.Rows[e.RowIndex];
                DataRow row = selectedData.NewRow();
                row["CustomerID"] = selectedRow.Cells["CustomerID"].Value.ToString();
                row["CompanyName"] = selectedRow.Cells["CompanyName"].Value.ToString();
                row["ContactName"] = selectedRow.Cells["ContactName"].Value.ToString();
                row["ContactTitle"] = selectedRow.Cells["ContactTitle"].Value.ToString();
                row["Address"] = selectedRow.Cells["Address"].Value.ToString();
                row["City"] = selectedRow.Cells["City"].Value.ToString();
                row["Region"] = selectedRow.Cells["Region"].Value?.ToString();
                row["PostalCode"] = selectedRow.Cells["PostalCode"].Value?.ToString();
                row["Country"] = selectedRow.Cells["Country"].Value.ToString();
                row["Phone"] = selectedRow.Cells["Phone"].Value.ToString();
                row["Fax"] = selectedRow.Cells["Fax"].Value?.ToString();
                selectedData.Rows.Add(row);
            

                EclientesEditar ece = new EclientesEditar(selectedData);
                ece.DatosActualizados += () => CargarDatosGrid("SELECT * FROM Customers");
                ece.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
