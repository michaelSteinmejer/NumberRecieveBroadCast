using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace NumberRecieveBroadCast
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpServer = new UdpClient(9876);
           
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 9876);
            //udpClient.Connect(RemoteIpEndPoint); //
            


            try
            {
                while (true)
                {
                    Byte[] receiveBytes = udpServer.Receive(ref RemoteIpEndPoint);
                    //Client is now activated");

                    string receivedData = Encoding.ASCII.GetString(receiveBytes);
                    Console.WriteLine(receivedData);

                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }
    }
}
