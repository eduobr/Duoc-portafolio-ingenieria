using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using DALC_01.modelo;
using DALC_01.controller;

namespace NoMasAccidentes.Profecional
{
    public partial class AgregarProfecional : Form
    {

        dbController emControl = new dbController();
        ProfesionalController PC = new ProfesionalController();
        UsuarioController us = new UsuarioController();
        ComunaController controlComuna = new ComunaController();

        public AgregarProfecional()
        {
            InitializeComponent();
            cargarCbo();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        //private Entitidades contex = new Entitidades();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rut, nombre, apellidop, apellidom, telefono, usuario,pass;
                DateTime fecha;
                int comuna,idUsuario;

                rut = txtRut.Text;
                nombre = txtNombre.Text;
                apellidom = txtapellidoM.Text;
                apellidop = txtApellidoP.Text;
                telefono = txtFono.Text;
                fecha = dtpFecha.Value;
                comuna = cboComuna.SelectedIndex + 1;
                usuario = txtUsuario.Text;
                pass = txtPass.Text;
                idUsuario = us.insertarUsuario(usuario, pass,3);
                int resul = PC.Insert_Profecional(rut, nombre, apellidop, apellidom, telefono, fecha, comuna, idUsuario);
                if (resul > 0)
                {
                    MessageBox.Show("Guardo Correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error a Guardar");
                }


                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Agregar " + ex);
            }


        }

        private void limpiar()
        {
            txtRut.Text="";
            txtNombre.Text = "";
            txtapellidoM.Text = "";
            txtApellidoP.Text = "";
            txtFono.Text = "";
           // dtpFecha.Value = ;
            cboComuna.SelectedIndex = 0;
            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        public void cargarCbo()
        {
            //OracleCommand sqlc = new OracleCommand("select * from Usuario;");
            //OracleDataReader dr;
            //dr = sqlc.ExecuteReader();
            //while (dr.Read())
            //{
            //    cboUser.Items.Add(dr[1]);
            //}

            var list1 = controlComuna.listarComuna();
            foreach (var c in list1)
            {
                cboComuna.Items.Add(c.descComuna);
            }




        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellidoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
