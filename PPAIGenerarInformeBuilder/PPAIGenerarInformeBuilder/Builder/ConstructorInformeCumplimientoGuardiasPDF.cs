using System;

namespace PPAIGenerarInformeBuilder.Builder
{
    /**
     * Constructor específico para Construir PDFs, implementa IConstructorInforme
     * por lo que debe implementar cada uno de sus métodos.
     **/
    public class ConstructorInformeCumplimientoGuardiasPDF : IConstructorInforme
    {
        public ConstructorInformeCumplimientoGuardiasPDF()
        {

        }

        public void construirCuerpo()
        {
            throw new NotImplementedException();
        }

        public void construirEncabezado()
        {
            throw new NotImplementedException();
        }

        public void construirPie()
        {
            throw new NotImplementedException();
        }

        public void construirProducto()
        {
            throw new NotImplementedException();
        }

        public object obtenerProducto()
        {
            throw new NotImplementedException();
        }
    }
}