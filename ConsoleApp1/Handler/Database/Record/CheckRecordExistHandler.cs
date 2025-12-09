using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Database.Record
{
    internal class CheckRecordExistHandler
    {
        public static bool CheckFoodIdExist(int id)
        {
            var sql = "SELECT * FROM FoodOrders WHERE food_id = @food_id";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@food_id", id);
            using var reader = command.ExecuteReader();
            return reader.HasRows;
        }

        public static bool CheckFoodNameExist(string name)
        {
            var sql = "SELECT * FROM Food WHERE name = @name";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@name", name);

            using var reader = command.ExecuteReader();

            return reader.HasRows;
        }

        public static bool CheckOrderIdExist(int id)
        {
            var sql = "SELECT * FROM Food WHERE id = @id";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();

            return reader.HasRows;
        }

        public static bool CheckOrderNoExist(int orderNo)
        {
            var sql = "SELECT * FROM Orders WHERE order_no = @order_no";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@order_no", orderNo);

            using var reader = command.ExecuteReader();

            return reader.HasRows;
        }

        public static bool CheckFoodOrderExist(int foodId, int orderId)
        {
            var sql = "SELECT * FROM FoodOrders WHERE food_id = @food_id AND order_id = @order_id";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@food_id", foodId);
            command.Parameters.AddWithValue("@order_id", orderId);
            using var reader = command.ExecuteReader();
            return reader.HasRows;
        }
    }
}
