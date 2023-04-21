using System;
using System.Collections.Generic;
using HarshaBank.Entities;
using HarshaBank.Exceptions;
using HarshaBank.BusinessLogicLayer;

namespace HarshaBank.Presentation
{
  static class CustomersPresentation
  {
    internal static void AddCustomer()
    {
      try
      {
        // create an object of customer
        Customer customer = new Customer();

        // read details from the user
        Console.WriteLine("\n******ADD CUSTOMER******");
        Console.Write("Customer Name");
        customer.CustomerName = Console.ReadLine();
        Console.Write("Customer Address");
        customer.Address = Console.ReadLine();
        Console.Write("Customer Landmark");
        customer.Landmark = Console.ReadLine();
        Console.Write("Customer City");
        customer.City = Console.ReadLine();
        Console.Write("Customer Country");
        customer.Country = Console.ReadLine();
        Console.Write("Customer Mobile");
        customer.Mobile = Console.ReadLine();

        // create BL object
        ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();
        Guid newGuid = customersBusinessLogicLayer.AddCustomer(customer);

        List<Customer> matchingCustomers = customersBusinessLogicLayer.GetCustomersByCondition(item => item.CustomerID == newGuid);

        if(matchingCustomers.Count >= 1)
        {
          customersBusinessLogicLayer.WriteLine("New Customer Code:" + matchingCustomers[0].CustomerCode);
          customersBusinessLogicLayer.WriteLine("Customer Added/\n");
        }
        else
        {
          customersBusinessLogicLayer.WriteLine("Customer Not added");
        }

      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.GetType);
      }
    }
  }


  
}
