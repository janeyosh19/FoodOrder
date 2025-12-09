using ConsoleApp1.Handler.Database.Record;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Database
{
    internal class DeleteRecordHandler
    {
        public static void DeleteFoodRecord(int id)
        {
            var sql = "DELETE FROM Food WHERE food_id = @food_id";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            //Get row to be deleted
            Console.WriteLine("To be deleted:");
            ShowRecordHandler.ShowFoodRecord(false, id);

            // Execute the DELETE statement
            command.Parameters.AddWithValue("@food_id", id);
            command.ExecuteNonQuery();

            Console.WriteLine("The food has been deleted successfully.");
        }

        public static void DeleteOrderRecord(int id)
        {
            var sql = "DELETE FROM Orders WHERE order_id = @order_id";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            //Get row to be deleted
            Console.WriteLine("To be deleted:");
            ShowRecordHandler.ShowOrderRecord(false, id);

            // Execute the DELETE statement
            command.Parameters.AddWithValue("@order_id", id);
            command.ExecuteNonQuery();

            Console.WriteLine("The food has been deleted successfully.");
        }

        public static void DeleteAllOrderRecords()
        {
            var sql = "DELETE FROM Orders";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            // Execute the DELETE statement
            command.ExecuteNonQuery();
            Console.WriteLine("The orders have been deleted successfully.");
        }

        public static void DeleteFoodOrderRecords(int order_id)
        {
            var sql = "DELETE FROM FoodOrders WHERE order_id = @order_id";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            // Execute the DELETE statement
            command.Parameters.AddWithValue("@order_id", order_id);
            command.ExecuteNonQuery();
            Console.WriteLine("The food orders have been deleted successfully.");
        }

        public static void DeleteAllFoodOrderRecords()
        {
            var sql = "DELETE FROM FoodOrders";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            // Execute the DELETE statement
            command.ExecuteNonQuery();
            Console.WriteLine("The food orders have been deleted successfully.");
        }

    }
}
