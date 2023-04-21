using System;
using HarshaBank.Entities;
using System.Collections.Generic;

namespace HarshaBank.DataAccessLayer.DALContracts
{
  /// <summary>
  /// Interface that represents customers data access layer
  /// </summary>
  public interface ICustomersDataAccessLayer
  {
    /// <summary>
    /// Returns all existing customers
    /// </summary>
    /// <returns>all customers</returns>
    List<Customer> GetCustomers();

    /// <summary>
    /// Returns a customer that matches the specified criteria
    /// </summary>
    /// <param name="predicate">Lambda expression that contains condition to check</param>
    /// <returns>The list of matching customers</returns>
    List<Customer> GetCustomersByCondition(Predicate<Customer> predicate);

    /// <summary>
    /// Adds new customer to the existing customer List
    /// </summary>
    /// <param name="customer">The customer object to add</param>
    /// <returns>bool, true if customer added successfully, false otherwise</returns>
    Guid AddCustomer(Customer customer);

    /// <summary>
    /// Updates an existing customer
    /// </summary>
    /// <param name="customer">Customer object that contains details to update</param>
    /// <returns>bool, true if customer was updated successfully, false otherwise</returns>
    bool UpdateCustomer(Customer customer);

    /// <summary>
    /// Delete an existing user
    /// </summary>
    /// <param name="customerID">CustomerID for user to Delete</param>
    /// <returns></returns>
    bool DeleteCustomer(Guid customerID);
  }
}