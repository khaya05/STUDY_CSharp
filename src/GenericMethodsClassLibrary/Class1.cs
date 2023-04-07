using System;

public class Employee
{
    public int salary;
}

public class Student
{
    public int marks;
}

public class Sample
{
    //generic method
    public void PrintData<T>(T data) where T : class
    {
        if(data.GetType() == typeof(Student))
        {
            Student temp = data as Student;
            Console.WriteLine(temp.marks);
        } else if(data.GetType() == typeof(Employee))
        {
            Employee temp = data as Employee;
            Console.WriteLine(temp.salary);
        }
    }
}