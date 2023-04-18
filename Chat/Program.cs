using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string username = Console.ReadLine();

        using (var clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
        {
            clientSocket.Connect("127.0.0.1", 8888);

            byte[] usernameBytes = Encoding.ASCII.GetBytes(username);
            clientSocket.Send(usernameBytes);

            Thread receiveThread = new Thread(() => ReceiveMessages(clientSocket));
            receiveThread.Start();

            Console.WriteLine("Connected to server. Start typing your messages:");
            string message = "";

            while (message != "/exit")
            {
                message = Console.ReadLine();
                byte[] messageBytes = Encoding.ASCII.GetBytes(message);
                clientSocket.Send(messageBytes);
            }

            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
    }

    static void ReceiveMessages(Socket clientSocket)
    {
        while (true)
        {
            byte[] buffer = new byte[1024];
            int bytesReceived = clientSocket.Receive(buffer);
            string message = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
            Console.WriteLine(message);
        }
    }
}