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

namespace NoMasAccidentes.Clientes
{
    public partial class Asignacion : Form
    {
        ClienteController cli = new ClienteController();
        ProfesionalController proC = new ProfesionalController();
        ComunaController comunaC = new ComunaController();
        public Asignacion()
        {
            InitializeComponent();
        }

        private void Asignacion_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ListaCliente.Items.Clear();
                var list = cli.BuscarCliente(txtRutCli.Text);

                foreach (var c in list)
                {

                    ListViewItem item = new ListViewItem(c.idCliente.ToString());
                    item.SubItems.Add(c.rutCliente.ToString());

                    item.SubItems.Add(c.nombre.ToString());
                    item.SubItems.Add(c.apePaterno.ToString());
                    item.SubItems.Add(c.apeMaterno.ToString());
                    item.SubItems.Add(c.direccion.ToString());
                    item.SubItems.Add(c.email.ToString());
                    item.SubItems.Add(c.telefono.ToString());
                    item.SubItems.Add(c.idComuna.ToString());
                    item.SubItems.Add(c.idRubro.ToString());
                    item.SubItems.Add(c.idUsuario.ToString());


                    ListaCliente.Items.Add(item);


                }


            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnBuscarProfecional_Click(object sender, EventArgs e)
        {
            try
            {

                ListaProfecional.Items.Clear();

                var list = proC.Buscar_Profecional(txtRutPro.Text);
                foreach (var pro in list)
                {

                    ListViewItem item = new ListViewItem(pro.idProfesional.ToString());
                    item.SubItems.Add(pro.rutProfesional);
                    item.SubItems.Add(pro.nombre);
                    item.SubItems.Add(pro.apePaterno);
                    item.SubItems.Add(pro.apeMaterno);
                    item.SubItems.Add(pro.telefono);
                    item.SubItems.Add(pro.fechaNacimientoPro.ToString("dd/MM/yyyy"));
                    var comunas = comunaC.listarComuna();
                    foreach (var c in comunas)
                    {
                        if (c.idCiudad == pro.idComuna)
                        {
                            item.SubItems.Add(c.descComuna);
                        }
                    }



                    ListaProfecional.Items.Add(item);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Listar " + ex);
            }
        
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

            var listP = proC.Buscar_Profecional(txtRutPro.Text);
            var listC = cli.BuscarCliente(txtRutCli.Text);



        }

        


    }
}
