namespace NoMasAcc2._0.accidentes
{
    partial class MantenedorAccidentes
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtParamAcc = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscarAcc = new MetroFramework.Controls.MetroButton();
            this.grdAccidentes = new MetroFramework.Controls.MetroGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccidentes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.txtParamAcc);
            this.panel1.Controls.Add(this.btnBuscarAcc);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Busqueda";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtParamAcc
            // 
            // 
            // 
            // 
            this.txtParamAcc.CustomButton.Image = null;
            this.txtParamAcc.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtParamAcc.CustomButton.Name = "";
            this.txtParamAcc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtParamAcc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtParamAcc.CustomButton.TabIndex = 1;
            this.txtParamAcc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtParamAcc.CustomButton.UseSelectable = true;
            this.txtParamAcc.CustomButton.Visible = false;
            this.txtParamAcc.Lines = new string[0];
            this.txtParamAcc.Location = new System.Drawing.Point(108, 15);
            this.txtParamAcc.MaxLength = 32767;
            this.txtParamAcc.Name = "txtParamAcc";
            this.txtParamAcc.PasswordChar = '\0';
            this.txtParamAcc.PromptText = "Nombre, Apellido, Rut";
            this.txtParamAcc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtParamAcc.SelectedText = "";
            this.txtParamAcc.SelectionLength = 0;
            this.txtParamAcc.SelectionStart = 0;
            this.txtParamAcc.ShortcutsEnabled = true;
            this.txtParamAcc.Size = new System.Drawing.Size(239, 23);
            this.txtParamAcc.TabIndex = 9;
            this.txtParamAcc.UseSelectable = true;
            this.txtParamAcc.WaterMark = "Nombre, Apellido, Rut";
            this.txtParamAcc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtParamAcc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscarAcc
            // 
            this.btnBuscarAcc.Location = new System.Drawing.Point(353, 1);
            this.btnBuscarAcc.Name = "btnBuscarAcc";
            this.btnBuscarAcc.Size = new System.Drawing.Size(185, 48);
            this.btnBuscarAcc.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBuscarAcc.TabIndex = 8;
            this.btnBuscarAcc.Text = "Buscar";
            this.btnBuscarAcc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBuscarAcc.UseSelectable = true;
            this.btnBuscarAcc.UseStyleColors = true;
            this.btnBuscarAcc.Click += new System.EventHandler(this.btnBuscarAcc_Click);
            // 
            // grdAccidentes
            // 
            this.grdAccidentes.AllowUserToResizeRows = false;
            this.grdAccidentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAccidentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdAccidentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAccidentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAccidentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdAccidentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccidentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdAccidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAccidentes.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdAccidentes.EnableHeadersVisualStyles = false;
            this.grdAccidentes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdAccidentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAccidentes.Location = new System.Drawing.Point(3, 60);
            this.grdAccidentes.Name = "grdAccidentes";
            this.grdAccidentes.ReadOnly = true;
            this.grdAccidentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccidentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdAccidentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccidentes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdAccidentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccidentes.Size = new System.Drawing.Size(574, 284);
            this.grdAccidentes.Style = MetroFramework.MetroColorStyle.Green;
            this.grdAccidentes.TabIndex = 10;
            this.grdAccidentes.UseStyleColors = true;
            // 
            // MantenedorAccidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdAccidentes);
            this.Controls.Add(this.panel1);
            this.Name = "MantenedorAccidentes";
            this.Size = new System.Drawing.Size(580, 372);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccidentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtParamAcc;
        private MetroFramework.Controls.MetroButton btnBuscarAcc;
        private MetroFramework.Controls.MetroGrid grdAccidentes;
    }
}
