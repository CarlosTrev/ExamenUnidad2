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
    public partial class AccesosEmpleado : Form
    {
        public AccesosEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleadotabla et = new Empleadotabla();
            et.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
