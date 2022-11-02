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

namespace NoMasAccidentes.Atrasos
{
   
    public partial class ListarAtrasos : Form
    {

        BoletaController controlBoleta = new BoletaController();


        public ListarAtrasos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listAtrasos.Items.Clear();
            var list = controlBoleta.listarBoleta();
            foreach (var b in list)
            {
                ListViewItem item = new ListViewItem(b.idBoleta.ToString());
                //item.SubItems.Add(b.idBoleta.ToString());
                item.SubItems.Add(b.fechaPago.ToString("dd/MM/yyyy"));
                item.SubItems.Add(b.fechaLimite.ToString("dd/MM/yyyy"));
                item.SubItems.Add(b.monto.ToString());
                if (b.estadoBoleta == 0)
                {
                    item.SubItems.Add("No Cancelada");
                }
                item.SubItems.Add(b.idPlan.ToString());

                if (b.fechaLimite<System.DateTime.Now)
                {
                    if (b.estadoBoleta == 0)
                    {
                        listAtrasos.Items.Add(item);
                    }

                }

            }



        }
    }
}
