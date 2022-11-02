namespace NoMasAccidentes.Clientes
{
    partial class Asignacion
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
            this.ListaCliente = new MetroFramework.Controls.MetroListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaProfecional = new MetroFramework.Controls.MetroListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutCli = new System.Windows.Forms.TextBox();
            this.btnBuscarProfecional = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutPro = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaCliente
            // 
            this.ListaCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.ListaCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListaCliente.FullRowSelect = true;
            this.ListaCliente.Location = new System.Drawing.Point(33, 68);
            this.ListaCliente.Name = "ListaCliente";
            this.ListaCliente.OwnerDraw = true;
            this.ListaCliente.Size = new System.Drawing.Size(775, 84);
            this.ListaCliente.TabIndex = 9;
            this.ListaCliente.UseCompatibleStateImageBehavior = false;
            this.ListaCliente.UseSelectable = true;
            this.ListaCliente.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "ID";
            this.columnHeader0.Width = 30;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RUT";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOMBRE";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido P";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Apellido M";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Direccion";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Telefono";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Comuna";
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Rubro";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Usuario";
            this.columnHeader10.Width = 100;
            // 
            // ListaProfecional
            // 
            this.ListaProfecional.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.ListaProfecional.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListaProfecional.FullRowSelect = true;
            this.ListaProfecional.Location = new System.Drawing.Point(33, 253);
            this.ListaProfecional.Name = "ListaProfecional";
            this.ListaProfecional.OwnerDraw = true;
            this.ListaProfecional.Size = new System.Drawing.Size(775, 97);
            this.ListaProfecional.TabIndex = 10;
            this.ListaProfecional.UseCompatibleStateImageBehavior = false;
            this.ListaProfecional.UseSelectable = true;
            this.ListaProfecional.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Tag = "32";
            this.id.Text = "ID";
            this.id.Width = 52;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Rut";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Tag = "156";
            this.columnHeader13.Text = "Nombre";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 156;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Apellido Paterno";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 140;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Apellido Materno";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 140;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Telefono";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 140;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Fecha de Nacimiento";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 140;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Comuna";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader18.Width = 140;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(318, 36);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(66, 26);
            this.btnBuscarCliente.TabIndex = 47;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Rut Cliente";
            // 
            // txtRutCli
            // 
            this.txtRutCli.Location = new System.Drawing.Point(128, 42);
            this.txtRutCli.Name = "txtRutCli";
            this.txtRutCli.Size = new System.Drawing.Size(184, 20);
            this.txtRutCli.TabIndex = 45;
            // 
            // btnBuscarProfecional
            // 
            this.btnBuscarProfecional.Location = new System.Drawing.Point(349, 221);
            this.btnBuscarProfecional.Name = "btnBuscarProfecional";
            this.btnBuscarProfecional.Size = new System.Drawing.Size(66, 26);
            this.btnBuscarProfecional.TabIndex = 50;
            this.btnBuscarProfecional.Text = "Buscar";
            this.btnBuscarProfecional.UseVisualStyleBackColor = true;
            this.btnBuscarProfecional.Click += new System.EventHandler(this.btnBuscarProfecional_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Rut Profecional";
            // 
            // txtRutPro
            // 
            this.txtRutPro.Location = new System.Drawing.Point(159, 227);
            this.txtRutPro.Name = "txtRutPro";
            this.txtRutPro.Size = new System.Drawing.Size(184, 20);
            this.txtRutPro.TabIndex = 48;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(186, 383);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(126, 58);
            this.btnAsignar.TabIndex = 51;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // Asignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 491);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnBuscarProfecional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRutPro);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRutCli);
            this.Controls.Add(this.ListaProfecional);
            this.Controls.Add(this.ListaCliente);
            this.Name = "Asignacion";
            this.Text = "Asignacion";
            this.Load += new System.EventHandler(this.Asignacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView ListaCliente;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private MetroFramework.Controls.MetroListView ListaProfecional;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutCli;
        private System.Windows.Forms.Button btnBuscarProfecional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutPro;
        private System.Windows.Forms.Button btnAsignar;
    }
}