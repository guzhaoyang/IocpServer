using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using IocpSharp.Server;

namespace ConsoleApp1
{
    public class ServerSocket : TcpIocpServer
    {
        public List<Socket> clientSockets = new List<Socket>();
        protected override void NewClient(Socket client)
        {
            clientSockets.Add(client);
            Console.WriteLine("已接入{0}个", clientSockets.Count);
        }
    }
}
