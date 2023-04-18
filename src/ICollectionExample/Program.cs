using System;
using System.Collections.Generic;
using System.Collections;

namespace ICollectionExample
{
  public enum TypeOfCustomer
  {
    RegularCustomer, VIPCustomer
  }

  public class Customer
  {
    public string CustomerID { get; set; } = string.Empty;
    public string CustomerName{ get; set; } = string.Empty;
    public string Email{ get; set; } = string.Empty;
    public TypeOfCustomer CustomerType{ get; set; }
  }

  // custom collection class
  public class CustomersList:ICollection<Customer>
  {
    // private collection
    private List<Customer> customers = new List<Customer>();

    public int Count => customers.Count;

    public bool IsReadOnly => false;

    // NON_GENERIC
    public IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    //GENERIC
    public IEnumerator<Customer> GetEnumerator()
    {
      for (var i = 0; i < customers.Count; i++)
      {
        yield return customers[i];
      }
    }

    // Add method
    public void Add(Customer customer)
    {
      if(customer.CustomerID.StartsWith('A') || customer.CustomerID.StartsWith("a"))
      {
        customers.Add(customer);
      }
      else
      {
        Console.WriteLine("Invalid customer ID");
      }
    }

    public void Clear()
    {
      customers.Clear();
    }

    public bool Contains(Customer item)
    {
      return customers.Contains(item);
    }

    public void CopyTo(Customer[] array, int arrayIndex)
    {
      customers.CopyTo(array, arrayIndex);
    }

    public bool Remove(Customer item)
    {
      return customers.Remove(item);
    }

    public Customer Find(Predicate<Customer>match)
    {
      return customers.Find(match);
    }

    public List<Customer> FindAll(Predicate<Customer>match)
    {
      return customers.Find(match);
    }
  }

  class Program 
  {
    static void Main()
    {
      CustomersList customersList = new CustomersList()
      {
        new Customer(){CustomerID="A101", CustomerName="James", Email="James@email.com", CustomerType= TypeOfCustomer.RegularCustomer},
        new Customer(){CustomerID="A102", CustomerName="Zack", Email="Zack@email.com", CustomerType= TypeOfCustomer.VIPCustomer},
        new Customer(){CustomerID="A103", CustomerName="Lissa", Email="Lissa@email.com", CustomerType= TypeOfCustomer.VIPCustomer},
      };
      IEnumerator enumerator = customersList.GetEnumerator();

      //add
      Customer newCustomer = new Customer()
      {
        CustomerID="A456", 
        CustomerName = "Jake", 
        Email = "Jake@email.com", 
        CustomerType = TypeOfCustomer.RegularCustomer 
      };

      customersList.Add(newCustomer);

      // contains
      

      Console.WriteLine("{0} customers found", customersList.Count);

      foreach(Customer customer in customersList)
      {
        Console.WriteLine("{0}, {1}, {2}", customer.CustomerID, customer.CustomerName, customer.CustomerType);
      }
    }
  }
}

