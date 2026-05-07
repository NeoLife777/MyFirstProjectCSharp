using MyFirstApp;

class Program
{
    static void Main(string[] args)
    {
    // Создаем объекты OldPrinter, Photocopier и MultiPriner
    OldPrinter printer = new OldPrinter("Canon x1");
    Photocopier photocopier = new Photocopier("HP x2");
    MultiPrinter multiPrinter = new MultiPrinter("Xerox x3");

    // Вызываем метод Print
    printer.Print("Мой важный документ");

    // Вызываем метод Print
    photocopier.Print("Тестовая надпись");

    // Вызываем метод Scan
    photocopier.Scan("Тестовый скан");

    // Вызываем все методы MultiPriner
    multiPrinter.Print("Ваня");
    multiPrinter.Scan("Хочу");
    multiPrinter.Fax("Всегда кодить на C#");
    }
}