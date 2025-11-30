using ConsoleApp1.Handler.Database;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.ProcessMenu
{
    internal class DeleteFoodHandler
    {
        public static void DeleteFood()
        {
            Console.WriteLine("Choose a Food number to delete.");
            string? foodNumber = UserInput.ProcessUserInput.Get();

            if (UserInput.ProcessUserInput.CheckIntegerValue(foodNumber) && !string.IsNullOrEmpty(foodNumber))
            {
                DeleteRecordHandler.DeleteFoodRecord(UserInput.ProcessUserInput.ConvertStringToInteger(foodNumber));
            }
            else
            {
                Console.WriteLine("It should be a food number.");
            }
        }
    }
}
