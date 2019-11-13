using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PPAIGenerarInformeBuilder.Vista
{
    public partial class PantallaVisualizacion : Form
    {
        public PantallaVisualizacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PDF generado con éxito");
        }
    }
}
