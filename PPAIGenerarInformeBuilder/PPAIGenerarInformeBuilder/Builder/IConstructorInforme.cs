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
        //Definir tipo del producto
        Object construirProducto();
        void construirEncabezado(DateTime fechaDesde, DateTime fechaHasta, string titulo);
        void construirCuerpo(Chart chart);
        void construirPie(DateTime fechaHoraGeneracion, string nombreUsuario);
        //TODO: cambiar Object por el tipo que realmente devuelve.
        Object obtenerProducto();
    }
}
