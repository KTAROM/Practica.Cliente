using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.Cliente.Formulario
{
    public partial class FrmMaster : Form
    {
        private FrmListarClientes _frmListaClientes;
        public FrmPersona _frmPersona;
        public FrmMaster()
        {
            this._frmListaClientes = new FrmListarClientes(this);
            this._frmPersona = new FrmPersona(this);

            InitializeComponent();
        }

       
        private void btnListaCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._frmListaClientes.Show();
        }
        private void btnDatosPersonales_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._frmPersona.Show();
        }
    }
}
