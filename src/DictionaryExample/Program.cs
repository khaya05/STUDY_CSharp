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

      string s = employees[101];
      Console.WriteLine("Value at 101: " + s);

      // access keys
      Dictionary<int, string>.KeyCollection keys = employees.Keys;

      Console.WriteLine("Dict Keys:-");
      
      foreach(int key in keys)
      {
        Console.WriteLine(key);
      }

      // ContainsKey
      bool a = employees.ContainsKey(104);
      Console.WriteLine("ContainsKey 104:- " + a);

      // ContainsValue 
      bool b = employees.ContainsValue("Larry");
      Console.WriteLine("ContainsValue Larry:- " + b);
    }
  }
}