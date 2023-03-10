using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ToDoList
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      WebApplication app = builder.Build();

      app.UseHttpsRedirection();

      app.UseRouting();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();
    }
  }
}


// using System;
// using System.Collections.Generic;
// using Dealership.Models;

// // UI logic

// namespace Dealership
// {
//   public class Program
//   {
//     public static void Main()
//     {
//       Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
//       Car yugo = new Car("1980 Yugo Koral", 700, 56000);
//       Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
//       Car amc = new Car("1976 AMC Pacer", 400, 198000);

//       List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

//       yugo.SetPrice(300);
//       Console.WriteLine(Car.MakeSound("bang"));

//       Console.WriteLine("Enter maximum price: ");
//       string stringMaxPrice = Console.ReadLine();
//       int maxPrice = int.Parse(stringMaxPrice);

//       List<Car> CarsMatchingSearch = new List<Car>(0);

//       foreach (Car automobile in Cars)
//       {
//         int newPrice = Car.Discount(automobile);
//         automobile.Price = newPrice;
//         if (automobile.WorthBuying(maxPrice))
//         {
//           CarsMatchingSearch.Add(automobile);
//         }
//       }

//       foreach (Car automobile in CarsMatchingSearch)
//       {
//         Console.WriteLine("--------------");
//         Console.WriteLine(automobile.GetMakeModel());
//         Console.WriteLine(automobile.GetMiles() + " miles");
//         Console.WriteLine("$" + automobile.GetPrice());
//       }
//     }
//   }
// }