namespace NoMasAccidentes.Plan
{
    partial class IngresarPlan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutProf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuc = new System.Windows.Forms.TextBox();
            this.btnIngPlan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dpVisita = new System.Windows.Forms.DateTimePicker();
            this.dpVisita2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Cliente ";
            // 
            // txtRutCli
            // 
            this.txtRutCli.Location = new System.Drawing.Point(116, 40);
            this.txtRutCli.Name = "txtRutCli";
            this.txtRutCli.Size = new System.Drawing.Size(100, 20);
            this.txtRutCli.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut Profesional ";
            // 
            // txtRutProf
            // 
            this.txtRutProf.Location = new System.Drawing.Point(328, 40);
            this.txtRutProf.Name = "txtRutProf";
            this.txtRutProf.Size = new System.Drawing.Size(100, 20);
            this.txtRutProf.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(116, 90);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(100, 20);
            this.txtPrec.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sucursal";
            // 
            // txtSuc
            // 
            this.txtSuc.Location = new System.Drawing.Point(116, 137);
            this.txtSuc.Name = "txtSuc";
            this.txtSuc.Size = new System.Drawing.Size(100, 20);
            this.txtSuc.TabIndex = 7;
            // 
            // btnIngPlan
            // 
            this.btnIngPlan.Location = new System.Drawing.Point(226, 202);
            this.btnIngPlan.Name = "btnIngPlan";
            this.btnIngPlan.Size = new System.Drawing.Size(75, 23);
            this.btnIngPlan.TabIndex = 8;
            this.btnIngPlan.Text = "Ingresar Plan";
            this.btnIngPlan.UseVisualStyleBackColor = true;
            this.btnIngPlan.Click += new System.EventHandler(this.btnIngPlan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "primera visita";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "segunda visita";
            // 
            // dpVisita
            // 
            this.dpVisita.Location = new System.Drawing.Point(314, 90);
            this.dpVisita.Name = "dpVisita";
            this.dpVisita.Size = new System.Drawing.Size(200, 20);
            this.dpVisita.TabIndex = 11;
            // 
            // dpVisita2
            // 
            this.dpVisita2.Location = new System.Drawing.Point(314, 137);
            this.dpVisita2.Name = "dpVisita2";
            this.dpVisita2.Size = new System.Drawing.Size(200, 20);
            this.dpVisita2.TabIndex = 12;
            // 
            // IngresarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 273);
            this.Controls.Add(this.dpVisita2);
            this.Controls.Add(this.dpVisita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIngPlan);
            this.Controls.Add(this.txtSuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRutProf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRutCli);
            this.Controls.Add(this.label1);
            this.Name = "IngresarPlan";
            this.Text = "IngresarPlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutProf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuc;
        private System.Windows.Forms.Button btnIngPlan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpVisita;
        private System.Windows.Forms.DateTimePicker dpVisita2;
    }
}