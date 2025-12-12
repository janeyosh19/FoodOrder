using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.Database.Table
{
    internal class SQLTableHandler
    {
        public static void HandleTable(string sql)
        {
            using var connection = new SqliteConnection("Data Source=foodOrder.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
