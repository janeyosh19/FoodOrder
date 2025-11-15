using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DisplayTotalOrder
    {
        public void DisplayOrder(List<KeyValuePair<int, int>> listofOrders, List<string> foods, List<float> prices)
        {
            List <float> amount = new List<float>();

            
            foreach (KeyValuePair<int, int> kvp in listofOrders)
            {
                float kvpValue = (float)kvp.Value;
                kvpValue *= prices[kvp.Key];
                amount.Add(kvpValue);
                Console.WriteLine("Food = {0}, Quantity = {1}, Total = {2}", foods[kvp.Key], kvp.Value, kvpValue);
            }

            if (amount.Count > 0)
            {
                float grandTotal = 0.0f;
                foreach (float item in amount)
                {
                    grandTotal += item;
                }
                Console.WriteLine("Grand Total = ${0}", grandTotal);
            }
            else
            {
                Console.WriteLine("No orders were made.");
            }
        }
    }
}
