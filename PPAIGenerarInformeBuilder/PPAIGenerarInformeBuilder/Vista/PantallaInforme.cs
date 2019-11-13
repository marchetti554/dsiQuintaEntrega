using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PPAIGenerarInformeBuilder.Vista
{
    public partial class PantallaInforme : Form
    {
        public PantallaInforme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form pantallaVisualizacion = new PantallaVisualizacion();
            pantallaVisualizacion.ShowDialog();

        }
    }
}
