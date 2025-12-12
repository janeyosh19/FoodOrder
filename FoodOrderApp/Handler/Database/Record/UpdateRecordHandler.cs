using ConsoleApp1.Handler.Database.Record;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Database
{
    internal class UpdateRecordHandler
    {
        public static void UpdateFoodRecord(int foodId, int column, string? update)
        {
            string sql;

            if (column == 1)
            {
                sql = "UPDATE Food SET name = @name WHERE food_id = @food_id";
            }
            else
            {
                sql = "UPDATE Food SET price = @price WHERE food_id = @food_id";
            }

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            //SHOW RECORDS BEFORE CHANGING
            Console.WriteLine("From:");
            ShowRecordHandler.ShowFoodRecord(false, foodId);

            if (column == 1)
            {
                command.Parameters.AddWithValue("@food_id", foodId);
                command.Parameters.AddWithValue("@name", update);
            }
            else
            {
                command.Parameters.AddWithValue("@food_id", foodId);
                command.Parameters.AddWithValue("@price", update);
            }

            command.ExecuteNonQuery();

            Console.WriteLine("To:");
            ShowRecordHandler.ShowFoodRecord(false, foodId);
        }

        public static void UpdateOrderRecord(int foodId, int orderNo, int quantity, decimal amount)
        {
            var sql = "UPDATE Orders SET quantity = quantity + @quantity, amount = amount + @amount WHERE order_no = @order_no";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@order_no", orderNo);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@amount", amount);
            command.ExecuteNonQuery();
        }

        public static void UpdateFoodOrderQuantityRecord(int foodId, int order_id, int quantity)
        {
            var sql = "UPDATE FoodOrders SET quantity = quantity + @quantity WHERE food_id = @food_id AND order_id = @order_id";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@food_id", foodId);
            command.Parameters.AddWithValue("@order_id", order_id);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.ExecuteNonQuery();
        }
    }
}
