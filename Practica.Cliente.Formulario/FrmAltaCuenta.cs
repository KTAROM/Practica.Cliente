using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica.Cliente.Negocio;

namespace Practica.Cliente.Formulario
{
    public partial class FrmAltaCuenta : Form
    {
        private ClienteServicio _ClienteServicio;
        
        public FrmAltaCuenta(Form propietario)
        {
            this._ClienteServicio = new ClienteServicio();
            this.Owner=propietario;
            InitializeComponent();
        }

        private void cmbCliente_Click(object sender, EventArgs e)
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = _ClienteServicio.GetListaClientes();            
            cmbCliente.DisplayMember = "MostrarPersona";
            cmbCliente.ValueMember = "Id";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtDescripcion.Text = string.Empty;
            txtNroCuenta.Text = string.Empty;
            txtSaldo.Text = string.Empty;
            txtFechaApertura.Text = string.Empty;
            cmbCliente.DataSource = null;
        }

        private void btnVolver_Click(object sender, EventArgs e )
        {
            this.Hide();
            this.Owner.Show();
        }

        private void IniciarCliente()
        {

        }
    }
}
