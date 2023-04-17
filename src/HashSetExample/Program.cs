using System;
using System.Collections.Generic;

namespace HashSetExample
{
  class Program
  {
    static void Main()
    {
      // create a hash set
      HashSet<string> fruits = new HashSet<string>()
      {
        "Apple", "Banana", "Litchi"
      };

      // add
      fruits.Add("Oranges");

      // removeWhere
      fruits.RemoveWhere(x => x.EndsWith('i'));

      Console.WriteLine("Count: " + fruits.Count);
      // loop
      foreach (string fruit in fruits)
      {
        Console.WriteLine(fruit);
      }

    }
  }
}