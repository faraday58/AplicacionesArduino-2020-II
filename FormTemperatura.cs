using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace AplicacionesArduino_2020_II
{
    public partial class FormTemperatura : Form
    {
        private int tiempo;
        private FileStream fs;        

        public FormTemperatura()
        {
            InitializeComponent();
        }

        private void TimerGenera_Tick(object sender, EventArgs e)
        {
            Random aleatoria = new Random();
            int temperatura = aleatoria.Next(15, 50);
            chSenal.Series[0].Points.AddXY(tiempo++, temperatura);
            dgvDatos.Rows.Add(tiempo, temperatura);
        }


        private void DetenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerGenera.Stop();
        }

        private void AleatoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerGenera.Start();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw=null;
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Datos (.txt)|*.txt| Archivo Excel (.csv)|*.csv";

            if( saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveFileDialog.FileName, FileMode.CreateNew, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("Tiempo,Temperatura");
                    for(int i=0; i < dgvDatos.Rows.Count; i++)
                    {
                        sw.WriteLine(dgvDatos.Rows[i].Cells[0].Value + "," + dgvDatos.Rows[i].Cells[1].Value);
                    }

                }
                catch(IOException error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
                finally
                {
                    sw.Close();
                    fs.Close();
                }



            }


        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chSenal.Series[0].Points.Clear();
            dgvDatos.Rows.Clear();
        }

        private void ExportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Document obj_doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo PDF (.pdf)|*.pdf";

            if( saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveFileDialog.FileName, FileMode.Append);
                    PdfWriter pdfWriter = PdfWriter.GetInstance(obj_doc, fs);
                    obj_doc.Open();
                    MemoryStream imagenBuffer = new MemoryStream();
                    chSenal.SaveImage(imagenBuffer, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                    iTextSharp.text.Image Grafimagen = iTextSharp.text.Image.GetInstance(imagenBuffer.GetBuffer());
                    obj_doc.Add(Grafimagen);

                }
                catch(IOException error)
                {
                    MessageBox.Show("Error: " + error);
                }
                finally
                {
                    obj_doc.Close();
                    fs.Close();
                }

            }




        }
    }
}
