using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.Axes;

namespace ExamenUnidad2
{
    public partial class GraficaClientes : Form
    {
        public GraficaClientes()
        {
            InitializeComponent();
        }

        private void GraficaClientes_Load(object sender, EventArgs e)
        {
            connect conexion = new connect();
            string query = @"
    SELECT Customers.Country, COUNT(Customers.CustomerID) AS CustomerCount
    FROM Customers
    GROUP BY Customers.Country";

            DataSet ds = conexion.Ejecutar(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                // Crear el modelo del gráfico
                var plotModel = new PlotModel { Title = "Clientes por País" };

                // Crear la serie de líneas
                var series = new LineSeries
                {
                    Title = "Número de Clientes",
                    MarkerType = MarkerType.Circle, // Marcadores en los puntos de la línea
                    MarkerSize = 5,
                    LineStyle = LineStyle.Solid // Línea sólida
                };

                // Llenar los datos de la serie con la cantidad de clientes
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    // Añadir puntos a la serie de líneas
                    series.Points.Add(new DataPoint(
                        ds.Tables[0].Rows.IndexOf(row), // El índice de la fila será el valor X (Países)
                        Convert.ToDouble(row["CustomerCount"]) // Número de clientes como valor Y
                    ));
                }

                // Añadir la serie al gráfico
                plotModel.Series.Add(series);

                // Crear el eje X (Categoría) con los nombres de los países
                var countryAxis = new CategoryAxis
                {
                    Position = AxisPosition.Bottom, // Eje X en la parte inferior
                    Key = "CountryAxis",
                    ItemsSource = ds.Tables[0].Rows.Cast<DataRow>()
                        .Select(r => r["Country"].ToString()).ToList() // Países como categorías
                };

                // Crear el eje Y (Valores numéricos) usando un LinearAxis
                var customerAxis = new LinearAxis
                {
                    Position = AxisPosition.Left, // Eje Y a la izquierda
                    Key = "CustomerAxis",
                    Minimum = 0, // Establecer un valor mínimo para el eje Y
                    Maximum = ds.Tables[0].Rows.Cast<DataRow>()
                        .Select(r => Convert.ToDouble(r["CustomerCount"])).Max() + 10, // Establecer el máximo basado en los datos
                    MajorStep = 10, // El paso entre los valores principales del eje
                    MinorStep = 5,  // El paso entre los valores menores del eje
                    Title = "Número de Clientes" // Título del eje Y
                };

                // Añadir los ejes al gráfico
                plotModel.Axes.Add(countryAxis);  // El eje de las categorías (País)
                plotModel.Axes.Add(customerAxis); // El eje numérico (Clientes)

                // Establecer el modelo al control PlotView
                plotView1.Model = plotModel; // Asegúrate de que 'plotView1' sea tu control de OxyPlot en el formulario
            }
            else
            {
                MessageBox.Show("No se encontraron clientes o países en la base de datos.");
            }
        }
    }
}
