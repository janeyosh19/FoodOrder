using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Order(int id, string name, string code, decimal price, int quantity, decimal amount)
    {
        public int Id { get; } = id;
        public string Name { get; set; } = name;
        public string Code { get; set; } = code;
        public decimal Price { get; set; } = price; 
        public int Quantity { get; set; }  = quantity;
        public decimal Amount { get; } = amount;
    }

    public class OrderInsert(string name, string code, decimal price, int quantity, decimal amount)
    {
        public string Name { get; set; } = name;
        public string Code { get; set; } = code;
        public decimal Price { get; set; } = price;
        public int Quantity { get; set; } = quantity;
        public decimal Amount { get; } = amount;
    }

    public class OrderList(int id, string name, string code, decimal price, int quantity, decimal amount)
    {
        public int Id { get; } = id;
        public string Name { get; set; } = name;
        public string Code { get; set; } = code;
        public decimal Price { get; set; } = price;
        public int Quantity { get; set; } = quantity;
        public decimal Amount { get; } = amount;
    }

    public class OrderDelete(int id)
    {
        public int Id { get; } = id;
    }

    public class OrderUpdate(int id, string name, string code, decimal price, int quantity, decimal amount)
    {
        public int Id { get; } = id;
        public string Name { get; set; } = name;
        public string Code { get; set; } = code;
        public decimal Price { get; set; } = price;
        public int Quantity { get; set; } = quantity;
        public decimal Amount { get; } = amount;
    }
}
