using PPAIGenerarInformeBuilder.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAIGenerarInformeBuilder.Vista;
using PPAIGenerarInformeBuilder.Builder;


namespace PPAIGenerarInformeBuilder.Controlador
{
    public class GestorGenerarInformeCumplimientoGuardias
    {

        IConstructorInforme constructor;
        DirectorConstruccionInforme directorBuilder;

        String fechaGeneracionReporteDesde;
        String fechaGeneracionReporteHasta;
        IList<Bombero> bomberos = new List<Bombero>();
        IList<Bombero> bomberosActivos = new List<Bombero>();

        IList<Bombero> bomberActivos = new List<Bombero>();
        IList<Bombero> bomberosSeleccionados = new List<Bombero>();

        IList<Convocatoria> convocatorias = new List<Convocatoria>();

        IList<String> bombXCump = new List<String>();

        public void crear() 
        {
            Estado e1 = new Estado(1, "ambito", "La guardia se encuentra en curso", "En curso");

            Bombero b1 = new Bombero(36, "Lopez", "Sol", "belgrano 20", "email1@email.com", 123, DateTime.Parse("6/1/2016"), true);
            Bombero b2 = new Bombero(48, "Konicoff", "Sebastian", "san martin 20", "email3@email.com", 456, DateTime.Parse("8/4/2010"), true);
            Bombero b3 = new Bombero(90, "Andrea", "Susana", "rivadavia 100", "email3@email.com", 999999, DateTime.Parse("9/4/1990"), true);

            bomberos.Add(b1);
            bomberos.Add(b2);
            bomberos.Add(b3);

            bomberosSeleccionados.Add(b1);
            bomberosSeleccionados.Add(b2);
            bomberosSeleccionados.Add(b3);

            GuardiaBombero g1 = new GuardiaBombero(1, 1, 36, "", DateTime.Parse("6:34:53"), DateTime.Parse("9:34:53"));
            GuardiaBombero g2 = new GuardiaBombero(2, 2, 36, "", DateTime.Parse("6:34:53"), DateTime.Parse("9:34:53"));
            GuardiaBombero g3 = new GuardiaBombero(3, 1, 36, "", DateTime.Parse("19:34:53"), DateTime.Parse("21:34:53"));

            GuardiaBombero g4 = new GuardiaBombero(4, 1, 48, "", DateTime.Parse("19:34:53"), DateTime.Parse("21:34:53"));
            GuardiaBombero g5 = new GuardiaBombero(5, 1, 48, "", DateTime.Parse("19:34:53"), DateTime.Parse("21:34:53"));
            GuardiaBombero g6 = new GuardiaBombero(6, 1, 48, "", DateTime.Parse("19:34:53"), DateTime.Parse("21:34:53"));

            GuardiaBombero g7 = new GuardiaBombero(7, 0, 90, "", DateTime.Parse("19:34:53"), DateTime.Parse("21:34:53"));
            GuardiaBombero g8 = new GuardiaBombero(8, 0, 90, "", DateTime.Parse("19:34:53"), DateTime.Parse("21:34:53"));
            GuardiaBombero g9 = new GuardiaBombero(9, 1, 90, "", DateTime.Parse("19:34:53"), DateTime.Parse("21:34:53"));

            Asistencia a1 = new Asistencia(1, DateTime.Parse("6/1/2019 9:34:53"), DateTime.Parse("9:34:53"), 36, 1);

            Convocatoria c1 = new Convocatoria(1, 36, true, DateTime.Parse("6/1/2019 6:34:53"), DateTime.Parse("6/1/2019 6:35:57"));
            Convocatoria c2 = new Convocatoria(2, 36, false, DateTime.Parse("10/1/2019 6:34:53"), DateTime.Parse("10/1/2019 6:35:57"));

            convocatorias.Add(c1);
            convocatorias.Add(c2);
        }


        public void generarInformeCumplimientoGuardia()
        {
            PantallaGenerarInformeCumplimientoGuardias pantalla = new PantallaGenerarInformeCumplimientoGuardias();
            crear();
            pantalla.solicitarPeriodoParaInforme();
            
            pantalla.mostrarBomberosActivos(buscarBomberosActivos());

            calcularCumplimientoGuardiaBombero();
        }

        public void generarReportePDF()
        {
            directorBuilder = new DirectorConstruccionInforme(new ConstructorInformeCumplimientoGuardiasPDF());
            directorBuilder.construir(new string[3, 3], fechaGeneracionReporteDesde, fechaGeneracionReporteHasta, "usuarioBombero");
        }

        public void tomarFechasParaInforme(String fechaReporteDesde, String fechaReporteHasta) 
        {
            fechaGeneracionReporteDesde = fechaReporteDesde;
            fechaGeneracionReporteHasta = fechaReporteHasta;
        }

        public IList<Bombero> buscarBomberosActivos() 
        {
            IList<Bombero> bomberosActivos = new List<Bombero>();
            for (int i = 0; i < bomberos.Count; i++) 
            {
                if (bomberosActivos[i].esActivo()) 
                {
                    bomberosActivos.Add(bomberosActivos[i]);
                }
            }
            return bomberosActivos;
        }

        public void calcularCumplimientoGuardiaBombero() 
        {
            
            for (int i = 0; i < bomberosSeleccionados.Count; i++)             
            {
                int contadorConvocatoria = 0;
                for (int o = 0; o < convocatorias.Count; o++) 
                {
                    if (convocatorias[o].esDeBombero(bomberosSeleccionados[i])) 
                    {
                        if (convocatorias[o].esConfirmada()) 
                        {
                            contadorConvocatoria++;
                        }
                    }                        
                    
                }

                bombXCump.Add(bomberosSeleccionados[i].nombre);
                bombXCump.Add(contadorConvocatoria.ToString());

            }         

        }

        public void calcularAsistenciasEfectivasConvocatoria() 
        { 
        }

    }

}
