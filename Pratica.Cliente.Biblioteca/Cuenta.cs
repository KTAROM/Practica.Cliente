using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Cliente.Entidades
{
    public class Cuenta
    {
        private int _Id;
        private int _NroCuenta;
        private string _Descripcion;
        private double _Saldo;
        private DateTime _FechaApertura;
        private DateTime _FechaModificacion;
        private bool _Activo;
        private int _IdCliente;

        public Cuenta()
        {

        }
        public Cuenta(int Id, int NroCuenta, string Descripcion, double Saldo, DateTime FechaApertura, bool Activo, int idCliente)
        {
            this._Id = Id;
            this._NroCuenta = NroCuenta;
            this._Descripcion = Descripcion;
            this._Saldo = Saldo;
            this._FechaApertura = FechaApertura;
            this._Activo = Activo;
            this._IdCliente = IdCliente;

        }

        public int IdCliente
        {
            get { return this._IdCliente; }
        }
        public string Descripcion
        {
            get { return this._Descripcion; }
        }
        public double Saldo
        { get { return this._Saldo; } }

        public DateTime FechaApertura
        {
            get { return this._FechaApertura; }
        }

        public int NroCuenta
        { get { return this._NroCuenta; } }
    }
}
