namespace NoMasAcc2._0.plan
{
    partial class MantenedorPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPlan = new MetroFramework.Controls.MetroButton();
            this.btnListPlan = new MetroFramework.Controls.MetroButton();
            this.tcPlan = new MetroFramework.Controls.MetroTabControl();
            this.tpAddPlan = new MetroFramework.Controls.MetroTabPage();
            this.dpVisita2 = new MetroFramework.Controls.MetroDateTime();
            this.dpVisita = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtRutProf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardarPlan = new MetroFramework.Controls.MetroButton();
            this.txtPrec = new MetroFramework.Controls.MetroTextBox();
            this.txtNomProf = new MetroFramework.Controls.MetroTextBox();
            this.txtRutCli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tpListPlan = new MetroFramework.Controls.MetroTabPage();
            this.txtParamPlan = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscarPlan = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.grdPlan = new MetroFramework.Controls.MetroGrid();
            this.txtNomCli = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.tcPlan.SuspendLayout();
            this.tpAddPlan.SuspendLayout();
            this.tpListPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnAddPlan);
            this.panel1.Controls.Add(this.btnListPlan);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 8;
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.Location = new System.Drawing.Point(7, 6);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(182, 37);
            this.btnAddPlan.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddPlan.TabIndex = 0;
            this.btnAddPlan.Text = "Ingresar Plan";
            this.btnAddPlan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddPlan.UseSelectable = true;
            this.btnAddPlan.UseStyleColors = true;
            this.btnAddPlan.Click += new System.EventHandler(this.btnAddPlan_Click);
            // 
            // btnListPlan
            // 
            this.btnListPlan.Location = new System.Drawing.Point(195, 6);
            this.btnListPlan.Name = "btnListPlan";
            this.btnListPlan.Size = new System.Drawing.Size(185, 37);
            this.btnListPlan.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnListPlan.TabIndex = 4;
            this.btnListPlan.Text = "Listar";
            this.btnListPlan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnListPlan.UseSelectable = true;
            this.btnListPlan.UseStyleColors = true;
            this.btnListPlan.Click += new System.EventHandler(this.btnListPlan_Click);
            // 
            // tcPlan
            // 
            this.tcPlan.Controls.Add(this.tpAddPlan);
            this.tcPlan.Controls.Add(this.tpListPlan);
            this.tcPlan.Location = new System.Drawing.Point(5, 9);
            this.tcPlan.Name = "tcPlan";
            this.tcPlan.SelectedIndex = 0;
            this.tcPlan.Size = new System.Drawing.Size(571, 357);
            this.tcPlan.TabIndex = 9;
            this.tcPlan.UseSelectable = true;
            // 
            // tpAddPlan
            // 
            this.tpAddPlan.Controls.Add(this.txtNomCli);
            this.tpAddPlan.Controls.Add(this.dpVisita2);
            this.tpAddPlan.Controls.Add(this.dpVisita);
            this.tpAddPlan.Controls.Add(this.metroLabel8);
            this.tpAddPlan.Controls.Add(this.txtRutProf);
            this.tpAddPlan.Controls.Add(this.metroLabel13);
            this.tpAddPlan.Controls.Add(this.btnGuardarPlan);
            this.tpAddPlan.Controls.Add(this.txtPrec);
            this.tpAddPlan.Controls.Add(this.txtNomProf);
            this.tpAddPlan.Controls.Add(this.txtRutCli);
            this.tpAddPlan.Controls.Add(this.metroLabel6);
            this.tpAddPlan.Controls.Add(this.metroLabel5);
            this.tpAddPlan.Controls.Add(this.metroLabel4);
            this.tpAddPlan.Controls.Add(this.metroLabel2);
            this.tpAddPlan.Controls.Add(this.metroLabel1);
            this.tpAddPlan.Controls.Add(this.metroLabel3);
            this.tpAddPlan.HorizontalScrollbarBarColor = true;
            this.tpAddPlan.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAddPlan.HorizontalScrollbarSize = 10;
            this.tpAddPlan.Location = new System.Drawing.Point(4, 38);
            this.tpAddPlan.Name = "tpAddPlan";
            this.tpAddPlan.Size = new System.Drawing.Size(563, 315);
            this.tpAddPlan.TabIndex = 0;
            this.tpAddPlan.VerticalScrollbarBarColor = true;
            this.tpAddPlan.VerticalScrollbarHighlightOnWheel = false;
            this.tpAddPlan.VerticalScrollbarSize = 10;
            // 
            // dpVisita2
            // 
            this.dpVisita2.Location = new System.Drawing.Point(147, 174);
            this.dpVisita2.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpVisita2.Name = "dpVisita2";
            this.dpVisita2.Size = new System.Drawing.Size(135, 29);
            this.dpVisita2.TabIndex = 30;
            // 
            // dpVisita
            // 
            this.dpVisita.Location = new System.Drawing.Point(147, 139);
            this.dpVisita.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpVisita.Name = "dpVisita";
            this.dpVisita.Size = new System.Drawing.Size(135, 29);
            this.dpVisita.TabIndex = 29;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(246, 42);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(103, 19);
            this.metroLabel8.TabIndex = 28;
            this.metroLabel8.Text = "Nombre Cliente";
            // 
            // txtRutProf
            // 
            // 
            // 
            // 
            this.txtRutProf.CustomButton.Image = null;
            this.txtRutProf.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.txtRutProf.CustomButton.Name = "";
            this.txtRutProf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRutProf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRutProf.CustomButton.TabIndex = 1;
            this.txtRutProf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRutProf.CustomButton.UseSelectable = true;
            this.txtRutProf.CustomButton.Visible = false;
            this.txtRutProf.Lines = new string[0];
            this.txtRutProf.Location = new System.Drawing.Point(147, 78);
            this.txtRutProf.MaxLength = 32767;
            this.txtRutProf.Name = "txtRutProf";
            this.txtRutProf.PasswordChar = '\0';
            this.txtRutProf.PromptText = "X.XXX.XXX-X";
            this.txtRutProf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRutProf.SelectedText = "";
            this.txtRutProf.SelectionLength = 0;
            this.txtRutProf.SelectionStart = 0;
            this.txtRutProf.ShortcutsEnabled = true;
            this.txtRutProf.Size = new System.Drawing.Size(88, 23);
            this.txtRutProf.TabIndex = 27;
            this.txtRutProf.UseSelectable = true;
            this.txtRutProf.WaterMark = "X.XXX.XXX-X";
            this.txtRutProf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRutProf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRutProf.Leave += new System.EventHandler(this.txtRutProf_Leave);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(3, 80);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(97, 19);
            this.metroLabel13.TabIndex = 26;
            this.metroLabel13.Text = "Rut Profesional";
            // 
            // btnGuardarPlan
            // 
            this.btnGuardarPlan.Location = new System.Drawing.Point(189, 283);
            this.btnGuardarPlan.Name = "btnGuardarPlan";
            this.btnGuardarPlan.Size = new System.Drawing.Size(218, 29);
            this.btnGuardarPlan.TabIndex = 25;
            this.btnGuardarPlan.Text = "Guardar Plan";
            this.btnGuardarPlan.UseSelectable = true;
            this.btnGuardarPlan.Click += new System.EventHandler(this.btnGuardarPlan_Click);
            // 
            // txtPrec
            // 
            // 
            // 
            // 
            this.txtPrec.CustomButton.Image = null;
            this.txtPrec.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtPrec.CustomButton.Name = "";
            this.txtPrec.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrec.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrec.CustomButton.TabIndex = 1;
            this.txtPrec.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrec.CustomButton.UseSelectable = true;
            this.txtPrec.CustomButton.Visible = false;
            this.txtPrec.Lines = new string[0];
            this.txtPrec.Location = new System.Drawing.Point(147, 107);
            this.txtPrec.MaxLength = 32767;
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.PasswordChar = '\0';
            this.txtPrec.PromptText = "Ingrese Precio";
            this.txtPrec.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrec.SelectedText = "";
            this.txtPrec.SelectionLength = 0;
            this.txtPrec.SelectionStart = 0;
            this.txtPrec.ShortcutsEnabled = true;
            this.txtPrec.Size = new System.Drawing.Size(135, 23);
            this.txtPrec.TabIndex = 11;
            this.txtPrec.UseSelectable = true;
            this.txtPrec.WaterMark = "Ingrese Precio";
            this.txtPrec.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrec.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrec_KeyPress);
            // 
            // txtNomProf
            // 
            // 
            // 
            // 
            this.txtNomProf.CustomButton.Image = null;
            this.txtNomProf.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtNomProf.CustomButton.Name = "";
            this.txtNomProf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomProf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomProf.CustomButton.TabIndex = 1;
            this.txtNomProf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomProf.CustomButton.UseSelectable = true;
            this.txtNomProf.CustomButton.Visible = false;
            this.txtNomProf.Enabled = false;
            this.txtNomProf.Lines = new string[0];
            this.txtNomProf.Location = new System.Drawing.Point(371, 76);
            this.txtNomProf.MaxLength = 32767;
            this.txtNomProf.Name = "txtNomProf";
            this.txtNomProf.PasswordChar = '\0';
            this.txtNomProf.PromptText = "Nombre Profesional";
            this.txtNomProf.ReadOnly = true;
            this.txtNomProf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomProf.SelectedText = "";
            this.txtNomProf.SelectionLength = 0;
            this.txtNomProf.SelectionStart = 0;
            this.txtNomProf.ShortcutsEnabled = true;
            this.txtNomProf.Size = new System.Drawing.Size(188, 23);
            this.txtNomProf.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtNomProf.TabIndex = 10;
            this.txtNomProf.UseSelectable = true;
            this.txtNomProf.UseStyleColors = true;
            this.txtNomProf.WaterMark = "Nombre Profesional";
            this.txtNomProf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomProf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRutCli
            // 
            // 
            // 
            // 
            this.txtRutCli.CustomButton.Image = null;
            this.txtRutCli.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.txtRutCli.CustomButton.Name = "";
            this.txtRutCli.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRutCli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRutCli.CustomButton.TabIndex = 1;
            this.txtRutCli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRutCli.CustomButton.UseSelectable = true;
            this.txtRutCli.CustomButton.Visible = false;
            this.txtRutCli.Lines = new string[0];
            this.txtRutCli.Location = new System.Drawing.Point(147, 42);
            this.txtRutCli.MaxLength = 32767;
            this.txtRutCli.Name = "txtRutCli";
            this.txtRutCli.PasswordChar = '\0';
            this.txtRutCli.PromptText = "X.XXX.XXX-X";
            this.txtRutCli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRutCli.SelectedText = "";
            this.txtRutCli.SelectionLength = 0;
            this.txtRutCli.SelectionStart = 0;
            this.txtRutCli.ShortcutsEnabled = true;
            this.txtRutCli.Size = new System.Drawing.Size(88, 23);
            this.txtRutCli.TabIndex = 9;
            this.txtRutCli.UseSelectable = true;
            this.txtRutCli.WaterMark = "X.XXX.XXX-X";
            this.txtRutCli.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRutCli.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRutCli.Leave += new System.EventHandler(this.txtRutCli_Leave);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 174);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(94, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Segunda Visita";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 139);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Primera Visita";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 107);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Precio";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Ingresar Plan";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Rut Cliente";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(246, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Nombre Profesional";
            // 
            // tpListPlan
            // 
            this.tpListPlan.Controls.Add(this.txtParamPlan);
            this.tpListPlan.Controls.Add(this.btnBuscarPlan);
            this.tpListPlan.Controls.Add(this.metroLabel7);
            this.tpListPlan.Controls.Add(this.grdPlan);
            this.tpListPlan.HorizontalScrollbarBarColor = true;
            this.tpListPlan.HorizontalScrollbarHighlightOnWheel = false;
            this.tpListPlan.HorizontalScrollbarSize = 10;
            this.tpListPlan.Location = new System.Drawing.Point(4, 38);
            this.tpListPlan.Name = "tpListPlan";
            this.tpListPlan.Size = new System.Drawing.Size(563, 315);
            this.tpListPlan.TabIndex = 1;
            this.tpListPlan.VerticalScrollbarBarColor = true;
            this.tpListPlan.VerticalScrollbarHighlightOnWheel = false;
            this.tpListPlan.VerticalScrollbarSize = 10;
            // 
            // txtParamPlan
            // 
            // 
            // 
            // 
            this.txtParamPlan.CustomButton.Image = null;
            this.txtParamPlan.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtParamPlan.CustomButton.Name = "";
            this.txtParamPlan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtParamPlan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtParamPlan.CustomButton.TabIndex = 1;
            this.txtParamPlan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtParamPlan.CustomButton.UseSelectable = true;
            this.txtParamPlan.CustomButton.Visible = false;
            this.txtParamPlan.Lines = new string[0];
            this.txtParamPlan.Location = new System.Drawing.Point(119, 13);
            this.txtParamPlan.MaxLength = 32767;
            this.txtParamPlan.Name = "txtParamPlan";
            this.txtParamPlan.PasswordChar = '\0';
            this.txtParamPlan.PromptText = "Nombre, Apellido, Fecha";
            this.txtParamPlan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtParamPlan.SelectedText = "";
            this.txtParamPlan.SelectionLength = 0;
            this.txtParamPlan.SelectionStart = 0;
            this.txtParamPlan.ShortcutsEnabled = true;
            this.txtParamPlan.Size = new System.Drawing.Size(220, 23);
            this.txtParamPlan.TabIndex = 7;
            this.txtParamPlan.UseSelectable = true;
            this.txtParamPlan.WaterMark = "Nombre, Apellido, Fecha";
            this.txtParamPlan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtParamPlan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscarPlan
            // 
            this.btnBuscarPlan.Location = new System.Drawing.Point(345, 10);
            this.btnBuscarPlan.Name = "btnBuscarPlan";
            this.btnBuscarPlan.Size = new System.Drawing.Size(98, 32);
            this.btnBuscarPlan.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBuscarPlan.TabIndex = 5;
            this.btnBuscarPlan.Text = "Buscar";
            this.btnBuscarPlan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBuscarPlan.UseSelectable = true;
            this.btnBuscarPlan.UseStyleColors = true;
            this.btnBuscarPlan.Click += new System.EventHandler(this.btnBuscarPlan_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(47, 17);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Busqueda";
            // 
            // grdPlan
            // 
            this.grdPlan.AllowUserToResizeRows = false;
            this.grdPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPlan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPlan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grdPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPlan.DefaultCellStyle = dataGridViewCellStyle14;
            this.grdPlan.EnableHeadersVisualStyles = false;
            this.grdPlan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPlan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPlan.Location = new System.Drawing.Point(0, 52);
            this.grdPlan.Name = "grdPlan";
            this.grdPlan.ReadOnly = true;
            this.grdPlan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grdPlan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPlan.Size = new System.Drawing.Size(570, 223);
            this.grdPlan.Style = MetroFramework.MetroColorStyle.Green;
            this.grdPlan.TabIndex = 2;
            this.grdPlan.UseStyleColors = true;
            // 
            // txtNomCli
            // 
            // 
            // 
            // 
            this.txtNomCli.CustomButton.Image = null;
            this.txtNomCli.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtNomCli.CustomButton.Name = "";
            this.txtNomCli.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomCli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomCli.CustomButton.TabIndex = 1;
            this.txtNomCli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomCli.CustomButton.UseSelectable = true;
            this.txtNomCli.CustomButton.Visible = false;
            this.txtNomCli.Enabled = false;
            this.txtNomCli.Lines = new string[0];
            this.txtNomCli.Location = new System.Drawing.Point(371, 38);
            this.txtNomCli.MaxLength = 32767;
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.PasswordChar = '\0';
            this.txtNomCli.PromptText = "Nombre Cliente";
            this.txtNomCli.ReadOnly = true;
            this.txtNomCli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomCli.SelectedText = "";
            this.txtNomCli.SelectionLength = 0;
            this.txtNomCli.SelectionStart = 0;
            this.txtNomCli.ShortcutsEnabled = true;
            this.txtNomCli.Size = new System.Drawing.Size(188, 23);
            this.txtNomCli.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtNomCli.TabIndex = 31;
            this.txtNomCli.UseSelectable = true;
            this.txtNomCli.UseStyleColors = true;
            this.txtNomCli.WaterMark = "Nombre Cliente";
            this.txtNomCli.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomCli.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MantenedorPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcPlan);
            this.Name = "MantenedorPlan";
            this.Size = new System.Drawing.Size(580, 372);
            this.panel1.ResumeLayout(false);
            this.tcPlan.ResumeLayout(false);
            this.tpAddPlan.ResumeLayout(false);
            this.tpAddPlan.PerformLayout();
            this.tpListPlan.ResumeLayout(false);
            this.tpListPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnAddPlan;
        private MetroFramework.Controls.MetroButton btnListPlan;
        private MetroFramework.Controls.MetroTabControl tcPlan;
        private MetroFramework.Controls.MetroTabPage tpAddPlan;
        private MetroFramework.Controls.MetroButton btnGuardarPlan;
        private MetroFramework.Controls.MetroTextBox txtPrec;
        private MetroFramework.Controls.MetroTextBox txtNomProf;
        private MetroFramework.Controls.MetroTextBox txtRutCli;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTabPage tpListPlan;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid grdPlan;
        private MetroFramework.Controls.MetroButton btnBuscarPlan;
        private MetroFramework.Controls.MetroDateTime dpVisita2;
        private MetroFramework.Controls.MetroDateTime dpVisita;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtRutProf;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtParamPlan;
        private MetroFramework.Controls.MetroTextBox txtNomCli;
    }
}
