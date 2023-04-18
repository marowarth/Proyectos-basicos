Random random = new Random();
int randomNumber = random.Next(1, 101);

int guess = 0;
int numberOfGuesses = 0;

while (guess != randomNumber)
{
    Console.WriteLine("Adivina el numero entre 1 y 100: ");
    guess = Convert.ToInt32(Console.ReadLine());

    numberOfGuesses++;

    if (guess < randomNumber)
    {
        Console.WriteLine("Muy bajo.");
    }
    else if (guess > randomNumber)
    {
        Console.WriteLine("Muy alto.");
    }
    else
    {
        Console.WriteLine("Felicidades! Has acertado en {0} intentos.", numberOfGuesses);
    }
}

Console.ReadLine();