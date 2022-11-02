using DALC_01.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMasAccidentes.Profecional
{
    public partial class ModificarProfecional : Form
    {

        ProfesionalController PC = new ProfesionalController();
        ComunaController comuna = new ComunaController();
        
        public ModificarProfecional()
        {
            InitializeComponent();
            var comunas = comuna.listarComuna();
            foreach (var i in comunas)
            {
                cboComuna.Items.Add( i.descComuna.ToString());
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            var pro = PC.Buscar_Profecional(txtRut.Text);
            foreach (var p in pro)
            {
                txtId.Text = p.idProfesional.ToString();
                txtRut.Text = p.rutProfesional.ToString();
                txtNombre.Text = p.nombre.ToString();
                txtapellidoM.Text = p.apeMaterno.ToString();
                txtApellidoP.Text = p.apePaterno.ToString();
                txtFono.Text = p.telefono.ToString();
                dtpFecha.Value = p.fechaNacimientoPro;
                cboComuna.SelectedIndex = p.idComuna - 1;


            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                string rut, nombre, apellidop, apellidom, telefono ;
                DateTime fecha;

                int comuna,usuario,id;

                rut = txtRut.Text;
                nombre = txtNombre.Text;
                apellidom = txtapellidoM.Text;
                apellidop = txtApellidoP.Text;
                telefono = txtFono.Text;
                fecha = dtpFecha.Value;
                comuna = cboComuna.SelectedIndex + 1;
                usuario =int.Parse(txtUsuario.Text);
                id =int.Parse(txtId.Text);


                int resul = PC.Update_Profecional(id, rut, nombre, apellidop, apellidom, telefono, fecha, comuna, usuario);
                if (resul > 0)
                {
                    MessageBox.Show("Modifico " + resul);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error a Modificar");
                }

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
            txtapellidoM.Text = "";
            txtApellidoP.Text = "";
            txtFono.Text = "";
            // dtpFecha.Value = ;
            cboComuna.SelectedIndex = 0;
            txtUsuario.Text = "";
            txtId.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
