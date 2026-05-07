using MyFirstApp;

class Program
{
    static void Main(string[] args)
    {
    // Создаем объекты OldPrinter и Photocopier
    OldPrinter printer = new OldPrinter();
    Photocopier photocopier = new Photocopier();

    // Вызываем метод Print
    printer.Print("Мой важный документ");

    // Вызываем метод Print
    photocopier.Print("Тестовая надпись");

    // Вызываем метод Scan
    photocopier.Scan("Тестовый скан");
    }
}