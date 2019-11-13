using System;

namespace PPAIGenerarInformeBuilder.Builder
{
    public class DirectorConstruccionInforme
    {

        /**
         * Constructor abstracto.
         **/
        private IConstructorInforme IConstructorInforme;

        /**
         * Default Constructor
         **/
        public DirectorConstruccionInforme()
        {
        }

        /**
         * Constructor que recibe el Constructor específico
         **/
        public DirectorConstruccionInforme(IConstructorInforme constructorInforme)
        {

        }

        /**
         * Método encargado de iniciar la construcción del informe.
         * 
         * */
        public void construir(string[,] procentajeBomberos, string fechaDesde, string fechaHasta, string usuario)
        {

        }
    }
}