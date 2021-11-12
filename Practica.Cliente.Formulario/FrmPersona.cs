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
    public partial class FrmPersona : Form
    {
        public List<Persona> _lstPersonas;
        public FrmPersona(Form propietario)
        {
            this._lstPersonas = new List<Persona>();
            _lstPersonas.Add(new Persona("Tomas", "Lopez", "Cramer 3369"));
            _lstPersonas.Add(new Persona("Agustina", "Garcia", "Maipu 886"));
            this.Owner = propietario;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        private void Limpiar()
        {
            this.txtApellido.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CompruebaPersona())
                {
                    Persona P1 = new Persona(txtNombre.Text, txtApellido.Text, txtDireccion.Text);

                    if (txtTelefono != null)
                    {
                        P1.Telefono = txtTelefono.Text;
                    }
                    MessageBox.Show("Se registraron correctamente los datos de " + P1.Nombre + " " + P1.Apellido);
                    _lstPersonas.Add(P1);
                    Limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DeletePersona(Persona P1)
        {
            this._lstPersonas.Remove(P1);
        }

        public bool CompruebaPersona()
        {

            if (!Validaciones.PedirString(txtNombre.Text) || !Validaciones.PedirString(txtApellido.Text) || !Validaciones.PedirString(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
                Limpiar();
                return false;
            }
            return true;
        }
    }

}

   