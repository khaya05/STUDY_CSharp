using System;
using System.Collections.Generic;

namespace HashSetExample3
{
  class Program
  {
    static void Main()
    {
      HashSet<string> employees2021 = new HashSet<string>() {"Amar", "Akhil", "Prioshia" };
      HashSet<string> employees2022 = new HashSet<string>() {"Amar", "Akhil","John", "Luke", "Zacky" };

      // unionWith
      employees2021.IntersectWith(employees2022);

      // print
      foreach(string employee in employees2021)
      {
        Console.WriteLine(employee);
      }
    }
  }
}