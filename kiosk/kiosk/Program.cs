using System;

namespace kiosk
{
    class Program
    {
        static void Main(string[] args)
        {
            const string mainMenuChoice = "1";
            const string purchaseManuChoice = "2";
            const string maintenenceManuChoice = "3";
            const string kioskResultsChoice = "4";
            const string purchaseItemChoice = "5";
            const string detailBillChoice = "6";
            const string addKioskItemChoice = "7";
            const string addKioskRawMaterialChoice = "8";
            const string clearKioskChoice = "9";
            const string updateKioskRawMaterialQtyChoice = "10";
            const string quitApplication = "999";

            string menuChoice = mainMenuChoice;
            while(menuChoice != quitApplication)
            {
                if(menuChoice == mainMenuChoice)
                {
                    Console.Clear();
                    Console.WriteLine("Main Menu");
                    Console.WriteLine("=========");
                    Console.WriteLine("1. Purchase");
                    Console.WriteLine("2. Maintenence");
                    Console.WriteLine("3. Kiosk Results");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            menuChoice = purchaseManuChoice;
                            break;
                        case "2":
                            menuChoice = maintenenceManuChoice;
                            break;
                        case "3":
                            menuChoice = kioskResultsChoice;
                            break;
                        case "Q":
                            menuChoice = quitApplication;
                            break;
                        case "q":
                            menuChoice = quitApplication;
                            break;
                        default:
                            Console.WriteLine("404, Menu item not found!");
                            break;
                    }
                }
                else if (menuChoice == maintenenceManuChoice)
                {
                    //Console.Clear();
                    Console.WriteLine("Maintenence");
                    Console.WriteLine("===========");
                    Console.WriteLine("1. Add item to kiosk");
                    Console.WriteLine("2. Add raw material to kiosk");
                    Console.WriteLine("3. Clear kiosk");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            menuChoice = addKioskItemChoice;
                            Console.Clear();
                            break;
                        case "2":
                            menuChoice = addKioskRawMaterialChoice;
                            Console.Clear();
                            break;
                        case "3":
                            menuChoice = clearKioskChoice;
                            break;
                        case "Q":
                            menuChoice = mainMenuChoice;
                            break;
                        case "q":
                            menuChoice = mainMenuChoice;
                            break;
                        default:
                            Console.WriteLine("\n404, Menu item not found!\n\n");
                            break;
                    }
                }
                else if (menuChoice == purchaseManuChoice)
                {
                    Console.WriteLine("Purchase Menu");
                    Console.WriteLine("=============");
                    Console.WriteLine("1. Purchase Item");
                    Console.WriteLine("2. Purchase Bill");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            menuChoice = purchaseManuChoice;
                            Console.Clear();
                            break;
                        case "2":
                            menuChoice = maintenenceManuChoice;
                            Console.Clear();
                            break;
                        case "Q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        case "q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("\n404, Menu item not found!\n\n");
                            break;
                    }
                }
                else if (menuChoice == detailBillChoice)
                {
                    Console.WriteLine("Detailed Bill Menu");
                    Console.WriteLine("==================");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "Q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        case "q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("\n404, Menu item not found!\n\n");
                            break;
                    }
                }
                else if (menuChoice == addKioskItemChoice)
                {
                    Console.WriteLine("Add Kiosk Item Menu");
                    Console.WriteLine("===================");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "Q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        case "q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("\n404, Menu item not found!\n\n");
                            break;
                    }
                }
                else if (menuChoice == addKioskRawMaterialChoice)
                {
                    Console.WriteLine("Add Kiosk Raw Material Menu");
                    Console.WriteLine("===========================");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "Q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        case "q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("\n404, Menu item not found!\n\n");
                            break;
                    }
                }
                else if (menuChoice == clearKioskChoice)
                {
                    Console.WriteLine("Clear Kiosk Menu");
                    Console.WriteLine("================");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "Q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        case "q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("\n404, Menu item not found!\n\n");
                            break;
                    }
                }
                else if (menuChoice == updateKioskRawMaterialQtyChoice)
                {
                    Console.WriteLine("Update Raw materials in Kiosk");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "Q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        case "q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("\n404, Menu item not found!\n\n");
                            break;
                    }
                }
                else if (menuChoice == kioskResultsChoice)
                {
                    Console.WriteLine("Kiosk results menu");
                    Console.WriteLine("==================");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "Q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        case "q":
                            menuChoice = mainMenuChoice;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("\n404, Menu item not found!\n\n");
                            break;
                    }
                }
            }
        }
    }
}
