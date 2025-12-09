using ConsoleApp1.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Database.Record
{
    internal class InsertRecordHandler
    {
        public static Food? InsertFoodRecord(string name, decimal price) //CS0161 why static ALEX?
        {
            var sql = "INSERT INTO Food (name, price) " +
                        "VALUES (@name, @price)";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@price", price);

            command.ExecuteNonQuery();

            return new Food { Name = name, Price = price};
        }

        public static int InsertOrderRecord(int? order_no, int? quantity, decimal? amount) //CS0161 why static ALEX?
        {
            var sql = "INSERT INTO Orders (order_no, quantity, amount)" +
                        "VALUES (@order_no, @quantity, @amount)";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@order_no", order_no);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@amount", amount);

            command.ExecuteNonQuery();

            return GetRecordHandler.GetOrderId(order_no);
        }

        public static void InsertFoodOrderRecord(int food_id, int order_id)
        {
            var sql = "INSERT INTO FoodOrders (food_id, order_id)" +
                        "VALUES (@food_id, @order_id)";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@food_id", food_id);
            command.Parameters.AddWithValue("@order_id", order_id);
            command.ExecuteNonQuery();
        }
    }
}
