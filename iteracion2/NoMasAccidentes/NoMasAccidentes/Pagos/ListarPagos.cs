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

namespace NoMasAccidentes.Pagos
{
    public partial class ListarPagos : Form
    {

        BoletaController controlBoleta = new BoletaController();

        public ListarPagos()
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
                listDePagos.Items.Clear();
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
                    if (b.estadoBoleta == 1)
                    {
                        item.SubItems.Add("Cancelada");
                    }

                    item.SubItems.Add(b.idPlan.ToString());

                    // MessageBox.Show(b.fechaPago.ToString("dd/MM/yyyy") +" "+ dTimeFecha.Value.ToString("dd/MM/yyyy"));
                    if (b.fechaPago.ToString("dd/MM/yyyy") == dTimeFecha.Value.ToString("dd/MM/yyyy"))
                        {
                        
                        listDePagos.Items.Add(item);
                        }
                  
                        
                }



            }
            catch (Exception)
            {

                throw;
            }
            


        }

        private void btnNoPagados_Click(object sender, EventArgs e)
        {
            try
            {
                listDePagos.Items.Clear();
                var list = controlBoleta.listarBoleta();
                foreach (var b in list)
                {

                    ListViewItem item = new ListViewItem(b.idBoleta.ToString());
                    //item.SubItems.Add(b.idBoleta.ToString());
                    item.SubItems.Add(b.fechaPago.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(b.fechaLimite.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(b.monto.ToString());
                    if (b.estadoBoleta==0)
                    {
                        item.SubItems.Add("No Cancelada");
                    }
                    item.SubItems.Add(b.idPlan.ToString());

                    if (b.fechaPago.ToString("dd/MM/yyyy") == dTimeFecha.Value.ToString("dd/MM/yyyy"))
                    {
                        if (b.estadoBoleta == 0)
                        {
                            listDePagos.Items.Add(item);
                        }
                        
                    }


                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPagados_Click(object sender, EventArgs e)
        {
            try
            {
                listDePagos.Items.Clear();
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
                        item.SubItems.Add("Cancelada");
                    }
                    item.SubItems.Add(b.idPlan.ToString());

                    if (b.fechaPago.ToString("dd/MM/yyyy") == dTimeFecha.Value.ToString("dd/MM/yyyy"))
                    {
                        if (b.estadoBoleta == 1)
                        {
                            listDePagos.Items.Add(item);
                        }

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
