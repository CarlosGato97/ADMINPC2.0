using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WinFormApp
{
    public partial class ReporteIslas : Form
    {
        public ReporteIslas()
        {
            InitializeComponent();
        }

        private void ReporteIslas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aDMINPCDataSet5.ReportIslas' table. You can move, or remove it, as needed.
            this.reportIslasTableAdapter.Fill(this.aDMINPCDataSet5.ReportIslas);
 
        }

        private void btnVolverMenuAdmin_Click(object sender, EventArgs e)
        {
            MenuAdministrador MenuAdmin = new MenuAdministrador();
            MenuAdmin.Show();
            this.Hide();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value != null ? cell.Value.ToString() : null);
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("Se exporto la informacion a PDF");
            MessageBox.Show("C:\\PDFs\\");
        }
    }
}
