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

namespace NoMasAccidentes.Actividades
{
    public partial class ListarVisitas : Form
    {
        CapacitacionController controlCapacitacion = new CapacitacionController();
        PlanContratadoController controlPlan = new PlanContratadoController();
        ClienteController controlCliente = new ClienteController();
        CheckListController controlCheck = new CheckListController();
        CheckListReporteController controlCheckReport = new CheckListReporteController();
        VisitaController controlVisita = new VisitaController();

        public ListarVisitas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarCapacitaciones_Click(object sender, EventArgs e)
        {
            try
            {
                listVisitas.Visible = false;
                listGestion.Visible = false;

                listCapasitaciones.Visible = true;
                listCapasitaciones.Items.Clear();
                
                var list = controlCapacitacion.listarCapacitacion();
                foreach (var c in list)
                {
                   
                    ListViewItem item = null;
                    
                    var listPlan = controlPlan.buscarPlan(c.idplan);
                    foreach (var plan in listPlan)
                    {
                        var listCliente = controlCliente.listarCliente();
                        foreach (var cli in listCliente)
                        {
                            if (cli.rutCliente==txtRut.Text && cli.idCliente == plan.idCliente)
                            {
                                item = new ListViewItem(c.idCapacitacion.ToString());
                                item.SubItems.Add(c.fechaCapacitacion.ToString("dd/MM/yyyy"));
                                item.SubItems.Add(c.desCapacitacion.ToString());
                                item.SubItems.Add(c.cantAsistentes.ToString());
                                item.SubItems.Add(c.idplan.ToString());
                                
                            }
                        }

                    }

                    listCapasitaciones.Items.Add(item);
                    


                }





            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Listar Capacitacion, Rut No Valido"+ex.Message);
            }


        }

        private void btnListarVisitas_Click(object sender, EventArgs e)
        {

            try
            {

                
                listGestion.Visible = true;
                listCapasitaciones.Visible = false;
                listVisitas.Visible = false;
                
                listGestion.Items.Clear();

                var reports = controlCheckReport.listarCheckListReporte();
                foreach (var report in reports)
                {
                    ListViewItem item = null;
                    var chects = controlCheck.listarCheckList();
                    foreach (var chect in chects)
                    {
                        var listPlan = controlPlan.buscarPlan(chect.idPlan);
                        foreach (var plan in listPlan)
                        {
                            var listCliente = controlCliente.listarCliente();
                            foreach (var cli in listCliente)
                            {
                                if (cli.rutCliente == txtRut.Text && cli.idCliente == plan.idCliente)
                                {
                                    item = new ListViewItem(report.idCheListRepo.ToString());

                                    if (report.estadoCheck>0)
                                    {
                                        item.SubItems.Add("APROBADO");
                                    }
                                    else
                                    {
                                        item.SubItems.Add("NO APROBADO");
                                    }
                                    
                                    item.SubItems.Add(report.fechaCheckRep.ToString("dd/MM/yyyy"));
                                    item.SubItems.Add(report.mejora.ToString());
                                    
                                }
                            }

                        }


                    }
                    listGestion.Items.Add(item);

                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Listar Visita, Rut No Valido" + ex.Message);
            }





        }

        private void btnListarVisita_Click(object sender, EventArgs e)
        {

            try
            {

                listCapasitaciones.Visible = false;
                listVisitas.Visible = true;
                listGestion.Visible = false;

                
                listVisitas.Items.Clear();
                ListViewItem item = null;

                var list = controlVisita.listarVisita(txtRut.Text);
                foreach (var v in list)
                {
                    item = new ListViewItem(v.idVisita.ToString());
           
                    item.SubItems.Add(v.fecha.ToString("dd/MM/yyyy"));
                    //item.SubItems.Add(v.idEstado.ToString());
                    item.SubItems.Add(v.rutCliente.ToString());
                    item.SubItems.Add(v.rutProfesional.ToString());
                    item.SubItems.Add(v.nombreCliente.ToString());
                    item.SubItems.Add(v.nombreProfecional.ToString());



                    listVisitas.Items.Add(item);
                    
                }


                }
            catch (Exception ex)
            {

                MessageBox.Show("Error Listar Visita, Rut No Valido" + ex.Message);
            }



        }
    }
}
