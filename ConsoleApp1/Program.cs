// See https://aka.ms/new-console-template for more information
//using ConsoleApp1.Handler.Database;
//using ConsoleApp1.Handler.Items;
//using ConsoleApp1.Handler.Order;
//using ConsoleApp1.Handler.UserInput;
using ConsoleApp1.Handler.Database;
using ConsoleApp1.Handler.Database.Record;
using ConsoleApp1.Handler.Database.Table;
using ConsoleApp1.Handler.ProcessMenu;
using ConsoleApp1.Models;
using System.Collections.Generic;
using System.Numerics;

//DeleteTableHandler.DeleteFoodTable();
//DeleteTableHandler.DeleteOrderTable();
//AddTableHandler.CreateFoodTable();
//AddTableHandler.CreateOrderTable();
//InsertRecordHandler.InsertFoodRecord("Burger", 12.13m);
//InsertRecordHandler.InsertFoodRecord("Pizza", 7.99m);
//InsertRecordHandler.InsertFoodRecord("Half-Chicken", 3.99m);
ShowRecordHandler.ShowFoodRecord(true, 0);
//DeleteRecordHandler.DeleteFoodRecord(3);


//AddFoodHandler.AddFood();
//DeleteFoodHandler.DeleteFood();





//SHOW RECORD
//RecordDB.ShowRecord(true, 0); //cs0176
//Console.WriteLine("Choose a number what you want to do?");
//Console.WriteLine("1. Place an order 2. Add menu 3. Update menu 4. Delete menu");
//string? Input = ProcessUserInput.Get();

//if (ProcessUserInput.CheckFloatValue(Input))
//{
//    switch(ProcessUserInput.ConvertStringToInteger(Input))
//    {
//        case 1:
//            GetOrder.GetOrder();
//            break;
//        case 2:
//            ProcessMenu.AddMenu();
//            break;
//        case 3:
//            ProcessMenu.UpdateMenu();
//            break;
//        case 4:
//            ProcessMenu.DeleteMenu();
//            break;
//        default:
//            Console.WriteLine("No chosen action.");
//            break;
//    }
//}
//else
//{
//    Console.WriteLine("The input cannot be empty or a text.");
//}


//public record Food
//{
//    public string Id { get;  set; }
//    public  string Menu { get; set; }
//    public  string Price { get; set; }
//};