using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMasAccidentes.Clientes
{
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["P_agregarTrab"] == null)
            //btnAgregar.BackColor = Color.FromArgb(4, 41, 68);
            //if (Application.OpenForms["P_ModificarTrab"] == null)
            //    btnModificar.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["P_ListarTrab"] == null) { }
            //btnListar.BackColor = Color.FromArgb(4, 41, 68);
            //if (Application.OpenForms["P_EliminarTrab"] == null)
            //    btnEliminar.BackColor = Color.FromArgb(4, 41, 68);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AgregarCliente>();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ListarCliente>();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ModificarCliente>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Asignacion>();
        }
    }
}
