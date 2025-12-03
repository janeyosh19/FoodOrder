// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Handler.Database;
using ConsoleApp1.Handler.UserInput;
using ConsoleApp1.Handler.Database.Record;
using ConsoleApp1.Handler.Database.Table;
using ConsoleApp1.Handler.ProcessMenu;
using ConsoleApp1.Models;
using System.Collections.Generic;
using System.Numerics;


ShowRecordHandler.ShowFoodRecord(true, 0);

Console.WriteLine("Choose a number what you want to do?");
Console.WriteLine("1. Place an order 2. Add menu 3. Update menu 4. Delete menu");
int input = ProcessUserInput.ConvertStringToInteger(ProcessUserInput.Get());

if(input is >= 1 and <= 4)
{
    switch (input)
    {
        case 1:
            //GetOrder.GetOrder();
            //break;
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
}
else
{
    Console.WriteLine("No chosen action");
}