using ConsoleApp1.Handler.Database.Table;
using ConsoleApp1.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Database
{
    internal class CreateTableHandler
    {
        public static void CreateFoodTable()
        {
            var sql = "CREATE TABLE IF NOT EXISTS Food (" +
                        "food_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "name TEXT NOT NULL," +
                        "price DECIMAL NOT NULL)";

            SQLTableHandler.HandleTable(sql);
            Console.WriteLine("Food table has been created.");
        }

        public static void CreateOrdersTable()
        {
            var sql = "CREATE TABLE IF NOT EXISTS Orders (" +
                      "order_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                      "order_no INTEGER NOT NULL," +
                      "quantity INTEGER NOT NULL," +
                      "amount REAL NOT NULL" +
                      ")";

            SQLTableHandler.HandleTable(sql);
            Console.WriteLine("Order table has been created.");
        }

        public static void CreateFoodOrdersTable()
        {
            var sql = "CREATE TABLE IF NOT EXISTS FoodOrders (" +
                        "food_id INTEGER NOT NULL REFERENCES Food(food_id)," +
                        "order_id INTEGER NOT NULL REFERENCES Orders(order_id)," +
                        "quantity INTEGER NOT NULL," +
                        "PRIMARY KEY (food_id, order_id))";

            SQLTableHandler.HandleTable(sql);
            Console.WriteLine("FoodOrders table has been created.");
        }

        
    }
}
