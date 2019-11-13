using System;

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
        void construirEncabezado();
        void construirCuerpo();
        void construirPie();
        //TODO: cambiar Object por el tipo que realmente devuelve.
        Object obtenerProducto();
    }
}
