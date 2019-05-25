using System;
using OOP.Domain.Entities;

namespace OOP.App
{
  class Program
  {
    static void Main(string[] args)
    {
      var cust = new Customer("Evandro Nuss", 2000);
      var cust2 = new Customer("Evandro Nuss", 2000, DateTime.Now);

      Console.WriteLine("Hello World!");
    }
  }
}
