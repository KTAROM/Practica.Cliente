using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.Cliente.Entidades;

namespace Practica.Cliente.AccesoDatos
{
    public class MapeadorCuenta
    {

        private List<Cuenta> _lstCuentas;

        public MapeadorCuenta()
        {
            this._lstCuentas = new List<Cuenta>();

            _lstCuentas.Add(new Cuenta(0, 101200, "Cuenta Corriente", 300, DateTime.Today, true, 0));
            _lstCuentas.Add(new Cuenta(1, 101201, "Cuenta Corriente", 1200, DateTime.Today, true, 3));

        }





        public void AgregarCuenta(Cuenta c)
        {
            _lstCuentas.Add(c);
        }

        public List<Cuenta> TraerCuentas()
        {
            return this._lstCuentas;
        }

    }
}
