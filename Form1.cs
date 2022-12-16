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
                    try
                    {
                        string[] division = linea.Split(new string[] { " " }, 2, StringSplitOptions.None);

                        dataGridView1.Rows.Add(division[0], division[1]);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid text format", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }

                btn_QRconv.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Only .txt files are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                private void btn_QRconv_Click(object sender, EventArgs e)
                {
                    int TamanoQr = 85;
                    int TamanoTexto = 10;
                    int CantidadFilas = 6;
            if (Qr_quantity.SelectedIndex == 0)
            {
                 TamanoQr = 85;
                 TamanoTexto = 10;
                 CantidadFilas = 6;
            }
            else if (Qr_quantity.SelectedIndex == 1)
            {
                TamanoQr = 100;
                TamanoTexto = 10;
                CantidadFilas = 5;
            }
            else if (Qr_quantity.SelectedIndex == 2)
            {
                TamanoQr = 120;
                TamanoTexto = 15;
                CantidadFilas = 4;
            }
            else if (Qr_quantity.SelectedIndex == 3)
            {
                TamanoQr = 130;
                TamanoTexto = 15;
                CantidadFilas = 4;
            }
            else if (Qr_quantity.SelectedIndex == 4)
            {
                TamanoQr = 150;
                TamanoTexto = 20;
                CantidadFilas = 4;
            }
            else if (Qr_quantity.SelectedIndex == 5)
            {
                TamanoQr = 169;
                TamanoTexto = 25;
                CantidadFilas = 3;
            }
            else if (Qr_quantity.SelectedIndex == 6)
            {
                TamanoQr = 300;
                TamanoTexto = 40;
                CantidadFilas = 1;
            }
            else if (Qr_quantity.SelectedIndex == 7)
            {
                TamanoQr = 530;
                TamanoTexto = 70;
                CantidadFilas = 1;
            }
                    
            //42 = (85,10,6) 30 = (100,10,5) 12 =(150,20,3) 16 =(130,15,4) 20 =(120,15,4) 9 = (169,25,3) 2 = (300,40,1) 1 = (530,70,1)
            Table table = new Table(UnitValue.CreatePercentArray(CantidadFilas)).UseAllAvailableWidth();
                    var savefiledialoge = new SaveFileDialog();
                    savefiledialoge.FileName = "Code QR " + DateTime.Now.ToString("yyyy-MM-dd");
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
                                    cell.Add(new Image(qrcode1.CreateFormXObject(pdfDoc)).SetHeight(TamanoQr).SetHorizontalAlignment(HorizontalAlignment.CENTER));
                                    table.AddCell(cell);
                                    Cont++;
                                }

                            }
                            table.SetFontSize(TamanoTexto);
                            table.SetTextAlignment(TextAlignment.CENTER);
                            doc.Add(table);
                            doc.Close();

                
                        }
                        
                    }

            MessageBox.Show("QRs generated correctly", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Qr_quantity.Items.Add("42");
            Qr_quantity.Items.Add("30");
            Qr_quantity.Items.Add("20");
            Qr_quantity.Items.Add("16");
            Qr_quantity.Items.Add("12");
            Qr_quantity.Items.Add("9");
            Qr_quantity.Items.Add("2");
            Qr_quantity.Items.Add("1");
            Qr_quantity.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
