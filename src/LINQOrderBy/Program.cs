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
    public double Salary{ get; set; } 

  }

  class Program
  {
    static void Main()
    {
      // collection
      List<Employee> employees = new List<Employee>
      {
        new Employee(){Id=101, Name="Stephen", Job="Surveyor", Salary = 42_00},
        new Employee(){Id=102, Name="Zack", Job="Electrician", Salary = 53_000},
        new Employee(){Id=103, Name="Luke", Job="Mechanic", Salary = 37_000},
        new Employee(){Id=104, Name="Nick", Job="Nurse", Salary = 32_000}, 
      };

      IOrderedEnumerable<Employee> sortedEmployees = employees.OrderBy(emp => emp.Name);
      foreach( Employee item in sortedEmployees)
      {
        Console.WriteLine("{0}, {1}, {2}", item.Name, item.Job, item.Salary);
      }
    }
  }
}