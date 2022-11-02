namespace NoMasAcc2._0.atrasos
{
    partial class MantenedorAtrasos
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
            this.btnNotAtraso = new MetroFramework.Controls.MetroButton();
            this.btnQuitServ = new MetroFramework.Controls.MetroButton();
            this.grdAtrasos = new MetroFramework.Controls.MetroGrid();
            this.btnRestServ = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAtrasos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnRestServ);
            this.panel1.Controls.Add(this.btnNotAtraso);
            this.panel1.Controls.Add(this.btnQuitServ);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 7;
            // 
            // btnNotAtraso
            // 
            this.btnNotAtraso.Location = new System.Drawing.Point(7, 6);
            this.btnNotAtraso.Name = "btnNotAtraso";
            this.btnNotAtraso.Size = new System.Drawing.Size(182, 37);
            this.btnNotAtraso.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNotAtraso.TabIndex = 1;
            this.btnNotAtraso.Text = "Notificar Atraso";
            this.btnNotAtraso.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNotAtraso.UseSelectable = true;
            this.btnNotAtraso.UseStyleColors = true;
            this.btnNotAtraso.Click += new System.EventHandler(this.btnNotAtraso_Click);
            // 
            // btnQuitServ
            // 
            this.btnQuitServ.Location = new System.Drawing.Point(195, 6);
            this.btnQuitServ.Name = "btnQuitServ";
            this.btnQuitServ.Size = new System.Drawing.Size(175, 37);
            this.btnQuitServ.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnQuitServ.TabIndex = 0;
            this.btnQuitServ.Text = "Quitar Servicio";
            this.btnQuitServ.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnQuitServ.UseSelectable = true;
            this.btnQuitServ.UseStyleColors = true;
            this.btnQuitServ.Click += new System.EventHandler(this.btnQuitServ_Click);
            // 
            // grdAtrasos
            // 
            this.grdAtrasos.AllowUserToResizeRows = false;
            this.grdAtrasos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAtrasos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAtrasos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAtrasos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdAtrasos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAtrasos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAtrasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAtrasos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdAtrasos.EnableHeadersVisualStyles = false;
            this.grdAtrasos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdAtrasos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAtrasos.Location = new System.Drawing.Point(10, 60);
            this.grdAtrasos.Name = "grdAtrasos";
            this.grdAtrasos.ReadOnly = true;
            this.grdAtrasos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAtrasos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdAtrasos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdAtrasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAtrasos.Size = new System.Drawing.Size(567, 284);
            this.grdAtrasos.Style = MetroFramework.MetroColorStyle.Green;
            this.grdAtrasos.TabIndex = 8;
            this.grdAtrasos.UseStyleColors = true;
            // 
            // btnRestServ
            // 
            this.btnRestServ.Location = new System.Drawing.Point(376, 6);
            this.btnRestServ.Name = "btnRestServ";
            this.btnRestServ.Size = new System.Drawing.Size(177, 37);
            this.btnRestServ.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRestServ.TabIndex = 2;
            this.btnRestServ.Text = "Restablecer Servicio";
            this.btnRestServ.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRestServ.UseSelectable = true;
            this.btnRestServ.UseStyleColors = true;
            this.btnRestServ.Click += new System.EventHandler(this.btnRestServ_Click);
            // 
            // MantenedorAtrasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdAtrasos);
            this.Controls.Add(this.panel1);
            this.Name = "MantenedorAtrasos";
            this.Size = new System.Drawing.Size(580, 372);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAtrasos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnQuitServ;
        private MetroFramework.Controls.MetroGrid grdAtrasos;
        private MetroFramework.Controls.MetroButton btnNotAtraso;
        private MetroFramework.Controls.MetroButton btnRestServ;
    }
}
