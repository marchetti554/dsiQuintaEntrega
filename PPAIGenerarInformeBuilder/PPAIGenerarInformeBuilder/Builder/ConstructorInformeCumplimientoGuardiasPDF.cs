using PPAIGenerarInformeBuilder.Modelo;
using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace PPAIGenerarInformeBuilder.Builder
{
    /**
     * Constructor específico para Construir PDFs, implementa IConstructorInforme
     * por lo que debe implementar cada uno de sus métodos.
     **/
    public class ConstructorInformeCumplimientoGuardiasPDF : IConstructorInforme
    {

        private InformePDF producto;

        /**
         * Constructor por defecto.
         **/
        public ConstructorInformeCumplimientoGuardiasPDF()
        {

        }

        public void construirCuerpo(Chart chart)
        {
            producto.setCuerpo(chart);
        }

        public void construirEncabezado(DateTime fechaDesde, DateTime fechaHasta, string titulo)
        {
            producto.setEncabezado(fechaDesde, fechaHasta, titulo);
        }

        public void construirPie(DateTime fechaHoraGeneracion, string nombreUsuario)
        {
            producto.setPie(fechaHoraGeneracion, nombreUsuario);
        }

        public void construirProducto()
        {
            producto = new InformePDF();
        }

        public InformePDF obtenerProducto()
        {
            return producto;
        }
    }
}