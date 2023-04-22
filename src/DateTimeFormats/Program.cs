using System;

namespace DateTimeFormats;
class Program 
{
  static void Main()
  {
    // DateTime dt = DateTime.Parse("2020.12.31 11:59:59");
    DateTime dt = DateTime.ParseExact
    (
      "31/12/2022 23:59:59", 
      "dd/MM/yyyy HH:mm:ss", 
      System.Globalization.CultureInfo.InvariantCulture, 
      System.Globalization.DateTimeStyles.None
    );

    string str1 = dt.ToString();
    Console.WriteLine(dt.ToShortDateString()); 
    Console.WriteLine(dt.ToLongDateString()); 
    Console.WriteLine(dt.ToShortTimeString()); 
    Console.WriteLine(dt.ToLongTimeString()); 

    Console.WriteLine(dt.ToString("dd.MM.yyyy HH:mm:ss")); 
    // Console.WriteLine(str1); 
  }
}