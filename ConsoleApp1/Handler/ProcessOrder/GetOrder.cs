//using ConsoleApp1.Handler.Database;
//using ConsoleApp1.Handler.UserInput;
//using ConsoleApp1.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Handler.ProcessOrder
//{

//    internal class GetOrder
//    {
//        public static void HandleOrder()
//        {
//            AddOrder addOrder = new AddOrder();

//            bool toOrder = false;

//            while (toOrder)
//            {
//                Console.WriteLine("Choose a menu number to order.");
//                int menuId = UserInput.ProcessUserInput.ConvertStringToInteger(UserInput.ProcessUserInput.Get());
//                Console.WriteLine("How many?");
//                int quantity = UserInput.ProcessUserInput.ConvertStringToInteger(UserInput.ProcessUserInput.Get());

//                var menu = GetRecordHandler.GetFoodRecord(menuId);
//                addOrder.HandleOrder(menu.Name, menu.Price, quantity);

//                Console.WriteLine("Do you want to order again?");
//                Console.WriteLine("1.Yes 2. No");
//                if (UserInput.ProcessUserInput.ConvertStringToInteger(UserInput.ProcessUserInput.Get()) == 1)
//                {
//                    toOrder = true;
//                }
//                else { toOrder = false; }
//            }
//        }
//    }
//}
