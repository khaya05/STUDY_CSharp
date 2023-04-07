public class Employee
{
    public int EmpID;
    public string EmpName;
    public int SalaryPerHour;
    public int NoOfWorkingHours;
    public int NetSalary;
    public static string OrganizationName;
    public readonly string DepartmentName;
    public const string TypeOfEmployee = "contact based";

    //custructor
    public Employee()
    {
        OrganizationName = "Harsha Inc";
        DepartmentName = "Finane Depatment";
    }

}