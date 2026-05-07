namespace MyFirstApp;

public class Photocopier : IPrinter, IScanner
{
    public void Print(string document)
    {
        Console.WriteLine($"Печатает фотопринтер \"{document}\"");
        
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Сканирует фотопринтер \"{document}\"");

    }
}