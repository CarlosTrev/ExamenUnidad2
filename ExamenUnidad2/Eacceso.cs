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
    }
}
