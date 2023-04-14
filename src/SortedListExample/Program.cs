using System;
using System.Collections.Generic;

namespace SortedListExample
{
    class Program
    {
    static void Main(string[] args)
    {
      // Create a new sorted list of strings, with string keys.
      SortedList<int, string> employees = new SortedList<int, string>()
      {
        { 1, "John" },
        { 2, "Jane" },
        { 3, "Mary" },
        { 4, "Bob" },
        { 5, "Steve" }
      };
      // add element
      employees.Add(6, "Bill");

      // remove element
      employees.Remove(2);

      //loop through the list
      foreach (KeyValuePair<int, string> employee in employees)
      {
        Console.WriteLine("Key: {0}, Value: {1}", employee.Key, employee.Value);
      }

      // get value by key
      string name = employees[3];
      Console.WriteLine("Name: {0}", name);

      // get specific key
      bool k = employees.ContainsKey(4);
      

    } 

  }
}