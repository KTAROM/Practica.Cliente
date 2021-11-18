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
using Practica.Cliente.Entidades;

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

        private void FrmAltaCuenta_load(object sender, EventArgs e)
        {
            CargarClientes();
        }
        private void cmbCliente_Click(object sender, EventArgs e)
        {
            CargarClientes();

        }
        private void CargarClientes()
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = _ClienteServicio.AsignarCuenta();
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
            
            
        }

        private void btnVolver_Click(object sender, EventArgs e )
        {
            this.Hide();
            this.Owner.Show();
        }

        private void cmbCliente_Selct(object sender, EventArgs e)
        {
           
            SeleccionarCliente();
           
        }

        private void SeleccionarCliente()
        {
            if (cmbCliente.SelectedItem != null)
            {
                int idCliente = ((Cliente1)cmbCliente.SelectedItem).Id;
                Cliente1 ClienteSeleccionado = _ClienteServicio.ClientePorId(idCliente);
                if (ClienteSeleccionado.Cuenta != null)
                {
                    Cuenta CuentaCliente = ClienteSeleccionado.Cuenta;
                    txtDescripcion.Text = CuentaCliente.Descripcion;
                    txtFechaApertura.Text = CuentaCliente.FechaApertura.ToString("dd-mm-yyyy");
                    txtNroCuenta.Text = CuentaCliente.NroCuenta.ToString("0,00");

                }
                else
                {
                    Limpiar();
                }
            }

           

        }

    }
}
