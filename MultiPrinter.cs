namespace MyFirstApp;

public class MultiPrinter : IPrinter, IScanner, IFax
{

    private String _model;

    public MultiPrinter(String model)
    {
        _model = model;
        Console.WriteLine($"Создан старый принтер модели: {_model}");

    }
    public void Print(string document)
    {
        Console.WriteLine($"Печатает мультипринтер \"{_model}\" на документе \"{document}\"");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Сканирует мультипринтер \"{_model}\" на документе \"{document}\"");
    }

    public void Fax(string document)
    {
        Console.WriteLine($"Отправляет Fax мультипринтер \"{_model}\" на документе \"{document}\"");
    }
}