using ConsoleApp1.Handler.Database;
using ConsoleApp1.Handler.Database.Record;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.ProcessMenu
{
    internal class UpdateFoodHandler
    {
        public static void UpdateFood()
        {
            Console.WriteLine("Choose a Food number to update.");
            int foodNumber = UserInput.ProcessUserInput.ConvertStringToInteger(UserInput.ProcessUserInput.Get());

            //CHECK IF FOOD EXIST
            if (CheckRecordExistHandler.CheckFoodIdExist(foodNumber))
            {
                Console.WriteLine("Choose a number which you want to update?");
                Console.WriteLine($"1.Food, 2.Price");

                int selectedColumn = UserInput.ProcessUserInput.ConvertStringToInteger(UserInput.ProcessUserInput.Get());

                if (selectedColumn == 1)
                {
                    Console.WriteLine("Rename the food.");
                    string? foodName = UserInput.ProcessUserInput.Get();

                    if (!string.IsNullOrEmpty(foodName))
                    {
                        UpdateRecordHandler.UpdateFoodRecord(foodNumber, selectedColumn, foodName);
                    }
                }
                else if (selectedColumn == 2)
                {
                    Console.WriteLine("Write down the new price.");
                    string? price = UserInput.ProcessUserInput.Get();

                    if (UserInput.ProcessUserInput.CheckDecimalValue(price) && !string.IsNullOrEmpty(price))
                    {
                        UpdateRecordHandler.UpdateFoodRecord(foodNumber, selectedColumn, price);
                    }
                }
                else
                {
                    Console.WriteLine("Column does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Food doesnt exist");
            }
        }
    }
}
