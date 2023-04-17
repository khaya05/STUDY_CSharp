using System;
using System.Collections.Generic;

namespace HashSetExample2
{
  class Program
  {
    static void Main()
    {
      HashSet<string> employees2021 = new HashSet<string>() {"Amar", "Akhil", "Prioshia" };
      HashSet<string> newEmployees2022 = new HashSet<string>() {"John", "Luke", "Zacky" };

      // unionWith
      employees2021.UnionWith(newEmployees2022);

      // print
      foreach(string employee in employees2021)
      {
        Console.WriteLine(employee);
      }
    }
  }
}