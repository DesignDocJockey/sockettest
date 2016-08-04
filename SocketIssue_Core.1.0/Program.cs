using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SocketIssue_Core._1._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //retrieve an open socket
            //var openSocket = OpenConnection();
        }

        public static async Task<Socket> OpenConnection(int version, string serverAddress, int serverPort, string socksAddress, int socksPort, string username = null, string password = null)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var endPoint = new DnsEndPoint(socksAddress, socksPort);
            //Func<AsyncCallback, object, IAsyncResult> begin =
            //    (cb, s) => socket.BeginConnect(endPoint, cb, s);

            await socket.ConnectAsync(endPoint);
            //from this point on, the runtime will now return an open socket connection

            return socket;
        }
    }
}
