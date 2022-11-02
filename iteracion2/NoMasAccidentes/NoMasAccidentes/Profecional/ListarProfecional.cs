using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALC_01.controller;
using DALC_01.modelo;
using System.Data;

namespace NoMasAccidentes.Profecional
{
    public partial class ListarProfecional : Form
    {
        ProfesionalController proC = new ProfesionalController();
        ComunaController comunaC = new ComunaController();
        public ListarProfecional()
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
               
                ListaProfecional.Items.Clear();
                
                var list = proC.listarProfecional();
                foreach (var pro in list)
                {
                   
                    ListViewItem item = new ListViewItem(pro.idProfesional.ToString());
                    item.SubItems.Add(pro.rutProfesional);
                    item.SubItems.Add(pro.nombre);
                    item.SubItems.Add(pro.apePaterno);
                    item.SubItems.Add(pro.apeMaterno);
                    item.SubItems.Add(pro.telefono);
                    item.SubItems.Add(pro.fechaNacimientoPro.ToString("dd/MM/yyyy"));
                    var comunas =comunaC.listarComuna();
                    foreach (var c in comunas)
                    {
                        if (c.idCiudad==pro.idComuna)
                        {
                            item.SubItems.Add(c.descComuna);
                        }
                    }


                    
                    ListaProfecional.Items.Add(item);


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Listar " + ex);
            }
        }
    }
}