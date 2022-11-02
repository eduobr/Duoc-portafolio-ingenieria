using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using DALC_01.controller;
using DALC_01.modelo;

namespace NoMasAcc2._0.actividades
{
    public partial class MantenedorActividades : MetroUserControl
    {
        CapacitacionController controlCapacitacion = new CapacitacionController();
        VisitaController controlVisita = new VisitaController();
        CheckListController controlCheck = new CheckListController();
        ClienteController controlCliente = new ClienteController();
        int estadoCheck=0;
        int estadoVentana = 0;
        public MantenedorActividades()
        {
            InitializeComponent();
        }

        private void btnVisitas_Click(object sender, EventArgs e)
        {
            btnAtras.Visible = false;
            estadoCheck = 0;
            estadoVentana = 1;
            var list = controlVisita.listarVisita();
            List<Visita> listaVisita = new List<Visita>();
            foreach (var v in list)
            {
                Visita visita = new Visita();
                visita.idVisita = v.idVisita;
                visita.fecha = v.fecha;
                visita.rutCliente = v.rutCliente;
                visita.nombreCliente = v.nombreCliente;
                visita.rutProfesional = v.rutProfesional;
                visita.nombreProfecional = v.nombreProfecional;
                visita.idEstado = v.idEstado;
                listaVisita.Add(visita);
            }
            grdActividades.DataSource = listaVisita;

            grdActividades.Columns["idVisita"].Visible = false;
            grdActividades.Columns["rutCliente"].DisplayIndex = 2;
            grdActividades.Columns["nombreCliente"].DisplayIndex = 3;
            grdActividades.Columns["idEstado"].DisplayIndex = 6;
        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            btnAtras.Visible = false;
            estadoCheck = 0;
            estadoVentana = 2;
            var list = controlCapacitacion.listarCapacitacion();
            List<Capacitacion> listaCapacitacion = new List<Capacitacion>();
            foreach (var c in list)
            {
                Capacitacion capacitacion = new Capacitacion();
                capacitacion.idCapacitacion = c.idCapacitacion;
                capacitacion.desCapacitacion = c.desCapacitacion;
                capacitacion.fechaCapacitacion = c.fechaCapacitacion;
                capacitacion.idplan = c.idplan;
                capacitacion.rutCliente = c.rutCliente;
                capacitacion.rutProfesional = c.rutProfesional;
                listaCapacitacion.Add(capacitacion);
            }
            grdActividades.DataSource = listaCapacitacion;
            grdActividades.Columns["idCapacitacion"].Visible = false;
            grdActividades.Columns["idPlan"].Visible = false;
            grdActividades.Columns["rutCliente"].DisplayIndex = 1;
            grdActividades.Columns["rutProfesional"].DisplayIndex = 2;
        }

        private void btnLstCheck_Click(object sender, EventArgs e)
        {
            cargarVentanaCheck();

            /*List<CheckList> listaCheck = new List<CheckList>();
            foreach (var ch in list)
            {
                CheckList check = new CheckList();
                check.idCheck = ch.idCheck;
                check.descCheckList = ch.descCheckList;
                check.idPlan = ch.idPlan;
                listaCheck.Add(check);
            }
            grdActividades.DataSource = listaCheck;*/
        }

        private void grdActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (estadoCheck==1 && estadoVentana==3)
                {
                    estadoVentana = 4;
                    btnAtras.Enabled = true;
                    string rut=grdActividades.Rows[e.RowIndex].Cells["rutCliente"].Value.ToString();
                    var list = controlCheck.listarCheckList(rut);
                    grdActividades.DataSource = list;
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            cargarVentanaCheck();
        }

        private void cargarVentanaCheck()
        {
            btnAtras.Visible = true;
            btnAtras.Enabled = false;
            estadoCheck = 1;
            estadoVentana = 3;
            var list = controlCliente.listarCliente();
            List<Cliente> listaCli = new List<Cliente>();
            foreach (var c in list)
            {
                Cliente cli = new Cliente();
                cli.idCliente = c.idCliente;
                cli.rutCliente = c.rutCliente;
                cli.nombre = c.nombre;
                cli.empresa = c.empresa;
                cli.direccion = c.direccion;
                listaCli.Add(cli);
            }

            grdActividades.DataSource = listaCli;
            grdActividades.Columns[0].Visible = false;
        }

        private void btnBuscarAct_Click(object sender, EventArgs e)
        {
            if (estadoVentana==1)
            {
                btnAtras.Visible = false;
                estadoCheck = 0;
                estadoVentana = 1;
                var list = controlVisita.buscarVisita(txtBuscAct.Text.ToLower());
                List<Visita> listaVisita = new List<Visita>();
                foreach (var v in list)
                {
                    Visita visita = new Visita();
                    visita.idVisita = v.idVisita;
                    visita.fecha = v.fecha;
                    visita.rutCliente = v.rutCliente;
                    visita.nombreCliente = v.nombreCliente;
                    visita.rutProfesional = v.rutProfesional;
                    visita.nombreProfecional = v.nombreProfecional;
                    visita.idEstado = v.idEstado;
                    listaVisita.Add(visita);
                }
                grdActividades.DataSource = listaVisita;

                grdActividades.Columns["idVisita"].Visible = false;
                grdActividades.Columns["rutCliente"].DisplayIndex = 2;
                grdActividades.Columns["nombreCliente"].DisplayIndex = 3;
                grdActividades.Columns["idEstado"].DisplayIndex = 6;
            }
            if (estadoVentana==2)
            {
                btnAtras.Visible = false;
                estadoCheck = 0;
                estadoVentana = 2;
                var list = controlCapacitacion.buscarCapacitacion(txtBuscAct.Text.ToLower());
                List<Capacitacion> listaCapacitacion = new List<Capacitacion>();
                foreach (var c in list)
                {
                    Capacitacion capacitacion = new Capacitacion();
                    capacitacion.idCapacitacion = c.idCapacitacion;
                    capacitacion.desCapacitacion = c.desCapacitacion;
                    capacitacion.fechaCapacitacion = c.fechaCapacitacion;
                    capacitacion.idplan = c.idplan;
                    capacitacion.rutCliente = c.rutCliente;
                    capacitacion.rutProfesional = c.rutProfesional;
                    listaCapacitacion.Add(capacitacion);
                }
                grdActividades.DataSource = listaCapacitacion;
                grdActividades.Columns["idCapacitacion"].Visible = false;
                grdActividades.Columns["idPlan"].Visible = false;
                grdActividades.Columns["rutCliente"].DisplayIndex = 1;
                grdActividades.Columns["rutProfesional"].DisplayIndex = 2;
            }
        }
    }
}
