using System;
using System.Text;

namespace StringBuilderExample;
class Program 
{
  static void Main()
  {
    string[] words = new string[] { "The", "lazy", "dog", "did", "the", "thing" };
    //string builder
    StringBuilder builder = new StringBuilder();
    foreach (string word in words)
    {
      builder.Append(word);
      builder.Append(" ");
    }

    Console.WriteLine(builder.ToString());
  }
}