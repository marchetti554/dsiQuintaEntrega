using PPAIGenerarInformeBuilder.Controlador;
using PPAIGenerarInformeBuilder.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAIGenerarInformeBuilder.Vista
{
    public partial class PantallaGenerarInformeCumplimientoGuardias : Form
    {

        GestorGenerarInformeCumplimientoGuardias gestorInforme = new GestorGenerarInformeCumplimientoGuardias();

        public PantallaGenerarInformeCumplimientoGuardias()
        {
            InitializeComponent();
        }

        private void PantallaGenerarInformeCumplimientoGuardias_Load(object sender, EventArgs e)
        {

        }

        private void lbl_bravo_Click(object sender, EventArgs e)
        {

        }

        private void btn_generar_informe_Click(object sender, EventArgs e)
        {
            IList<Bombero> bomberosSeleccionados = new List<Bombero>();
            fillBomberosSeleccionados(bomberosSeleccionados);
            gestorInforme.generarInformeCumplimientoGuardia(fecha_desde.Value, fecha_hasta.Value, bomberosSeleccionados);
        }

        private void fillBomberosSeleccionados(IList<Bombero> listaBomberos)
        {

        }
    }
}
