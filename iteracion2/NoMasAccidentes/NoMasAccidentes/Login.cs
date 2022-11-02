using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALC_01.controller;

namespace NoMasAccidentes
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        UsuarioController contolUsuario = new UsuarioController();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var list = contolUsuario.listarUsuario();
                foreach (var usu in list)
                {
                    if (usu.usu==txtUsu.Text && usu.pass==txtPass.Text && usu.idTipoUsu==1)
                    {
                        this.Hide();
                        FromPrincipal f = new FromPrincipal();
                       
                        //f.idhotel = em.HOTEL_ID_HOTEL;
                        
                        f.Show();
                        return;
                    }
                }

                MessageBox.Show("Usuario o Contraseña incorrecto");
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario/Contraceña Incorrecto ERROR");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
