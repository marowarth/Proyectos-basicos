
    Thread thread = new Thread(SomeMethod);
    thread.Start();

    Console.WriteLine("Hilo principal");


static void SomeMethod()
{
    Console.WriteLine("Hilo secundario");
}