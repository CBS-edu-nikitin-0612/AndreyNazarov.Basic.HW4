using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Контракт", "Тело контракта...", "Директор: Иванов И.И.");
            document.Show();
            // Delay.
            Console.ReadKey();
        }
    }
}
