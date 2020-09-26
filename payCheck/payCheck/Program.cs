using System;

namespace payCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursWorked = 0;
            double payRate = 1300;

            Console.WriteLine("how many hours did you work this week?");

            //hoursWorked = Convert.ToDouble(Console.ReadLine());
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
        }
    }
}
