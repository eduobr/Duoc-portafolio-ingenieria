namespace NoMasAcc2._0.reporteCliente
{
    partial class MantenedorReporteCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLstCli = new MetroFramework.Controls.MetroButton();
            this.btnAddRepCli = new MetroFramework.Controls.MetroButton();
            this.btnLstRepGlo = new MetroFramework.Controls.MetroButton();
            this.grdReporteCli = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnCliPdf = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReporteCli)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnLstCli);
            this.panel1.Controls.Add(this.btnAddRepCli);
            this.panel1.Controls.Add(this.btnLstRepGlo);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 7;
            // 
            // btnLstCli
            // 
            this.btnLstCli.Location = new System.Drawing.Point(4, 6);
            this.btnLstCli.Name = "btnLstCli";
            this.btnLstCli.Size = new System.Drawing.Size(185, 37);
            this.btnLstCli.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLstCli.TabIndex = 5;
            this.btnLstCli.Text = "Listar Clientes";
            this.btnLstCli.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLstCli.UseSelectable = true;
            this.btnLstCli.UseStyleColors = true;
            this.btnLstCli.Click += new System.EventHandler(this.btnLstCli_Click);
            // 
            // btnAddRepCli
            // 
            this.btnAddRepCli.Location = new System.Drawing.Point(386, 6);
            this.btnAddRepCli.Name = "btnAddRepCli";
            this.btnAddRepCli.Size = new System.Drawing.Size(182, 37);
            this.btnAddRepCli.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddRepCli.TabIndex = 0;
            this.btnAddRepCli.Text = "Generar Reporte";
            this.btnAddRepCli.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddRepCli.UseSelectable = true;
            this.btnAddRepCli.UseStyleColors = true;
            this.btnAddRepCli.Click += new System.EventHandler(this.btnAddRepGlo_Click);
            // 
            // btnLstRepGlo
            // 
            this.btnLstRepGlo.Location = new System.Drawing.Point(195, 6);
            this.btnLstRepGlo.Name = "btnLstRepGlo";
            this.btnLstRepGlo.Size = new System.Drawing.Size(185, 37);
            this.btnLstRepGlo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLstRepGlo.TabIndex = 4;
            this.btnLstRepGlo.Text = "Listar Reportes";
            this.btnLstRepGlo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLstRepGlo.UseSelectable = true;
            this.btnLstRepGlo.UseStyleColors = true;
            this.btnLstRepGlo.Click += new System.EventHandler(this.btnLstRepGlo_Click);
            // 
            // grdReporteCli
            // 
            this.grdReporteCli.AllowUserToResizeRows = false;
            this.grdReporteCli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdReporteCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdReporteCli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdReporteCli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReporteCli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdReporteCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdReporteCli.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdReporteCli.EnableHeadersVisualStyles = false;
            this.grdReporteCli.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdReporteCli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdReporteCli.Location = new System.Drawing.Point(5, 93);
            this.grdReporteCli.Name = "grdReporteCli";
            this.grdReporteCli.ReadOnly = true;
            this.grdReporteCli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReporteCli.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdReporteCli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdReporteCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdReporteCli.Size = new System.Drawing.Size(570, 252);
            this.grdReporteCli.Style = MetroFramework.MetroColorStyle.Green;
            this.grdReporteCli.TabIndex = 8;
            this.grdReporteCli.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(110, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Busqueda";
            this.metroLabel1.Visible = false;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(182, 66);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(166, 23);
            this.metroTextBox1.TabIndex = 10;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.Visible = false;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(370, 66);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Buscar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            // 
            // btnCliPdf
            // 
            this.btnCliPdf.Enabled = false;
            this.btnCliPdf.Location = new System.Drawing.Point(491, 66);
            this.btnCliPdf.Name = "btnCliPdf";
            this.btnCliPdf.Size = new System.Drawing.Size(84, 23);
            this.btnCliPdf.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCliPdf.TabIndex = 5;
            this.btnCliPdf.Text = "Generar PDF";
            this.btnCliPdf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCliPdf.UseSelectable = true;
            this.btnCliPdf.UseStyleColors = true;
            this.btnCliPdf.Click += new System.EventHandler(this.btnCliPdf_Click);
            // 
            // MantenedorReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCliPdf);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grdReporteCli);
            this.Controls.Add(this.panel1);
            this.Name = "MantenedorReporteCliente";
            this.Size = new System.Drawing.Size(580, 372);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReporteCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnAddRepCli;
        private MetroFramework.Controls.MetroButton btnLstRepGlo;
        private MetroFramework.Controls.MetroGrid grdReporteCli;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnCliPdf;
        private MetroFramework.Controls.MetroButton btnLstCli;
    }
}
