public class Employee
{
    // instance fields
    private int _id;
    private string _name;
    private string _job;
    private int _salary;
    private double _tax;

    // static fiels
    public static string _companyName;

    // instance property
    public int ID
    {
        set
        { 
            if(value >= 100)
            {
                _id = (int)value;
            }
        }
        get { return _id; }
    }

    public string Name
    {
        set { _name = value; }
        get { return _name; }
    }

    public string Job
    {
        set { _job = value; }
        get { return _job; }
    }

    // readonly property
    public int Salary
    {
        get { return _salary; } 
    }

    // write-only
    public double Tax
    {
        set
        { 
            if(value >= 0 && value <= 100)
            {
                _tax = value;
            }
            
        }
    }

    // method double
    public double CalculateNetSalary()
    {
        return Salary - _tax;
    }

    public static string CompanyName
    {
        set 
        { 
            if(value.Length <= 20)
            {
                _companyName = value;
            }
            
        }
        get { return _companyName; }
    }

    // instance constructor
    public Employee(int id, string name, string job)
    {
        this.ID = id;   
        this.Name = name;   
        this.Job = job; 
    }

    // constructor overloding: constructor 2
    public Employee(int id, string name)
    {
        this.ID = id;   
        this.Name = name;
    }    
    
    // constroctor 2
    public Employee()
    {
        _id = 1;
        this._salary = 1000;
    }

    // automatic properties
    public string NativePlace { get; set; } = "New Delhi";

    // static consstructor
    static Employee()
    {
        CompanyName = "ABC (pty)ltd";

    }

}