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
    public partial class GradicaShippers : Form
    {
        public GradicaShippers()
        {
            InitializeComponent();
        }

        private void GradicaShippers_Load(object sender, EventArgs e)
        {
            connect conexion = new connect();
            string query = @"
SELECT Shippers.CompanyName, COUNT(Orders.OrderID) AS OrderCount
FROM Shippers
LEFT JOIN Orders ON Shippers.ShipperID = Orders.ShipVia
GROUP BY Shippers.CompanyName";

            DataSet ds = conexion.Ejecutar(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                // Crear el modelo del gráfico
                var plotModel = new PlotModel { Title = "Órdenes por Compañía de Envío" };

                // Crear la serie de barras
                var series = new BarSeries
                {
                    Title = "Número de Pedidos",
                    LabelPlacement = LabelPlacement.Outside,
                    LabelFormatString = "{0}", // Formato de las etiquetas
                };

                // Llenar los datos de la serie con la cantidad de pedidos
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    series.Items.Add(new BarItem
                    {
                        Value = Convert.ToDouble(row["OrderCount"]), // Número de pedidos como valor X
                    });
                }

                // Añadir la serie al gráfico
                plotModel.Series.Add(series);

                // Crear el eje X (Categoría) con los nombres de los Shippers
                var shipperAxis = new CategoryAxis
                {
                    Position = AxisPosition.Left, // Eje Y en la izquierda
                    Key = "ShipperAxis",
                    ItemsSource = ds.Tables[0].Rows.Cast<DataRow>()
                        .Select(r => r["CompanyName"].ToString()).ToList() // Nombres de los Shippers
                };

                // Crear el eje Y (Valores numéricos) usando un LinearAxis
                var orderAxis = new LinearAxis
                {
                    Position = AxisPosition.Bottom, // Eje X en la parte inferior
                    Key = "OrderAxis",
                    Minimum = 0, // Establecer un valor mínimo para el eje X
                    Maximum = ds.Tables[0].Rows.Cast<DataRow>()
                        .Select(r => Convert.ToDouble(r["OrderCount"])).Max() + 10, // Establecer el máximo basado en los datos
                    MajorStep = 10, // El paso entre los valores principales del eje
                    MinorStep = 5,  // El paso entre los valores menores del eje
                    Title = "Número de Pedidos" // Título del eje X
                };

                // Añadir los ejes al gráfico
                plotModel.Axes.Add(shipperAxis);  // El eje de las categorías (Shippers)
                plotModel.Axes.Add(orderAxis);    // El eje numérico (Pedidos)

                // Establecer el modelo al control PlotView
                plotView1.Model = plotModel; // Asegúrate de que 'plotView1' sea tu control de OxyPlot en el formulario
            }
            else
            {
                MessageBox.Show("No se encontraron Shippers o pedidos en la base de datos.");
            }
        }
    }
}
