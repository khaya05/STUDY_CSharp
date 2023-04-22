using System;

namespace DateOperations;
class Employee
{
  public string Name { get; set; } = string.Empty;
  public DateTime DateOfJoining{ get; set; }
  public double ExperienceYears { get; set; }
  public double ExperienceMonths { get; set; }
}

class Program 
{

  static void Main()
  {
    Employee emp = new Employee() 
    { 
      Name = "Zack", 
      DateOfJoining = DateTime.Parse("1999/10/11") 
    };

    DateTime today = DateTime.Now;
    if(today.CompareTo(emp.DateOfJoining) == 1)
    {
      TimeSpan ts = today.Subtract(emp.DateOfJoining);
      Console.WriteLine(ts);

    } 
    else 
    {
      Console.WriteLine("Error");
    };
  }
}