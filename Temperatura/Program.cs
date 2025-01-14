using System;

class Temperatura
{
    static void Main()
    {
        Console.WriteLine("Conversor de Temperatura");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Fahrenheit a Celsius");
        Console.Write("Elige una opción (1 o 2): ");
        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Introduce la temperatura: ");
        double temperatura = double.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            double fahrenheit = (temperatura * 9 / 5) + 32;
            Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit:F2}");
        }
        else if (opcion == 2)
        {
            double celsius = (temperatura - 32) * 5 / 9;
            Console.WriteLine($"La temperatura en Celsius es: {celsius:F2}");
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }
}
