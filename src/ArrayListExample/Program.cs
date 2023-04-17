using System;
using System.Collections;

namespace ArrayListExample
{
  class Sample
  {
    public int GetNumber()
    {
      return 28;
    }

    public double GetDouble()
    {
      return 10.6;
    }

    public string GetMessage()
    {
      return "Hello";
    }

    public Employee GetEmployee()
    {
      return new Employee(){EmployeeName = "Scott"};
    }
  }

  class Employee
  {
    public string EmployeeName { get; set; } = string.Empty;
  }

  class Program
  {
    static void Main()
    {
      Sample s = new Sample();
      // create object
      ArrayList arrayList = new ArrayList() { 100, 'A' };

      // Add
      arrayList.Add(s.GetNumber());
      arrayList.Add(s.GetDouble());
      arrayList.Add(s.GetMessage());
      arrayList.Add(s.GetEmployee());

      //print

      foreach (var item in arrayList)
      {
        if(item is Employee emp)
        {
          Console.WriteLine(emp.EmployeeName);
        }
        else
        {
          Console.WriteLine(item);
        }
      }
    }
  }
}