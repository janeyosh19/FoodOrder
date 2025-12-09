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
        public static void AddOrder()
        {
            Food food = new Food();
            Order order = new Order();

            var rand = new Random();
            bool toOrder = true;

            order.No = 1;

            //check if orderNo exist
            while (CheckRecordExistHandler.CheckOrderNoExist(order.No))
            {
                order.No = rand.Next(1, 9999); 
            }

            while(true)
            {
                //Ask order details
                Console.WriteLine("Choose a menu number to order.");
                food.Id = UserInput.ProcessUserInput.ConvertStringToInteger(UserInput.ProcessUserInput.Get());
                Console.WriteLine("How many?");
                order.Quantity = UserInput.ProcessUserInput.ConvertStringToInteger(UserInput.ProcessUserInput.Get());

                food.Price = GetRecordHandler.GetFoodRecord(food.Id).Price;
                
                //Add order record
                InsertRecordHandler.InsertOrderRecord(order.No, order.Quantity, food.Price * order.Quantity);
                order.Id = GetRecordHandler.GetOrderId(order.No);

                //Check if foodid exist in food order table
                if (CheckRecordExistHandler.CheckFoodIdExist(food.Id))
                {
                   UpdateRecordHandler.UpdateOrderRecord(food.Id, order.Id, order.Quantity, food.Price * order.Quantity);
                //Update  FoodOrder quantity based on the foo id and  order id 
                UpdateRecordHandler.UpdateFoodOrderQuantityRecord(food.Id, order.Id, order.Quantity);
                }
                //Add food order record
                else {
                    InsertRecordHandler.InsertFoodOrderRecord(food.Id, order.Id);
                }

                Console.WriteLine("Do you want to order again?");
                Console.WriteLine("1.Yes 2. No");
                if (UserInput.ProcessUserInput.ConvertStringToInteger(UserInput.ProcessUserInput.Get()) == 1)
                {
                    toOrder = true;
                }
                else { toOrder = false; }
            }
        }
    }
}
