using System;

class Student
{
    public void DisplayMarks(int marks1,int marks2, int marks3)
    {
        double avgMarks = getAverageMarks(marks1, marks2,marks3);
        Console.WriteLine("Marks1: " + marks1);
        Console.WriteLine("Marks1: " + marks2);
        Console.WriteLine("Marks1: " + marks3);
        Console.WriteLine("Avarage marks:" + avgMarks);

        // local function
        static double getAverageMarks(int m1, int m2, int m3)
        {
            double avg;
            avg = (double)(m1 + m2 + m3) / 3;
            return avg;
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        // call DisplayMarks method
        s.DisplayMarks(80,45,71);

        Console.ReadKey();
    }
}