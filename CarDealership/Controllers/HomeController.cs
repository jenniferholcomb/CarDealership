using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      //Car newCar = new Car(makeModel, price, miles);
      Dictionary<string, int[]> allCars = Car.GetAll();
      //allCars["_instances"] = Car.GetAll();
      return View(allCars);
      // Car yugo = new Car("1980 Yugo Koral", 700, 56000);
    }

    [HttpGet("/car/new")]
    public ActionResult NewForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
      Car myCar = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }



  }
}
    // Car yugo = new Car("1980 Yugo Koral", 700, 56000);
    //Dictionary<string, int[]>