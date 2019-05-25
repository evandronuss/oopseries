
using System;

namespace OOP.Domain.Entities
{
  public class Customer
  {
    public Customer(string name, decimal salary, DateTime? birtdate = null)
    {
      Name = name;
      Birtdate = birtdate;
      Salary = salary;
    }

    public string Name { get; set; }
    public DateTime? Birtdate { get; set; }
    public decimal Salary { get; set; }
  }
}