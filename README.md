# C# és Visual Studio alapok
**Tartalom**
- [Visual Studio]()
- [`Hello World` program]()
- [I/O alapok]()
- [Számok]()
- [Szövegek]()
- [Logikai változók és összehasonlítások]()
- [`if` `then` `else`]()
- [Cilusok]()
  - [`For`]()
  - [`While`]()
  - [do-while]()

## Visual Studio
1. [Letöltés és telepítés](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=16)
2. Szükséges telepítendő csomag(ok): `.NET desktop development` és `Universal Windows Platform Development`
3. `Create New Project` >  `Console App (.NET Core)`
4. Sor sorszámozás bekapcsolása: https://docs.microsoft.com/en-us/visualstudio/ide/reference/how-to-display-line-numbers-in-the-editor?view=vs-2019

-----

## `Hello World!`
fájl: [Hello World.sln](https://github.com/gabboraron/CSharp_alapok/blob/3c1c9d903cdaf32805564a8f5751d21a8850a3be/Hello%20World.sln), [Hello World](https://github.com/gabboraron/CSharp_alapok/tree/3c1c9d903cdaf32805564a8f5751d21a8850a3be/Hello%20World)
```C#
using System;

namespace Hello_World
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
```

## I/O alapok
fájl: [ConsoleBasedIO](https://github.com/gabboraron/CSharp_alapok/tree/master/ConsoleBasedIO)
```C#
using System;

namespace ConsoleBasedIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What  is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, nice name!");                           //fontos, hogy " és nem '
            Console.Write($"so, hey {name}, What would you like to order today? ");   //változóval kiíratás
            var order = Console.ReadLine();
            Console.Write($"Well, this {order} sounds delicious!\nThis will be ");
            Console.BackgroundColor = ConsoleColor.Blue;                              //sor háttérszínének megváltoztatása, bővebben: https://www.dotnetperls.com/console-color
            Console.WriteLine("$5.6");
            Console.BackgroundColor = ConsoleColor.Black;                             //sor háttérszínének megváltoztatása
        }
    }
}
```

## Számok
fájl: [ProgramVariableNumbers](https://github.com/gabboraron/CSharp_alapok/tree/master/ProgramVariableNumbers)
```C#
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
```

## Szövegek
> A karakterek sázmok amik szöveggé alakíthatóak, ha összefűzünk karaktereket akkor a végeredmény alapértelmezetten lehet szám **!**

fájl: [programVariableStrings](https://github.com/gabboraron/CSharp_alapok/tree/master/programVariableStrings)
```C#
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
```

## Logikai változók és összehasonlítások
`>`,`<`,`>=`,`<=`,`==`,`!=`

fájl: [variableBooleanAndCompare](https://github.com/gabboraron/CSharp_alapok/tree/master/variableBooleanAndCompare)
```C#
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
```

## `if` `then` `else`
fájl: [payCheck](https://github.com/gabboraron/CSharp_alapok/tree/master/payCheck)
```C#
            if (double.TryParse(Console.ReadLine(), out hoursWorked))
            {
                if (hoursWorked > 0)
                {
                    //calc payment
                    if (hoursWorked > 40)
                    {
                        //calc overtime
                        double payAmount = hoursWorked * payRate + (hoursWorked - 40) * payRate * 1.5;
                        Console.WriteLine("Your payment is: " + payAmount);
                    }
                    else
                    {
                        double payAmount = hoursWorked * payRate;
                        Console.WriteLine("Your payment is: " + payAmount);
                    }
                }
                else
                {
                    Console.WriteLine("No work = no money");
                }
            }
            else
            {
                Console.WriteLine("BAD DATA FORMAT!");
            }
```

## Ciklusok
fájl:[looping](https://github.com/gabboraron/CSharp_alapok/tree/master/looping)
### For
```C#
            for (int i = 0; i < length; i++)
            {
                Console.Write(" :) ");
            }
```
### While
```C#
            while (length > 0)
            {
                Console.Write(" :( ");
                length--;
            }
```
### do-While
```C#
            do
            {
                Console.Write(" :/ ");
                length++;
            } while (length<5);
```
### y = x^2 gráfja
> `-15` és `+15` között az x értéke a `y = x^2` egyenletre
>
> hogy beleférjen az ablakba lekicsinyítjük: `225 * x = 80` => `x = .3555`
```C#
            for (int i = -15; i <= 15; i++)
            {
                var y = i * i * .3555;
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
```
kimenet: 
```
                                                                      *
                                                             *
                                                    *
                                            *
                                    *
                             *
                       *
                  *
             *
         *
      *
    *
  *
 *
*
 *
  *
    *
      *
         *
             *
                  *
                       *
                             *
                                    *
                                            *
                                                    *
                                                             *
                                                                      *

```
## Példaprogram
fál: []()
