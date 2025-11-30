using ConsoleApp1.Handler.Database;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.ProcessMenu
{
    internal class GetFoodHandler
    {
        public Food Food = new();
        public static Food? GetFood(int FoodId, string FoodName, float FoodPrice)
        {
            return GetRecordHandler.GetFoodRecord(FoodId);
        }
    }
}
