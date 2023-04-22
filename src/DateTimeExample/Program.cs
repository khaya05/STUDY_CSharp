using System;

namespace DateTimeExample;
class Person
{
  public string PersonName { get; set; } = string.Empty;
  public DateTime DateOfBirth { get; set; }
}


class Program 
{
  static void Main()
  {
    Person person1 = new Person();
    person1.PersonName = "Luke";
    person1.DateOfBirth = DateTime.Parse("1999/10/11");

    Console.WriteLine("Day: {0}", person1.DateOfBirth.Day);
    Console.WriteLine("Month: {0}", person1.DateOfBirth.Month);
    Console.WriteLine("Year: {0}", person1.DateOfBirth.Year);
    Console.WriteLine("Day Of Week: {0}", person1.DateOfBirth.DayOfWeek);
    Console.WriteLine("Day Of Year: {0}", person1.DateOfBirth.DayOfYear);

    DateTime dt = DateTime.Now;
    Console.WriteLine(dt.ToString());
  }
}