using System;
using System.Collections.Generic;

namespace StackExample
{
  class Student
  {
    public int Marks { get; set; }
    public int Rank { get; set; }
  }

  class Program
  {
    static void Main()
    {
      // object of stack
      Stack<Student> marks = new Stack<Student>();

      // add
      marks.Push(new Student(){Marks = 45});
      marks.Push(new Student(){Marks = 55});
      marks.Push(new Student(){Marks = 65});

      // pop
      Student stu = marks.Peek();
      Console.WriteLine("Pop: " + stu.Marks);

      int rank = 1;
      //print
      foreach (Student item in marks)
      {
        item.Rank = rank;
        Console.WriteLine("Marks {0}, Rank {1}", item.Marks, item.Rank);
        rank++;
      }
    }
  }
}