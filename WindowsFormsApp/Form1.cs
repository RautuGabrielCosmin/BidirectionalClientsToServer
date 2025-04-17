using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;
using WindowsFormsApp.Utils;


namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        //constants
        private const string CRLF = "\r\n";

        //fields
        private List<TcpClient> _client_list;
        private TcpListener _listener;
        private int _client_count;
        private bool _keep_going;
        private int _port;
        private int DEFAULT_PORT = 5000;

        public Form1()
        {
            InitializeComponent();
            _client_list = new List<TcpClient>();
            _connectedClientsTextBox.Text = "0";
            _startServerButton.Enabled = true;
            _stopServerButton.Enabled = false;
            _sendCommandButton.Enabled = false;
            _statusTextBox.Text = string.Empty;
        }

        private void StartServerButtonHandler(object sender, EventArgs e)
        {

            try
            {
                if(!Int32.TryParse(_portTextBox.Text, out _port))
                {
                    _port = DEFAULT_PORT;
                    _statusTextBox.Text += CRLF + "You have entered an invalid number. Using port:" + _port;
                }

                Thread t = new Thread(ListenForIncomingConnections);
                t.Name = "Server Listener Thread";
                t.IsBackground = true;
                t.Start();
                _startServerButton.Enabled = false;
                _stopServerButton.Enabled = true;
                _sendCommandButton.Enabled = true;
            }
            catch (Exception ex)
            {
                _statusTextBox.Text += CRLF + "Problem starting server";
                _statusTextBox.Text += CRLF + ex.ToString();
            }
        }

        private void ListenForIncomingConnections()
        {

            try
            {
                _keep_going = true;
                _listener = new TcpListener(IPAddress.Any, _port);
                _listener.Start();
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Server started, listening on port: " + _port);

                while (_keep_going)
                {
                    _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Waiting for incoming client connections...");
                    TcpClient client = _listener.AcceptTcpClient(); //blocks until client connection accepted
                    _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Incoming client connection accepted...");

                    Thread t = new Thread(ProcessClientRequest);
                    t.IsBackground = true;
                    t.Start(client);
                }

            }
            catch (SocketException se)
            {
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "SocketException: " + se.Message);

            }
            catch (Exception ex)
            {
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Exception: " + ex.Message);

            }
            _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Exiting listener thread...");
            _statusTextBox.InvokeEx(stb => stb.Text = string.Empty);
        }//end ListenForIncmingConnections 

        private void StopServerButtonHandler(object sender, EventArgs e)
        {
            _keep_going = false;
            _statusTextBox.Text = string.Empty;
            _statusTextBox.Text = "Shutting down server, disconnecting all clients...";

            try
            {
                foreach(TcpClient client in _client_list)
                {
                    client.Close();
                    _client_count -= 1;
                    if (_client_count < 0)
                    {
                        _client_count = 0;
                    }
                    _connectedClientsTextBox.Text = _client_count.ToString();

                }
                _client_list.Clear();
                _listener.Stop();
            }
            catch(Exception ex)
            {
                _statusTextBox.Text += CRLF + "Problem stopping server or client connections forcebly closed";
                _statusTextBox.Text += CRLF + ex.ToString();
            }

            _startServerButton.Enabled = true;
            _stopServerButton.Enabled = false;
            _sendCommandButton.Enabled = false;
            _client_count = 0;
            //_statusTextBox.InvokeEx(stb => stb.Text = string.Empty);

        }//StopServerButtonHandler

        private void SendCommandButtonHandler(object sender, EventArgs e)
        {
            try
            {
                foreach (TcpClient client in _client_list)
                {
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    writer.WriteLine(_clientCommandTextBox.Text);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                _statusTextBox.Text += CRLF + "Problem sending commands to clients...";
                _statusTextBox.Text += CRLF + ex.ToString();
                
            }
            _clientCommandTextBox.Text = string.Empty;
        }//SendCommandButtonHandler

        private void ProcessClientRequest(object tcpClient)
        {
            TcpClient client = (TcpClient)tcpClient;
            _client_list.Add(client);
            _client_count += 1;
            _connectedClientsTextBox.InvokeEx(cctb => cctb.Text = _client_count.ToString());

            string input = string.Empty;

            try
            {

                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());

                while (client.Connected)
                {
                    input = reader.ReadLine(); //block until it receives something from the client

                    switch (input) //implement commands here
                    {
                        default:
                            {
                                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "From client: " + client.GetHashCode() + " " + input);
                                writer.WriteLine("Server received: " + input);
                                writer.Flush();
                                break;
                            }
                    }
                }
            }
            catch (SocketException se)
            {
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Problem processing client requests!");
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + se.ToString());
            }
            catch (Exception ex)
            {
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Problem processing client requests!");
                _statusTextBox.InvokeEx(stb => stb.Text += CRLF + ex.ToString());
            }
            _client_list.Remove(client);
            _client_count -= 1;
            if(_client_count < 0)
            {
                _client_count = 0;
            }
            _connectedClientsTextBox.InvokeEx(cctb => cctb.Text = _client_count.ToString());
            _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Finished processing client requests for client:" + client.GetHashCode());
        }//ProcessClientRequest
    }
}
