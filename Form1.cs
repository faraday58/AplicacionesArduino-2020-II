using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionesArduino_2020_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperatura formTemperatura = new FormTemperatura();
            formTemperatura.MdiParent = this;
            formTemperatura.Height = Height;
            formTemperatura.Width = Width;
            

            formTemperatura.Show();
        }
    }
}
