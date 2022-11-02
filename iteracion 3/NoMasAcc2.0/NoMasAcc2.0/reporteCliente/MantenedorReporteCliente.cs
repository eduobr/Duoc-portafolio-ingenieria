using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using DALC_01.controller;
using DALC_01.modelo;
using System.IO;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace NoMasAcc2._0.reporteCliente
{
    public partial class MantenedorReporteCliente : MetroUserControl
    {
        ClienteController controlCliente = new ClienteController();
        ServicioReportes.Service1Client servicio = new ServicioReportes.Service1Client();
        public MantenedorReporteCliente()
        {
            InitializeComponent();

            cargarClientes();

        }

        private void cargarClientes()
        {
            ClienteController proC = new ClienteController();

            var list = proC.listarCliente();
            List<Cliente> listaCli = new List<Cliente>();

            foreach (var cl in list)
            {
                Cliente cli = new Cliente();
                //ListViewItem item = new ListViewItem(pro.idProfesional.ToString());
                cli.idCliente = cl.idCliente;
                cli.rutCliente = cl.rutCliente;
                cli.nombre = cl.nombre;
                cli.direccion = cl.direccion;
                cli.empresa = cl.empresa;

                //prof.fechaNacimientoPro = pro.fechaNacimientoPro.ToString("dd/MM/yyyy");
                //cli.fechaNacimiento = cl.fechaNacimientoPro;
                listaCli.Add(cli);
            }

            grdReporteCli.DataSource = listaCli;

            grdReporteCli.Columns["idCliente"].Visible = false;
            grdReporteCli.Columns["rutCliente"].HeaderText = "Rut Cliente";
            grdReporteCli.Columns["rutCliente"].Width = 80;
            grdReporteCli.Columns["nombre"].Width = 250;
        }

        private void btnAddRepGlo_Click(object sender, EventArgs e)
        {
            btnCliPdf.Enabled = false;
            int idCliente = Convert.ToInt32(grdReporteCli.SelectedCells[0].Value);
            //MessageBox.Show(idCliente.ToString());
            servicio.ingresarReporte(idCliente);
        }

        private void btnLstRepGlo_Click(object sender, EventArgs e)
        {
            btnAddRepCli.Enabled = false;
            btnCliPdf.Enabled = true;
            grdReporteCli.DataSource = servicio.listaReporteCli();
            grdReporteCli.Columns["idReporte"].Visible = false;
            grdReporteCli.Columns["rutCliente"].DisplayIndex = 0;
            grdReporteCli.Columns["nombreCliente"].DisplayIndex = 1;
            grdReporteCli.Columns["empresa"].DisplayIndex = 2;
            grdReporteCli.Columns["fecha"].DisplayIndex = 3;
            grdReporteCli.Columns["visitas"].DisplayIndex = 4;
            grdReporteCli.Columns["rutProfesional"].DisplayIndex = 9;
        }

        private void btnLstCli_Click(object sender, EventArgs e)
        {
            btnAddRepCli.Enabled = true;
            btnCliPdf.Enabled = false;
            cargarClientes();
        }

        private void btnCliPdf_Click(object sender, EventArgs e)
        {
            To_pdf();
        }

        #region crearPDF
        private void To_pdf()
        {

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
                string remito = "Autorizo: NoMasAccidente";
                string envio = "Fecha:" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Reporte Global", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));

                doc.Add(new Paragraph(remito));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerarDocumento(doc);
                doc.AddCreationDate();
                //doc.Add(new Paragraph("______________________________________________", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                //doc.Add(new Paragraph("Firma", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Close();
                Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }

        }
        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(grdReporteCli.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(grdReporteCli);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < grdReporteCli.ColumnCount; i++)
            {
                datatable.AddCell(grdReporteCli.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < grdReporteCli.Rows.Count; i++)
            {
                for (j = 0; j < grdReporteCli.Columns.Count; j++)
                {
                    if (grdReporteCli[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(grdReporteCli[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;

        }
        #endregion
    }
}
