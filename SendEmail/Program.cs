// See https://aka.ms/new-console-template for more information
using System.Net.Mail;
using System.Net;
using System;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Bienvenido al mejor programa para enviar emails!");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("A quien quieres enviar un email?");
Console.ForegroundColor = ConsoleColor.White;
string to=Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Cual es el asunto?");
Console.ForegroundColor = ConsoleColor.White;
string emailSubject = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Que quieres decirle?");
Console.ForegroundColor = ConsoleColor.White;
string emailBody=Console.ReadLine();

MailAddress addressFrom = new MailAddress("marowarthYT@gmail.com", "MarowarthYT");
MailAddress addressTo = new MailAddress(to);
MailMessage message = new MailMessage(addressFrom, addressTo);
message.Subject = emailSubject;
message.IsBodyHtml = true;
message.Body = emailBody;
SmtpClient client = new SmtpClient("smtp.gmail.com");
client.Port = 587;
client.EnableSsl = true;
client.UseDefaultCredentials = false;
client.Credentials =
new NetworkCredential("marowarthYT@gmail.com", "ubup bbom xkkh tcht");
try
{
    client.Send(message);
}
catch (Exception ex)
{
    System.Diagnostics.Trace.TraceInformation("Exception caught in CreateTestMessage2(): {0}",
        ex.ToString());
    Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
        ex.ToString());
}