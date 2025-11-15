using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;


namespace ConsoleApp1
{
    internal class RecordDB
    { 
        public static int InsertRecord(string? food, float? price) //CS0161 why static ALEX?
        {
            var sql = "INSERT INTO Food (food, price) " +
                        "VALUES (@food, @price)";

            try
            {
                using var connection = new SqliteConnection("Data Source=foodOrder.db");
                connection.Open();
                using var command = new SqliteCommand(sql, connection);

                command.Parameters.AddWithValue("@food", food);
                command.Parameters.AddWithValue("@price", price);

                int rowInserted = command.ExecuteNonQuery();

                return rowInserted;
            }
            catch (SqliteException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public static void ShowRecord(bool showAll, int id)
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

            try
            {
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
                        var food = reader.GetString(1);
                        var price = reader.GetString(2);
                        Console.WriteLine($"{rowId}\t{food}\t{price}");
                    }
                }
                else
                {
                    Console.WriteLine("No menu found.");
                }
            }
            catch (SqliteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ChangeRecord(int id)
        {
            string sql; //why acceptable if its string and not var

            if (menuName)
            {
                sql = "UPDATE Food SET food = @food WHERE id = @id";
            }
            else
            {
                sql = "UPDATE Food SET price = @price WHERE id = @id";
            }

            try
            {
                using var connection = new SqliteConnection("Data Source=foodOrder.db");
                connection.Open();
                using var command = new SqliteCommand(sql, connection);

                //SHOW RECORDS BEFORE CHANGING
                Console.WriteLine("To be change:");
                ShowRecord(false, id);

                if (!menuName)
                {
                    command.Parameters.AddWithValue("@food", food);
                    command.Parameters.AddWithValue("@id", id);
                }
                else
                {
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@id", id);
                }

                command.ExecuteNonQuery();

            }
            catch (SqliteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DeleteRecord(int id)
        {
            var sql = "DELETE FROM Food WHERE id = @id";

            try
            {
                using var connection = new SqliteConnection("Data Source=foodOrder.db");
                connection.Open();
                using var command = new SqliteCommand(sql, connection);

                //Get row to be deleted
                Console.WriteLine("To be deleted:");
                ShowRecord(false, id);

                // Execute the DELETE statement
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                Console.WriteLine($"The menu has been deleted successfully.");
            }
            catch (SqliteException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        //public void InsertRecord(string food, float )
        //{
        //    var sql = "INSERT INTO Food (food, price) " +
        //                "VALUES (@food, @price)";

        //    string[] food = ["Pizza", "Burger", "Pasta"];
        //    float[] price = [9.99f, 5.49f, 7.99f];

        //    try
        //    {
        //        using var connection = new SqliteConnection("Data Source=foodOrder.db");
        //        connection.Open();
        //        using var command = new SqliteCommand(sql, connection);

        //        INSERT MULTIPLE RECORD IN SQLITE
        //        var foodx = command.CreateParameter();
        //        var pricex = command.CreateParameter();
        //        foodx.ParameterName = "food";
        //        pricex.ParameterName = "price";
        //        command.Parameters.Add(foodx);
        //        command.Parameters.Add(pricex);

        //        // Insert a lot of data
        //        for (var i = 0; i < food.Length; i++)
        //        {
        //            foodx.Value = food[i];
        //            pricex.Value = price[i];
        //            command.ExecuteNonQuery();
        //        }

        //        Console.WriteLine("Records has been inserted.");
        //    }
        //    catch (SqliteException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}
