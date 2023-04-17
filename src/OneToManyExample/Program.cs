using System;
using System.Collections.Generic;
using College;

namespace OneToManyExample
{
    class Progam
    {
        public static void Main()
        {
            // obj of student Class
            Student student = new Student() { Id = 1, Name = "Allen", Email = "allen@gmail.com"};
            student.examinations = new List<Examination>();

            student.examinations.Add(new Examination() { ExaminationName = "Test 1", Month = 1 , Year = 2020, MaxMarks = 100, SecuredMarks = 87});
            student.examinations.Add(new Examination() { ExaminationName = "Test 2", Month = 2, Year = 2020, MaxMarks = 100, SecuredMarks = 77 });
            student.examinations.Add(new Examination() { ExaminationName = "Test 3", Month = 3, Year = 2020, MaxMarks = 100, SecuredMarks = 55 });

            // print
            Console.WriteLine();
        }
    }
}