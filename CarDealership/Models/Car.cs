using System;
using System.Collections.Generic;

// Business Logic

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public static Dictionary<string, int []> _instances = new Dictionary<string, int[]>() { };

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(makeModel, new int[]{price, miles});
    }

    public static Dictionary<string, int[] > GetAll()  
    {
      return _instances;
    }

    // instance methods
    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    // static method
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public static int Discount(Car automobile)
    {
      double discountMultiplier = 0.9;
      double currentPrice = Convert.ToDouble(automobile.Price);
      double newPriceDouble = currentPrice * discountMultiplier;
      int newPrice = Convert.ToInt32(Math.Round(newPriceDouble));
      return newPrice;
    }
  }
}
