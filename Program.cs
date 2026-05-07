using MyFirstApp;

class Program
{
    static void Main(string[] args)
    {
    // Создаем объекты OldPrinter, Photocopier и MultiPriner
    OldPrinter printer = new OldPrinter();
    Photocopier photocopier = new Photocopier();
    MultiPrinter multiPrinter = new MultiPrinter();

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