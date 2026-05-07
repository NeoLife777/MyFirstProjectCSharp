namespace MyFirstApp;

public class MultiPrinter : IPrinter, IScanner, IFax
{
    public void Print(string document)
    {
        Console.WriteLine($"Печатает мультпринтер \"{document}\"");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Сканирует мультипринтер \"{document}\"");
    }

    public void Fax(string document)
    {
        Console.WriteLine($"Отправляет Fax мультпринтер \"{document}\"");
    }
}