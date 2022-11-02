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

namespace NoMasAccidentes.Reporte_Global
{
    public partial class Reporte : Form
    {

        Reporte2Controller reporteControl = new Reporte2Controller();

        public Reporte()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

            DateTime fecha_I = DateTime.Parse(dtpFechaInicial.Value.ToString("dd/MM/yyyy"));
            DateTime fecha_F = DateTime.Parse(dtpFechafinal.Value.ToString("dd/MM/yyyy"));

            dgvReporte.DataSource = reporteControl.listarGlobal(fecha_I, fecha_F);


        }
    }
}
