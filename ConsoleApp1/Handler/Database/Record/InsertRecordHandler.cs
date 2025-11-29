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
        public static int InsertFoodRecord(string? name, decimal? price) //CS0161 why static ALEX?
        {
            var sql = "INSERT INTO Food (name, price) " +
                        "VALUES (@name, @price)";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@price", price);

            int rowInserted = command.ExecuteNonQuery();

            return rowInserted;
        }

        public static int InsertOrderRecord(string? name, string? code,  decimal? price, int? quantity, decimal? amount) //CS0161 why static ALEX?
        {
            var sql = "INSERT INTO Food (name, code, price, quantity, amount) " +
                        "VALUES (@name, @code, @price, @quantity, @amount)";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@code", code);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@amount", amount);


            int rowInserted = command.ExecuteNonQuery();

            return rowInserted;
        }
    }
}
