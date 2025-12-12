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
        public static Food? InsertFoodRecord(string foodName, decimal price) 
        {
            var sql = "INSERT INTO Food (name, price) " +
                        "VALUES (@name, @price)";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@name", foodName);
            command.Parameters.AddWithValue("@price", price);

            command.ExecuteNonQuery();

            return new Food { Name = foodName, Price = price};
        }

        public static int InsertOrderRecord(int? orderNo, int? quantity, decimal? amount) 
        {
            var sql = "INSERT INTO Orders (order_no, quantity, amount)" +
                        "VALUES (@order_no, @quantity, @amount)";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@order_no", orderNo);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@amount", amount);
            command.ExecuteNonQuery();

            return GetRecordHandler.GetOrderId(orderNo);
        }

        public static void InsertFoodOrderRecord(int foodId, int orderId, int quantity)
        {
            var sql = "INSERT INTO FoodOrders (food_id, order_id, quantity)" +
                        "VALUES (@food_id, @order_id, @quantity)";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@food_id", foodId);
            command.Parameters.AddWithValue("@order_id", orderId);
            command.Parameters.AddWithValue("@quantity", quantity);

            command.ExecuteNonQuery();
        }
    }
}
