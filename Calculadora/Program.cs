Console.WriteLine("Primer numero: ");
double firstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Segundo numero: ");
double secondNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Elige operacion (+, -, *, /): ");
string operation = Console.ReadLine();

double result;

switch (operation)
{
    case "+":
        result = firstNumber + secondNumber;
        Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
        break;
    case "-":
        result = firstNumber - secondNumber;
        Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
        break;
    case "*":
        result = firstNumber * secondNumber;
        Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);
        break;
    case "/":
        if (secondNumber == 0)
        {
            Console.WriteLine("no se puede dividir por 0.");
        }
        else
        {
            result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);
        }
        break;
    default:
        Console.WriteLine("operacion invalida.");
        break;
}

Console.ReadLine();