using System;
using System.ComponentModel.DataAnnotations;

namespace looping
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 5;
            Console.WriteLine("length: " + length);

            for (int i = 0; i < length; i++)
            {
                Console.Write(" :) ");
            }

            Console.WriteLine("length: "+length);

            while (length > 0)
            {
                Console.Write(" :( ");
                length--;
            }
            
            Console.WriteLine("length: " + length);

            do
            {
                Console.Write(" :/ ");
                length++;
            } while (length<5);

            Console.WriteLine("length: " + length);
            
            
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");

            //y = x^2 gráfja
            //az ablak méretei miatt vegyük le a méretét: 225 * x = 80
            //                                            x = .3555
            for (int i = -15; i <= 15; i++)
            {
                var y = i * i * .3555;
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

        }
    }
}
