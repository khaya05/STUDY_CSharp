namespace ValueTupleClassLib
{
  public class Customer
  {
    public (int ID, string Name, string Email) GetCustomerDetails()
    {
      return (101, "scott", "scott@email.com");
    }
  }

};
