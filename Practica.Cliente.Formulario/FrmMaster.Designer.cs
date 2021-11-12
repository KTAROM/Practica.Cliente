
namespace Practica.Cliente.Formulario
{
    partial class FrmMaster
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLstClientes = new System.Windows.Forms.Button();
            this.btnModificarClientes = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLstClientes
            // 
            this.btnLstClientes.Location = new System.Drawing.Point(33, 56);
            this.btnLstClientes.Name = "btnLstClientes";
            this.btnLstClientes.Size = new System.Drawing.Size(139, 23);
            this.btnLstClientes.TabIndex = 0;
            this.btnLstClientes.Text = "Lista Clientes";
            this.btnLstClientes.UseVisualStyleBackColor = true;
            this.btnLstClientes.Click += new System.EventHandler(this.btnListaCliente_Click);
            // 
            // btnModificarClientes
            // 
            this.btnModificarClientes.Location = new System.Drawing.Point(33, 140);
            this.btnModificarClientes.Name = "btnModificarClientes";
            this.btnModificarClientes.Size = new System.Drawing.Size(139, 23);
            this.btnModificarClientes.TabIndex = 4;
            this.btnModificarClientes.Text = "Modificar Clientes";
            this.btnModificarClientes.UseVisualStyleBackColor = true;
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(33, 222);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(139, 23);
            this.btnPersona.TabIndex = 5;
            this.btnPersona.Text = "Ingresar Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnDatosPersonales_Click);
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 286);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.btnModificarClientes);
            this.Controls.Add(this.btnLstClientes);
            this.Name = "FrmMaster";
            this.Text = "Bienvenido a la Aplicación!!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLstClientes;
        private System.Windows.Forms.Button btnModificarClientes;
        private System.Windows.Forms.Button btnPersona;
    }
}

