using System;

namespace Flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = 50;
            
            while (true)
            {
                Console.WriteLine("What flower colour would you like to buy?");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yellow");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Black");
                Console.ResetColor();

                budget -= FlowerShop.FlowerBuying();
            }
        }
    }
}
