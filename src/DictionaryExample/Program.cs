using System;
using System.Collections.Generic;

namespace DictionaryExample
{
  class Program
  {
    static void Main()
    {
      Dictionary<int, string> employees = new Dictionary<int, string>()
      {
        {101, "Larry"},
        {102, "Page"},
        {103, "Nancy"}
      };

      foreach(KeyValuePair<int, string> item in employees)
      {
        Console.WriteLine(item.Key + ", " + item.Value);
      }
    }
  }
}