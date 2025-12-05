using ConsoleApp1.Handler.Database;
using ConsoleApp1.Handler.Database.Record;
using ConsoleApp1.Handler.UserInput;
using ConsoleApp1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.ProcessOrder
{
    internal class AddOrderHandler
    {
        public static void AddOrder(string orderName, decimal orderPrice, int quantity)
        {
            //check rcode if exist

            //Add record order

            //addrecord 
            //rand.Next(1000, 9999);
            //InsertRecordHandler.InsertOrderRecord(orderName, orderPrice, quantity);

            ////Sent amount back

            //order.Amount = order.Price * order.Quantity;
            //order.TotalAmount += order.Amount;

            //Console.WriteLine($"menu, Price, Quantity, Amount");
            //Console.WriteLine($"{orderName} {orderPrice} {order.Quantity}, {order.Amount}");
        }

        public static string CreateCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var list = Enumerable.Repeat(0, 8).Select(x => chars[random.Next(chars.Length)]);
            return string.Join("", list);
        }
    }
}
