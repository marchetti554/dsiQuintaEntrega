using PPAIGenerarInformeBuilder.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAIGenerarInformeBuilder
{
    public partial class PantallaMenu : Form
    {
        public PantallaMenu()
        {
            InitializeComponent();
        }

        private void btn_generar_informe_Click(object sender, EventArgs e)
        {
            Form pantallaGenerarInforme = new PantallaGenerarInformeCumplimientoGuardias();
            pantallaGenerarInforme.ShowDialog();
        }
    }
}
