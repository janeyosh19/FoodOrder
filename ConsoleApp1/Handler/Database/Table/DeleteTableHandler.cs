using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Database.Table
{
    internal class DeleteTableHandler
    {
        public static void DeleteFoodTable()
        {
            SQLTableHandler.HandleTable("DROP TABLE IF EXISTS Food");
            Console.WriteLine("Food table has been deleted.");
        }

        public static void DeleteOrderTable()
        {
            SQLTableHandler.HandleTable("DROP TABLE IF EXISTS Orders");
            Console.WriteLine("Order table has been deleted.");
        }
    }
}
