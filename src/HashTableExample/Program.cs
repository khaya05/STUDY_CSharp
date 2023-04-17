using System;
using System.Collections;

namespace HashTableExample
{
    class Program
    {
    static void Main(string[] args)
    {
      // Create hash table
      Hashtable employees = new Hashtable()
      {
        { 1, "John" },
        { 2, "Jane" },
        { 3, "Mary" },
        { 4, "Bob" },
        { 5, "Steve" },
        {"Hello", 1.04}
      };

      // add element
      employees.Add(6, "Bill");

      // remove element
      employees.Remove(2);

      // get value by key
      if(employees[3] is string)
      {
        string name = employees[3].ToString();
        Console.WriteLine("Name: {0}", name);
      } else if(employees[3] is int)
      {
        int age = (int)employees[3];
        Console.WriteLine("Age: {0}", age);
      }

      //keys
      foreach (var key in employees.Keys)
      {
        Console.WriteLine("Key: {0}", key);
      }

      //values
      foreach (var value in employees.Values)
      {
        Console.WriteLine("Value: {0}", value);
      }
    } 

  }
}