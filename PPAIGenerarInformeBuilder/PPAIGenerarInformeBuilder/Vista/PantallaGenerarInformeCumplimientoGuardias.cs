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
            mostrarBomberosActivos(gestorInforme.buscarBomberosActivos());

        }
        private void lbl_bravo_Click(object sender, EventArgs e)
        {

        }


        private void btn_generar_informe_Click(object sender, EventArgs e)
        {



            //IList<Bombero> bomberosSeleccionados = new List<Bombero>();
            //fillBomberosSeleccionados(bomberosSeleccionados);
            //gestorInforme.generarInformeCumplimientoGuardia(fecha_desde.Value, fecha_hasta.Value, bomberosSeleccionados);

            Form pantallaInforme = new PantallaInforme();
            pantallaInforme.ShowDialog();
        }

        private void fillBomberosSeleccionados(IList<Bombero> listaBomberos)
        {

        }

        public void solicitarPeriodoParaInforme() 
        {
            String txtFechaDesdeReporte = (fecha_desde.Value).ToString("dd-MM-yyyy");
            String txtFechaHastaReporte = (fecha_hasta.Value).ToString("dd-MM-yyyy");

            //String txtFechaDesdeReporte = boxprueba1.Text;
            //String txtFechaHastaReporte = boxprueba2.Text;
            if (validarFechasIngresadas(txtFechaDesdeReporte, txtFechaHastaReporte))
            {
                gestorInforme.tomarFechasParaInforme(txtFechaDesdeReporte, txtFechaHastaReporte);

            }
            else
            {
                MessageBox.Show("La fecha desde es mayor que la fecha hasta");
            }

            
        }

        //public Boolean validarFechasIngresadas(String fechaDesde, String fechaHasta) 
        //{
        //    if (fechaDesde.CompareTo(fechaHasta) > 0)
        //    {
        //        return true;
        //    }
        //    else { return false; }

        //}

        public Boolean validarFechasIngresadas(String fechaDesde, String fechaHasta)
        {
            if (fechaDesde.CompareTo(fechaHasta) < 0)
            {
                return true;
            }
            else { return false; }

        }

        public void mostrarBomberosActivos(IList<Bombero> bomberActivos) 
        {
            for (int i = 0; i < (bomberActivos.Count); i++) 
            {
                DataGridViewCheckBoxColumn cc = new DataGridViewCheckBoxColumn();
                //TODO: Cargar bien esta grilla por ahora no anda con esto -> 
                dgv_bomberos.Rows.Add(cc, bomberActivos[i].nombre, bomberActivos[i].apellido, bomberActivos[i].dni);
            }           
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            gestorInforme.generarInformeCumplimientoGuardia();
        }

        public void tomarSeleccionBomberos(List<String> bomberActivos) 
        {
            for (int i = 0; i < (bomberActivos.Count) / 2; i++)
            {
                
            }
            //if (checkBox1.Checked)
            //{
                
            //}
        }

        private void dgv_bomberos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
