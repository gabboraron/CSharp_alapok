using System;

namespace programVariableStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string aString = "Hello";
            string anotherstring = "XY";
            string theString;
            string bString = string.Empty;
            var varString = "one more";

            Console.Write("Enter a string: ");
            theString = Console.ReadLine();

            Console.WriteLine($"Astring: {aString}, another: {anotherstring}, theString: {theString}");
            Console.WriteLine($"Astring: {aString.Length}, another: {anotherstring.Length}, theString: {theString.Length}");

            string concat = aString + " " +  anotherstring;
            Console.WriteLine($"concat: {concat}");
            Console.WriteLine("concat: "+ concat);

            char aChar = 'A';
            char bChar = 'B';
            char cChar = 'C';
            char dChar;

            Console.WriteLine($"{aChar}|{bChar}|{cChar}");
            string ABC = aChar.ToString() + bChar.ToString() + cChar.ToString();
            Console.WriteLine(ABC);

            Console.Write("Pls enter 4 chars: ");
            aChar = Convert.ToChar(Console.Read());
            bChar = Convert.ToChar(Console.Read());
            cChar = Convert.ToChar(Console.Read());
            dChar = Convert.ToChar(Console.Read());
            Console.ReadLine();

            Console.WriteLine($"{aChar},{bChar},{cChar},{dChar}");

        }   
    }
}
