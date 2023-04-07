using System;
using System.Collections.Generic;

namespace FindIndexExample
{
    class Program
    {
        static void Main()
        {
            // marks collection 
            List<int> marks = new List<int>() { 40, 45, 24, 91, 50, 81 };

            // Get index of marks first failed
            int index = marks.FindIndex(x => x < 35);

            Console.WriteLine(index);
        }
    }
}