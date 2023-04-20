using System;
using HarshaBank.Entities;
using HarshaBank.Exceptions;
using System.Collections.Generic;
using HarshaBank.BusinessLogicLayer.Contracts;

namespace HarshaBank.BusinessLogic;
/// <summary>
/// Represents customer business logic
/// </summary>
public class CustomerBusinessLayer:ICustomerBusinessLogicLayer
{
  #region Private Fields
  private ICustomerBusinessLogicLayer _customerDataAccessLayer;
  #endregion

  #region Constructors
  /// <summary>
  /// Constructor that initializes CustomerDataAccessLayer
  /// </summary>
  public CustomerBusinessLayer()
  {
    _customerDataAccessLayer = new CustomerDataAccessLayer();
  }
  #endregion

  #region Properties
  /// <summary>
  /// Private property that represents reference of CustomerDataAccessLayer
  /// </summary>
  public ICustomerDataAccessLayer CustomersDataAccessLayer
  {
    set => _customerDataAccessLayer = value;
    get => _customerDataAccessLayer;
  }
  #endregion

  #region  Methods
  /// <summary>
  /// Returns all existing customers
  /// </summary>
  /// <returns>all customers</returns>
  public List<Customers> GetCustomers()
  {
    try
    {
      // invoke DAL
      return CustomerBusinessLayer.GetCustomers();
    }
    catch (CustomerException)
    {
      throw;
    }
    catch (Exception)
    {
      throw;
    }
  }

  /// <summary>
  /// Returns a customer that matches the specified criteria
  /// </summary>
  /// <param name="predicate">Lambda expression that contains condition to check</param>
  /// <returns>The list of matching customers</returns>
  public List<Customers> GetCustomersByCondition(Predicate<Customer> predicate)
  {
    try
    {
      // invoke DAL
      return CustomerBusinessLayer.GetCustomersByCondition(predicate);
    }
    catch (CustomerException)
    {
      throw;
    }
    catch (Exception)
    {
      throw;
    }
  }

  /// <summary>
  /// Adds new customer to the existing customer List
  /// </summary>
  /// <param name="customer">The customer object to add</param>
  /// <returns>bool, true if customer added successfully, false otherwise</returns>
  public Guid AddCustomer(Customer customer)
  {
    try
    {
      // get all customers
      List<Customer> allCustomers = CustomersDataAccessLayer.GetCustomers();
      long maxCustomerCode = 0;

      foreach(var item in allCustomers){
        if(item.CustomerCode > maxCustomerCode)
        {
          maxCustomerCode = item.CustomerCode;
        }
      }

      if(allCustomers.Count >= 1)
      {
        customer.CustomerCode = maxCustomerCode + 1;
      }
      else
      {
        customer.CustomerCode = HarshaBank.Configuration.Settings.BaseCustomerNo + 1;
      }

      return CustomerBusinessLayer.AddCustomer(customer);
    }
    catch (CustomerException)
    {
      throw;
    }
    catch (Exception)
    {
      throw;
    }
  }

  /// <summary>
  /// Updates an existing customer
  /// </summary>
  /// <param name="customer">Customer object that contains details to update</param>
  /// <returns>bool, true if customer was updated successfully, false otherwise</returns>
  public bool UpdateCustomer(Customer customer)
  {
    try
    {
      // invoke DAL
      return CustomerBusinessLayer.UpdateCustomer(customer);
    }
    catch (CustomerException)
    {
      throw;
    }
    catch (Exception)
    {
      throw;
    }
  }

  /// <summary>
  /// Delete an existing user
  /// </summary>
  /// <param name="customerID">CustomerID for user to Delete</param>
  /// <returns></returns>
  public bool DeleteCustomer(Guid customerID)
  {
    try
    {
      // invoke DAL
      return CustomerBusinessLayer.DeleteCustomer(customerID);
    }
    catch (CustomerException)
    {
      throw;
    }
    catch (Exception)
    {
      throw;
    }
  }
  #endregion
}
