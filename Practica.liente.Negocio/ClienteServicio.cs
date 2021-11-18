using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.Cliente.Entidades;
using Practica.Cliente.AccesoDatos;

namespace Practica.Cliente.Negocio
{
    public class ClienteServicio
    {
        private MapeadorCliente _Mapeador;
        private List<Cliente1> _lstClientes;
        private List<Cuenta> _lstCuentas;
        private MapeadorCuenta _MapeadorCuenta;


        public ClienteServicio()
        {
            this._Mapeador = new MapeadorCliente();
            this._lstClientes = new List<Cliente1>();
            this._lstCuentas = new List<Cuenta>();
            this._MapeadorCuenta = new MapeadorCuenta();
        }

        public List<Cliente1> GetListaClientes()
        {
            this._lstClientes = _Mapeador.TraerClientes();
            return _lstClientes;
        }

        public void AddCliente(Cliente1 c)
        {
            _Mapeador.AgregarCliente(c);

        }
        public List<Cliente1> AsignarCuenta()
        {
            GetListaClientes();
            _lstCuentas = _MapeadorCuenta.TraerCuentas();

            foreach (Cliente1 c in _lstClientes)
            {
                foreach (Cuenta cta in _lstCuentas)
                {
                    if (c.Id == cta.IdCliente)
                    {
                        c.Cuenta = cta;
                        
                    }
                }
            }
            return _lstClientes;
        }

        public Cliente1 ClientePorId(int idCliente)
        {
            Cliente1 ClienteSeleccionado = null;
            foreach(Cliente1 c in _lstClientes)
            {
                if(c.Id== idCliente)
                {
                    ClienteSeleccionado = c;
                }
            }
            return ClienteSeleccionado;
        }
    }
}
