using System;
using ValueTupleClassLib;

namespace ValueTupleExample
{
  class Program
  {
    static void Main()
    {
      Customer c = new Customer();

      // getDetails
      (int Id, string Name, string Email) = c.GetCustomerDetails();

      Console.WriteLine(Email);
    }
  }
}