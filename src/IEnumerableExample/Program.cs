using System;
using System.Collections.Generic;

namespace IEnumerableExample
{
    class Program
    {
        static void Main()
        {
            // collection
            IEnumerable<string> fruits;
            fruits = new List<string>() { "Apple", "Mango", "Grape"};

            // foreach
            Console.WriteLine("IENumerable");
            foreach (string item in fruits)
            {
                Console.WriteLine(item);
            }
        }
    }
}