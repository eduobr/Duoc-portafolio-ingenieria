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

namespace NoMasAccidentes.Accidentes
{
    public partial class ListarAccidentes : Form
    {
        EventoController controlEvento = new EventoController();
        public ListarAccidentes()
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

                listAccidente.Items.Clear();

                ListViewItem item = null;
            var list = controlEvento.listarEvento();
            foreach (var evento in list)
            {
                item = new ListViewItem(evento.idEvento.ToString());

                item.SubItems.Add(evento.asesoria);
                item.SubItems.Add(evento.fechaEvento.ToString("dd/MM/yyyy"));
                item.SubItems.Add(evento.idTipoEvento.ToString());
                item.SubItems.Add(evento.idPlan.ToString());
                if (evento.idTipoEvento == 1)
                {
                    listAccidente.Items.Add(item);
                }


            }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
