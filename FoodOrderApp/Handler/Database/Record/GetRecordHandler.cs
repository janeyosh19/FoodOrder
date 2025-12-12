using ConsoleApp1.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Database
{
    internal class GetRecordHandler
    {
        public static Food? GetFoodRecord(int foodId)
        {
            var sql = "SELECT * FROM Food WHERE food_id = @food_id";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@food_id", foodId);

            Food food = new Food();

            using var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    food.Id = reader.GetInt32(0);
                    food.Name = reader.GetString(1);
                    food.Price = reader.GetDecimal(2);
                    return food;
                }
                return null;
            }
            else
            {
                Console.WriteLine("No food found.");
                return null;
            }
        }

        public static int GetOrderId(int? orderNo)
        {
            var sql = "SELECT order_id FROM Orders WHERE order_no = @order_no";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@order_no", orderNo);
            var result = command.ExecuteScalar();
            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                Console.WriteLine("No order found.");
                return 0;
            }
        }
    }
}
