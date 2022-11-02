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

namespace NoMasAccidentes.Accidentes
{
    public partial class BuscarAccidente : Form
    {

        EventoController controlEvento = new EventoController();
        
        public BuscarAccidente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
            listEvento.Items.Clear();
            ListViewItem item = null;
            var list = controlEvento.listarEventoID(int.Parse(txtIdEvento.Text));
            foreach (var evento in list)
            {
                item = new ListViewItem(evento.idEvento.ToString());

                item.SubItems.Add(evento.asesoria);
                item.SubItems.Add(evento.fechaEvento.ToString("dd/MM/yyyy"));
                item.SubItems.Add(evento.idTipoEvento.ToString());
                item.SubItems.Add(evento.idPlan.ToString());
                if (evento.idTipoEvento==1)
                {
                    listEvento.Items.Add(item);
                }
                

            }
            }
            catch (Exception )
            {

                MessageBox.Show("Error Al Buscar");
            }


        }
    }
}
