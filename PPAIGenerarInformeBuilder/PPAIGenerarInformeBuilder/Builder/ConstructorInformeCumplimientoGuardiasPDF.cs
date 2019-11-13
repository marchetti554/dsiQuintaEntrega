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

        /**
         * Constructor por defecto.
         **/
        public ConstructorInformeCumplimientoGuardiasPDF()
        {

        }

        public void construirCuerpo(Chart chart)
        {
            throw new NotImplementedException();
        }

        public void construirEncabezado(DateTime fechaDesde, DateTime fechaHasta, string titulo)
        {
            
        }

        public void construirPie(DateTime fechaHoraGeneracion, string nombreUsuario)
        {
            throw new NotImplementedException();
        }

        public Object construirProducto()
        {
            return new Object();
        }

        //TODO: Definir tipo del producto
        public Object obtenerProducto()
        {
            throw new NotImplementedException();
        }
    }
}