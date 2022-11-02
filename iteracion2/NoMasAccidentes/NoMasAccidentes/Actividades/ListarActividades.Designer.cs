namespace NoMasAccidentes.Actividades
{
    partial class ListarVisitas
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
            this.btnListarCapacitaciones = new System.Windows.Forms.Button();
            this.listCapasitaciones = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListarGestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.listVisitas = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listGestion = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListarVisita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarCapacitaciones
            // 
            this.btnListarCapacitaciones.Location = new System.Drawing.Point(388, 86);
            this.btnListarCapacitaciones.Name = "btnListarCapacitaciones";
            this.btnListarCapacitaciones.Size = new System.Drawing.Size(91, 39);
            this.btnListarCapacitaciones.TabIndex = 0;
            this.btnListarCapacitaciones.Text = "Listar Capacitaciones";
            this.btnListarCapacitaciones.UseVisualStyleBackColor = true;
            this.btnListarCapacitaciones.Click += new System.EventHandler(this.btnListarCapacitaciones_Click);
            // 
            // listCapasitaciones
            // 
            this.listCapasitaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listCapasitaciones.Location = new System.Drawing.Point(34, 143);
            this.listCapasitaciones.Name = "listCapasitaciones";
            this.listCapasitaciones.Size = new System.Drawing.Size(510, 192);
            this.listCapasitaciones.TabIndex = 1;
            this.listCapasitaciones.UseCompatibleStateImageBehavior = false;
            this.listCapasitaciones.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descripcion";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantidad De Asistente";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id Plan";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 70;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(684, 22);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnListarGestion
            // 
            this.btnListarGestion.Location = new System.Drawing.Point(502, 86);
            this.btnListarGestion.Name = "btnListarGestion";
            this.btnListarGestion.Size = new System.Drawing.Size(91, 39);
            this.btnListarGestion.TabIndex = 11;
            this.btnListarGestion.Text = "Listar CheckList";
            this.btnListarGestion.UseVisualStyleBackColor = true;
            this.btnListarGestion.Click += new System.EventHandler(this.btnListarVisitas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rut De Cliente";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(198, 85);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(139, 20);
            this.txtRut.TabIndex = 13;
            // 
            // listVisitas
            // 
            this.listVisitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.listVisitas.Location = new System.Drawing.Point(34, 143);
            this.listVisitas.Name = "listVisitas";
            this.listVisitas.Size = new System.Drawing.Size(667, 192);
            this.listVisitas.TabIndex = 15;
            this.listVisitas.UseCompatibleStateImageBehavior = false;
            this.listVisitas.View = System.Windows.Forms.View.Details;
            this.listVisitas.Visible = false;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "FECHA";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "IDESTADO";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "RUT CLIENTE";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "RUT PROFESI";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "NOMBRE CLIENTE";
            this.columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "NOMBRE PROFESIONAL";
            this.columnHeader16.Width = 100;
            // 
            // listGestion
            // 
            this.listGestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader10});
            this.listGestion.Location = new System.Drawing.Point(34, 143);
            this.listGestion.Name = "listGestion";
            this.listGestion.Size = new System.Drawing.Size(470, 192);
            this.listGestion.TabIndex = 16;
            this.listGestion.UseCompatibleStateImageBehavior = false;
            this.listGestion.View = System.Windows.Forms.View.Details;
            this.listGestion.Visible = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID Visita";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Fecha";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mejora";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 200;
            // 
            // btnListarVisita
            // 
            this.btnListarVisita.Location = new System.Drawing.Point(614, 86);
            this.btnListarVisita.Name = "btnListarVisita";
            this.btnListarVisita.Size = new System.Drawing.Size(91, 39);
            this.btnListarVisita.TabIndex = 12;
            this.btnListarVisita.Text = "Listar Visitas";
            this.btnListarVisita.UseVisualStyleBackColor = true;
            this.btnListarVisita.Click += new System.EventHandler(this.btnListarVisita_Click);
            // 
            // ListarVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listGestion);
            this.Controls.Add(this.listVisitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.btnListarVisita);
            this.Controls.Add(this.btnListarGestion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.listCapasitaciones);
            this.Controls.Add(this.btnListarCapacitaciones);
            this.Name = "ListarVisitas";
            this.Text = "Listar Visitas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarCapacitaciones;
        private System.Windows.Forms.ListView listCapasitaciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnListarGestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.ListView listVisitas;
        private System.Windows.Forms.ListView listGestion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnListarVisita;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
    }
}