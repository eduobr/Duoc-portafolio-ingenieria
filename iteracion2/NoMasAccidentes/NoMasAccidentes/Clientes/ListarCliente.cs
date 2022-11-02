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
    public partial class ListarCliente : Form
    {
        ClienteController cli = new ClienteController();

        public ListarCliente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                ListaCliente.Items.Clear();
                var list = cli.listarCliente();

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
    }
}
