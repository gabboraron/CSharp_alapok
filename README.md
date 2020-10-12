# C# és Visual Studio alapok
> Könyv: [Reiter István C# programozás  lépésről lépésre](https://github.com/gabboraron/CSharp_alapok/blob/master/Cshprogramozas.pdf)

> - szemétgyűjtőt használ
> - A legtöbb objektum-hozzáférés csak biztonságos hivatkozásokon keresztül tehető meg, és az aritmetikai műveletek debug módban túlcsordulás szempontjából ellenőrzöttek.
> - a szemétgyűjtő szabadítja fel az objektumokat, mikor már nincs rájuk hivatkozás
> - destruktorok (`~`) elérhetőek. A megfelelően megírt `IDisposable` interfész (Disposable programozási minta), aminek a lefutását garantálja using blokk, együtt kikényszerítheti az azonnali felszabadítást az osztályon belüli natív erőforrások esetében. A nem natív erőforrások felszabadítását ebben az esetben is a szemétgyűjtő (Garbage Collector) végzi. A finalizerek szintén rendelkezésre állnak, de nem váltanak ki azonnali felszabadítást.
> - csak egyszeres öröklődést támogat, de egy osztály több interfészt is megvalósíthat
> - Az egyetlen implicit konverzió a biztonságos konverzió, úgy mint az egészek tágabb intervallumba konvertálása vagy a leszármazott osztályok alaposztályba konvertálása. Nincs implicit konverzió az egészek és a logikai típus (`boolean`) között, a felsorolás tagok és az egészek között. Nincsenek void mutatók (bár az Object osztályra mutató mutatók hasonlóak), valamint bármely, a felhasználó által definiált implicit konverziót explicit módon meg kell jelölni.
> - felsorolás adattagjai a saját névtérben
> - 2.0+ rendelkezik a generikus programozás néhány eszközével
> - alapértelmezett láthatósága `private`
> -  kód névterekbe van rendezve, mely a hasonló funkciót ellátó osztályokat fogja össze. Például `System.Drawing` a grafikai, `System.Collections` az adatstruktúra és `System.Windows.Forms` a Windows ablakos megjelenítéséért felelős funkciókat fogja össze.
> - sorok vége `;`
> - Namespaces are named using Pascal Case (also called `UpperCamelCase`)
> - If an assembly contains only one namespace, the assembly and the namespace should use the same name. Otherwise, assemblies should follow the normal Pascal Case format.
> - kivételek a `System.Exception` -ből származnak le
> - aming conventions combined.
```C#
    using System;
     
    namespace MyExampleNamespace
    {
        public class Customer : IDisposable
        {
            private string _customerName;
            public string CustomerName 
            { 
                get 
                { 
                    return _customerName; 
                }
                set
                {
                    _customerName = value;
                    _lastUpdated = DateTime.Now;
                }
            }
     
            private DateTime _lastUpdated;
     
            public DateTime LastUpdated
            {
                get
                {
                    return _lastUpdated;
                }
                private set
                {
                    _lastUpdated = value;
                }
            }
     
            public void UpdateCustomer(string newName)
            {
                if (!newName.Equals(CustomerName))
                {
                    CustomerName = newName;
                }
            }
     
            public void Dispose()
            {
                //Do nothing
            }
        }
    }
```

**Tartalom**
- [Visual Studio](https://github.com/gabboraron/CSharp_alapok#visual-studio)
- [Alap adattípusok]()
- [`Hello World` program](https://github.com/gabboraron/CSharp_alapok#hello-world)
- [I/O alapok](https://github.com/gabboraron/CSharp_alapok#io-alapok)
- [Számok](https://github.com/gabboraron/CSharp_alapok#sz%C3%A1mok)
- [Szövegek](https://github.com/gabboraron/CSharp_alapok#sz%C3%B6vegek)
  - [Szöveges argumentumok]()
- [Logikai változók és összehasonlítások](https://github.com/gabboraron/CSharp_alapok#logikai-v%C3%A1ltoz%C3%B3k-%C3%A9s-%C3%B6sszehasonl%C3%ADt%C3%A1sok)
- [Típuskonverzió]()
- [Tömbök, sorok]()
- [`if` `then` `else`](https://github.com/gabboraron/CSharp_alapok#if-then-else)
- [`switch`-`case`](https://github.com/gabboraron/CSharp_alapok#switch-case)
- [Cilusok](https://github.com/gabboraron/CSharp_alapok#ciklusok)
  - [`For`](https://github.com/gabboraron/CSharp_alapok#for)
  - [`While`](https://github.com/gabboraron/CSharp_alapok#while)
  - [do-while](https://github.com/gabboraron/CSharp_alapok#do-while)
- [y = x^2 grafikonja](https://github.com/gabboraron/CSharp_alapok#y--x2-grafikonja)  
- [Példaprogram](https://github.com/gabboraron/CSharp_alapok#p%C3%A9ldaprogram) 
- [Egyéb hasznos C# parancsok]()

## Visual Studio
1. [Letöltés és telepítés](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=16)
2. Szükséges telepítendő csomag(ok): `.NET desktop development` és `Universal Windows Platform Development`
3. `Create New Project` >  `Console App (.NET Core)`
4. Sor sorszámozás bekapcsolása: https://docs.microsoft.com/en-us/visualstudio/ide/reference/how-to-display-line-numbers-in-the-editor?view=vs-2019

-----
## Alap adattípusok
- `Integer`
  - `Byte` 
  - `Short` 
  - `Int`
  - `Long`
- `Floating point`
  - `Float`
  - `Double`
- `boolean`
- `Classes`
- `Interfaces`
- `Arrays`
- `Strings`
bővebben: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

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
> A `változónév++` és `++változónév` közti különbség az, hogy előbbi visszadja előbb a változó eredeti értékét, majd megnöveli az értéket, utóbbi viszont előbb növel, aztán adja vissza az értéket.

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
### Szöveges argumentumok
```C#
static void Main(string[] args)
{
}
```
A függvényenk átadható szöveges argumentumok.
A `Console.Writeline(args[0])` használatához a menüsorból: `build` -> `build solution`(F6) ->  `project` click -> `open folder in file explorer` -> `project név` -> `build` -> `debug` -> `valami.exe` futtatása parancssorból és név után argumentum megadása, pl: `C:\User\valami\programnev.exe almafa` 

## Logikai változók és összehasonlítások
- `>`,`<`,`>=`,`<=`,`==`,`!=`
- `&&`, `||`, `^=`,`&=`
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

## Típuskonverzió és típuskényszerítés
```C#
int age = 100;
string name = "Béla"
age.ToString();
```
Ehez hasonlóan az `int`, `float`, `double`, `bool` típusokat is át lehet konvertálni `változónév.ToString();` használatával, vagy a `ToString()` függvénynek argumentumként átadva, pl: `ToString(7.0002);`. Ehhez hasonlóan léteznek a `Convert.ToInt();`, `Convert.ToDouble();` és hasonló függvények is.

Ugyanakkor a Javahoz megszokottként lehet típuskényszerítést használni: 
```C#
double y = 55.089;
int z = (int) y;
```

## Pointerek és mutatók
- `sizeof()` - az adattípus méretét adja vissza
- `typeof()` - az osztály típusát adja vissza
- `&` - változó címre hivatkozás, pl: `&a;`
- `*` - mutató a változóra, pl `*a;` egy mutatót hoz létre `a`-ra

## Tömbök, sorok
Egy üres `int` tömb definiálása, ahol `array` a tömb neve:
```C#
int[] array;
```

Egy 100 méretű `int` tömb definiálása, ahol `array` a tömb neve:
```C#
int[100] array;
```

másik módszer: 
```C#
public string[] Flavors = {"Vanilla", "Oreo", "AmeriShop Dream", "French Vanilla", "Mint", "Better Batter", "Rocky Road", "Mint Chocolate Chip", "Coffee", "Phish Food", "New York Super Fudge Chunk" };
```
Ugyanakkor a rendezés sem nehéz
```C#
    Array.Sort(Flavors);
    Utility.AllValues(Flavors);
    
    //////
    
public static void AllValues(String[] _array)
{
    for (int i = _array.GetLowerBound(0); i <= _array.GetUpperBound(0); i++)
    {
        //space adds padding on the left side
	Console.WriteLine(space + _array[i]);
    }
    Console.WriteLine();
```
Keresés: `Utility.Search(ARRAY, SEARCHTERM)`
```C#
    public static bool Search(string[] _array, string _string)
    {
        bool result = false;
        int i = 0;
        foreach (string s in _array)
        {
    	_array[i] = s.ToLower();
    	i++;
        }
     
        if (Array.Find(_array, element => element == _string) == _string)
        {
    	result = true;
        }
        else
        {
    	result = false;
        }
        return result;
    }   
```

## Futtatási egységek:
```C#
{
// ami a zárójelek között van :)
// egy namspacen belül
}
```
Ezeken belül használhatóak:
- `break` - kilép az aktuális futtatási egységből
- `continue` - kihagyja a hátralevő logikai részeket és a futtatási egység végére lép, csak ciklusokban használható, de azokon belül hasznos
- `goto` ugrik a jelzett sorhoz <- FUCK YOU OBJEKTUMORIENTÁLTSÁG
- `return` - visszatéréési érték
- `throw` - kivételdobás

## `if` `then` `else`
fájl: [payCheck](https://github.com/gabboraron/CSharp_alapok/tree/master/payCheck)

> gyors `if` értékadás: `?:` használata: `if feltétel_igaz ? akkor_igaz_érték : egyébként_egyébérték`
>
> `is` ha egy iobjektum bizonyos típusú, pl: `if(ford is Car)
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

## `switch`-`case`
bővebben: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch
```C#
      int caseSwitch = 1;

      switch (caseSwitch)
      {
          case 1:
              Console.WriteLine("Case 1");
              break;
          case 2:
              Console.WriteLine("Case 2");
              break;
          default:
              Console.WriteLine("Default case");
              break;
      }
```

másik példa:
```C#
	    char ch;
            Console.WriteLine("Enter a Character");
            ch = Convert.ToChar(Console.ReadLine());
 
            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not Vowel");
                    break;
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
ha a felététel igaz akkor teljesül, elöl tesztel
```C#
            while (length > 0)
            {
                Console.Write(" :( ");
                length--;
            }
```
```C#
            int i = 5;
            while (i<4)
            {
                Console.WriteLine("This is while loop ");
                
            }
```
### do-While
hátul tesztel, ha a feltétel igaz akkor folytatja az ismétlést
```C#
            do
            {
                Console.Write(" :/ ");
                length++;
            } while (length<5);
```
```C#
            do {
                Console.WriteLine("This is a do while loop ");
            } while (i < 4);
```
### y = x^2 grafikonja
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

## Példaprogramok
### kiosk
fájl: [kiosk](https://github.com/gabboraron/CSharp_alapok/tree/master/kiosk)
> Egy egyszerű programocska, választó menükkel, stb.

### dátumkezelő
```C#
            DateTime MyAge;
            Console.WriteLine("Enter Your Age");
            MyAge = Convert.ToDateTime(Console.ReadLine());
            int years = Convert.ToInt32((DateTime.Now.Subtract(MyAge).TotalDays)) / 360;
 
            Console.WriteLine("Your Age is " + years + "Years");
            Console.ReadKey();
```

## Egyéb hasznos C# parancsok
- `Console.Readkey();` - vár egy billentyűá leütésre és azt adja vissza, hasznos lehet program végére is

## GUI programok
- egyszerű GUI példa: https://github.com/gabboraron/CSharp_alapok/tree/master/GUI-apps/first-v2/first-v2
- egyszerű webes program példa: https://github.com/gabboraron/CSharp_alapok/tree/master/GUI-apps/first-v2/first_web_app/first_web_app
