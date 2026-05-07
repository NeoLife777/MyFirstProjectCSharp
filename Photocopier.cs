namespace MyFirstApp;

public class Photocopier : IPrinter, IScanner
{
    private String _model;

    public Photocopier(String model)
    {
        _model = model;
        Console.WriteLine($"Создан старый принтер модели: {_model}");

    }
    public void Print(string document)
    {
        Console.WriteLine($"Печатает фотопринтер \"{_model}\" на документе \"{document}\"");
        
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Сканирует фотопринтер \"{_model}\" на документе \"{document}\"");

    }
}