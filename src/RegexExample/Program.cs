using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace RegexExample;
class Program 
{
  static void Main()
  {
    Regex regex = new Regex("[0-9a-zA-Z]");
    Console.WriteLine("Enter a Digit");
    string inputValue = Console.ReadLine()!;
    bool result = regex.IsMatch(inputValue);
    Console.WriteLine(result);
  }
}