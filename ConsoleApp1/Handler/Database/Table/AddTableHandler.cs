using ConsoleApp1.Handler.Database.Table;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Database
{
    internal class AddTableHandler
    {
        public static void CreateFoodTable()
        {
            var sql = "CREATE TABLE IF NOT EXISTS Food (" +
                        "code TEXT PRIMARY KEY," +
                        "name TEXT NOT NULL," +
                        "price DECIMAL NOT NULL)";

            SQLTableHandler.HandleTable(sql);
            Console.WriteLine("Food table has been created.");
        }

        public static void CreateOrderTable()
        {
            var sql = "CREATE TABLE IF NOT EXISTS Food (" +
                      "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                      "name TEXT NOT NULL," +
                      "code TEXT NOT NULL," +
                      "price DECIMAL NOT NULL," +
                      "quantity INTEGER NOT NULL," +
                      "amount REAL NOT NULL)";

            SQLTableHandler.HandleTable(sql);
            Console.WriteLine("Order table has been created.");
        }
    }
}
