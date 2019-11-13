using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIGenerarInformeBuilder.Modelo
{
    public class Bombero
    {
        private Int64 _dni;
        private string _apellido;
        private string _nombre;
        private string _direccion;
        private string _email;
        private Int64 _telefono;
        private DateTime _fechaNacimiento;
        private Boolean _activo;

        public Int64 dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }
        public string apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }
        public string email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        public Int64 telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        public DateTime fechaNacimiento
        {
            get { return this._fechaNacimiento; }
            set { this._fechaNacimiento = value; }
        }
        public Boolean activo
        {
            get { return this._activo; }
            set { this._activo = value; }
        }

        public Bombero(Int64 dni, string apellido, string nombre, string direccion, string email, Int64 telefono, DateTime fechaNacimiento, Boolean activo)
        {
            _dni = dni;
            _apellido = apellido;
            _nombre = nombre;
            _direccion = direccion;
            _email = email;
            _telefono = telefono;
            _fechaNacimiento = fechaNacimiento;
            _activo = activo;

        }

        public Boolean esActivo() 
        {
            if (this.activo ) { return true; }
            return false;
        
        }


        public void compararFechaConvocatoriaConAsistencia() 
        {
           
        }
    }
}
