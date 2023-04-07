class Program
{
    static void Main()
    {
        Employee emp1 = new Employee(101 , "Luke", "Cleaner"); 
        Employee emp2 = new Employee(102, "Amy", "CEO"); 
        Employee emp3 = new Employee(103, "J", "HR");

        Employee emp4 = new Employee();
        emp4.ID = 101;
        emp4.Name = "Zack";
        emp4.Job = "film producer";
        emp4.NativePlace = "Nkandla";

        Employee emp5 = new Employee(102, "Luke");
        emp5.Job = "Systems designer";

        Employee emp6 = new Employee() { Name = "Ann", Job = "None" };
    }
}