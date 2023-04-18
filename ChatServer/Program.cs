using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;


class Program
{
    static Dictionary<Socket, string> clients = new Dictionary<Socket, string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Starting chat server...");

        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888));
        serverSocket.Listen(10);

        while (true)
        {
            Socket clientSocket = serverSocket.Accept();
            Console.WriteLine("New client connected: {0}", clientSocket.RemoteEndPoint);

            byte[] buffer = new byte[1024];
            int bytesReceived = clientSocket.Receive(buffer);
            string username = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
            clients.Add(clientSocket, username);
            Console.WriteLine("Client username: {0}", username);

            string welcomeMessage = GetWelcomeMessage();
            byte[] welcomeMessageBytes = Encoding.ASCII.GetBytes(welcomeMessage);
            clientSocket.Send(welcomeMessageBytes);

            string newClientMessage = string.Format("{0} has joined the chat!", username);
            SendMessageToAllClients(newClientMessage);

            Console.WriteLine("Current number of clients: {0}", clients.Count);

            Thread receiveThread = new Thread(() => ReceiveMessage(clientSocket));
            receiveThread.Start();
        }
    }

    static void ReceiveMessage(Socket clientSocket)
    {
        while (true)
        {
            byte[] buffer = new byte[1024];
            try
            {
                int bytesReceived = clientSocket.Receive(buffer);
                if (bytesReceived > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesReceived);

                    string username = clients[clientSocket];
                    string formattedMessage = string.Format("{0}: {1}", username, message);

                    SendMessageToAllClients(formattedMessage);
                }
                else
                {
                    // If the client socket is closed, remove the client from the dictionary and notify other clients.
                    string username = clients[clientSocket];
                    clients.Remove(clientSocket);
                    string leaveMessage = string.Format("{0} has left the chat.", username);
                    SendMessageToAllClients(leaveMessage);
                    Console.WriteLine("Client {0} disconnected.", clientSocket.RemoteEndPoint);
                    Console.WriteLine("Current number of clients: {0}", clients.Count);
                    break;
                }
            }
            catch (SocketException)
            {
                // If there is an error receiving data from the client, assume the client has disconnected and remove the client from the dictionary and notify other clients.
                string username = clients[clientSocket];
                clients.Remove(clientSocket);
                string leaveMessage = string.Format("{0} has left the chat.", username);
                SendMessageToAllClients(leaveMessage);
                Console.WriteLine("Client {0} disconnected.", clientSocket.RemoteEndPoint);
                Console.WriteLine("Current number of clients: {0}", clients.Count);
                break;
            }
        }
    }

    static void SendMessageToAllClients(string message)
    {
        foreach (Socket clientSocket in clients.Keys)
        {
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            clientSocket.Send(messageBytes);
        }
    }
    static string GetWelcomeMessage()
    {
        StringBuilder message = new StringBuilder();
        message.AppendLine("Welcome to the chat!");
        message.AppendLine("Type your messages below and press enter to send.");
        message.AppendLine("Type /exit to leave the chat.");
        message.AppendLine("-----------------------------");
        message.AppendLine("Current clients:");

        foreach (string username in clients.Values)
        {
            message.AppendLine(username);
        }

        message.AppendLine("-----------------------------");

        return message.ToString();
    }
}