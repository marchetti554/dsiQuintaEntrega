using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIGenerarInformeBuilder.Modelo
{
    class GuardiaBombero
    {
        private Int64 _idGuardiaBombero;
        private Int64 _idEstado;
        private Int64 _dniBombero;
        private string _motivoRechazo;
        private DateTime _horaDesde;
        private DateTime _horaHasta;

        public Int64 idGuardiaBombero
        {
            get { return this._idGuardiaBombero; }
            set { this._idGuardiaBombero = value; }
        }
        public Int64 idEstado
        {
            get { return this._idEstado; }
            set { this._idEstado = value; }
        }
        public Int64 dniBombero
        {
            get { return this._dniBombero; }
            set { this._dniBombero = value; }
        }
        public string motivoRechazo
        {
            get { return this._motivoRechazo; }
            set { this._motivoRechazo = value; }
        }
        public DateTime horaDesde
        {
            get { return this._horaDesde; }
            set { this._horaDesde = value; }
        }
        public DateTime horaHasta
        {
            get { return this._horaHasta; }
            set { this._horaHasta = value; }
        }

        public GuardiaBombero(Int64 idGuardiaBombero, Int64 idEstado, Int64 dniBombero, string motivoRechazo, 
            DateTime horaDesde, DateTime horaHasta)
        {
            _idGuardiaBombero = idGuardiaBombero;
            _idEstado = idEstado;
            _dniBombero = dniBombero;
            _motivoRechazo = motivoRechazo;
            _horaDesde = horaDesde;
            _horaHasta = horaHasta;            

        }


    }
}
