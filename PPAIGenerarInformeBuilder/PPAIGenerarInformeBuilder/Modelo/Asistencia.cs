using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIGenerarInformeBuilder.Modelo
{
    class Asistencia
    {
        private Int64 _idAsistencia;
        private DateTime _fechaHoraLlegada; 
        private DateTime _fechaHoraSalida; 
        private Int64 _dniBombero; 
        private Int64 _idGuardiaBombero;

        public Int64 idAsistencia
        {
            get { return this._idAsistencia; }
            set { this._idAsistencia = value; }
        }

        public DateTime fechaHoraLlegada
        {
            get { return this._fechaHoraLlegada; }
            set { this._fechaHoraLlegada = value; }
        }

        public DateTime fechaHoraSalida
        {
            get { return this._fechaHoraSalida; }
            set { this._fechaHoraSalida = value; }
        }

        public Int64 dniBombero
        {
            get { return this._dniBombero; }
            set { this._dniBombero = value; }
        }

        public Int64 idGuardiaBombero
        {
            get { return this._idGuardiaBombero; }
            set { this._idGuardiaBombero = value; }
        }

        public Asistencia(Int64 idAsistencia, DateTime fechaHoraLlegada, DateTime fechaHoraSalida, 
            Int64 dniBombero, Int64 idGuardiaBombero)
        {
            _idAsistencia = idAsistencia;
            _fechaHoraLlegada = fechaHoraLlegada;
            _fechaHoraSalida = fechaHoraSalida;
            _dniBombero = dniBombero;
            _idGuardiaBombero = idGuardiaBombero;
           
        }




    }


}

    
