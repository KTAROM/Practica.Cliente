using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica.Cliente.Entidades; 
using Practica.Cliente.Negocio;

namespace Practica.Cliente.Formulario
{
    public partial class FrmListarClientes : Form
    {
        
        public FrmAltaCliente _frmAltaCliente;
        private ClienteServicio _ClienteServicio;
        
        public FrmListarClientes(Form propietario)
        {
            this._frmAltaCliente = new FrmAltaCliente(this, propietario);
            this._ClienteServicio = new ClienteServicio();
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
            lstClientes.DataSource = this._ClienteServicio.GetListaClientes();
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
            _ClienteServicio.AddCliente(C1);
            InicializarLista();
            
        }
    }
}
