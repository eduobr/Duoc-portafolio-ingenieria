using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NoMasAccidentes.Clientes;

namespace NoMasAccidentes
{
    public partial class FromPrincipal : Form
    {
        public FromPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        // private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        //private Rectangle sizeGripRectangle;

        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
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
            if (Application.OpenForms["MantenedorCliente"] == null)
                btnInfCliente.BackColor = Color.FromArgb(154, 154, 154);
            if (Application.OpenForms["MantenedorProfecional"] == null)
                btnInfProfecional.BackColor = Color.FromArgb(154, 154, 154);
            if (Application.OpenForms["MantenedorPagos"] == null)
                btnPagos.BackColor = Color.FromArgb(154, 154, 154);
            if (Application.OpenForms["MantenedorAccidentes"] == null)
                btnAccidentabilidad.BackColor = Color.FromArgb(154, 154, 154);
            if (Application.OpenForms["MantenedorActividades"] == null)
                btnActividad.BackColor = Color.FromArgb(154, 154, 154);
            if (Application.OpenForms["MantenedorAtrasos"] == null)
                btnAtrasos.BackColor = Color.FromArgb(154, 154, 154);
            if (Application.OpenForms["MantenedorReporteC"] == null)
                btnReporteCliente.BackColor = Color.FromArgb(154, 154, 154);
            if (Application.OpenForms["MantenedorReporteG"] == null)
                btnReporteGlobal.BackColor = Color.FromArgb(154, 154, 154);
            if (Application.OpenForms["MantenedorPlan"] == null)
                btnPlan.BackColor = Color.FromArgb(154, 154, 154);

        }

        private void btnInfCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MantenedorCliente>();
            btnInfCliente.BackColor = Color.FromArgb(180, 180, 255);
        }

        private void btnInfProfecional_Click(object sender, EventArgs e)
        {

            AbrirFormulario<Profecional.MantenedorProfecional>();
            btnInfProfecional.BackColor = Color.FromArgb(180, 180, 255);
        }

        private void btnAccidentabilidad_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Accidentes.MantenedorAccidentes>();
            btnAccidentabilidad.BackColor = Color.FromArgb(180, 180, 255);
        }

        private void btnActividad_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Actividades.MantenedorActividades>();
            btnActividad.BackColor = Color.FromArgb(180, 180, 255);
        }

        private void btnAtrasos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Atrasos.MantenedorAtrasos>();
            btnAtrasos.BackColor = Color.FromArgb(180, 180, 255);
        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ReportesCliente.MantenedorReporteC>();
            btnReporteCliente.BackColor = Color.FromArgb(180, 180, 255);
        }

        private void btnReporteGlobal_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Reporte_Global.MantenedorReporteG>();
            btnReporteGlobal.BackColor = Color.FromArgb(180, 180, 255);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Pagos.MantenedorPagos>();
            btnPagos.BackColor = Color.FromArgb(180, 180, 255);
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Plan.MantenedorPlan>();
            btnPlan.BackColor = Color.FromArgb(180, 180, 255);
        }
    }
}
