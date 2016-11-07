using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.IO.Ports;
using System.Net.Sockets;

namespace poseplayer
{
    class UdpBridgeController : Controller
    {
        // ----- public -----
        /* typedef, enum */
        /* const */
        /* constructor */
        public UdpBridgeController(SerialPort p, string ip_adr, int port)
        {
            uart_ = p;
            remoteHost_ = ip_adr;
            remotePort_ = port;
            localPort_ = port;
        }
        /* destructor */
        /* member, static member */
        /* method, static method */
        public void Init()
        {
            udp_ = new UdpClient(localPort_);
        }

        public override void Start()
        {
            // start service
            base.Start();
            is_thread_enable_ = true;
            this.service_thread_ = new Thread(new ThreadStart(main_proc));
            this.service_thread_.Start();
        }

        public override void Kill()
        {
            // kill service
            base.Kill();
            is_thread_enable_ = false;
        }

        public void Dispose()
        {
            udp_.Close();
        }

        // ----- protected -----
        /* typedef, enum */
        /* const */
        /* constructor */
        /* destructor */
        /* member, static member */
        /* method, static method */

        // ----- private -----
        /* typedef, enum */
        private const int kReceiveUartDataLength = 6;
        /* const */
        /* constructor */
        /* destructor */
        /* member, static member */
        SerialPort uart_ = null;
        private bool is_thread_enable_ = false;
        UdpClient udp_ = null;
        private string remoteHost_ = "localhost";
        private int remotePort_ = 10000;
        private int localPort_ = 10000;
        /* method, static method */
        private void main_proc()
        {
            while(is_thread_enable_)
            {
                try
                {
                    System.Net.IPEndPoint remoteEP = null;
                    byte[] rcvBytes = udp_.Receive(ref remoteEP);
                    uart_.Write(rcvBytes, 0, rcvBytes.Length);

                    byte[] rcvUartBytes = new byte[256];
                    int uart_rcv_length = uart_.Read(rcvUartBytes, 0, kReceiveUartDataLength);
                    udp_.Send(rcvUartBytes, 6, remoteHost_, remotePort_);
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
