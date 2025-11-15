using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {
        public static void AddMenu()
        {
            Console.WriteLine("Add a new menu.");
            string? addfood = UserInput(); //IDE0059  //CS8600
            if (addfood != "")
            {
                Console.WriteLine("Add a price.");
                //float? addprice = float.Parse(Console.ReadLine()); //CS8604
                string? addprice = UserInput();

                if (CheckStringIfFloat(addprice) && !string.IsNullOrEmpty(addprice))
                {
                    Console.WriteLine($"{RecordDB.InsertRecord(addfood, ConvertStringToFloat(addprice))} has been inserted.");
                }
                else
                {
                    Console.WriteLine("The price value cannot be empty or a text.");
                }
            }
            else
            {
                Console.WriteLine("There's no new menu added.");
            }
        }

        public static void ChangeMenu()
        {
            Console.WriteLine("Choose a menu number to change.");
            string? menuNumber = UserInput();

            if (CheckStringIfInteger(menuNumber) && !string.IsNullOrEmpty(menuNumber))
            {
                Console.WriteLine("Choose a number which you want to change?");
                Console.WriteLine($"1.Menu, 2.Price");

                string? chosenNumber = UserInput();

                if (CheckStringIfInteger(chosenNumber) && !string.IsNullOrEmpty(chosenNumber))
                {
                    RecordDB.ChangeRecord(ConvertStringToInteger(chosenNumber));
                }
                else
                {
                    Console.WriteLine("No number is chosen.");
                }

            }
            else
            {
                Console.WriteLine("It should be a menu number.");
            }
        }

        public static void RemoveMenu()
        {
            Console.WriteLine("Choose a menu number to delete.");
            string? menuNumber = UserInput();

            if (CheckStringIfInteger(menuNumber) && !string.IsNullOrEmpty(menuNumber))
            {
                RecordDB.DeleteRecord(ConvertStringToInteger(menuNumber));
            }
            else
            {
                Console.WriteLine("It should be a menu number.");
            }
        }

        public static string? UserInput()
        {
            return Console.ReadLine();
        }

        public static int ConvertStringToInteger(string? menuNumber)
        {
            _ = int.TryParse(menuNumber, out int number);
            return number;
        }

        public static bool CheckStringIfInteger(string? menuNumber)
        {
            return int.TryParse(menuNumber, out _);
        }

        public static float ConvertStringToFloat(string? menuPrice)
        {
            _ = float.TryParse(menuPrice, out float price);
            return price;
        }

        public static bool CheckStringIfFloat(string? menuPrice)
        {
            return float.TryParse(menuPrice, out _);
        }
    }
}
