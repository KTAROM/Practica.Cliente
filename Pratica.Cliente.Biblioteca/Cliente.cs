using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Cliente.Entidades
{
    public class Cliente1:Persona
    {
        private int _Id;
        private long _Cuit;
        private string _Email;
        private DateTime _FechaNacimiento;
        private bool _Activo;

        public Cliente1(string Nombre, string Apellido, string Direccion, int Id, long Cuit): base(Nombre,Apellido,Direccion)
        {
            this._Id = Id;
            this._Cuit = Cuit;
        }
        public Cliente1(string Nombre, string Apellido, string Direccion) : base(Nombre, Apellido, Direccion)
        {
          
        }
        public Cliente1()
        {

        }
        public string MostrarCliente
        {
            get{ return ("Cliente "+this.Apellido+" "+this.Nombre+" \nCUIT: "+this.Cuit); }
        }

        public int Id
        {
            get { return this._Id; }
        }

        public long Cuit
        {
            get { return this._Cuit; }
        }

        public string Email
        {
            set { this._Email = value; }
        }
        public DateTime FechaNacimiento
        {
            set { this._FechaNacimiento = value; }
        }
       
    }
}
