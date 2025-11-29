using ConsoleApp1.Handler.Database;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Items
{
    internal class ProcessMenu
    {
        private Menu Menu = new Menu();
        public GetMenu(int menuId, string menuName, float menuPrice)
        {
            RecordDB.GetRecord(menuId);
        }
        public static void AddMenu()
        {
            Console.WriteLine("Add a new menu.");
            string? menu = UserInput.Get(); //IDE0059  //CS8600
            if (menu != "")
            {
                Console.WriteLine("Add a price.");
                string? price = UserInput.Get();

                if (UserInput.CheckFloatValue(price))
                {
                    Console.WriteLine($"{RecordDB.InsertRecord(menu, UserInput.ConvertStringToFloat(price))} has been inserted.");
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

        public static void UpdateMenu()
        {
            Console.WriteLine("Choose a menu number to update.");
            string? menu = UserInput.Get();
            int menuNumber = UserInput.ConvertStringToInteger(menu);

            if (UserInput.CheckIntegerValue(menu))
            {
                Console.WriteLine("Choose a number which you want to update?");
                Console.WriteLine($"1.Menu, 2.Price");

                string? selected = UserInput.Get();
                int selectedNumber = UserInput.ConvertStringToInteger(selected);

                if (UserInput.CheckIntegerValue(selected))
                {
                    if (selectedNumber == 1)
                    {
                        Console.WriteLine("Rename the menu.");
                        string? food = UserInput.Get();
                        RecordDB.UpdateRecord(menuNumber, selectedNumber, food);
                    }
                    else if (selectedNumber == 2)
                    {
                        Console.WriteLine("Write down the new price.");
                        string? price = UserInput.Get();
                        if (UserInput.CheckStringIfFloat(price) && !string.IsNullOrEmpty(price))
                        {
                            RecordDB.UpdateRecord(menuNumber, selectedNumber, price);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No number is selected.");
                }

            }
            else
            {
                Console.WriteLine("It should be a menu number.");
            }
        }

        public static void DeleteMenu()
        {
            Console.WriteLine("Choose a menu number to delete.");
            string? menuNumber = UserInput.Get();

            if (UserInput.CheckStringIfInteger(menuNumber) && !string.IsNullOrEmpty(menuNumber))
            {
                RecordDB.DeleteRecord(UserInput.ConvertStringToInteger(menuNumber));
            }
            else
            {
                Console.WriteLine("It should be a menu number.");
            }
        }
    }
}
