using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GetOrder
    {
        public KeyValuePair<int, int> GetKeyValue()
        {
            int orderIndex = 0;
            int orderTotal = 0;

            Console.WriteLine("Food number?");
            orderIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("how many?");
            orderTotal = int.Parse(Console.ReadLine());

            return new KeyValuePair<int, int>(orderIndex, orderTotal);
        }
    }
}
