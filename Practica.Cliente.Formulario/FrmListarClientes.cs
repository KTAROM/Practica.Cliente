using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica.Cliente.Biblioteca;

namespace Practica.Cliente.Formulario
{
    public partial class FrmListarClientes : Form
    {
        private List<Cliente1> _lstClientes;
        public FrmAltaCliente _frmAltaCliente;
        
        public FrmListarClientes(Form propietario)
        {
            this._frmAltaCliente = new FrmAltaCliente(this, propietario);
            this._lstClientes = new List<Cliente1>();
            _lstClientes.Add(new Cliente1("Luis", "Perez", "Malavia 222", 0, 20145563329));
            _lstClientes.Add(new Cliente1("María", "Suarez", "Estomba 1509", 1, 27326659864));
            _lstClientes.Add(new Cliente1("Paula", "Martinez", "Plaza 3369", 2, 27406323312));
            _lstClientes.Add(new Cliente1("Roberto", "Gonzalez", "Cabildo 5699", 3, 20226301549));
            _lstClientes.Add(new Cliente1("Carla", "Pereira", "Mitre 1603", 4, 27385214470));
            this.Owner = propietario;
            
            
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            
        }

        private void InicializarLista()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = this._lstClientes;
            lstClientes.DisplayMember = "MostrarPersona";
            lstClientes.ValueMember = "Apellido";

        }
        private void FrmListarClientes_Load(object sender, EventArgs e)
        {
            InicializarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._frmAltaCliente.Show();
            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            
            Cliente1 ClienteSeleccionado = (Cliente1)lstClientes.SelectedItem;
            MessageBox.Show(ClienteSeleccionado.MostrarCliente);

        }

        public void AgregarCliente(Cliente1 C1)
        {
            this._lstClientes.Add(C1);
            InicializarLista();
            
        }
    }
}
