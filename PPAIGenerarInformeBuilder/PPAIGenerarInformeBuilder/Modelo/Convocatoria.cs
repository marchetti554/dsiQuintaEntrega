using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIGenerarInformeBuilder.Modelo
{
    class Convocatoria
    {
        private Int64 _idConvocatoria;
        private Int64 _dniBombero;
        private Boolean _estaConfirmada;
        private DateTime _fechaHora;
        private DateTime _fechaHoraRespuesta;

        public Int64 idConvocatoria
        {
            get { return this._idConvocatoria; }
            set { this._idConvocatoria = value; }
        }
        public Int64 dniBombero
        {
            get { return this._dniBombero; }
            set { this._dniBombero = value; }
        }

        public Boolean estaConfirmada
        {
            get { return this._estaConfirmada; }
            set { this._estaConfirmada = value; }
        }
        public DateTime fechaHora
        {
            get { return this._fechaHora; }
            set { this._fechaHora = value; }
        }
        public DateTime fechaHoraRespuesta
        {
            get { return this._fechaHoraRespuesta; }
            set { this._fechaHoraRespuesta = value; }
        }

        public Convocatoria(Int64 idConvocatoria, Int64 dniBombero, Boolean estaConfirmada, DateTime fechaHora, DateTime fechaHoraRespuesta)
        {
            _idConvocatoria = idConvocatoria;
            _dniBombero = dniBombero;
            _estaConfirmada = estaConfirmada;
            _fechaHora = fechaHora;
            _fechaHoraRespuesta = fechaHoraRespuesta;
            

        }

        public Boolean esDeBombero(Bombero bombero) 
        {
            if (bombero.dni == this.dniBombero) { return true; }; return false;
        }

        public Boolean perteneceAPeriodo(DateTime fechaDesde, DateTime fechaHasta) 
        {
            if(fechaDesde > fechaHora && fechaHora < fechaHasta){ return true; }
            return false;
        }

        public Boolean esConfirmada() 
        {
            if (this._estaConfirmada) { return true; }
            return false;
        }


    }
}
