using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
namespace AplicacionesArduino_2020_II
{
    public partial class Foco : Form
    {
        bool enciende;
        SerialPort serialPort;

        public Foco(SerialPort serialPort)
        {
            InitializeComponent();
            this.serialPort = serialPort;
            ptbFoco.BackColor = Color.White;
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {

            if(enciende)
            {
                ptbFoco.BackColor = Color.Yellow;
                serialPort.Write("a");
                enciende = false;
            }
            else
            {
                ptbFoco.BackColor = Color.White;
                serialPort.Write("b");
                enciende = true;
            }
            
        }
    }
}
