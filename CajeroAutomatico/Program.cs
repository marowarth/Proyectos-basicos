using System;

class CajeroAutomatico
{
    static void Main()
    {
        decimal saldo = 1000m; // Saldo inicial
        int opcion;

        do
        {
            Console.WriteLine("\nCajero Automático");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Tu saldo actual es: {saldo:C}");
                    break;

                case 2:
                    Console.Write("Introduce la cantidad a depositar: ");
                    decimal deposito = decimal.Parse(Console.ReadLine());
                    saldo += deposito;
                    Console.WriteLine($"Has depositado {deposito:C}. Nuevo saldo: {saldo:C}");
                    break;

                case 3:
                    Console.Write("Introduce la cantidad a retirar: ");
                    decimal retiro = decimal.Parse(Console.ReadLine());
                    if (retiro > saldo)
                    {
                        Console.WriteLine("Saldo insuficiente.");
                    }
                    else
                    {
                        saldo -= retiro;
                        Console.WriteLine($"Has retirado {retiro:C}. Nuevo saldo: {saldo:C}");
                    }
                    break;

                case 4:
                    Console.WriteLine("Gracias por usar el cajero. ¡Adiós!");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 4);
    }
}
