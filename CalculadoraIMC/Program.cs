using System;

class CalculadoraIMC
{
    static void Main()
    {
        Console.Write("Introduce tu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Introduce tu altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine($"\nTu IMC es: {imc:F2}");
        if (imc < 18.5)
        {
            Console.WriteLine("Clasificación: Bajo peso.");
        }
        else if (imc < 24.9)
        {
            Console.WriteLine("Clasificación: Peso normal.");
        }
        else if (imc < 29.9)
        {
            Console.WriteLine("Clasificación: Sobrepeso.");
        }
        else
        {
            Console.WriteLine("Clasificación: Obesidad.");
        }
    }
}
