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
        public static bool CheckRecordExist(int id)
        {
            var sql = "SELECT * FROM Food WHERE id = @id";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@id", id);

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
    }
}
