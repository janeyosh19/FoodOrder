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
            string? food = UserInput.ProcessUserInput.ConvertStringToInteger(UserInput.ProcessUserInput.Get();
            int foodNumber = UserInput.ProcessUserInput.ConvertStringToInteger(food);

            if (UserInput.ProcessUserInput.CheckIntegerValue(food))
            {
                Console.WriteLine("Choose a number which you want to update?");
                Console.WriteLine($"1.Food, 2.Price");

                string? selected = UserInput.ProcessUserInput.Get();
                int selectedNumber = UserInput.ProcessUserInput.ConvertStringToInteger(selected);

                if (UserInput.ProcessUserInput.CheckIntegerValue(selected))
                {
                    if (selectedNumber == 1)
                    {
                        Console.WriteLine("Rename the food.");
                        string? food = UserInput.ProcessUserInput.Get();

                        UpdateFoodHandler.UpdateFood(foodNumber, selectedNumber, food);
                    }
                    else if (selectedNumber == 2)
                    {
                        Console.WriteLine("Write down the new price.");
                        string? price = UserInput.ProcessUserInput.Get();
                        if (UserInput.ProcessUserInput.CheckDecimalValue(price) && !string.IsNullOrEmpty(price))
                        {
                            UpdateRecordHandler.UpdateFoodRecord(foodNumber, selectedNumber, price);
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
                Console.WriteLine("It should be a food number.");
            }
        }
    }
}
