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
using DALC_01.controller;
using DALC_01.modelo;
using System.Text.RegularExpressions;

namespace NoMasAcc2._0.profesional
{
    public partial class MantenedorProfesional : MetroUserControl
    {
        ProfesionalController proC = new ProfesionalController();
        UsuarioController us = new UsuarioController();
        ErrorProvider error = new ErrorProvider();
        public MantenedorProfesional()
        {
            InitializeComponent();
            tcProfesional.SelectedTab = tpAddProf;
            cboComunaProf.DataSource = Enum.GetValues(typeof(Comunas));
        }

        private void btnAddProf_Click(object sender, EventArgs e)
        {
            tcProfesional.SelectedTab = tpAddProf;
        }

        private void btnListProf_Click(object sender, EventArgs e)
        {
            tcProfesional.SelectedTab = tpListProf;

            var list = proC.listarProfecional();
            List<Profesional> listaProf = new List<Profesional>();

            foreach (var pro in list)
            {
                Profesional prof = new Profesional();
                //ListViewItem item = new ListViewItem(pro.idProfesional.ToString());
                prof.idProfesional = pro.idProfesional;
                prof.rutProfesional = pro.rutProfesional;
                prof.nombre = pro.nombre;
                prof.telefono = pro.telefono;
                //prof.fechaNacimientoPro = pro.fechaNacimientoPro.ToString("dd/MM/yyyy");
                listaProf.Add(prof);
            }

            grdProfesional.DataSource = listaProf;
            grdProfesional.Columns["idProfesional"].Visible = false;
            grdProfesional.Columns["rutProfesional"].HeaderText = "Rut Profesional";
            grdProfesional.Columns["rutProfesional"].Width = 80;
            grdProfesional.Columns["nombre"].Width = 320;
        }

        private void btnBuscarProf_Click(object sender, EventArgs e)
        {
            var list = proC.buscarProfesional(txtParamProf.Text.ToLower());
            List<Profesional> listaProf = new List<Profesional>();

            foreach (var pro in list)
            {
                Profesional prof = new Profesional();
                //ListViewItem item = new ListViewItem(pro.idProfesional.ToString());
                prof.idProfesional = pro.idProfesional;
                prof.rutProfesional = pro.rutProfesional;
                prof.nombre = pro.nombre;
                prof.telefono = pro.telefono;
                //prof.fechaNacimientoPro = pro.fechaNacimientoPro.ToString("dd/MM/yyyy");
                listaProf.Add(prof);
            }

            grdProfesional.DataSource = listaProf;
            grdProfesional.Columns["idProfesional"].Visible = false;
            grdProfesional.Columns["rutProfesional"].HeaderText = "Rut Profesional";
            grdProfesional.Columns["rutProfesional"].Width = 80;
            grdProfesional.Columns["nombre"].Width = 320;
        }

        private void btnGuardarProf_Click(object sender, EventArgs e)
        {
            try
            {
                string rut, nombre, apellidop, apellidom, telefono, usuario, pass;
                DateTime fecha;
                int comuna, idUsuario;

                rut = txtRut.Text;
                nombre = txtNombre.Text;
                apellidom = txtApellidoM.Text;
                apellidop = txtApellidoP.Text;
                telefono = txtFono.Text;
                fecha = dtpFecha.Value;
                comuna = cboComunaProf.SelectedIndex + 1;
                usuario = txtUsuario.Text;
                pass = txtPass.Text;
                
                Regex rgRut = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgLetras = new Regex(@"^[a-zA-Z]{3,10}$");
                Regex rgTel = new Regex(@"^(\+?56)?(\s?)(0?9)(\s?)[9876543]\d{7}$");
                Regex rgUsu = new Regex(@"^(?=.{4,20}$)[a-z0-9]{0,1}([a-z0-9._-][a-z0-9]+)*[a-z0-9.-_]{0,1}$");
                Regex rgPass = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");
                if (!rgRut.IsMatch(rut))
                {
                    txtRut.WithError = true;
                    error.SetError(txtRut,"El rut ingresado no es valido");
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
                }else
                {
                    txtNombre.WithError = false;
                    error.SetError(txtNombre, "");
                }

                if (!rgLetras.IsMatch(apellidop))
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

                if (!rgLetras.IsMatch(apellidom))
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
                    txtFono.WithError = true;
                    error.SetError(txtFono, "El telefono debe comenzar con +569");
                    return;
                }else
                {
                    txtFono.WithError = false;
                    error.SetError(txtFono, "");
                }
                if (!rgUsu.IsMatch(usuario))
                {
                    txtUsuario.WithError = true;
                    error.SetError(txtUsuario, "El usuario debe tener al menos 4 caracteres");
                    return;
                }else
                {
                    txtUsuario.WithError = false;
                    error.SetError(txtUsuario, "");
                }

                if (!rgPass.IsMatch(pass))
                {
                    txtPass.WithError = true;
                    error.SetError(txtPass, "Mínimo 6 caracteres al menos 1 alfabeto y 1 número");
                    return;
                }else
                {
                    txtPass.WithError = false;
                    error.SetError(txtPass, "");
                }

                //MessageBox.Show(idUsuario.ToString());
                idUsuario = us.insertarUsuario(usuario, pass, 3);
                /*int resul = proC.Insert_Profecional(rut, nombre, apellidop, apellidom, telefono, fecha, comuna, idUsuario);
                if (resul > 0)
                {
                    MessageBox.Show("Guardo Correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error a Guardar");
                }*/


                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Agregar " + ex);
            }
        }

        private void limpiar()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellidoM.Text = "";
            txtApellidoP.Text = "";
            txtFono.Text = "";
            // dtpFecha.Value = ;
            cboComunaProf.SelectedIndex = 0;
            txtUsuario.Text = "";
            txtPass.Text = "";
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
