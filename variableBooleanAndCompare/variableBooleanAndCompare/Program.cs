using System;

namespace variableBooleanAndCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            bool TrueValue = true;
            bool falseValue = false;

            Console.WriteLine($"true: {TrueValue}; false: {falseValue}");

            int a = 5, b = 6, c = 7, d = 9;

            TrueValue = a < b;
            falseValue = b > c;

            bool compareValue1 = TrueValue || falseValue; // || az or
            bool compareValue2 = TrueValue && !falseValue; // && az and

            Console.WriteLine($"compareValue1: {compareValue1}; compareValue2: {compareValue2}");

            bool compareValue = a == b;
            Console.WriteLine(compareValue);
            compareValue = a != b;
            Console.WriteLine(compareValue);



        }
    }
}
