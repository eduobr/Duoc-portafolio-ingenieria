namespace NoMasAcc2._0.profesional
{
    partial class MantenedorProfesional
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddProf = new MetroFramework.Controls.MetroButton();
            this.btnListProf = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcProfesional = new MetroFramework.Controls.MetroTabControl();
            this.tpAddProf = new MetroFramework.Controls.MetroTabPage();
            this.btnGuardarProf = new MetroFramework.Controls.MetroButton();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.cboComunaProf = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dtpFecha = new MetroFramework.Controls.MetroDateTime();
            this.txtFono = new MetroFramework.Controls.MetroTextBox();
            this.txtApellidoM = new MetroFramework.Controls.MetroTextBox();
            this.txtApellidoP = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtRut = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tpListProf = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtParamProf = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscarProf = new MetroFramework.Controls.MetroButton();
            this.grdProfesional = new MetroFramework.Controls.MetroGrid();
            this.tpModProf = new MetroFramework.Controls.MetroTabPage();
            this.panel1.SuspendLayout();
            this.tcProfesional.SuspendLayout();
            this.tpAddProf.SuspendLayout();
            this.tpListProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProf
            // 
            this.btnAddProf.Location = new System.Drawing.Point(7, 6);
            this.btnAddProf.Name = "btnAddProf";
            this.btnAddProf.Size = new System.Drawing.Size(182, 37);
            this.btnAddProf.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddProf.TabIndex = 0;
            this.btnAddProf.Text = "Agregar";
            this.btnAddProf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddProf.UseSelectable = true;
            this.btnAddProf.UseStyleColors = true;
            this.btnAddProf.Click += new System.EventHandler(this.btnAddProf_Click);
            // 
            // btnListProf
            // 
            this.btnListProf.Location = new System.Drawing.Point(195, 6);
            this.btnListProf.Name = "btnListProf";
            this.btnListProf.Size = new System.Drawing.Size(185, 37);
            this.btnListProf.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnListProf.TabIndex = 4;
            this.btnListProf.Text = "Listar";
            this.btnListProf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnListProf.UseSelectable = true;
            this.btnListProf.UseStyleColors = true;
            this.btnListProf.Click += new System.EventHandler(this.btnListProf_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnAddProf);
            this.panel1.Controls.Add(this.btnListProf);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 6;
            // 
            // tcProfesional
            // 
            this.tcProfesional.Controls.Add(this.tpAddProf);
            this.tcProfesional.Controls.Add(this.tpListProf);
            this.tcProfesional.Controls.Add(this.tpModProf);
            this.tcProfesional.Location = new System.Drawing.Point(3, 14);
            this.tcProfesional.Name = "tcProfesional";
            this.tcProfesional.SelectedIndex = 0;
            this.tcProfesional.Size = new System.Drawing.Size(571, 355);
            this.tcProfesional.TabIndex = 7;
            this.tcProfesional.UseSelectable = true;
            // 
            // tpAddProf
            // 
            this.tpAddProf.Controls.Add(this.btnGuardarProf);
            this.tpAddProf.Controls.Add(this.txtPass);
            this.tpAddProf.Controls.Add(this.txtUsuario);
            this.tpAddProf.Controls.Add(this.cboComunaProf);
            this.tpAddProf.Controls.Add(this.metroLabel10);
            this.tpAddProf.Controls.Add(this.metroLabel9);
            this.tpAddProf.Controls.Add(this.metroLabel8);
            this.tpAddProf.Controls.Add(this.dtpFecha);
            this.tpAddProf.Controls.Add(this.txtFono);
            this.tpAddProf.Controls.Add(this.txtApellidoM);
            this.tpAddProf.Controls.Add(this.txtApellidoP);
            this.tpAddProf.Controls.Add(this.txtNombre);
            this.tpAddProf.Controls.Add(this.txtRut);
            this.tpAddProf.Controls.Add(this.metroLabel7);
            this.tpAddProf.Controls.Add(this.metroLabel6);
            this.tpAddProf.Controls.Add(this.metroLabel5);
            this.tpAddProf.Controls.Add(this.metroLabel4);
            this.tpAddProf.Controls.Add(this.metroLabel2);
            this.tpAddProf.Controls.Add(this.metroLabel1);
            this.tpAddProf.Controls.Add(this.metroLabel3);
            this.tpAddProf.HorizontalScrollbarBarColor = true;
            this.tpAddProf.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAddProf.HorizontalScrollbarSize = 10;
            this.tpAddProf.Location = new System.Drawing.Point(4, 38);
            this.tpAddProf.Name = "tpAddProf";
            this.tpAddProf.Size = new System.Drawing.Size(563, 313);
            this.tpAddProf.TabIndex = 0;
            this.tpAddProf.UseStyleColors = true;
            this.tpAddProf.VerticalScrollbarBarColor = true;
            this.tpAddProf.VerticalScrollbarHighlightOnWheel = false;
            this.tpAddProf.VerticalScrollbarSize = 10;
            // 
            // btnGuardarProf
            // 
            this.btnGuardarProf.Location = new System.Drawing.Point(191, 281);
            this.btnGuardarProf.Name = "btnGuardarProf";
            this.btnGuardarProf.Size = new System.Drawing.Size(218, 29);
            this.btnGuardarProf.TabIndex = 21;
            this.btnGuardarProf.Text = "Guardar Profesional";
            this.btnGuardarProf.UseSelectable = true;
            this.btnGuardarProf.Click += new System.EventHandler(this.btnGuardarProf_Click);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(335, 103);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PromptText = "Ingrese Contraseña Profesional";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(209, 23);
            this.txtPass.TabIndex = 20;
            this.txtPass.UseSelectable = true;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WaterMark = "Ingrese Contraseña Profesional";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(394, 42);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PromptText = "Ingrese Usuario Profesional";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(150, 23);
            this.txtUsuario.TabIndex = 19;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMark = "Ingrese Usuario Profesional";
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboComunaProf
            // 
            this.cboComunaProf.FormattingEnabled = true;
            this.cboComunaProf.ItemHeight = 23;
            this.cboComunaProf.Location = new System.Drawing.Point(147, 233);
            this.cboComunaProf.Name = "cboComunaProf";
            this.cboComunaProf.Size = new System.Drawing.Size(150, 29);
            this.cboComunaProf.TabIndex = 18;
            this.cboComunaProf.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(335, 76);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(79, 19);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "Contraseña ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(335, 42);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(53, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Usuario";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(4, 243);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(59, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Comuna";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(147, 198);
            this.dtpFecha.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 29);
            this.dtpFecha.TabIndex = 14;
            this.dtpFecha.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // txtFono
            // 
            // 
            // 
            // 
            this.txtFono.CustomButton.Image = null;
            this.txtFono.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtFono.CustomButton.Name = "";
            this.txtFono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFono.CustomButton.TabIndex = 1;
            this.txtFono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFono.CustomButton.UseSelectable = true;
            this.txtFono.CustomButton.Visible = false;
            this.txtFono.Lines = new string[0];
            this.txtFono.Location = new System.Drawing.Point(147, 169);
            this.txtFono.MaxLength = 32767;
            this.txtFono.Name = "txtFono";
            this.txtFono.PasswordChar = '\0';
            this.txtFono.PromptText = "+569....";
            this.txtFono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFono.SelectedText = "";
            this.txtFono.SelectionLength = 0;
            this.txtFono.SelectionStart = 0;
            this.txtFono.ShortcutsEnabled = true;
            this.txtFono.Size = new System.Drawing.Size(167, 23);
            this.txtFono.TabIndex = 13;
            this.txtFono.UseSelectable = true;
            this.txtFono.WaterMark = "+569....";
            this.txtFono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApellidoM
            // 
            // 
            // 
            // 
            this.txtApellidoM.CustomButton.Image = null;
            this.txtApellidoM.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtApellidoM.CustomButton.Name = "";
            this.txtApellidoM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellidoM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellidoM.CustomButton.TabIndex = 1;
            this.txtApellidoM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellidoM.CustomButton.UseSelectable = true;
            this.txtApellidoM.CustomButton.Visible = false;
            this.txtApellidoM.Lines = new string[0];
            this.txtApellidoM.Location = new System.Drawing.Point(147, 139);
            this.txtApellidoM.MaxLength = 32767;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.PasswordChar = '\0';
            this.txtApellidoM.PromptText = "Ingrese Apellido Materno";
            this.txtApellidoM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellidoM.SelectedText = "";
            this.txtApellidoM.SelectionLength = 0;
            this.txtApellidoM.SelectionStart = 0;
            this.txtApellidoM.ShortcutsEnabled = true;
            this.txtApellidoM.Size = new System.Drawing.Size(167, 23);
            this.txtApellidoM.TabIndex = 12;
            this.txtApellidoM.UseSelectable = true;
            this.txtApellidoM.WaterMark = "Ingrese Apellido Materno";
            this.txtApellidoM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellidoM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApellidoP
            // 
            // 
            // 
            // 
            this.txtApellidoP.CustomButton.Image = null;
            this.txtApellidoP.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtApellidoP.CustomButton.Name = "";
            this.txtApellidoP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellidoP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellidoP.CustomButton.TabIndex = 1;
            this.txtApellidoP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellidoP.CustomButton.UseSelectable = true;
            this.txtApellidoP.CustomButton.Visible = false;
            this.txtApellidoP.Lines = new string[0];
            this.txtApellidoP.Location = new System.Drawing.Point(147, 107);
            this.txtApellidoP.MaxLength = 32767;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.PasswordChar = '\0';
            this.txtApellidoP.PromptText = "Ingrese Apellido Paterno";
            this.txtApellidoP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellidoP.SelectedText = "";
            this.txtApellidoP.SelectionLength = 0;
            this.txtApellidoP.SelectionStart = 0;
            this.txtApellidoP.ShortcutsEnabled = true;
            this.txtApellidoP.Size = new System.Drawing.Size(167, 23);
            this.txtApellidoP.TabIndex = 11;
            this.txtApellidoP.UseSelectable = true;
            this.txtApellidoP.WaterMark = "Ingrese Apellido Paterno";
            this.txtApellidoP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellidoP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(147, 76);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Ingrese Nombre Profesional";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(167, 23);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Ingrese Nombre Profesional";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRut
            // 
            // 
            // 
            // 
            this.txtRut.CustomButton.Image = null;
            this.txtRut.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtRut.CustomButton.Name = "";
            this.txtRut.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRut.CustomButton.TabIndex = 1;
            this.txtRut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRut.CustomButton.UseSelectable = true;
            this.txtRut.CustomButton.Visible = false;
            this.txtRut.Lines = new string[0];
            this.txtRut.Location = new System.Drawing.Point(147, 42);
            this.txtRut.MaxLength = 32767;
            this.txtRut.Name = "txtRut";
            this.txtRut.PasswordChar = '\0';
            this.txtRut.PromptText = "X.XXX.XXX-X";
            this.txtRut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRut.SelectedText = "";
            this.txtRut.SelectionLength = 0;
            this.txtRut.SelectionStart = 0;
            this.txtRut.ShortcutsEnabled = true;
            this.txtRut.Size = new System.Drawing.Size(167, 23);
            this.txtRut.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtRut.TabIndex = 9;
            this.txtRut.UseSelectable = true;
            this.txtRut.WaterMark = "X.XXX.XXX-X";
            this.txtRut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 202);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(133, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Fecha de Nacimiento";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 169);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Telefono";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 139);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(112, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Apellido Materno";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 107);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Apellido Paterno";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(182, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Agregar Profesional";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(28, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Rut";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Nombre";
            // 
            // tpListProf
            // 
            this.tpListProf.Controls.Add(this.metroLabel11);
            this.tpListProf.Controls.Add(this.txtParamProf);
            this.tpListProf.Controls.Add(this.btnBuscarProf);
            this.tpListProf.Controls.Add(this.grdProfesional);
            this.tpListProf.HorizontalScrollbarBarColor = true;
            this.tpListProf.HorizontalScrollbarHighlightOnWheel = false;
            this.tpListProf.HorizontalScrollbarSize = 10;
            this.tpListProf.Location = new System.Drawing.Point(4, 38);
            this.tpListProf.Name = "tpListProf";
            this.tpListProf.Size = new System.Drawing.Size(563, 313);
            this.tpListProf.TabIndex = 1;
            this.tpListProf.VerticalScrollbarBarColor = true;
            this.tpListProf.VerticalScrollbarHighlightOnWheel = false;
            this.tpListProf.VerticalScrollbarSize = 10;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(75, 14);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(66, 19);
            this.metroLabel11.TabIndex = 5;
            this.metroLabel11.Text = "Busqueda";
            // 
            // txtParamProf
            // 
            // 
            // 
            // 
            this.txtParamProf.CustomButton.Image = null;
            this.txtParamProf.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.txtParamProf.CustomButton.Name = "";
            this.txtParamProf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtParamProf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtParamProf.CustomButton.TabIndex = 1;
            this.txtParamProf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtParamProf.CustomButton.UseSelectable = true;
            this.txtParamProf.CustomButton.Visible = false;
            this.txtParamProf.Lines = new string[0];
            this.txtParamProf.Location = new System.Drawing.Point(147, 10);
            this.txtParamProf.MaxLength = 32767;
            this.txtParamProf.Name = "txtParamProf";
            this.txtParamProf.PasswordChar = '\0';
            this.txtParamProf.PromptText = "Nombre, Apellido, Telefono";
            this.txtParamProf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtParamProf.SelectedText = "";
            this.txtParamProf.SelectionLength = 0;
            this.txtParamProf.SelectionStart = 0;
            this.txtParamProf.ShortcutsEnabled = true;
            this.txtParamProf.Size = new System.Drawing.Size(266, 23);
            this.txtParamProf.TabIndex = 4;
            this.txtParamProf.UseSelectable = true;
            this.txtParamProf.WaterMark = "Nombre, Apellido, Telefono";
            this.txtParamProf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtParamProf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscarProf
            // 
            this.btnBuscarProf.Location = new System.Drawing.Point(419, 10);
            this.btnBuscarProf.Name = "btnBuscarProf";
            this.btnBuscarProf.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProf.TabIndex = 3;
            this.btnBuscarProf.Text = "Buscar";
            this.btnBuscarProf.UseSelectable = true;
            this.btnBuscarProf.Click += new System.EventHandler(this.btnBuscarProf_Click);
            // 
            // grdProfesional
            // 
            this.grdProfesional.AllowUserToResizeRows = false;
            this.grdProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProfesional.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProfesional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProfesional.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdProfesional.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProfesional.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProfesional.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdProfesional.EnableHeadersVisualStyles = false;
            this.grdProfesional.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdProfesional.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProfesional.Location = new System.Drawing.Point(0, 39);
            this.grdProfesional.Name = "grdProfesional";
            this.grdProfesional.ReadOnly = true;
            this.grdProfesional.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProfesional.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProfesional.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProfesional.Size = new System.Drawing.Size(570, 236);
            this.grdProfesional.Style = MetroFramework.MetroColorStyle.Green;
            this.grdProfesional.TabIndex = 2;
            this.grdProfesional.UseStyleColors = true;
            // 
            // tpModProf
            // 
            this.tpModProf.HorizontalScrollbarBarColor = true;
            this.tpModProf.HorizontalScrollbarHighlightOnWheel = false;
            this.tpModProf.HorizontalScrollbarSize = 10;
            this.tpModProf.Location = new System.Drawing.Point(4, 38);
            this.tpModProf.Name = "tpModProf";
            this.tpModProf.Size = new System.Drawing.Size(563, 313);
            this.tpModProf.TabIndex = 2;
            this.tpModProf.VerticalScrollbarBarColor = true;
            this.tpModProf.VerticalScrollbarHighlightOnWheel = false;
            this.tpModProf.VerticalScrollbarSize = 10;
            // 
            // MantenedorProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcProfesional);
            this.Name = "MantenedorProfesional";
            this.Size = new System.Drawing.Size(580, 372);
            this.panel1.ResumeLayout(false);
            this.tcProfesional.ResumeLayout(false);
            this.tpAddProf.ResumeLayout(false);
            this.tpAddProf.PerformLayout();
            this.tpListProf.ResumeLayout(false);
            this.tpListProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAddProf;
        private MetroFramework.Controls.MetroButton btnListProf;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl tcProfesional;
        private MetroFramework.Controls.MetroTabPage tpAddProf;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage tpListProf;
        private MetroFramework.Controls.MetroTabPage tpModProf;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid grdProfesional;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroComboBox cboComunaProf;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime dtpFecha;
        private MetroFramework.Controls.MetroTextBox txtFono;
        private MetroFramework.Controls.MetroTextBox txtApellidoM;
        private MetroFramework.Controls.MetroTextBox txtApellidoP;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtRut;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnGuardarProf;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtParamProf;
        private MetroFramework.Controls.MetroButton btnBuscarProf;
    }
}
