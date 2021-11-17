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
        private Mapeador _Mapeador;

        public ClienteServicio()
        {
            this._Mapeador = new Mapeador();
        }

        public List<Cliente1> GetListaClientes()
        {
            return _Mapeador.TraerClientes();
        }

        public void AddCliente(Cliente1 c)
        {
            _Mapeador.AgregarCliente(c);

        }

    }
}
