using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Handler.Database.Record
{
    internal class ShowRecordHandler
    {
        public static void ShowFoodRecord(bool showAll, int foodId)
        {
            string sql;

            if (showAll)
            {
                sql = "SELECT * FROM Food";
            }
            else
            {
                sql = "SELECT * FROM Food WHERE food_id = @food_id";
            }

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            if (!showAll)
            {
                command.Parameters.AddWithValue("@food_id", foodId);
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

        public static void ShowOrderRecord(bool showAll, int? orderNo)
        {
            string sql;

            if (showAll)
            {
                sql = "SELECT * FROM Orders";
            }
            else
            {
                sql = "SELECT * FROM Orders WHERE order_no = @order_no";
            }

            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            if (!showAll)
            {
                command.Parameters.AddWithValue("@order_no", orderNo);
            }

            using var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var rowId = reader.GetInt32(0);
                    var order_no = reader.GetInt32(1);
                    var quantity = reader.GetString(2);
                    var amount = reader.GetString(3);

                   Console.WriteLine($"{rowId}\t{order_no}\t{quantity}\t{amount}");
                }
            }
            else
            {
                Console.WriteLine("No order found.");
            }
        }

        public static void ShowFoodOrdersRecord()
        {
            var sql = "SELECT * FROM FoodOrders";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            using var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var food_id = reader.GetInt32(0);
                    var order_id = reader.GetInt32(1);
                    var quantity = reader.GetInt32(2);
                    Console.WriteLine($"{food_id}\t{order_id}\t{quantity}");
                }
            }
            else
            {
                Console.WriteLine("No food orders found.");
            }
        }

        public static void ShowFoodWithOrders()
        {
            var sql = @"SELECT Food.food_id, Food.name, Food.price, Orders.order_id, Orders.order_no, Orders.quantity, Orders.amount
                        FROM Food
                        JOIN FoodOrders ON Food.food_id = FoodOrders.food_id
                        JOIN Orders ON FoodOrders.order_id = Orders.order_id";
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            using var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var food_id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var price = reader.GetDecimal(2);
                    var order_id = reader.GetInt32(3);
                    var order_no = reader.GetInt32(4);
                    var quantity = reader.GetInt32(5);
                    var amount = reader.GetDecimal(6);
                    Console.WriteLine($"Food ID: {food_id}, Name: {name}, Price: {price}, Order ID: {order_id}, Order No: {order_no}, Quantity: {quantity}, Amount: {amount}");
                }
            }
            else
            {
                Console.WriteLine("No food with orders found.");
            }
        }
    }
}
