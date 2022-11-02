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

namespace NoMasAccidentes.Plan
{
    public partial class IngresarPlan : Form
    {
        PlanContratadoController controllerPlan = new PlanContratadoController();
        public IngresarPlan()
        {
            InitializeComponent();
        }

        private void btnIngPlan_Click(object sender, EventArgs e)
        {
            string rutCli, rutProf, sucursal;
            int precio;
            DateTime fecVisita, fecVisita2;
            rutCli = txtRutCli.Text;
            rutProf = txtRutProf.Text;
            precio = Convert.ToInt32(txtPrec.Text);
            sucursal = txtSuc.Text;
            fecVisita = dpVisita.Value;
            fecVisita2 = dpVisita2.Value;
            int resp = controllerPlan.Insert_Plan(precio,sucursal,rutCli,rutProf,fecVisita,fecVisita2);
            if (resp<1)
            {
                MessageBox.Show("No se pudo ingresar el plan");
            }else
            {
                MessageBox.Show("El plan se ingreso correctamente");
            }
        }
    }
}
