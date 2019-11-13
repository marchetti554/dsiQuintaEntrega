using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace PPAIGenerarInformeBuilder.Modelo
{
    public class InformePDF
    {
        string titulo;
        string nombreUsuario;
        DateTime fechaDesde;
        DateTime fechaHasta;
        DateTime fechaHoraGeneracion;
        Chart grafico;

        public void setEncabezado(DateTime fechaDesde, DateTime fechaHasta, string titulo)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.titulo = titulo;
        }
        public void setCuerpo(Chart chart)
        {
            this.grafico = chart;
        }
        public void setPie(DateTime fechaHoraGeneracion, string nombreUsuario)
        {
            this.fechaHoraGeneracion = fechaHoraGeneracion;
            this.nombreUsuario = nombreUsuario;
        }
    }
}
