using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALC_01.controller;
using DALC_01.modelo;

namespace NoMasAcc2._0.atrasos
{
    public partial class MantenedorAtrasos : UserControl
    {
        BoletaController controlBoleta = new BoletaController();
        public MantenedorAtrasos()
        {
            InitializeComponent();

            //Rut, Nombre, Fecha Limite, estado
            cargarBoleta();
        }

        private void cargarBoleta()
        {
            var list = controlBoleta.listarBoleta();
            List<Boleta> listaPago = new List<Boleta>();
            foreach (var b in list)
            {
                Boleta boleta = new Boleta();
                boleta.idBoleta = b.idBoleta;
                boleta.rutCliente = b.rutCliente;
                boleta.nombreCliente = b.nombreCliente;
                boleta.fechaLimite = b.fechaLimite;
                boleta.estado = b.estado;
                boleta.idPlan = b.idPlan;
                boleta.estadoServicio = b.estadoServicio;
                listaPago.Add(boleta);
            }
            grdAtrasos.DataSource = listaPago;
            grdAtrasos.Columns[0].Visible = false;
            grdAtrasos.Columns[5].Visible = false;
        }

        private void btnNotAtraso_Click(object sender, EventArgs e)
        {
            if (grdAtrasos.RowCount>0)
            {
                int idBoleta = Convert.ToInt32(grdAtrasos.SelectedCells[0].Value);
                int resp = controlBoleta.notificarAtraso(idBoleta);
                if (resp == 1)
                {
                    MessageBox.Show("Se notifico el atraso correctamente");
                    cargarBoleta();
                }
                else
                {
                    MessageBox.Show("No se pudo notificar el atraso");
                }
            }else
            {
                MessageBox.Show("Debe seleccionar una boleta");
            }
            
        }

        private void btnQuitServ_Click(object sender, EventArgs e)
        {
            int idPlan = Convert.ToInt32(grdAtrasos.SelectedCells[5].Value);
            int resp = controlBoleta.quitarServicio(idPlan);
            if (resp == 1)
            {
                MessageBox.Show("Se quito el servicio correctamente");
                cargarBoleta();
            }
            else
            {
                MessageBox.Show("No se pudo quitar el servicio");
            }
        }

        private void btnRestServ_Click(object sender, EventArgs e)
        {
            int idPlan = Convert.ToInt32(grdAtrasos.SelectedCells[5].Value);
            int resp = controlBoleta.restablecerServicio(idPlan);
            if (resp == 1)
            {
                MessageBox.Show("Se restablecio el servicio correctamente");
                cargarBoleta();
            }
            else
            {
                MessageBox.Show("No se pudo restablecer el servicio");
            }
        }
    }
}
