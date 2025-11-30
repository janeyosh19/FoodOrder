using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public sealed record Food
    {
        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Food(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
