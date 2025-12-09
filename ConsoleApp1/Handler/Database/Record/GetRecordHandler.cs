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
        public static Food? GetFoodRecord(int food_id)
        {
            var sql = "SELECT * FROM Food WHERE food_id = @food_id";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@food_id", food_id);

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

        public static int GetLastOrderId()
        {
            var sql = "SELECT order_id FROM Orders ORDER BY order_id DESC LIMIT 1";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
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

        public static int GetOrderId(int? order_no)
        {
            var sql = "SELECT order_id FROM Orders WHERE order_no = @order_no";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@order_no", order_no);
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

        //public static Order? GetOrderRecord()
        //{

        //    var sql = "SELECT * FROM Orders";

        //    using var connection = new SqliteConnection("Data Source=foodOrder.db");
        //    connection.Open();
        //    using var command = new SqliteCommand(sql, connection);

        //    command.Parameters.AddWithValue("@code", code);

        //    using var reader = command.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Order order = new Order();
        //            order.Id = reader.GetInt32(0);
        //            order.Name = reader.GetString(1);
        //            order.Code = reader.GetString(2);
        //            order.Price = reader.GetDecimal(3);
        //            order.Quantity = reader.GetInt32(4);
        //            order.Amount = reader.GetDecimal(5);
        //            return order;
        //        }
        //        return null;
        //    }
        //    else
        //    {
        //        Console.WriteLine("No food found.");
        //        return null;
        //    }
        //}
    }
}
