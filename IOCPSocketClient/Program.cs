using System;
using System.Net;

namespace IOCPSocketClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPAddress remote = IPAddress.Parse("192.168.1.5");
            client c = new client(1085, remote);

            c.connect();
            Console.WriteLine("服务器连接成功!");
            while (true)
            {
                Console.Write("send>");
                string msg = Console.ReadLine();
                if (msg == "exit")
                    break;
                c.send(msg);
            }
            c.disconnect();
            Console.ReadLine();
        }
    }
}
