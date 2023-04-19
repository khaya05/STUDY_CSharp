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
    private List<Customer> _customers;
    #endregion

    #region Constructors
    public CustomersDataAccessLayer()
    {
      _customers = new List<Customer>();
    }
    #endregion

    #region Properties
    /// <summary>
    /// Represents source customers collection
    /// </summary>
    private List<Customer> Customers
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
      // create new customers list
      List<Customer> customersList = new List<Customer>();

      // copy all customers from the source collection into newCustomers list
      Customers.ForEach(item => customersList.Add(item.Clone() as Customer));

      return customersList;
    }
    #endregion
  }
};

