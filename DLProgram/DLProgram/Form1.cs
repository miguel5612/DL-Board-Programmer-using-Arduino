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
using System.IO;
using System.Globalization;
using System.Text;


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
            fillRoute();
            pfillSendMode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            try
            {
                if (btnConnect.Text == "Conectar!")
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
                    catch (Exception)
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
            catch (Exception)
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
        private void pfillSendMode()
        {
            cmbSendMode.Items.Add("Byte-Byte (DEC)");
            cmbSendMode.Items.Add("Byte-Byte (HEX)");
            cmbSendMode.Items.Add("4 byte-4 byte (DEC)");
            cmbSendMode.Items.Add("4 byte-4 byte (HEX)");
            cmbSendMode.Items.Add("Line-Line (32-Bit)(DEC)");
            cmbSendMode.Items.Add("Line-Line (32-Bit)(HEX)");
            cmbSendMode.Items.Add("Line-Line (16-Bit)(DEC)");
            cmbSendMode.Items.Add("Line-Line (16-Bit)(HEX)");
            cmbSendMode.Items.Add("Line-Line (8-Bit)(DEC)");
            cmbSendMode.Items.Add("Line-Line (8-Bit)(HEX)");
            cmbSendMode.SelectedIndex = 0;
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
        private void fillRoute()
        {
            var path = Environment.CurrentDirectory;
            txtRoute.Text = path + "\\app.exe";
        }
        private void ddBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //fillPortListe: Con esta funcion se llena la lista de puertos que se puede seleccionar en el DropDown
            fillPortListe();
            //fillBaudRate: Con esta funcion se llena los baudrate
            fillBaudRate();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            var path = Environment.CurrentDirectory + "\\app.exe";
            OpenFileDialog window = new OpenFileDialog();
            string line = "", text = "";
            if (window.ShowDialog() == DialogResult.OK)
            {
                string fileStr = "";
                string location = window.FileName;
                byte[] file = File.ReadAllBytes(location);
                fileStr = ByteArrayToString(file);
                fileStr = formatStr(fileStr, 4, 8);
                txtExe.Text = fileStr;
                txtNumBytes.Text = fileStr.Trim().Replace(" ", "").Replace("\r\n", "").Length.ToString();
            }

        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        public static string formatStr(String inputText, int chunkSize, int CRSize)
        {
            string rText = " ";
            int counter = 0;
            foreach (string s in Split(inputText, chunkSize).ToList())
            {
                counter++;
                rText += " " + s;
                if (counter >= CRSize)
                {
                    rText += "  \r\n ";
                    counter = 0;
                }
            }
            return rText;
        }
        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtExe.Text != "")
            {
                txtMod.Text = "";
                char sep = '\r';
                //Voy a enviar caracter por caractercmbSendMode.Items.Add("Byte-Byte (DEC)");
                if (cmbSendMode.Text == "Byte-Byte (DEC)")
                {
                    string text = txtExe.Text;
                    text = text.Trim().Replace(" ", "").Replace("\r\n", ""); //remove whitespaces
                    for (int i = 0; i <= text.Length - 1; i++)
                    {
                        string character = text.Substring(i, 1);
                        int caracter = int.Parse(character, System.Globalization.NumberStyles.HexNumber);
                        ArduinoPort.WriteLine(caracter.ToString());
                        txtMod.Text += caracter.ToString() + "\r\n";
                    }
                }
                else if (cmbSendMode.Text == "Byte-Byte (HEX)")
                {
                    string text = txtExe.Text;
                    text = text.Trim().Replace(" ", "").Replace("\r\n", ""); //remove whitespaces
                    for (int i = 0; i <= text.Length - 1; i++)
                    {
                        string character = text.Substring(i, 1);
                        ArduinoPort.WriteLine(character);
                        txtMod.Text += character + "\r\n";
                    }
                }
                else if (cmbSendMode.Text == "4 byte-4 byte (DEC)")
                {
                    string text = txtExe.Text;
                    text = text.Trim().Replace(" ", "").Replace("\r\n", ""); //remove whitespaces
                    for (int i = 0; i <= text.Length - 1; i += 4)
                    {
                        string character = text.Substring(i, 4);
                        string lineInt = "";
                        for(int bIndex = 0; bIndex <= character.Length -1; bIndex++)
                        {
                            int caracter = int.Parse(character.Substring(bIndex,1), System.Globalization.NumberStyles.HexNumber);
                            lineInt += caracter.ToString();
                        }
                        ArduinoPort.WriteLine(lineInt);
                        txtMod.Text += lineInt + "\r\n";
                    }
                }
                else if (cmbSendMode.Text == "4 byte-4 byte (HEX)")
                {
                    string text = txtExe.Text;
                    text = text.Trim().Replace(" ", "").Replace("\r\n", ""); //remove whitespaces
                    for (int i = 0; i <= text.Length - 1; i += 4)
                    {
                        string character = text.Substring(i, 4);
                        ArduinoPort.WriteLine(character);
                        txtMod.Text += character + "\r\n";
                    }
                }

                else if (cmbSendMode.Text == "Line-Line (32-Bit)(DEC)")
                {
                    string text = txtExe.Text;
                    text = text.Trim().Replace(" ", "").Replace("\n", ""); //remove whitespaces
                    string[] lines = text.Split(sep);
                    foreach (string line in lines)
                    {
                        string lineF = line.Replace("\r", "");
                        string lineInt = "";
                        for (int i = 0; i <= lineF.Length - 1; i++)
                        {
                            lineInt += int.Parse(lineF.Substring(i, 1), System.Globalization.NumberStyles.HexNumber);
                        }
                        ArduinoPort.WriteLine(lineInt);
                        txtMod.Text += lineInt + "\r\n";
                    }
                }
                else if (cmbSendMode.Text == "Line-Line (32-Bit)(HEX)")
                {
                    string text = txtExe.Text;
                    text = text.Trim().Replace(" ", "").Replace("\n", ""); //remove whitespaces
                    string[] lines = text.Split(sep);
                    foreach (string line in lines)
                    {
                        string lineF = line.Replace("\r", "");
                        ArduinoPort.WriteLine(lineF);
                        txtMod.Text += lineF + "\r\n";
                    }
                }
                else if (cmbSendMode.Text == "Line-Line (16-Bit)(DEC)")
                {
                    string text = txtExe.Text;
                    text = text.Trim().Replace(" ", "").Replace("\n", ""); //remove whitespaces
                    string[] lines = text.Split(sep);
                    foreach (string line in lines)
                    {
                        string lineF = line.Replace("\r", "");
                        for (int j = 0; j <= lineF.Length - 1; j += lineF.Length / 2)
                        {
                            string line16 = lineF.Substring(j, 16);
                            string lineInt = "";
                            for (int i = 0; i <= line16.Length - 1; i++)
                            {
                                lineInt += int.Parse(line16.Substring(i, 1), System.Globalization.NumberStyles.HexNumber);
                            }
                            ArduinoPort.WriteLine(lineInt);
                            txtMod.Text += lineInt + "\r\n";
                        }
                    }
                }
                else if (cmbSendMode.Text == "Line-Line (16-Bit)(HEX)")
                {
                    string text = txtExe.Text;
                    text = text.Trim().Replace(" ", "").Replace("\n", ""); //remove whitespaces
                    string[] lines = text.Split(sep);
                    foreach (string line in lines)
                    {
                        string lineF = line.Replace("\r", "");
                        for (int j = 0; j <= lineF.Length - 1; j += lineF.Length / 2)
                        {
                            string line16 = lineF.Substring(j, 16);
                            ArduinoPort.WriteLine(line16);
                            txtMod.Text += line16 + "\r\n";
                        }
                    }
                }
                else if (cmbSendMode.Text == "Line-Line (8-Bit)(DEC)")
                {
                    string text = txtExe.Text;
                    text = text.Trim().Replace(" ", "").Replace("\n", ""); //remove whitespaces
                    string[] lines = text.Split(sep);
                    foreach (string line in lines)
                    {
                        string lineF = line.Replace("\r", "");
                        for (int j = 0; j <= lineF.Length - 1; j += lineF.Length / 4)
                        {
                            string line8 = lineF.Substring(j, 8);
                            string lineInt = "";
                            for (int i = 0; i <= line8.Length - 1; i++)
                            {
                                lineInt += int.Parse(line8.Substring(i, 1), System.Globalization.NumberStyles.HexNumber);
                            }
                            ArduinoPort.WriteLine(lineInt);
                            txtMod.Text += lineInt + "\r\n";
                        }
                    }
                }
                else if (cmbSendMode.Text == "Line-Line (8-Bit)(HEX)")
                {
                    string text = txtExe.Text;
                    text = text.Trim().Replace(" ", "").Replace("\n", ""); //remove whitespaces
                    string[] lines = text.Split(sep);
                    foreach (string line in lines)
                    {
                        string lineF = line.Replace("\r", "");
                        for (int j = 0; j <= lineF.Length - 1; j += lineF.Length / 4)
                        {
                            string line8 = lineF.Substring(j, 8);
                            ArduinoPort.WriteLine(line8);
                            txtMod.Text += line8 + "\r\n";
                        }
                    }
                }

            }
            else
            {
                Form dlg1 = new Form();
                dlg1.Text = "Debes cargar por lo menos un archivo .Exe";
                dlg1.Visible = true;
            }
        }
    }

}
