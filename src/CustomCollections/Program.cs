using System;
using System.Collections.Generic;
using System.Collections;

namespace CustomCollections
{
  public enum TypeOfCustomer
  {
    RegularCustomer, VIPCustomer
  }

  public class Customer
  {
    public string CustomerID{ get; set; }
    public string CustomerName{ get; set; }
    public string Email{ get; set; }
    public TypeOfCustomer CustomerType{ get; set; }
  }

  // custom collection class
  public class CustomerList
  {
    
  }
}