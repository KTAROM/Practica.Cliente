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

namespace Practica.Cliente.Formulario
{
    public partial class FrmAltaCliente : Form
    {
        public FrmPersona _frmPersona;
        public FrmAltaCliente(Form propietario, Form Principal)
        {
            this._frmPersona = new FrmPersona(Principal);
            this.Owner = propietario;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Hide();
            this.Owner.Owner.Show();
        }
        private void Limpiar()
        {
            this.txtId.Text = string.Empty;
            this.txtCuit.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtFechaNacimiento.Text = string.Empty;
            this.cmbPersona.DataSource = null;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._frmPersona.Show();

        }
        private void cmbPersona_Click(object sender, EventArgs e)
        {
            cmbPersona.DataSource = null;
            cmbPersona.DataSource = this._frmPersona._lstPersonas;
            cmbPersona.DisplayMember = "MostrarPersona";
            cmbPersona.ValueMember = "Apellido";
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.cmbPersona.SelectedItem != null)
                {
                    if (!int.TryParse(txtId.Text, out int a) ||txtId.Text==string.Empty)
                    {
                        MessageBox.Show("Los valores ingresados son incorrectos");
                        Limpiar();
                        
                    }
                    else
                    {
                        if (!int.TryParse(txtCuit.Text, out a)|| txtCuit.Text == string.Empty)
                        {
                            MessageBox.Show("Los valores ingresados son incorrectos");
                            Limpiar();
                        }
                        else
                        {
                            Persona P1 = (Persona)this.cmbPersona.SelectedItem;
                            ((FrmPersona)this._frmPersona).DeletePersona(P1);

                            Cliente1 C1 = new Cliente1(P1.Nombre, P1.Apellido, P1.Direccion, Convert.ToInt32(this.txtId.Text), Convert.ToInt64(this.txtCuit.Text));


                            if (this.txtEmail.Text != string.Empty)
                            {
                                C1.Email = this.txtEmail.Text;
                            }

                            if (this.txtFechaNacimiento.Text != string.Empty)
                            {
                                C1.FechaNacimiento = Convert.ToDateTime(this.txtFechaNacimiento.Text);
                                MessageBox.Show("Se ingreso la fecha de nacimiento");
                            }
                            MessageBox.Show("Se registro el CUIT: " + C1.Cuit);
                            ((FrmListarClientes)this.Owner).AgregarCliente(C1);
                            Limpiar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar los datos personales");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
              
   


    

