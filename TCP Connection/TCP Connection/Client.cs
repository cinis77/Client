using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Connection
{
    internal class Client
    {
        public delegate void EventDelagateFunction(string Echo);

        public event EventDelagateFunction EchoReveived;

        public int PortNo { get; }
        public string ServerIP { get; }

        public byte[] EchoBuffer { get; private set; }
        public string EchoData { get; private set; }
        public string LastSentData { get; private set; }

        private TcpClient _client;
        private IPAddress _ip;
        private byte[] _buffer;
        private NetworkStream networkStream;

        public Client(int portNo, string serverIP)
        {
            PortNo = portNo;
            ServerIP = serverIP;
            _ip = IPAddress.Parse(ServerIP);
            _client = new TcpClient(ServerIP, PortNo);
        }

        public void DataToSend(string Data)
        {
            networkStream = _client.GetStream();
            _buffer = UTF8Encoding.UTF8.GetBytes(Data);
            networkStream.Write(_buffer, 0, _buffer.Length);
            GetEcho();
        }

        private void GetEcho()
        {
            EchoBuffer = new byte[_client.ReceiveBufferSize];
            int bytesAmount = networkStream.Read(EchoBuffer, 0, _client.ReceiveBufferSize);
            EchoData = Encoding.UTF8.GetString(EchoBuffer, 0, bytesAmount);
            EchoReveived.Invoke(EchoData);
        }

        public void Stop()
        {
            _client.Close();
            _client.Dispose();
        }
    }
}