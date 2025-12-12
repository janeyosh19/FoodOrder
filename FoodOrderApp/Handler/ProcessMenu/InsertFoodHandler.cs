using ConsoleApp1.Handler.Database.Record;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.ProcessMenu
{
    internal class InsertFoodHandler
    {
        public static void InsertFood()
        {
            Console.WriteLine("Add name of the food.");
            string? foodName = UserInput.ProcessUserInput.Get();

            if (!string.IsNullOrWhiteSpace(foodName) && !CheckRecordExistHandler.CheckFoodNameExist(foodName))
            {
                Console.WriteLine("Add a price.");
                string? price = UserInput.ProcessUserInput.Get();

                if (!string.IsNullOrWhiteSpace(price) && UserInput.ProcessUserInput.CheckDecimalValue(price))
                {
                    Console.WriteLine($"{InsertRecordHandler.InsertFoodRecord(foodName, UserInput.ProcessUserInput.ConvertStringToDecimal(price))} has been inserted.");
                }
                else
                {
                    Console.WriteLine("The price value cannot be empty or a text.");
                }
            }
            else
            {
                Console.WriteLine("Food already exist or no food added.");
        }
    }
}

            }