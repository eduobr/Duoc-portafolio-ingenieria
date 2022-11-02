namespace NoMasAcc2._0.clientes
{
    partial class MantenedorCliente
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
            this.btnAddCli = new MetroFramework.Controls.MetroButton();
            this.btnListCli = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcCliente = new MetroFramework.Controls.MetroTabControl();
            this.tpAddCli = new MetroFramework.Controls.MetroTabPage();
            this.cboRubro = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardarCli = new MetroFramework.Controls.MetroButton();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.cboComunaCli = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.txtApellidoM = new MetroFramework.Controls.MetroTextBox();
            this.txtApellidoP = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtRut = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tpListCli = new MetroFramework.Controls.MetroTabPage();
            this.grdCliente = new MetroFramework.Controls.MetroGrid();
            this.tpModCli = new MetroFramework.Controls.MetroTabPage();
            this.panel1.SuspendLayout();
            this.tcCliente.SuspendLayout();
            this.tpAddCli.SuspendLayout();
            this.tpListCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCli
            // 
            this.btnAddCli.Location = new System.Drawing.Point(7, 6);
            this.btnAddCli.Name = "btnAddCli";
            this.btnAddCli.Size = new System.Drawing.Size(182, 37);
            this.btnAddCli.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddCli.TabIndex = 0;
            this.btnAddCli.Text = "Agregar";
            this.btnAddCli.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddCli.UseSelectable = true;
            this.btnAddCli.UseStyleColors = true;
            this.btnAddCli.Click += new System.EventHandler(this.btnAddCli_Click);
            // 
            // btnListCli
            // 
            this.btnListCli.Location = new System.Drawing.Point(195, 6);
            this.btnListCli.Name = "btnListCli";
            this.btnListCli.Size = new System.Drawing.Size(185, 37);
            this.btnListCli.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnListCli.TabIndex = 4;
            this.btnListCli.Text = "Listar";
            this.btnListCli.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnListCli.UseSelectable = true;
            this.btnListCli.UseStyleColors = true;
            this.btnListCli.Click += new System.EventHandler(this.btnListCli_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnAddCli);
            this.panel1.Controls.Add(this.btnListCli);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 7;
            // 
            // tcCliente
            // 
            this.tcCliente.Controls.Add(this.tpAddCli);
            this.tcCliente.Controls.Add(this.tpListCli);
            this.tcCliente.Controls.Add(this.tpModCli);
            this.tcCliente.Location = new System.Drawing.Point(5, 9);
            this.tcCliente.Name = "tcCliente";
            this.tcCliente.SelectedIndex = 0;
            this.tcCliente.Size = new System.Drawing.Size(571, 360);
            this.tcCliente.TabIndex = 8;
            this.tcCliente.UseSelectable = true;
            // 
            // tpAddCli
            // 
            this.tpAddCli.Controls.Add(this.cboRubro);
            this.tpAddCli.Controls.Add(this.metroLabel13);
            this.tpAddCli.Controls.Add(this.txtEmpresa);
            this.tpAddCli.Controls.Add(this.metroLabel7);
            this.tpAddCli.Controls.Add(this.btnGuardarCli);
            this.tpAddCli.Controls.Add(this.txtEmail);
            this.tpAddCli.Controls.Add(this.metroLabel12);
            this.tpAddCli.Controls.Add(this.txtDireccion);
            this.tpAddCli.Controls.Add(this.metroLabel11);
            this.tpAddCli.Controls.Add(this.txtPass);
            this.tpAddCli.Controls.Add(this.txtUsuario);
            this.tpAddCli.Controls.Add(this.cboComunaCli);
            this.tpAddCli.Controls.Add(this.metroLabel10);
            this.tpAddCli.Controls.Add(this.metroLabel9);
            this.tpAddCli.Controls.Add(this.metroLabel8);
            this.tpAddCli.Controls.Add(this.txtTelefono);
            this.tpAddCli.Controls.Add(this.txtApellidoM);
            this.tpAddCli.Controls.Add(this.txtApellidoP);
            this.tpAddCli.Controls.Add(this.txtNombre);
            this.tpAddCli.Controls.Add(this.txtRut);
            this.tpAddCli.Controls.Add(this.metroLabel6);
            this.tpAddCli.Controls.Add(this.metroLabel5);
            this.tpAddCli.Controls.Add(this.metroLabel4);
            this.tpAddCli.Controls.Add(this.metroLabel2);
            this.tpAddCli.Controls.Add(this.metroLabel1);
            this.tpAddCli.Controls.Add(this.metroLabel3);
            this.tpAddCli.HorizontalScrollbarBarColor = true;
            this.tpAddCli.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAddCli.HorizontalScrollbarSize = 10;
            this.tpAddCli.Location = new System.Drawing.Point(4, 38);
            this.tpAddCli.Name = "tpAddCli";
            this.tpAddCli.Size = new System.Drawing.Size(563, 318);
            this.tpAddCli.TabIndex = 0;
            this.tpAddCli.VerticalScrollbarBarColor = true;
            this.tpAddCli.VerticalScrollbarHighlightOnWheel = false;
            this.tpAddCli.VerticalScrollbarSize = 10;
            // 
            // cboRubro
            // 
            this.cboRubro.FormattingEnabled = true;
            this.cboRubro.ItemHeight = 23;
            this.cboRubro.Location = new System.Drawing.Point(401, 106);
            this.cboRubro.Name = "cboRubro";
            this.cboRubro.Size = new System.Drawing.Size(149, 29);
            this.cboRubro.TabIndex = 29;
            this.cboRubro.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(335, 111);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(45, 19);
            this.metroLabel13.TabIndex = 28;
            this.metroLabel13.Text = "Rubro";
            // 
            // txtEmpresa
            // 
            // 
            // 
            // 
            this.txtEmpresa.CustomButton.Image = null;
            this.txtEmpresa.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtEmpresa.CustomButton.Name = "";
            this.txtEmpresa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpresa.CustomButton.TabIndex = 1;
            this.txtEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpresa.CustomButton.UseSelectable = true;
            this.txtEmpresa.CustomButton.Visible = false;
            this.txtEmpresa.Lines = new string[0];
            this.txtEmpresa.Location = new System.Drawing.Point(401, 77);
            this.txtEmpresa.MaxLength = 32767;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.PasswordChar = '\0';
            this.txtEmpresa.PromptText = "Ingrese la Empresa";
            this.txtEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpresa.SelectedText = "";
            this.txtEmpresa.SelectionLength = 0;
            this.txtEmpresa.SelectionStart = 0;
            this.txtEmpresa.ShortcutsEnabled = true;
            this.txtEmpresa.Size = new System.Drawing.Size(149, 23);
            this.txtEmpresa.TabIndex = 27;
            this.txtEmpresa.UseSelectable = true;
            this.txtEmpresa.WaterMark = "Ingrese la Empresa";
            this.txtEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(335, 76);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Empresa";
            // 
            // btnGuardarCli
            // 
            this.btnGuardarCli.Location = new System.Drawing.Point(189, 286);
            this.btnGuardarCli.Name = "btnGuardarCli";
            this.btnGuardarCli.Size = new System.Drawing.Size(218, 29);
            this.btnGuardarCli.TabIndex = 25;
            this.btnGuardarCli.Text = "Guardar Cliente";
            this.btnGuardarCli.UseSelectable = true;
            this.btnGuardarCli.Click += new System.EventHandler(this.btnGuardarCli_Click);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(147, 202);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Ingrese Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(167, 23);
            this.txtEmail.TabIndex = 24;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Ingrese Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(3, 206);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(41, 19);
            this.metroLabel12.TabIndex = 23;
            this.metroLabel12.Text = "Email";
            // 
            // txtDireccion
            // 
            // 
            // 
            // 
            this.txtDireccion.CustomButton.Image = null;
            this.txtDireccion.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtDireccion.CustomButton.Name = "";
            this.txtDireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion.CustomButton.TabIndex = 1;
            this.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion.CustomButton.UseSelectable = true;
            this.txtDireccion.CustomButton.Visible = false;
            this.txtDireccion.Lines = new string[0];
            this.txtDireccion.Location = new System.Drawing.Point(147, 233);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PromptText = "Ingrese Direccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(167, 23);
            this.txtDireccion.TabIndex = 22;
            this.txtDireccion.UseSelectable = true;
            this.txtDireccion.WaterMark = "Ingrese Direccion";
            this.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 237);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(63, 19);
            this.metroLabel11.TabIndex = 21;
            this.metroLabel11.Text = "Dirección";
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(335, 190);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PromptText = "Contraseña Cliente";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(215, 23);
            this.txtPass.TabIndex = 20;
            this.txtPass.UseSelectable = true;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WaterMark = "Contraseña Cliente";
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
            this.txtUsuario.Location = new System.Drawing.Point(401, 139);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PromptText = "Usuario Cliente";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(150, 23);
            this.txtUsuario.TabIndex = 19;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMark = "Usuario Cliente";
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboComunaCli
            // 
            this.cboComunaCli.FormattingEnabled = true;
            this.cboComunaCli.ItemHeight = 23;
            this.cboComunaCli.Location = new System.Drawing.Point(400, 42);
            this.cboComunaCli.Name = "cboComunaCli";
            this.cboComunaCli.Size = new System.Drawing.Size(150, 29);
            this.cboComunaCli.TabIndex = 18;
            this.cboComunaCli.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(335, 168);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(79, 19);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "Contraseña ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(335, 143);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(53, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Usuario";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(335, 42);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(59, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Comuna";
            // 
            // txtTelefono
            // 
            // 
            // 
            // 
            this.txtTelefono.CustomButton.Image = null;
            this.txtTelefono.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtTelefono.CustomButton.Name = "";
            this.txtTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefono.CustomButton.TabIndex = 1;
            this.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefono.CustomButton.UseSelectable = true;
            this.txtTelefono.CustomButton.Visible = false;
            this.txtTelefono.Lines = new string[0];
            this.txtTelefono.Location = new System.Drawing.Point(147, 169);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PromptText = "+569....";
            this.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(167, 23);
            this.txtTelefono.TabIndex = 13;
            this.txtTelefono.UseSelectable = true;
            this.txtTelefono.WaterMark = "+569....";
            this.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtNombre.PromptText = "Ingrese Nombre Cliente";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(167, 23);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Ingrese Nombre Cliente";
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
            this.txtRut.TabIndex = 9;
            this.txtRut.UseSelectable = true;
            this.txtRut.WaterMark = "X.XXX.XXX-X";
            this.txtRut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroLabel2.Size = new System.Drawing.Size(145, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Agregar Cliente";
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
            // tpListCli
            // 
            this.tpListCli.Controls.Add(this.grdCliente);
            this.tpListCli.HorizontalScrollbarBarColor = true;
            this.tpListCli.HorizontalScrollbarHighlightOnWheel = false;
            this.tpListCli.HorizontalScrollbarSize = 10;
            this.tpListCli.Location = new System.Drawing.Point(4, 38);
            this.tpListCli.Name = "tpListCli";
            this.tpListCli.Size = new System.Drawing.Size(563, 318);
            this.tpListCli.TabIndex = 1;
            this.tpListCli.VerticalScrollbarBarColor = true;
            this.tpListCli.VerticalScrollbarHighlightOnWheel = false;
            this.tpListCli.VerticalScrollbarSize = 10;
            // 
            // grdCliente
            // 
            this.grdCliente.AllowUserToAddRows = false;
            this.grdCliente.AllowUserToDeleteRows = false;
            this.grdCliente.AllowUserToResizeColumns = false;
            this.grdCliente.AllowUserToResizeRows = false;
            this.grdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdCliente.EnableHeadersVisualStyles = false;
            this.grdCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCliente.Location = new System.Drawing.Point(0, 8);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCliente.Size = new System.Drawing.Size(570, 267);
            this.grdCliente.Style = MetroFramework.MetroColorStyle.Green;
            this.grdCliente.TabIndex = 2;
            this.grdCliente.UseStyleColors = true;
            // 
            // tpModCli
            // 
            this.tpModCli.HorizontalScrollbarBarColor = true;
            this.tpModCli.HorizontalScrollbarHighlightOnWheel = false;
            this.tpModCli.HorizontalScrollbarSize = 10;
            this.tpModCli.Location = new System.Drawing.Point(4, 38);
            this.tpModCli.Name = "tpModCli";
            this.tpModCli.Size = new System.Drawing.Size(563, 318);
            this.tpModCli.TabIndex = 2;
            this.tpModCli.VerticalScrollbarBarColor = true;
            this.tpModCli.VerticalScrollbarHighlightOnWheel = false;
            this.tpModCli.VerticalScrollbarSize = 10;
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcCliente);
            this.Name = "MantenedorCliente";
            this.Size = new System.Drawing.Size(580, 372);
            this.panel1.ResumeLayout(false);
            this.tcCliente.ResumeLayout(false);
            this.tpAddCli.ResumeLayout(false);
            this.tpAddCli.PerformLayout();
            this.tpListCli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAddCli;
        private MetroFramework.Controls.MetroButton btnListCli;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl tcCliente;
        private MetroFramework.Controls.MetroTabPage tpAddCli;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroComboBox cboComunaCli;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtTelefono;
        private MetroFramework.Controls.MetroTextBox txtApellidoM;
        private MetroFramework.Controls.MetroTextBox txtApellidoP;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtRut;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTabPage tpListCli;
        private MetroFramework.Controls.MetroGrid grdCliente;
        private MetroFramework.Controls.MetroTabPage tpModCli;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton btnGuardarCli;
        private MetroFramework.Controls.MetroTextBox txtEmpresa;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cboRubro;
        private MetroFramework.Controls.MetroLabel metroLabel13;
    }
}
