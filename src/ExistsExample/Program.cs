using System;
using System.Collections.Generic;

namespace ExistsExample
{
    class Program
    {
        static void Main()
        {
            // marks collection 
            List<int> marks = new List<int>() { 40, 45, 74, 91, 50, 81 };

            // check if student failed
            bool failed = marks.Exists(mark => mark <= 35);


            Console.WriteLine(failed ? "FAILED" : "PASSED");
        }
    }
}