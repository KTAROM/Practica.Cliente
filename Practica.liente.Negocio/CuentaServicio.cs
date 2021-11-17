using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.Cliente.AccesoDatos;
using Practica.Cliente.Entidades;
using Practica.Cliente.Entidades;

namespace Practica.Cliente.Negocio
{
    public class CuentaServicio
    {
        private Mapeador _Mapeador;
        public CuentaServicio()
        {
            _Mapeador = new Mapeador();
        }

        public List<Cuenta> GetListaCuentas()
        {
            return _Mapeador.TraerCuentas();
        }

     
    }
}
