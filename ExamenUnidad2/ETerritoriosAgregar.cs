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

namespace ExamenUnidad2
{
    public partial class ETerritoriosAgregar : Form
    {
        public ETerritoriosAgregar()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string territoryId = txtTIDA.Text.Trim();
            string description = txtDA.Text.Trim();
            int regionId;

            // Verifica que el ComboBox tenga un valor seleccionado y convierte a entero
            if (cmbRIDA.SelectedItem != null && int.TryParse(cmbRIDA.SelectedItem.ToString(), out regionId))
            {
                // Consulta SQL para insertar datos en la tabla correspondiente
                string consulta = "INSERT INTO Territories (TerritoryID, TerritoryDescription, RegionID) VALUES (@TerritoryID, @TerritoryDescription, @RegionID)";

                try
                {
                    connect conexion = new connect();
                    using (SqlCommand cmd = new SqlCommand(consulta))
                    {
                        cmd.Parameters.AddWithValue("@TerritoryID", territoryId);
                        cmd.Parameters.AddWithValue("@TerritoryDescription", description);
                        cmd.Parameters.AddWithValue("@RegionID", regionId);

                        bool resultado = conexion.EjecutarComando(cmd);

                        if (resultado)
                        {
                            MessageBox.Show("Datos insertados exitosamente.");
                            ETerritorios eTerritorios = new ETerritorios();
                            eTerritorios.CargarTerritorios();
                        }
                        else
                        {
                            MessageBox.Show("Error al insertar los datos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un valor válido para RegionID.");
            }
        }
    }
}
