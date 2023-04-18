using System;
using System.Collections.Generic;

namespace IteratorExample
{
  public class Sample
  {
    public IEnumerable<int> Method()
    {
      Console.WriteLine("Iterator method executes");
      yield return 10;
      Console.WriteLine("Iterator method executes again");
      yield return 12;

    }
  }

  public class Program
  {
    public static void Main()
    {
      Sample s = new Sample();
      var enumerable1 = s.Method();
      // var enumerator1 = enumerable1.GetEnumerator();
      // enumerator1.MoveNext();
      // Console.WriteLine(enumerator1.Current);
      // enumerator1.MoveNext();
      // Console.WriteLine(enumerator1.Current);
      foreach(var item in enumerable1)
      {
        Console.WriteLine(item);
      }
    }
  }
}