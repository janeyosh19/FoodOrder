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
        public static void UpdateFoodRecord(int id, int column, string? update)
        {
            string sql; //why acceptable if its string and not var

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
            ShowRecordHandler.ShowFoodRecord(false, id);

            if (column == 1)
            {
                command.Parameters.AddWithValue("@food_id", id);
                command.Parameters.AddWithValue("@name", update);
            }
            else
            {
                command.Parameters.AddWithValue("@food_id", id);
                command.Parameters.AddWithValue("@price", update);
            }

            command.ExecuteNonQuery();

            Console.WriteLine("To:");
            ShowRecordHandler.ShowFoodRecord(false, id);
        }

        public static void UpdateOrderRecord(int food_id, int order_id, int quantity, decimal amount)
        {
            var sql = "UPDATE Orders SET quantity = @quantity, amount = amount + @amount WHERE order_id = @order_id";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            //SHOW RECORDS BEFORE CHANGING
            Console.WriteLine("From:");
            ShowRecordHandler.ShowOrderRecord(false, order_id);
            command.Parameters.AddWithValue("@order_id", order_id);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@amount", amount);
            command.ExecuteNonQuery();
            Console.WriteLine("To:");
            ShowRecordHandler.ShowOrderRecord(false, order_id);
        }

        public static void UpdateFoodOrderQuantityRecord(int food_id, int order_id, int quantity)
        {
            var sql = "UPDATE FoodOrders SET quantity = quantity + @quantity WHERE food_id = @food_id AND order_id = @order_id";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            //SHOW RECORDS BEFORE CHANGING
            Console.WriteLine("From:");
            ShowRecordHandler.ShowOrderRecord(false, order_id);
            command.Parameters.AddWithValue("@food_id", food_id);
            command.Parameters.AddWithValue("@order_id", order_id);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.ExecuteNonQuery();
            Console.WriteLine("To:");
            ShowRecordHandler.ShowOrderRecord(false, order_id);
        }
    }
}
