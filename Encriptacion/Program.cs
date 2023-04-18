Console.WriteLine("Mensaje a encriptar: ");
string message = Console.ReadLine();

string encryptedMessage = "";

for (int i = 0; i < message.Length; i++)
{
    char c = message[i];
    char encryptedC = (char)(c + 3);
    encryptedMessage += encryptedC;
}
Console.WriteLine("Mensaje encriptado: " + encryptedMessage);

string decryptedMessage = "";

for (int i = 0; i < encryptedMessage.Length; i++)
{
    char c = encryptedMessage[i];
    char decryptedC = (char)(c - 3);
    decryptedMessage += decryptedC;
}
Console.WriteLine("Quieres desencriptar(s/n)?");
if(Console.ReadLine().ToLower() == "s")
    Console.WriteLine("Mensaje desencriptado: " + decryptedMessage);

Console.ReadLine();