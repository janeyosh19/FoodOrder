using ConsoleApp1.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Database
{
    internal class GetRecordHandler
    {
        public static Food? GetFoodRecord(int id)
        {

            var sql = "SELECT * FROM Food WHERE id = @id";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Food food = new Food();
                    food.Id = reader.GetInt32(0);
                    food.Name = reader.GetString(1);
                    food.Price = reader.GetDecimal(2);
                    return food;
                }
                return null;
            }
            else
            {
                Console.WriteLine("No food found.");
                return null;
            }
        }

        public static Order? GetOrderRecord(string code)
        {

            var sql = "SELECT * FROM Food WHERE code = @code";

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@code", code);

            using var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Order order = new Order();
                    order.Id = reader.GetInt32(0);
                    order.Name = reader.GetString(1);
                    order.Code = reader.GetString(2);
                    order.Price = reader.GetDecimal(3);
                    order.Quantity = reader.GetInt32(4);
                    order.Amount = reader.GetDecimal(5);
                    return order;
                }
                return null;
            }
            else
            {
                Console.WriteLine("No food found.");
                return null;
            }
        }
    }
}
