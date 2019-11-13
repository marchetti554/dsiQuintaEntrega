using PPAIGenerarInformeBuilder.Modelo;
using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace PPAIGenerarInformeBuilder.Builder
{
    /**
     * Interfaz en cargo de específicar cuales son las operaciones
     * que el constructor abstracto puede realizar.
     * 
     **/
    public interface IConstructorInforme
    {
        void construirProducto();
        void construirEncabezado(DateTime fechaDesde, DateTime fechaHasta, string titulo);
        void construirCuerpo(Chart chart);
        void construirPie(DateTime fechaHoraGeneracion, string nombreUsuario);
        InformePDF obtenerProducto();
    }
}
