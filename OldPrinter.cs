namespace MyFirstApp;

public class OldPrinter : IPrinter
{
    private String _model;

    public OldPrinter(String model)
    {
        _model = model;
        Console.WriteLine($"Создан старый принтер модели: {_model}");

    }

    public void Print(string document)
    {
        Console.WriteLine($"Печатает старый принтер \"{_model}\" на документе \"{document}\"");
    }
}