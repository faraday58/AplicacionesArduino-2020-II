using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace AplicacionesArduino_2020_II
{
    public partial class Form1 : Form
    {
        private SerialPort puerto;
        public Form1()
        {
            InitializeComponent();
            puerto = new SerialPort();
            selecciona();
        }


        private void selecciona()
        {
            string[] v = SerialPort.GetPortNames();
            Array.Sort(v);
            tspCmbPuertos.Items.AddRange(v);
        }

        private void TemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperatura formTemperatura = new FormTemperatura(puerto);
            formTemperatura.MdiParent = this;
            formTemperatura.Height = Height;
            formTemperatura.Width = Width;
            

            formTemperatura.Show();
        }

        private void ConectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                puerto.BaudRate = int.Parse(tspCmbVelocidad.SelectedItem.ToString());
                puerto.PortName = tspCmbPuertos.SelectedItem.ToString();
                puerto.Open();

                conectarToolStripMenuItem.Checked = true;
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }


        }

        private void FocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Foco foco = new Foco(puerto);
            foco.MdiParent = this;
            foco.Show();

        }

        private void TspCmbPuertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            conectarToolStripMenuItem.Enabled = true;


        }
    }
}
