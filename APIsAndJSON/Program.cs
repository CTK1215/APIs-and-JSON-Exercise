using System;


namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var generator = new QuoteGenerator();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {generator.GetKanyeQuote()}");
                Console.WriteLine($"Ron:   {generator.GetRonSwansonQuote()}");
                Console.WriteLine();
            }
        }
    }
}