using System;
using HarshaBank.Entities;
using HarshaBank.Exceptions;
using System.Collections.Generic;
using HarshaBank.DataAccessLayer.DALContracts;

namespace HarshaBank.DataAccessLayer
{
  /// <summary>
  /// Represents DAL for bank customers
  /// </summary>
  public class CustomersDataAccessLayer:ICustomersDataAccessLayer
  {
    #region Fields
    private static List<Customer> _customers;
    #endregion

    #region Constructors
    static CustomersDataAccessLayer()
    {
      _customers = new List<Customer>();
    }
    #endregion

    #region Properties
    /// <summary>
    /// Represents source customers collection
    /// </summary>
    private static List<Customer> Customers
    {
      set => _customers = value;
      get => _customers;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Returns all existing customers
    /// </summary>
    /// <returns>Customers Lis</returns>
    public List<Customer> GetCustomers()
    {
      try
      {
        // create new customers list
        List<Customer> customersList = new List<Customer>();

        // copy all customers from the source collection into newCustomers list
        Customers.ForEach(item => customersList.Add(item.Clone() as Customer));

        return customersList;
      }
      catch(CustomerException)
      {
        throw;
      }
      catch (Exception)
      {
        throw;
      }
    }

    /// <summary>
    /// Returns list of customers that are matching with specific criteria.
    /// </summary>
    /// <param name="predicate">Lambda expression with condition</param>
    /// <returns>List of matching customers</returns>
    public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
    {
      try
      {
        List<Customer> customerList = new List<Customer>();
        List<Customer> filteredCustomer = Customers.FindAll(predicate);
        filteredCustomer.ForEach(item => customerList.Add(item.Clone() as Customer));
        return customerList;
      }
      catch(CustomerException)
      {
        throw;
      }
      catch (Exception)
      {
        throw;
      }
    }

    /// <summary>
    /// Add new customer to the existing list
    /// </summary>
    /// <param name="customer">Customer object to add</param>
    /// <returns>Guid of newly created customer</returns>
    public Guid AddCustomer(Customer customer)
    {
      try
      {
        // generate new guid
        customer.CustomerId = Guid.NewGuid();

        //add customer
        Customers.Add(customer);

        return customer.CustomerId;
      }
      catch(CustomerException)
      {
        throw;
      }
      catch (Exception)
      {
        throw;
      }
    }

    /// <summary>
    /// Update customer
    /// </summary>
    /// <param name="customer">Customer object with updated details</param>
    /// <returns>Determines whether the customer is updated or not</returns>
    public bool UpdateCustomer(Customer customer)
    {
      try
      {
        Customer existingCustomer = Customers.Find(item => item.CustomerId == customer.CustomerId);

        if(existingCustomer != null)
        {
          existingCustomer.CustomerCode = customer.CustomerCode;
          existingCustomer.CustomerName = customer.CustomerName;
          existingCustomer.Address = customer.Address;
          existingCustomer.Landmark = customer.Landmark;
          existingCustomer.City = customer.City;
          existingCustomer.Country = customer.Country;
          existingCustomer.Mobile = customer.Mobile;

          return true;
        }
        return false;
      }
      catch(CustomerException)
      {
        throw;
      }
      catch (Exception)
      {
        throw;
      }
    }

    /// <summary>
    /// Deletes an existing customer
    /// </summary>
    /// <param name="customerId">CustomerId to delete</param>
    /// <returns></returns>
    public bool DeleteCustomer(Guid customerId)
    {
      try
      {
        if(Customers.RemoveAll(item => item.CustomerId == customerId) > 0)
        {
          return true;
        }
        return false;
      }
      catch(CustomerException)
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
};

