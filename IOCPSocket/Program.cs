using NetFrame.Net;
using System;
using System.Net;

namespace IOCPSocket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AsyncIOCPServer server = new AsyncIOCPServer(IPAddress.Parse("192.168.1.5"), 1085, 1024);
            server.Start();
            Console.WriteLine("服务器已启动....");
            System.Console.ReadLine();
        }
    }
}
