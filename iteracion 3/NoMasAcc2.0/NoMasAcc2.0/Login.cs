using DALC_01.controller;
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
    public partial class Login : MetroForm
    {
        int progress = 0;
        UsuarioController us = new UsuarioController();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            

            try
            {
                var list = us.listarUsuario();
                foreach (var usu in list)
                {
                    if (usu.usu == txtUsu.Text && usu.pass == txtPass.Text && usu.idTipoUsu == 1)
                    {
                        prgLoading.Visible = true;
                        //timerProgress.Start();
                        for (int i = 0; i < 90; i++)
                        {
                            if (i >= 0 && i <= 90)
                            {
                                progress += 1;
                                prgLoading.Value = progress;
                            }
                            System.Threading.Thread.Sleep(10);
                        }
                        
                        prgLoading.Visible = false;
                        prgLoading.Value = 0;
                        progress = 0;
                        this.Hide();
                        RunPrincipal(usu.usu,this);
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

        private void RunPrincipal(string user, Form login)
        {
            FormPrincipal p = new FormPrincipal(user, login);
            p.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
