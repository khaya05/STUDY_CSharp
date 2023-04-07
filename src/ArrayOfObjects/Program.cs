using ArrayOfObjectsClassLibrary;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // objects
            Employee emp1 = new Employee() { Id = 101, Name = "Luke" };
            Employee emp2 = new Employee() { Id = 102, Name = "Cage" };
            Employee emp3 = new Employee() { Id = 103, Name = "Zack" };

            //
            Employee[] employees = new Employee[] { emp1, emp2, emp3 };
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}