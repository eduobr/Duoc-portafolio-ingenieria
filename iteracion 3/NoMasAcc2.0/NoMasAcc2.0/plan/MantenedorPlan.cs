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

namespace NoMasAcc2._0.plan
{
    public partial class MantenedorPlan : UserControl
    {
        PlanContratadoController planController = new PlanContratadoController();
        PlanContratadoController controllerPlan = new PlanContratadoController();

        public MantenedorPlan()
        {
            InitializeComponent();
            tcPlan.SelectedTab = tpAddPlan;
        }

        private void btnListPlan_Click(object sender, EventArgs e)
        {
            tcPlan.SelectedTab = tpListPlan;
            var list = planController.listarPlan();
            List<PlanContratado> listaPlan = new List<PlanContratado>();
            foreach (var p in list)
            {
                PlanContratado plan = new PlanContratado();
                plan.idPlanContra = p.idPlanContra;
                plan.nombreCliente = p.nombreCliente;
                plan.nombreProfesional = p.nombreProfesional; 
                plan.estado= p.estado;
                plan.fechaPlanContra = p.fechaPlanContra;
                listaPlan.Add(plan);
            }
            grdPlan.DataSource=listaPlan;
            grdPlan.Columns["IDPLANCONTRA"].Visible = false;
            grdPlan.Columns["nombreCliente"].HeaderText = "Nombre Cliente";
            grdPlan.Columns["nombreProfesional"].HeaderText = "Nombre Profesional";
            grdPlan.Columns["fechaPlanContra"].Width = 80;
            grdPlan.Columns["fechaPlanContra"].HeaderText = "fecha contrato";
            grdPlan.Columns["estado"].Width = 80;

        }

        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            tcPlan.SelectedTab = tpAddPlan;
        }

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            tcPlan.SelectedTab = tpListPlan;
            var list = planController.buscarPlan(txtParamPlan.Text);
            List<PlanContratado> listaPlan = new List<PlanContratado>();
            foreach (var p in list)
            {
                PlanContratado plan = new PlanContratado();
                plan.idPlanContra = p.idPlanContra;
                plan.nombreCliente = p.nombreCliente;
                plan.nombreProfesional = p.nombreProfesional;
                plan.estado = p.estado;
                plan.fechaPlanContra = p.fechaPlanContra;
                listaPlan.Add(plan);
            }
            grdPlan.DataSource = listaPlan;
            grdPlan.Columns["IDPLANCONTRA"].Visible = false;
            grdPlan.Columns["nombreCliente"].HeaderText = "Nombre Cliente";
            grdPlan.Columns["nombreProfesional"].HeaderText = "Nombre Profesional";
            grdPlan.Columns["fechaPlanContra"].Width = 80;
            grdPlan.Columns["fechaPlanContra"].HeaderText = "fecha contrato";
            grdPlan.Columns["estado"].Width = 80;
        }

        private void btnGuardarPlan_Click(object sender, EventArgs e)
        {
            string rutCli, rutProf, sucursal;
            int precio;
            DateTime fecVisita, fecVisita2;
            rutCli = txtRutCli.Text;
            rutProf = txtRutProf.Text;
            if (txtNomCli.Text=="")
            {
                MessageBox.Show("Ingrese un rut de cliente valido");
                return;
            }

            if (txtRutCli.Text == "")
            {
                MessageBox.Show("Ingrese un rut de profesional valido");
                return;
            }

            if (txtPrec.Text!="")
            {
                precio = Convert.ToInt32(txtPrec.Text);
            }else
            {
                precio = 0;
            }
            fecVisita = dpVisita.Value;
            fecVisita2 = dpVisita2.Value;
            if (fecVisita <= DateTime.Now.AddDays(15))
            {
                MessageBox.Show("La fecha seleccionada debe ser mayor en 15 dias a la de hoy");
                return;
            }
            if (fecVisita2.AddDays(15)<=fecVisita)
            {
                MessageBox.Show("La segunda visita debe ser mayor en 15 dias a la primera");
                return;
            }

            int resp = controllerPlan.Insert_Plan(precio, rutCli, rutProf, fecVisita, fecVisita2);
            if (resp < 1)
            {
                MessageBox.Show("No se pudo ingresar el plan");
            }
            else
            {
                MessageBox.Show("El plan se ingreso correctamente");
            }
        }

        private void txtRutCli_Leave(object sender, EventArgs e)
        {
            ClienteController cliController = new ClienteController();
            List<Cliente> cliente = cliController.BuscarCliente(txtRutCli.Text);
            txtNomCli.Text= cliente[0].nombre.ToString();
        }

        private void txtRutProf_Leave(object sender, EventArgs e)
        {
            ProfesionalController proController = new ProfesionalController();
            List<Profesional> profesional = proController.Buscar_Profecional(txtRutProf.Text);
            txtNomProf.Text = profesional[0].nombre.ToString();
        }

        private void txtPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
