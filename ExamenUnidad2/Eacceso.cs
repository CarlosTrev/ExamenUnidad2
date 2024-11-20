using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad2
{
    public partial class Eacceso : Form
    {
        public Eacceso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ETabla et = new ETabla();
            et.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Eproveedores ep = new Eproveedores();
            ep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eclientes eclientes = new Eclientes();
            eclientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EPyV ePyV = new EPyV();
            ePyV.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eproductos eproductos = new Eproductos();
            eproductos.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ETerritorios territorios = new ETerritorios();
            territorios.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Eshippers eshippers = new Eshippers();
            eshippers.Show();
        }
    }
}
