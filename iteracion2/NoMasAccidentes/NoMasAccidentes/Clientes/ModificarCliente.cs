using DALC_01.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using DALC_01.modelo;

namespace NoMasAccidentes.Clientes
{
    public partial class ModificarCliente : Form
    {
        ComunaController controlComuna = new ComunaController();
        RubroController controlRubro = new RubroController();
        ClienteController controlCliente = new ClienteController();
        public ModificarCliente()
        {
            InitializeComponent();
            
            llenarCBO();
            cboComuna.SelectedIndex = 0;
            cboRubro.SelectedIndex = 0;
        }

        private void llenarCBO()
        {
            var list1 = controlComuna.listarComuna();
            foreach (var c in list1)
            {
                cboComuna.Items.Add(c.descComuna);
            }

            var list2 = controlRubro.listarCiudad();
            foreach (var r in list2)
            {
                cboRubro.Items.Add(r.descRubro);
            }
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
               
                var resul = controlCliente.BuscarCliente(txtRut.Text.ToString());
               
                foreach (var item in resul)
                {

                   
                    txtNombre.Text = item.nombre.ToString();
                    txtApellido.Text = item.apePaterno.ToString();
                    txtApellidoM.Text = item.apeMaterno.ToString();
                    txtDireccion.Text = item.direccion.ToString();
                    txtEmail.Text = item.email.ToString();
                    txtTelefono.Text = item.telefono.ToString();
                    cboComuna.SelectedIndex = item.idComuna-1;
                    cboRubro.SelectedIndex = item.idRubro-1;
                    
                    txtUsuario.Text = item.idUsuario.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Buscar");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                string rut, nombre, apellidoP, apellidoM, direccion, email, telefono;
                int comuna, rubro, usuario;
                rut = txtRut.Text;
                nombre = txtNombre.Text;
                apellidoP = txtApellido.Text;
                apellidoM = txtApellidoM.Text;
                direccion = txtDireccion.Text;
                email = txtEmail.Text;
                telefono = txtTelefono.Text;
                comuna = cboComuna.SelectedIndex + 1;
                rubro = cboRubro.SelectedIndex + 1;
                usuario = 1;



                int resul = controlCliente.Insert_Cliente(rut, nombre, apellidoP, apellidoM, direccion, email, telefono, comuna, rubro, usuario);

                if (resul > 0)
                {
                    MessageBox.Show("Modifico " + resul);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error a Modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error a Modificar" + ex.Message);
            }


        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtApellidoM.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cboComuna.SelectedIndex = 0;
            cboRubro.SelectedIndex =0;

            txtUsuario.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                var resul = controlCliente.BuscarCliente(txtRut.Text.ToString());
                Cliente cliente = new Cliente();
                foreach (var item in resul)
                {
                    cliente.rutCliente = item.rutCliente;
                    cliente.nombre = item.nombre.ToString();
                    cliente.apePaterno = item.apePaterno.ToString();
                    cliente.apeMaterno = item.apeMaterno.ToString();
                    cliente.direccion = item.direccion.ToString();
                    cliente.email = item.email.ToString();
                    cliente.telefono = item.telefono.ToString();
                    cliente.idComuna = item.idComuna;
                    cliente.idRubro = item.idRubro;

                }


                    Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:";
                saveFileDialog1.Title = "Guardar Reporte";
                saveFileDialog1.DefaultExt = "pdf";
                saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                string filename = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog1.FileName;
                }

                if (filename.Trim() != "")
                {
                    FileStream file = new FileStream(filename,
                    FileMode.OpenOrCreate,
                    FileAccess.ReadWrite,
                    FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, file);
                    doc.Open();
                    string remito = "Autorizo: NoMasAccidentes";
                    string envio = "Fecha:" + DateTime.Now.ToString();

                    Chunk chunk = new Chunk("Contrato de Servicio", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                    doc.Add(new Paragraph(chunk));
                    doc.Add(new Paragraph("                       "));
                    doc.Add(new Paragraph("                       "));
                    doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                    doc.Add(new Paragraph(cliente.nombre + " " + cliente.apePaterno + " " + cliente.apeMaterno));
                    doc.Add(new Paragraph(remito));
                    doc.Add(new Paragraph(envio));
                    doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                    doc.Add(new Paragraph("                       "));
                    doc.Add(new Paragraph("                       "));
                    doc.Add(new Paragraph("                       "));
                    //GenerarDocumento(doc);
                    doc.Add(new Paragraph("el cliente "+ cliente.nombre + " " + cliente.apePaterno + " " + cliente.apeMaterno + "  Contratara los serviocio de "));
                    doc.Add(new Paragraph(" "));

                    doc.AddCreationDate();
                    doc.Add(new Paragraph("______________________________________________", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("Firma", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                    doc.Close();
                    Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
                }





            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
