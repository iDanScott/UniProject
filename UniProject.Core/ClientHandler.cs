﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace UniProject.Core
{
    public class ClientHandler : IDisposable
    {
        public delegate void ClientDisconnectedHandler(object sender, CustomEventArgs e);
        public delegate void DataSentHandler(object sender, CustomEventArgs e);
        public delegate void DataReceivedHandler(object sender, CustomEventArgs e);
        public event ClientDisconnectedHandler ClientDisconnected;
        public event DataSentHandler DataSent;
        public event DataReceivedHandler DataReceived;

        private Server m_Server;
        private TcpClient m_Client;
        private Thread m_WorkerThread;
        private volatile bool m_ShouldWork;
        private string m_CurrentUser;

        public bool Connected
        {
            get { return m_Client.Connected; }
        }

        public IPAddress Address
        {
            get
            {
                if (m_Client.Client != null)
                    return ((IPEndPoint)m_Client.Client.RemoteEndPoint).Address;
                else
                    return (IPAddress.Any);
            }
        }

        public string CurrentUser
        {
            get { return m_CurrentUser;  }
            set { m_CurrentUser = value; }
        }

        public ClientHandler(Server server, TcpClient client)
        {
            m_Server = server;
            m_Client = client;
            m_WorkerThread = new Thread(Main);
            m_ShouldWork = true;
        }

        public void Main()
        {
            while (m_ShouldWork)
            {
                byte[] data;
                try
                {
                    int dataTotal = 0;
                    int dataReceived = 0;
                    byte[] packetSize = new byte[4];
                    if (m_Client.Client != null)
                        dataReceived = m_Client.Client.Receive(packetSize, 0, 4, 0);
                    int dataBuffer = BitConverter.ToInt32(packetSize, 0);
                    int dataLeft = dataBuffer;
                    data = new byte[dataBuffer];
                    while (dataTotal < dataBuffer)
                    {
                        if (m_Client.Client != null)
                            dataReceived = m_Client.Client.Receive(data, dataTotal, dataLeft, 0);
                        if (dataReceived == 0)
                            break;
                        dataTotal += dataReceived;
                        dataLeft -= dataReceived;
                    }

                    if (DataReceived != null)
                        DataReceived(this, new CustomEventArgs(data));
                }
                catch (SocketException)
                {
                    // Connection Dropped
                    Stop();
                }
                catch (Exception)
                {
                    data = new byte[4];
                }
            }
        }

        public void Send(string data)
        {
            Send(ASCIIEncoding.ASCII.GetBytes(data));
        }

        public void Send(byte[] data)
        {
            try
            {
                if (m_Client.Connected)
                {
                    int dataTotal = 0;
                    int dataLeft = data.Length;
                    int dataSize = data.Length;
                    int dataSent;
                    byte[] dataBuffer = new byte[4];
                    dataBuffer = BitConverter.GetBytes(data.Length);
                    int bytesSent = m_Client.Client.Send(dataBuffer);
                    while (dataTotal < dataSize)
                    {
                        dataSent = m_Client.Client.Send(data, dataTotal, dataLeft, SocketFlags.None);
                        dataTotal += dataSent;
                        dataLeft -= dataSent;
                    }
                    if (DataSent != null)
                        DataSent(this, new CustomEventArgs(data));
                }
            }
            catch
            {
                this.Stop();
            }
        }

        public void Start()
        {
            if (!m_WorkerThread.IsAlive)
                m_WorkerThread.Start();
        }

        public void Stop()
        {
            if (ClientDisconnected != null)
                ClientDisconnected(this, new CustomEventArgs(Address.ToString()));
            m_ShouldWork = false;
            m_Client.Close();
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
