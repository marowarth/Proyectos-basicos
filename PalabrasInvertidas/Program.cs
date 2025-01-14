using System;

class PalabrasInvertidas
{
    static void Main()
    {
        Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine();
        char[] caracteres = palabra.ToCharArray();
        Array.Reverse(caracteres);
        string invertida = new string(caracteres);

        Console.WriteLine($"Palabra invertida: {invertida}");

        if (palabra.Equals(invertida, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("La palabra es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra no es un palíndromo.");
        }
    }
}
