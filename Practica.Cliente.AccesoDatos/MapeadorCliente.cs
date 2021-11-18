using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.Cliente.Entidades;

namespace Practica.Cliente.AccesoDatos
{
    public class MapeadorCliente
    {
        private List<Cliente1> _lstClientes;
       
        public MapeadorCliente()
        {
           
            this._lstClientes = new List<Cliente1>();
            _lstClientes.Add(new Cliente1("Luis", "Perez", "Malavia 222", 0, 20145563329));
            _lstClientes.Add(new Cliente1("María", "Suarez", "Estomba 1509", 1, 27326659864));
            _lstClientes.Add(new Cliente1("Paula", "Martinez", "Plaza 3369", 2, 27406323312));
            _lstClientes.Add(new Cliente1("Roberto", "Gonzalez", "Cabildo 5699", 3, 20226301549));
            _lstClientes.Add(new Cliente1("Carla", "Pereira", "Mitre 1603", 4, 27385214470));
        }

       

        public List<Cliente1> TraerClientes()
        {
            return _lstClientes;
        }

        public void AgregarCliente(Cliente1 c)
        {
            _lstClientes.Add(c);
        }

       

    }
}
