using System;

namespace ProgramVariableNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 53;
            int aNumber;
            var someNumber = 33;

            Console.Write("Enter a number: ");
            aNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number 1: {number}, A number: {aNumber}, Some Number: {someNumber}");

            double doubleValue = 44.5;
            var anotherDouble = 54.66;

            Console.Write("Enter a decimal number: ");
            double enteredNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Double1: {doubleValue}, Another: {anotherDouble}, Entered: {enteredNumber}");

            int counter = 0;
            for (int i = 0; i < 15; i++)
            {
                counter++;
                Console.WriteLine($"Counter is: {counter}");
            }

            Console.WriteLine(" ");
            for (int i = 0; i < 15; i++)
            {
                counter--;
                Console.WriteLine($"Counter is: {counter}");
            }

            var answer = aNumber + number / 122 * doubleValue - anotherDouble;
            Console.WriteLine($"Aswer: {answer} :) ");
        }
    }
}
