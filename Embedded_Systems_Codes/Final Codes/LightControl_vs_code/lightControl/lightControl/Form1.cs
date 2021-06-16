using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lightControl
{
    public partial class Form1 : Form
    {
        //commands
        private const byte commsCheckInstruction = 0x00;
        private const byte RX_HEADER_STATE = 0x01;

        //SERIAL PORTS
        private byte rxChar;
        private byte rxCommand;

        private byte rxData1, rxData2;
        private byte[] txBuffer = new byte[100];

        //FLAGS
        private bool rxNewDataFlag = false;
        private bool commsTestFlag = false;

        //TIMERS
        private int commsTestTimer = 10;
        private int actionTimer = 50;

        SerialPort mySerialPort = new SerialPort();     // Created new srial port object
        private byte[] txbuffer = new byte[100];        // byte txBuffer = 0

        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames(); // looking for comm ports 
            portComboBox.Items.AddRange(ports);         // Arranged in the drop box
                                                        //if (ports != null)

            //portComboComboBox.SelectedIndex = 0;      // arranged in the drop box
            string[] baudItems = new string[] { "9600", "19200", "38400", "57600", "115200" };
            baudRateComboBox.DataSource = baudItems;
            baudRateComboBox.SelectedIndex = 0;         // setting up PORT and baud combo box
        }

        private void serialOpenButton_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen == true)            // if serial port already open close
            {
                mySerialPort.Close();
                serialStatusTextBox.AppendText("Serial port closed \r\n");
                serialRadioButton.Checked = false;
            }
            else
            {
                //Serial port parameters, port , and baudrate from form
                //mySerialPort.PortName = portComboBox.SelectedItem.ToString();
                mySerialPort.BaudRate = int.Parse(baudRateComboBox.SelectedItem.ToString());
                mySerialPort.Parity = Parity.None;
                mySerialPort.DataBits = 8;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.Handshake = Handshake.None;
                try
                {
                    mySerialPort.Open();

                    if (mySerialPort.IsOpen)
                    {
                        serialStatusTextBox.AppendText("Serial port opened\r\n\n");
                        serialStatusTextBox.AppendText(portComboBox.SelectedItem.ToString());
                        serialStatusTextBox.AppendText("  ");
                        serialStatusTextBox.AppendText(baudRateComboBox.SelectedItem.ToString());
                        serialStatusTextBox.AppendText("baud, 8 data bits, 1 stop bit\r\n");
                        serialRadioButton.Checked = true;
                    }
                }
                catch (Exception)
                {
                    serialStatusTextBox.AppendText("Erro cannot open serial port \r\n");
                }
            }
        }

        private void lightTrackBar_Scroll(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen)
            {
                trackValueLabel.Text = trackValueLabel.Value.ToString();
                txbuffer[0] = (byte)trackValueLabel.Value;
                mySerialPort.Write(txbuffer, 0, 1);
            }
            else
            {
                MessageBox.Show("Open the Serial Port firts");
            }
        }

        private void readingMicroRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StartsCommsButton_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen == true)    //if serial port already open, then close
            {
                if (readingMicroRadioButton.Checked == false)
                {
                    serialStatusTextBox.AppendText("Microboard communications Started \n");
                    readingMicroRadioButton.Checked = true;
                }
                else
                {
                    serialStatusTextBox.AppendText("Microboard comunications stopped \n");
                    readingMicroRadioButton.Checked = false;
                }
            }
            else
            {
                serialStatusTextBox.AppendText("you must open the serial port before starting microboard communications \n");
            }
        }

        private void commsTestButton_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen == true)    //if serial port already open, then close
            {
                sendInstruction(commsCheckInstruction, 0, 0);
                serialStatusTextBox.AppendText("comms test started \n");
                commsTestTimer = 20;            //used to time out if no reply from NIOS
                commsTestFlag = true;           //used to activate the time out in serialtimer
            }
            else
            {
                serialStatusTextBox.AppendText("you must open the serial port before starting a comms test \n");
            }

        }

        private void sendInstruction(byte txInstruction, byte txData1, byte txData2)
      {
        if (mySerialPort.IsOpen)
        {
            txBuffer[0] = 0xC4;     //open header
            txBuffer[1] = 0x3B;
            txBuffer[2] = txInstruction;
            txBuffer[3] = txData1;  //number of data bytes
            txBuffer[4] = txData2;  //number of data bytes
            txBuffer[5] = 0xA5;     //command to send
            mySerialPort.Write(txBuffer, 0, 6);
        }
      }
    }
}


