using System;
using System.Collections.Generic;

namespace FindExample
{
    class Program
    {
        static void Main()
        {
            // marks collection 
            List<int> marks = new List<int>() { 40, 45, 24, 91, 50, 81 };

            // get marks of failed subject
            int grade = marks.Find(x => x < 35);
            int index = marks.IndexOf(grade);


            Console.WriteLine(index);
        }
    }
}