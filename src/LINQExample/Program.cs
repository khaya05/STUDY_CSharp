using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
  class Employee
  {
    public int Id { get; set; }
    public string Name{ get; set; } = string.Empty;
    public string Job{ get; set; } = string.Empty;
    public string City{ get; set; } = string.Empty;

  }

  class Program
  {
    static void Main()
    {
      // collection
      List<Employee> employees = new List<Employee>
      {
        new Employee(){Id=101, Name="Stephen", Job="Surveyor", City="Durban"},
        new Employee(){Id=102, Name="Zack", Job="Electrician", City="Cape town"},
        new Employee(){Id=103, Name="Luke", Job="Mechanic", City="Johannesburg"},
        new Employee(){Id=104, Name="Nick", Job="Nurse", City="PE"},
      };

      var result = employees.Where(employee => employee.Job == "Mechanic");
      foreach(Employee item in result)
      {
        Console.WriteLine(item.Name, item.City);
      }
    }
  }
}