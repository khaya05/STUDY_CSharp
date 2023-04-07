using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>(10) { 10,20,30};

            // Add new element
            // list.Add(40);

            //newList
            List<int> newList = new List<int>(3) { 50, 60, 70 };

            //addrange
            //list.addrange(newlist);

            // Insert(int, newVal)
            list.Insert(1, 100);

            // InsertRange
            list.InsertRange(2, newList);

            // Remove(T)
            // list.Remove(100);

            //RemoveAt(int)
            // list.RemoveAt(2);

            // RemoveRange
            //list.RemoveRange(1, 2);

            // RemoveAll()
            // list.RemoveAll(X => X >= 30);

            // Clear

            // sort / reverse
            list.Sort();
            list.Reverse();

            //ToArray
            int[] listArr = list.ToArray();

            list.ForEach(num => Console.WriteLine(num));
        }
    }
}