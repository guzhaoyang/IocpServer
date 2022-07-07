
// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

string ip = "192.168.1.5";
int port = 1085;

#region IocpSharp
ServerSocket ServerSocket = new ServerSocket();
ServerSocket.Start(ip, port);
#endregion

Console.ReadLine();