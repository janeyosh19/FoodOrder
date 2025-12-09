// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Handler.Database;
using ConsoleApp1.Handler.UserInput;
using ConsoleApp1.Handler.Database.Record;
using ConsoleApp1.Handler.Database.Table;
using ConsoleApp1.Handler.ProcessMenu;
using ConsoleApp1.Models;
using System.Collections.Generic;
using System.Numerics;
using ConsoleApp1.Handler.ProcessOrder;


//CreateTableHandler.CreateFoodTable();
//CreateTableHandler.CreateOrdersTable();
//CreateTableHandler.CreateFoodOrdersTable();

//DeleteTableHandler.DeleteFoodOrdersTable();
//DeleteTableHandler.DeleteFoodTable();
//DeleteTableHandler.DeleteOrderTable();

DeleteRecordHandler.DeleteAllFoodOrderRecords();
DeleteRecordHandler.DeleteAllOrderRecords();


ShowRecordHandler.ShowFoodRecord(true, 0);
ShowRecordHandler.ShowOrderRecord(true, 0);
ShowRecordHandler.ShowFoodOrdersRecord();


Console.WriteLine("Choose a number what you want to do?");
Console.WriteLine("1. Place an order 2. Add menu 3. Update menu 4. Delete menu");
int input = ProcessUserInput.ConvertStringToInteger(ProcessUserInput.Get());
switch (input)
{
    case 1:
        AddOrderHandler.AddOrder();
        break;
    case 2:
        InsertFoodHandler.InsertFood();
        break;
    case 3:
        UpdateFoodHandler.UpdateFood();
        break;
    case 4:
        DeleteFoodHandler.DeleteFood();
        break;
    default:
        Console.WriteLine("No chosen action.");
        break;
}
