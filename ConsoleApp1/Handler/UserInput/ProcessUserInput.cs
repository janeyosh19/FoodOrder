using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Handler.UserInput
{
    internal class ProcessUserInput
    {
        public static string? Get()
        {
            return Console.ReadLine();
        }
        public static int ConvertStringToInteger(string input)
        {
            _ = int.TryParse(input, out int result);
            return result;
        }
        public static bool CheckIntegerValue(string input)
        {
            return int.TryParse(input, out _);
        }
        public static decimal ConvertStringToDecimal(string input)
        {
            _ = decimal.TryParse(input, out decimal result);
            return result;
        }
        public static bool CheckDecimalValue(string input)
        {
            return decimal.TryParse(input, out _);
        }
    }
}