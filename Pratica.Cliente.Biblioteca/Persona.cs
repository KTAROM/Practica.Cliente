using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Cliente.Biblioteca
{
    public  class Persona
    {
        private string _Nombre;
        private string _Apellido;
        private string _Direccion;
        private string _Telefono;

        public string Nombre
        { get { return this._Nombre; }
        }
        public string Apellido
        {
            get { return _Apellido; }
        }

        public string Direccion { get { return this._Direccion; } }

        public string Telefono
        {
            get { return this._Telefono; }
            set { this._Telefono = value; }
        }

        public Persona()
        {

        }

        public Persona(string Nombre, string Apellido, string Direccion)
        {
            this._Nombre = Nombre;
            this._Apellido = Apellido;
            this._Direccion = Direccion;
            
        }

        public string MostrarPersona
        { get { return Apellido+" "+Nombre; } }
        
    }
}
