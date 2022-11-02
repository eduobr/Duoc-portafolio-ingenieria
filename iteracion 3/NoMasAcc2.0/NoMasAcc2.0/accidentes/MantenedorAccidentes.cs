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

namespace NoMasAcc2._0.accidentes
{
    public partial class MantenedorAccidentes : MetroUserControl
    {
        EventoController controlEvento = new EventoController();
        public MantenedorAccidentes()
        {
            InitializeComponent();

            //Rut, Nombre Cliente, Cant de Accidentes, sucursal

            var list = controlEvento.listarAccidentes();
            List<Accidente> listaEvento = new List<Accidente>();
            foreach (var a in list)
            {
                Accidente evento = new Accidente();
                evento.rutCliente = a.rutCliente;
                evento.nombreCliente = a.nombreCliente;
                evento.rutProfesional = a.rutProfesional;
                evento.nombreProfesional = a.nombreProfesional;
                evento.cantAccidente = a.cantAccidente;
                listaEvento.Add(evento);
            }
            grdAccidentes.DataSource = listaEvento;
            grdAccidentes.Columns["cantAccidente"].HeaderText = "Cantidad";
            //grdAccidentes.Columns[0].Width = 80;
            //grdAccidentes.Columns[2].Width = 80;
        }

        private void btnBuscarAcc_Click(object sender, EventArgs e)
        {
            var list = controlEvento.buscarAccidentes(txtParamAcc.Text.ToLower());
            List<Accidente> listaEvento = new List<Accidente>();
            foreach (var a in list)
            {
                Accidente evento = new Accidente();
                evento.rutCliente = a.rutCliente;
                evento.nombreCliente = a.nombreCliente;
                evento.rutProfesional = a.rutProfesional;
                evento.nombreProfesional = a.nombreProfesional;
                evento.cantAccidente = a.cantAccidente;
                listaEvento.Add(evento);
            }
            grdAccidentes.DataSource = listaEvento;
            grdAccidentes.Columns["cantAccidente"].HeaderText = "Cantidad";
            //grdAccidentes.Columns[0].Width = 80;
            //grdAccidentes.Columns[2].Width = 80;
        }
    }
}
