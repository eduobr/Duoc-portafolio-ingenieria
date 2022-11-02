using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using DALC_01.modelo;
using DALC_01.controller;
using System.Text.RegularExpressions;

namespace NoMasAcc2._0.clientes
{
    public partial class MantenedorCliente : MetroUserControl
    {
        RubroController controlRubro = new RubroController();
        ClienteController controlCliente = new ClienteController();
        UsuarioController controlUsuario = new UsuarioController();
        ErrorProvider error = new ErrorProvider();
        public MantenedorCliente()
        {
            InitializeComponent();
            cboComunaCli.DataSource = Enum.GetValues(typeof(Comunas));

            var listRubro = controlRubro.listarRubro();
            foreach (var r in listRubro)
            {
                cboRubro.Items.Add(r.descRubro);
            }

            cboRubro.SelectedIndex = 0;
        }

        private void btnListCli_Click(object sender, EventArgs e)
        {
            tcCliente.SelectedTab = tpListCli;

            ClienteController proC = new ClienteController();

            var list = proC.listarCliente();
            List<Cliente> listaCli = new List<Cliente>();

            foreach (var cl in list)
            {
                Cliente cli = new Cliente();
                //ListViewItem item = new ListViewItem(pro.idProfesional.ToString());
                cli.idCliente = cl.idCliente;
                cli.rutCliente= cl.rutCliente;
                cli.nombre = cl.nombre;
                cli.direccion = cl.direccion;
                cli.empresa = cl.empresa;

                //prof.fechaNacimientoPro = pro.fechaNacimientoPro.ToString("dd/MM/yyyy");
                //cli.fechaNacimiento = cl.fechaNacimientoPro;
                listaCli.Add(cli);
            }

            grdCliente.DataSource = listaCli;

            grdCliente.Columns["idCliente"].Visible = false;
            grdCliente.Columns["rutCliente"].HeaderText = "Rut Cliente";
            grdCliente.Columns["rutCliente"].Width = 80;
            grdCliente.Columns["nombre"].Width = 250;

        }

        private void btnAddCli_Click(object sender, EventArgs e)
        {
            tcCliente.SelectedTab = tpAddCli;
        }

        private void btnGuardarCli_Click(object sender, EventArgs e)
        {
            try
            {
                string rut, nombre, apellidoP, apellidoM, direccion, email, telefono, usuario, pass,empresa;
                int comuna, rubro, idUsuario;
                rut = txtRut.Text;
                nombre = txtNombre.Text;
                apellidoP = txtApellidoP.Text;
                apellidoM = txtApellidoM.Text;
                direccion = txtDireccion.Text;
                email = txtEmail.Text;
                telefono = txtTelefono.Text;
                comuna = cboComunaCli.SelectedIndex + 1;
                rubro = cboRubro.SelectedIndex + 1;
                empresa = txtEmpresa.Text;
                usuario = txtUsuario.Text;
                pass = txtPass.Text;

                Regex rgRut = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgLetras = new Regex(@"^[a-zA-Z\u00f1\u00d1]{3,15}$");
                Regex rgTel = new Regex(@"^(\+?56)?(\s?)(0?9)(\s?)[9876543]\d{7}$");
                Regex rgUsu = new Regex(@"^(?=.{4,20}$)[a-z0-9]{0,1}([a-z0-9._-][a-z0-9]+)*[a-z0-9.-_]{0,1}$");
                Regex rgPass = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");
                Regex rgCorreo = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$");
                if (!rgRut.IsMatch(rut))
                {
                    txtRut.WithError = true;
                    error.SetError(txtRut, "El formato del rut es incorrecto");
                    return;
                }
                else
                {
                    txtRut.WithError = false;
                    error.SetError(txtRut, "");

                }

                if (!validarRut(rut))
                {
                    txtRut.WithError = true;
                    error.SetError(txtRut, "El rut ingresado no es valido");
                    return;
                }
                else
                {
                    txtRut.WithError = false;
                    error.SetError(txtRut, "");

                }

                if (!rgLetras.IsMatch(nombre))
                {
                    txtNombre.WithError = true;
                    error.SetError(txtNombre, "El nombre debe contener solo letras");
                    return;
                }
                else
                {
                    txtNombre.WithError = false;
                    error.SetError(txtNombre, "");
                }

                if (!rgLetras.IsMatch(apellidoP))
                {
                    txtApellidoP.WithError = true;
                    error.SetError(txtApellidoP, "El apellido paterno debe contener solo letras");
                    return;
                }
                else
                {
                    txtApellidoP.WithError = false;
                    error.SetError(txtApellidoP, "");
                }

                if (!rgLetras.IsMatch(apellidoM))
                {
                    txtApellidoM.WithError = true;
                    error.SetError(txtApellidoM, "El apellido materno debe contener solo letras");
                    return;
                }
                else
                {
                    txtApellidoM.WithError = false;
                    error.SetError(txtApellidoM, "");
                }
                if (!rgTel.IsMatch(telefono))
                {
                    txtTelefono.WithError = true;
                    error.SetError(txtTelefono, "El telefono debe comenzar con +569");
                    return;
                }
                else
                {
                    txtTelefono.WithError = false;
                    error.SetError(txtTelefono, "");
                }

                if (!rgLetras.IsMatch(empresa))
                {
                    txtEmpresa.WithError = true;
                    error.SetError(txtEmpresa, "Debe tener entre 3 y 15 caracteres");
                    return;
                }else
                {
                    txtEmpresa.WithError = false;
                    error.SetError(txtEmpresa, "");
                }
                if (!rgUsu.IsMatch(usuario))
                {
                    txtUsuario.WithError = true;
                    error.SetError(txtUsuario, "El usuario debe tener al menos 4 caracteres");
                    return;
                }
                else
                {
                    txtUsuario.WithError = false;
                    error.SetError(txtUsuario, "");
                }

                if (!rgPass.IsMatch(pass))
                {
                    txtPass.WithError = true;
                    error.SetError(txtPass, "Mínimo 6 caracteres al menos 1 alfabeto y 1 número");
                    return;
                }
                else
                {
                    txtPass.WithError = false;
                    error.SetError(txtPass, "");
                }
                if (!rgCorreo.IsMatch(email))
                {
                    txtEmail.WithError = true;
                    error.SetError(txtEmail, "El correo ingresado no es valido");
                    return;
                }else
                {
                    txtPass.WithError = false;
                    error.SetError(txtEmail, "");
                }
                if (txtDireccion.Text=="")
                {
                    txtDireccion.WithError = true;
                    error.SetError(txtDireccion, "La direccion no puede estar vacia");
                    return;
                }else
                {
                    txtDireccion.WithError = false;
                    error.SetError(txtDireccion, "");
                }
                
                idUsuario = controlUsuario.insertarUsuario(usuario, pass, 2);

                int resul = controlCliente.Insert_Cliente(rut, nombre, apellidoP, apellidoM, direccion, email, telefono, comuna, rubro, idUsuario,empresa);

                if (resul > 0)
                {
                    MessageBox.Show("Guardo Correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error a Guardar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error a Guardar" + ex.Message);
            }
        }

        private void limpiar()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cboComunaCli.SelectedIndex = 0;
            cboRubro.SelectedIndex = 0;
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtEmpresa.Text = "";
        }
        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }
    }
}
