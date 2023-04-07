using System;
using System.Collections.Generic;

namespace FindAllExample
{
    class Program
    {
        static void Main()
        {
            // marks collection 
            List<int> marks = new List<int>() { 40, 45, 24, 91, 30, 81 };

            // Get index of marks of failed subjects
            List<int> failedSubjects = marks.FindAll(x => x < 35);

            // print collection
            Console.WriteLine("\nFailed Marks:");
            foreach (int item  in failedSubjects)
            {
                Console.WriteLine(item);
            }
        }
    }
}