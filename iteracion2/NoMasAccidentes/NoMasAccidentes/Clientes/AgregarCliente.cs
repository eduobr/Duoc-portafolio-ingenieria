using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALC_01.controller;

namespace NoMasAccidentes.Clientes
{
    public partial class AgregarCliente : Form
    {

        ComunaController controlComuna = new ComunaController();
        RubroController controlRubro = new RubroController();
        ClienteController controlCliente = new ClienteController();
        UsuarioController controlUsuario = new UsuarioController();


        public AgregarCliente()
        {
            InitializeComponent();

            llenarCBO();
            cboComuna.SelectedIndex = 0;
            cboRubro.SelectedIndex = 0;

        }

        private void llenarCBO()
        {
            var list1 = controlComuna.listarComuna();
            foreach (var c in list1)
            {
                cboComuna.Items.Add(c.descComuna);
            }

            var list2 = controlRubro.listarCiudad();
            foreach (var r in list2)
            {
                cboRubro.Items.Add(r.descRubro);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                string rut, nombre, apellidoP, apellidoM, direccion, email, telefono,usuario,pass;
                int comuna, rubro, idUsuario;
                rut = txtRut.Text;
                nombre = txtNombre.Text;
                apellidoP = txtApellido.Text;
                apellidoM = txtApellidoM.Text;
                direccion = txtDireccion.Text;
                email = txtEmail.Text;
                telefono = txtTelefono.Text;
                comuna = cboComuna.SelectedIndex + 1;
                rubro = cboRubro.SelectedIndex + 1;
                usuario = txtUsuario.Text;
                pass = txtPass.Text;
                idUsuario= controlUsuario.insertarUsuario(usuario,pass,2);

                int resul = controlCliente.Insert_Cliente(rut, nombre, apellidoP, apellidoM, direccion, email, telefono, comuna, rubro, idUsuario);
                
                if (resul > 0) { 
                MessageBox.Show("Guardo Correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error a Guardar");
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Error a Guardar" + ex.Message);
            }

        }

        private void limpiar()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtApellidoM.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cboComuna.SelectedIndex=0;
            cboRubro.SelectedIndex=0;
            txtUsuario.Text="";
        }
    }
}
