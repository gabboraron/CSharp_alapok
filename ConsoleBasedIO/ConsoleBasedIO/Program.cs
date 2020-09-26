using System;

namespace ConsoleBasedIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What  is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, nice name!"); //fontos, hogy " és nem '
            Console.Write($"so, hey {name}, What would you like to order today? ");
            var order = Console.ReadLine();
            Console.Write($"Well, this {order} sounds delicious!\nThis will be ");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("$5.6");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
