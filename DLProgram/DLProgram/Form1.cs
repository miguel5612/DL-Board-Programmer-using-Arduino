using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace DLProgram
{
    public partial class Form1 : Form
    {
        SerialPort ArduinoPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            //fillPortListe: Con esta funcion se llena la lista de puertos que se puede seleccionar en el DropDown
            fillPortListe();
            //fillBaudRate: Con esta funcion se llena los baudrate
            fillBaudRate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            try
            {
                if(btnConnect.Text == "Conectar!")
                {
                    //Conectar 

                    ArduinoPort.PortName = ddPorts.Text;
                    ArduinoPort.BaudRate = Int32.Parse(ddBaudRate.Text);                   
                    ArduinoPort.DataBits = 8;
                    ArduinoPort.Parity = Parity.None;
                    ArduinoPort.StopBits = StopBits.One;
                    ArduinoPort.Handshake = Handshake.None;
                    try
                    {
                        ArduinoPort.Open();
                        btnConnect.Text = "Desconectar!";
                        btnConnect.Enabled = true;
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    //Desconectar
                    ArduinoPort.Close();
                    btnConnect.Text = "Conectar!";
                    btnConnect.Enabled = true;
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fillBaudRate()
        {
            ddBaudRate.Items.Add("9600");
            ddBaudRate.Items.Add("57600");
            ddBaudRate.Items.Add("115200");
            ddBaudRate.Items.Add("250000");
            ddBaudRate.SelectedIndex = 0;
        }
        private void fillPortListe()
        {
            ddPorts.Items.Add("COM3");
            foreach (String port in SerialPort.GetPortNames())
            {
                ddPorts.Items.Add(port);
            }
            ddPorts.SelectedIndex = 0;
        }

        private void ddBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
