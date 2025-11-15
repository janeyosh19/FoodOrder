// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Collections.Generic;
using System.Numerics;



//SHOW RECORD
RecordDB.ShowRecord(true, 0); //cs0176
EditMenu.ChangeRecord();


//int orderIndex = 0;
//int orderTotal = 0;
//float totalPrice = 0.0f;
//bool orderAgain = false;

//Dictionary<int, int> listofOrders =
//    new Dictionary<int, int>();

//for (int i = 0; i < foods.Length; i++)
//{
//    Console.WriteLine($"{i}: {foods[i]} - ${prices[i]}");
//}

//GetOrder myorder = new GetOrder();
//Console.WriteLine("Do you want to order?");
//orderAgain = Console.ReadLine().ToLower() == "yes"; //if it gives a number then ask again

//while (orderAgain == true)
//{
//    var order = myorder.GetKeyValue();
//    if (order.Value != 0)
//    {
//        if (listofOrders.ContainsKey(order.Key)) // add total to the existing key
//        {
//            listofOrders.TryGetValue(order.Key, out int existingValue);
//            existingValue += order.Value;
//            listofOrders[order.Key] = existingValue;
//        }
//        else
//        {
//            listofOrders.Add(order.Key, order.Value); //if its a new key
//        }
//    }
//    Console.WriteLine("Do you want to order again?");
//    orderAgain = Console.ReadLine().ToLower() == "yes";
//}

//DisplayTotalOrder displayOrder = new DisplayTotalOrder();
//displayOrder.DisplayOrder(listofOrders.ToList(), foods.ToList(), prices.ToList());



