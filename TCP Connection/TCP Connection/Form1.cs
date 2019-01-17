using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Connection
{
    public partial class Form1 : Form
    {
        private Client _client;
        private bool connected = false;

        public Form1()
        {
            InitializeComponent();
            PrefillTextBox();
        }

        private void PrefillTextBox()
        {
            textBoxIp.Text = "127.0.0.1";
            textBoxPort.Text = "59152";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (connected)
                {
                    throw new FieldAccessException("Already connected");
                }
                try
                {
                    if (string.IsNullOrEmpty(textBoxIp.Text) || string.IsNullOrEmpty(textBoxPort.Text))
                    {
                        throw new NoNullAllowedException("Please fill the ip/port text fields");
                    }
                    _client = new Client(int.Parse(textBoxPort.Text), textBoxIp.Text);
                    _client.EchoReveived += WriteEchoToTextBox;
                    textBoxIp.ReadOnly = true;
                    textBoxPort.ReadOnly = true;
                    connected = true;
                }
                catch (NoNullAllowedException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kvieskit Dominyka!!");
                }
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kvieskit Dominyka!!");
            }
        }

        private void WriteEchoToTextBox(string Echo)
        {
            textBoxEcho.Text += Echo + Environment.NewLine;
        }

        private void buttonSendA_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(A1.Text) ||
                    string.IsNullOrEmpty(A2.Text) ||
                    string.IsNullOrEmpty(A3.Text) ||
                    string.IsNullOrEmpty(A4.Text) ||
                    string.IsNullOrEmpty(A5.Text) ||
                    string.IsNullOrEmpty(A6.Text))
                {
                    throw new NoNullAllowedException("Please fill A1-A6 fields");
                }
                string dataToSend = @"<Sensor><speed>1</speed><Show control= """ + 1 + @"""></Show><Positions><Current A1="""
                + A1.Text + @""""" />< Current A2 = """ + A2.Text + @""" />< Current A3 = """
                + A3.Text + @""" />< Current A4 = """ + A4.Text
                + @""" />< Current A5 = """ + A5.Text
                + @""" />< Current A6 = """ + A6.Text
                + @""" />< Current X = """ + X.Text
                + @""" />< Current Y = """ + Y.Text
                + @""" />< Current Z = """ + Z.Text
                + @""" />< Current A = """ + A.Text
                + @""" />< Current B = """ + B.Text
                + @""" />< Current C = """ + C.Text
                + @""" /></ Positions >< Read >< xyzabc X = """
                + X.Text + @""" Y = """ + Y.Text + @""" Z = """
                + Z.Text + @""" A = """ + A.Text + @""" B = """
                + B.Text + @""" C = """ + C.Text + @""" /></ Read ></ Sensor > ";
                _client.DataToSend(dataToSend);
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kviesti Dominyka");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            connected = false;
            _client.Stop();
            textBoxIp.ReadOnly = false;
            textBoxPort.ReadOnly = false;
        }
    }
}