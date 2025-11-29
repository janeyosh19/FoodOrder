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
            var sql = "DELETE FROM Food WHERE id = @id";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            //Get row to be deleted
            Console.WriteLine("To be deleted:");
            ShowRecordHandler.ShowFoodRecord(false, id);

            // Execute the DELETE statement
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            Console.WriteLine("The food has been deleted successfully.");
        }

        public static void DeleteOrderRecord(int id)
        {
            var sql = "DELETE FROM Food WHERE id = @id";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            //Get row to be deleted
            Console.WriteLine("To be deleted:");
            ShowRecordHandler.ShowOrderRecord(false, id);

            // Execute the DELETE statement
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            Console.WriteLine("The food has been deleted successfully.");
        }

    }
}
