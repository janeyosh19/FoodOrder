using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Order()
    {
        public int Id { get; set; }
        public int No { get; set; } 
        public int Quantity { get; set; }
        public decimal Amount { get; }
    }
}
