using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using WindowsFormsAppClient.Utils;

namespace WindowsFormsAppClient
{
    public partial class Form1 : Form
    {

        //Constants
        private const String CRLF = "\r\n";
        private const String LOCALHOST = "127.0.0.1";
        private const int DEFAULT_PORT = 5000;

        //Fields
        private IPAddress _serverIpAddress;
        private int _port;
        private TcpClient _client;

        /// <summary>
        ///Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            _serverIpAddress = GetIpAddress(_ipAddressTextBox.Text);
            _port = GetPort(_portTextBox.Text);
            _connectButton.Enabled = true;
            _disconnectButton.Enabled = false;
            _sendCommandButton.Enabled = false;
        }

        #region Event Handlers

        private void ConnectButtonHandler(object sender, EventArgs e)
        {

            try
            {
                _client =  new TcpClient(_serverIpAddress.ToString(), _port);
                Thread t = new Thread(ProcessClientTransactions);
                t.IsBackground = true;
                t.Start(_client);

                _connectButton.Enabled = false;
                _disconnectButton.Enabled = true;
                _sendCommandButton.Enabled = true;

            }
            catch (Exception ex)
            {
                _statusTextBox.Text += CRLF + "Problem connecting to server";
                _statusTextBox.Text += CRLF + ex.ToString();
            }


        }//end of ConnectButtonHandler

        private void DisconnectButtonHandler(object sender,EventArgs e)
        {
            DisconnectFromServer();

        }//end of DisconnectButtonHandler

        private void SendCommandButtonHandler(object sender, EventArgs e)
        {
            try
            {
                if (_client.Connected)
                {
                    StreamWriter writer = new StreamWriter(_client.GetStream());
                    writer.WriteLine(_commandTextBox.Text);
                    writer.Flush();
                    _statusTextBox.Text += CRLF + "Command sent to server: " + _commandTextBox.Text;
                    _commandTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                _statusTextBox.Text += CRLF + "Problem sending command to the server!";
                _statusTextBox.Text += CRLF + ex.ToString(); 
            }
        }//end of SendCommandButtonHandler

        #endregion Event Handlers


        private void ProcessClientTransactions(object tcpClient)
        {
            TcpClient client = (TcpClient) tcpClient;
            string input = string.Empty;
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());
                //Say, Hello to the server once we connect...
                writer.WriteLine("Hello from a client! Ready to do your bidding");
                writer.Flush();

                while (client.Connected)
                {
                    input = reader.ReadLine(); //block here until the server sends a message
                    if(input == null)
                    {
                        DisconnectFromServer();
                    }
                    else 
                    {
                        switch(input)
                        {
                            default:
                                {
                                    _statusTextBox.InvokeEx(SendToBack => SendToBack.Text += CRLF + "Received form Server:" + input);
                                    break;
                                }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Problem communicating with the server.");
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + ex.ToString());
            }
            _connectButton.InvokeEx(cb => cb.Enabled = true);
            _disconnectButton.InvokeEx(dcb => dcb.Enabled = false);
        }//end of ProcessClientTransactions


        private void DisconnectFromServer()
        {
            try
            {
                _client.Close();
                _statusTextBox.InvokeEx(stb => stb.Text = string.Empty);
                _connectButton.InvokeEx(cb => cb.Enabled = true);
                _disconnectButton.InvokeEx(dcb => dcb.Enabled = false);
                _sendCommandButton.InvokeEx(scb => scb.Enabled = false);
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Disconnected from the server.");

            }
            catch (Exception ex)
            {
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Problem disconnecting form the server");
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + ex.ToString());


            }
        }


        #region Utility Methods

        private IPAddress GetIpAddress(string ipAddress)
        {

            IPAddress address = IPAddress.Parse(LOCALHOST);

            try
            {

                if (!IPAddress.TryParse(ipAddress, out address))
                {
                    address = IPAddress.Parse(LOCALHOST);
                }

            }
            catch (Exception ex)
            {
                _statusTextBox.Text += CRLF + "Invalid IP address - Client will connect to: " + address.ToString();
                _statusTextBox.Text += CRLF + ex.ToString();
            }
            return address;
        }//end of GetIpAddress


        private int GetPort(string serverPort)
        {
            int port = DEFAULT_PORT;

            try
            {
                if (!Int32.TryParse(serverPort, out port))
                {
                    port = DEFAULT_PORT;
                }
            }
            catch (Exception ex)
            {
                _statusTextBox.Text += CRLF + "Invalid port value - Client will connect to port: " +port.ToString();
                _statusTextBox.Text += CRLF + ex.ToString();
            }
            return port;
        }//end of GetPort



        #endregion Utility Methods
    }
}
