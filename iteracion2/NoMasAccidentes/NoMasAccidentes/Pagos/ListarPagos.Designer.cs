namespace NoMasAccidentes.Pagos
{
    partial class ListarPagos
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
            this.listDePagos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListar = new System.Windows.Forms.Button();
            this.dTimeFecha = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNoPagados = new System.Windows.Forms.Button();
            this.btnPagados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDePagos
            // 
            this.listDePagos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listDePagos.Location = new System.Drawing.Point(81, 157);
            this.listDePagos.Name = "listDePagos";
            this.listDePagos.Size = new System.Drawing.Size(566, 192);
            this.listDePagos.TabIndex = 3;
            this.listDePagos.UseCompatibleStateImageBehavior = false;
            this.listDePagos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha de Pago";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha Limite";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Monto";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Estado";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Plan";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(385, 76);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 39);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar Todos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dTimeFecha
            // 
            this.dTimeFecha.Location = new System.Drawing.Point(136, 86);
            this.dTimeFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dTimeFecha.Name = "dTimeFecha";
            this.dTimeFecha.Size = new System.Drawing.Size(200, 29);
            this.dTimeFecha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese fecha";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(693, 26);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNoPagados
            // 
            this.btnNoPagados.Location = new System.Drawing.Point(514, 76);
            this.btnNoPagados.Name = "btnNoPagados";
            this.btnNoPagados.Size = new System.Drawing.Size(91, 39);
            this.btnNoPagados.TabIndex = 11;
            this.btnNoPagados.Text = "Listar No Pagados";
            this.btnNoPagados.UseVisualStyleBackColor = true;
            this.btnNoPagados.Click += new System.EventHandler(this.btnNoPagados_Click);
            // 
            // btnPagados
            // 
            this.btnPagados.Location = new System.Drawing.Point(628, 76);
            this.btnPagados.Name = "btnPagados";
            this.btnPagados.Size = new System.Drawing.Size(91, 39);
            this.btnPagados.TabIndex = 12;
            this.btnPagados.Text = "Listar Pagados";
            this.btnPagados.UseVisualStyleBackColor = true;
            this.btnPagados.Click += new System.EventHandler(this.btnPagados_Click);
            // 
            // ListarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPagados);
            this.Controls.Add(this.btnNoPagados);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTimeFecha);
            this.Controls.Add(this.listDePagos);
            this.Controls.Add(this.btnListar);
            this.Name = "ListarPagos";
            this.Text = "ListarPagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listDePagos;
        private System.Windows.Forms.Button btnListar;
        private MetroFramework.Controls.MetroDateTime dTimeFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnNoPagados;
        private System.Windows.Forms.Button btnPagados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}