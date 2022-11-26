using iText.Barcodes;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Geom;

using Image = iText.Layout.Element.Image;
using QRCoder;
using System.Runtime.Remoting.Contexts;
using HorizontalAlignment = iText.Layout.Properties.HorizontalAlignment;
using Microsoft.Win32;
using Path = System.IO.Path;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using iText.StyledXmlParser.Jsoup.Nodes;
using Document = iText.Layout.Document;

namespace GeneradorQr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Subir_Click(object sender, EventArgs e)
        {
            openFileSubirArchivo.ShowDialog();
            String Texto = openFileSubirArchivo.FileName;

            if (File.Exists(Texto) && Path.GetExtension(openFileSubirArchivo.FileName) == ".txt")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                textBox1.Text = Texto;
                string[] Lineas = File.ReadAllLines(Texto);

                
                foreach (string linea in Lineas)
                {
                    string[] division = linea.Split(new string[] { " " }, 2, StringSplitOptions.None);
        
                    dataGridView1.Rows.Add(division[0], division[1]);
                  

                }

                btn_QRconv.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Error. Use solo archivos .txt");
            }
        }
                private void btn_QRconv_Click(object sender, EventArgs e)
                {
                    Table table = new Table(UnitValue.CreatePercentArray(5)).UseAllAvailableWidth();
                    var savefiledialoge = new SaveFileDialog();
                    savefiledialoge.FileName = "Códigos " + DateTime.Now.ToString("yyyy-MM-dd");
                    savefiledialoge.DefaultExt = ".pdf";
                    if (savefiledialoge.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                        {

                            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(stream));
                            Document doc = new Document(pdfDoc);

                    
                            int Cont = 0;
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells[0].Value != null)
                                {
                                    string value1 = row.Cells[0].Value.ToString();
                                    Cell cell = new Cell().SetKeepTogether(true);
                                    Paragraph Titulo = new Paragraph("  "+ value1).SetHorizontalAlignment(HorizontalAlignment.CENTER);
                                    BarcodeQRCode qrcode1 = new BarcodeQRCode(row.Cells[0].Value.ToString() + "\n" + row.Cells[1].Value.ToString());
                                    cell.Add(Titulo.SetHorizontalAlignment(HorizontalAlignment.CENTER));
                                    cell.Add(new Image(qrcode1.CreateFormXObject(pdfDoc)).SetHeight(100));
                                    table.AddCell(cell);
                                    Cont++;
                                }

                            }
                            table.SetFontSize(10);
                            table.SetTextAlignment(TextAlignment.CENTER);
                            doc.Add(table);
                            doc.Close();

                
                        }
                        
                    }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
