using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace ListeningSocketTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Server myServer = new Server();
            myServer.createSocket();
            myServer.bindListenerAndListen();
            Console.ReadKey();
        }
    }
}
