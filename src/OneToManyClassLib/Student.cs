using System;
using System.Collections.Generic;

namespace College
{
    /// <summary>
    /// Represents a student
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Email { get; set; }   
        public List<Examination> examinations { get; set; }
    }
}
 