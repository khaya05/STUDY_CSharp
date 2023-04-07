class Sample
{
    static void Main()
    {
        //reference variables
        Employee employee1, employee2, employee3;

        //objects
        employee1 = new Employee();
        employee2 = new Employee();
        employee3 = new Employee(); 

        //initializing
        employee1.EmpID = 1;
        employee1.EmpName = "Zack";
        employee1.SalaryPerHour = 8;
        employee1.NoOfWorkingHours = 40;
        employee1.NetSalary = 320;

        employee2.EmpID = 2;
        employee2.EmpName = "Army";
        employee2.SalaryPerHour = 10;
        employee2.NoOfWorkingHours = 40;
        employee2.NetSalary = 400;

        employee3.EmpID = 3;
        employee3.EmpName = "Luke";
        employee3.SalaryPerHour = 12;
        employee3.NoOfWorkingHours = 40;
        employee3.NetSalary = 480;

        Console.WriteLine(employee1.EmpID);


    }
}