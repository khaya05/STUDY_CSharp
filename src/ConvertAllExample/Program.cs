using System;
using System.Collections.Generic;

namespace ConvetAllExample
{
    class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>() { 1, 3, 5, 8, 9 };
            List<string> strCollection = intList.ConvertAll<string>(n =>
            {
                // squre n
                int m = n * n;
                return Convert.ToString(m);
            });

            // print the result
            foreach(string str in strCollection)
            {
                Console.WriteLine(str);
            }

        }

    }
}