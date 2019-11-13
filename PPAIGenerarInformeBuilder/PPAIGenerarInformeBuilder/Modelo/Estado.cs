using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIGenerarInformeBuilder.Modelo
{
    class Estado
    {
        private Int64 _idEstado;
        private string _ambito;
        private string _descripcion;
        private string _nombre;
        public Int64 idEstado
        {
            get { return this._idEstado; }
            set { this._idEstado = value; }
        }
        public string ambito
        {
            get { return this._ambito; }
            set { this._ambito = value; }
        }
        public string descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }
        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public Estado(Int64 idEstado, string ambito, string descripcion, string nombre)
        {
            _idEstado = idEstado;
            _ambito = ambito;
            _descripcion = descripcion;
            _nombre = nombre;           

        }



    }

    


}
