using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Handler.Database.Record
{
    internal class ShowRecordHandler
    {
        public static void ShowFoodRecord(bool showAll, int id)
        {
            string sql;

            if (showAll)
            {
                sql = "SELECT * FROM Food";
            }
            else
            {
                sql = "SELECT * FROM Food WHERE id = @id";
            }

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            if (!showAll)
            {
                command.Parameters.AddWithValue("@id", id);
            }

            using var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var rowId = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var price = reader.GetString(2);
                    Console.WriteLine($"{rowId}\t{name}\t{price}");
                }
            }
            else
            {
                Console.WriteLine("No food found.");
            }
        }

        public static void ShowOrderRecord(bool showAll, int id)
        {
            string sql;

            if (showAll)
            {
                sql = "SELECT * FROM Orders";
            }
            else
            {
                sql = "SELECT * FROM Orders WHERE id = @id";
            }

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            if (!showAll)
            {
                command.Parameters.AddWithValue("@id", id);
            }

            using var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var rowId = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var code = reader.GetString(2);
                    var price = reader.GetString(3);
                    var quantity = reader.GetString(4);
                    var amount = reader.GetString(5);

                   Console.WriteLine($"{rowId}\t{name}\t{code}\t{price}\t{quantity}\t{amount}");
                }
            }
            else
            {
                Console.WriteLine("No food found.");
            }
        }
    }
}
