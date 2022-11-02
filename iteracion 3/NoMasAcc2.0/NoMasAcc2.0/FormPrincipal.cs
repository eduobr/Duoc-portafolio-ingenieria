using DALC_01.modelo;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMasAcc2._0
{
    public partial class FormPrincipal : MetroForm
    {
        string usuario;
        Form iniciar_sesion;
        public FormPrincipal(string user, Form frm)
        {
            InitializeComponent();
            usuario = user;
            iniciar_sesion = frm;
        }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnInfProfecional_Click(object sender, EventArgs e)
        {
            profesional.MantenedorProfesional mProf = new profesional.MantenedorProfesional();
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(mProf);
            //mProf.Dock = DockStyle.Fill;
        }

        private void btnInfCliente_Click(object sender, EventArgs e)
        {
            clientes.MantenedorCliente mCli = new clientes.MantenedorCliente();
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(mCli);
            //mCli.Dock = DockStyle.Fill;
        }

        private void btnAtraso_Click(object sender, EventArgs e)
        {
            atrasos.MantenedorAtrasos mAtrasos = new atrasos.MantenedorAtrasos();
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(mAtrasos);
            //mAtrasos.Dock = DockStyle.Fill;
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            plan.MantenedorPlan mPlan = new plan.MantenedorPlan();
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(mPlan);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            pago.MantenedorPago mPago = new pago.MantenedorPago();
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(mPago);
        }

        private void btnAccidentabilidad_Click(object sender, EventArgs e)
        {
            accidentes.MantenedorAccidentes mAccidente = new accidentes.MantenedorAccidentes();
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(mAccidente);
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            actividades.MantenedorActividades mActividades = new actividades.MantenedorActividades();
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(mActividades);
        }

        private void btnReporteCli_Click(object sender, EventArgs e)
        {
            reporteCliente.MantenedorReporteCliente mReporteCli = new reporteCliente.MantenedorReporteCliente();
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(mReporteCli);
        }

        private void btnReporteGlo_Click(object sender, EventArgs e)
        {
            reporteGlobal.MantenedorReporteGlobal mReporteGlo = new reporteGlobal.MantenedorReporteGlobal();
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(mReporteGlo);
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha desconectado Correctamente");
            this.Close();
        }
    }
}
