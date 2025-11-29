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
                sql = "UPDATE Food SET food = @name WHERE id = @id";
            }
            else
            {
                sql = "UPDATE Food SET price = @price WHERE id = @id";
            }

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            //SHOW RECORDS BEFORE CHANGING
            Console.WriteLine("From:");
            ShowRecordHandler.ShowFoodRecord(false, id);

            if (column == 1)
            {
                command.Parameters.AddWithValue("@name", update);
                command.Parameters.AddWithValue("@id", id);
            }
            else
            {
                command.Parameters.AddWithValue("@price", update);
                command.Parameters.AddWithValue("@id", id);
            }

            command.ExecuteNonQuery();

            Console.WriteLine("To:");
            ShowRecordHandler.ShowFoodRecord(false, id);
        }
    }
}
