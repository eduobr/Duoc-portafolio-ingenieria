namespace NoMasAcc2._0
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.prgLoading = new MetroFramework.Controls.MetroProgressSpinner();
            this.txtUsuario = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUsu = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.btnIniciarSesion = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prgLoading
            // 
            this.prgLoading.Location = new System.Drawing.Point(82, 113);
            this.prgLoading.Maximum = 100;
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.Size = new System.Drawing.Size(128, 103);
            this.prgLoading.Style = MetroFramework.MetroColorStyle.Green;
            this.prgLoading.TabIndex = 0;
            this.prgLoading.UseSelectable = true;
            this.prgLoading.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Location = new System.Drawing.Point(23, 140);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(53, 19);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 176);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Contraseña";
            // 
            // txtUsu
            // 
            // 
            // 
            // 
            this.txtUsu.CustomButton.Image = null;
            this.txtUsu.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtUsu.CustomButton.Name = "";
            this.txtUsu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsu.CustomButton.TabIndex = 1;
            this.txtUsu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsu.CustomButton.UseSelectable = true;
            this.txtUsu.CustomButton.Visible = false;
            this.txtUsu.Lines = new string[0];
            this.txtUsu.Location = new System.Drawing.Point(113, 140);
            this.txtUsu.MaxLength = 32767;
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.PasswordChar = '\0';
            this.txtUsu.PromptText = "Ingrese su Usuario";
            this.txtUsu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsu.SelectedText = "";
            this.txtUsu.SelectionLength = 0;
            this.txtUsu.SelectionStart = 0;
            this.txtUsu.ShortcutsEnabled = true;
            this.txtUsu.Size = new System.Drawing.Size(140, 23);
            this.txtUsu.TabIndex = 3;
            this.txtUsu.UseSelectable = true;
            this.txtUsu.WaterMark = "Ingrese su Usuario";
            this.txtUsu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(113, 176);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PromptText = "Ingrese su contraseña";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(140, 23);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMark = "Ingrese su contraseña";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.LimeGreen;
            this.btnIniciarSesion.Location = new System.Drawing.Point(23, 243);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(252, 31);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseCustomBackColor = true;
            this.btnIniciarSesion.UseSelectable = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 312);
            this.Controls.Add(this.prgLoading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner prgLoading;
        private MetroFramework.Controls.MetroLabel txtUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUsu;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroButton btnIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}