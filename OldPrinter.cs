namespace MyFirstApp;

public class OldPrinter : IPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Печатает старый принтер \"{document}\"");
    }
}