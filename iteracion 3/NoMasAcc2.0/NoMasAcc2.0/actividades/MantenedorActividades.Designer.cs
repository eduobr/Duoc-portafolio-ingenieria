namespace NoMasAcc2._0.actividades
{
    partial class MantenedorActividades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLstCheck = new MetroFramework.Controls.MetroButton();
            this.btnCapacitaciones = new MetroFramework.Controls.MetroButton();
            this.btnVisitas = new MetroFramework.Controls.MetroButton();
            this.grdActividades = new MetroFramework.Controls.MetroGrid();
            this.btnBuscarAct = new MetroFramework.Controls.MetroButton();
            this.txtBuscAct = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAtras = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnLstCheck);
            this.panel1.Controls.Add(this.btnCapacitaciones);
            this.panel1.Controls.Add(this.btnVisitas);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 10;
            // 
            // btnLstCheck
            // 
            this.btnLstCheck.Location = new System.Drawing.Point(349, 3);
            this.btnLstCheck.Name = "btnLstCheck";
            this.btnLstCheck.Size = new System.Drawing.Size(103, 45);
            this.btnLstCheck.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLstCheck.TabIndex = 12;
            this.btnLstCheck.Text = "Listar CheckList";
            this.btnLstCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLstCheck.UseSelectable = true;
            this.btnLstCheck.UseStyleColors = true;
            this.btnLstCheck.Click += new System.EventHandler(this.btnLstCheck_Click);
            // 
            // btnCapacitaciones
            // 
            this.btnCapacitaciones.Location = new System.Drawing.Point(216, 3);
            this.btnCapacitaciones.Name = "btnCapacitaciones";
            this.btnCapacitaciones.Size = new System.Drawing.Size(127, 45);
            this.btnCapacitaciones.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCapacitaciones.TabIndex = 11;
            this.btnCapacitaciones.Text = "Listar Capacitaciones";
            this.btnCapacitaciones.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCapacitaciones.UseSelectable = true;
            this.btnCapacitaciones.UseStyleColors = true;
            this.btnCapacitaciones.Click += new System.EventHandler(this.btnCapacitaciones_Click);
            // 
            // btnVisitas
            // 
            this.btnVisitas.Location = new System.Drawing.Point(104, 3);
            this.btnVisitas.Name = "btnVisitas";
            this.btnVisitas.Size = new System.Drawing.Size(106, 45);
            this.btnVisitas.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnVisitas.TabIndex = 8;
            this.btnVisitas.Text = "Listar Visitas";
            this.btnVisitas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVisitas.UseSelectable = true;
            this.btnVisitas.UseStyleColors = true;
            this.btnVisitas.Click += new System.EventHandler(this.btnVisitas_Click);
            // 
            // grdActividades
            // 
            this.grdActividades.AllowUserToResizeRows = false;
            this.grdActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdActividades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdActividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdActividades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdActividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdActividades.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdActividades.EnableHeadersVisualStyles = false;
            this.grdActividades.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdActividades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdActividades.Location = new System.Drawing.Point(3, 87);
            this.grdActividades.Name = "grdActividades";
            this.grdActividades.ReadOnly = true;
            this.grdActividades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdActividades.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdActividades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdActividades.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdActividades.Size = new System.Drawing.Size(574, 260);
            this.grdActividades.Style = MetroFramework.MetroColorStyle.Green;
            this.grdActividades.TabIndex = 11;
            this.grdActividades.UseStyleColors = true;
            this.grdActividades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdActividades_CellClick);
            // 
            // btnBuscarAct
            // 
            this.btnBuscarAct.Location = new System.Drawing.Point(366, 60);
            this.btnBuscarAct.Name = "btnBuscarAct";
            this.btnBuscarAct.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAct.TabIndex = 12;
            this.btnBuscarAct.Text = "Buscar";
            this.btnBuscarAct.UseSelectable = true;
            this.btnBuscarAct.Click += new System.EventHandler(this.btnBuscarAct_Click);
            // 
            // txtBuscAct
            // 
            // 
            // 
            // 
            this.txtBuscAct.CustomButton.Image = null;
            this.txtBuscAct.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtBuscAct.CustomButton.Name = "";
            this.txtBuscAct.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscAct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscAct.CustomButton.TabIndex = 1;
            this.txtBuscAct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscAct.CustomButton.UseSelectable = true;
            this.txtBuscAct.CustomButton.Visible = false;
            this.txtBuscAct.Lines = new string[0];
            this.txtBuscAct.Location = new System.Drawing.Point(165, 60);
            this.txtBuscAct.MaxLength = 32767;
            this.txtBuscAct.Name = "txtBuscAct";
            this.txtBuscAct.PasswordChar = '\0';
            this.txtBuscAct.PromptText = "Nombre, Apellido, Rut";
            this.txtBuscAct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscAct.SelectedText = "";
            this.txtBuscAct.SelectionLength = 0;
            this.txtBuscAct.SelectionStart = 0;
            this.txtBuscAct.ShortcutsEnabled = true;
            this.txtBuscAct.Size = new System.Drawing.Size(195, 23);
            this.txtBuscAct.TabIndex = 13;
            this.txtBuscAct.UseSelectable = true;
            this.txtBuscAct.WaterMark = "Nombre, Apellido, Rut";
            this.txtBuscAct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscAct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(93, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Busqueda";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(499, 60);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 15;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseSelectable = true;
            this.btnAtras.Visible = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // MantenedorActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtBuscAct);
            this.Controls.Add(this.btnBuscarAct);
            this.Controls.Add(this.grdActividades);
            this.Controls.Add(this.panel1);
            this.Name = "MantenedorActividades";
            this.Size = new System.Drawing.Size(580, 372);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.UseStyleColors = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnLstCheck;
        private MetroFramework.Controls.MetroButton btnCapacitaciones;
        private MetroFramework.Controls.MetroButton btnVisitas;
        private MetroFramework.Controls.MetroGrid grdActividades;
        private MetroFramework.Controls.MetroButton btnBuscarAct;
        private MetroFramework.Controls.MetroTextBox txtBuscAct;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAtras;
    }
}
