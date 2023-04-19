using System;
using HarshaBank.Entities.Contracts;
using HarshaBank.Exceptions;

namespace HarshaBank.Entities
{
  /// <summary>
  /// Represents customer of a bank
  /// </summary>
  public class Customer:ICustomer, ICloneable
  {
    #region Private Fields
    private Guid _customerId;
    private long _customerCode;
    private string _customerName;
    private string _address;
    private string _landmark;
    private string _city;
    private string _country;
    private string _mobile;
    #endregion

    #region Public Properties
    /// <summary>
    /// Guid for unique Customer Id
    /// </summary>
    public Guid CustomerId { get => _customerId; set => _customerId = value; }

    /// <summary>
    /// Auto-generated code number of the customer
    /// </summary>
    public long CustomerCode 
    { 
      get => _customerCode;
      set
      {
        //customer code should be positive
        if(value > 0)
        {
          _customerCode = value;
        }
        else
        {
          throw new CustomerException("Customer code should be positive only.");
        }
      }
    }

    /// <summary>
    /// Name of the customer
    /// </summary>
    public string CustomerName 
    { 
      get => _customerName;
      set
      {
        //customer name should be less than 40 characters
        if(value.Length < 40 && !string.IsNullOrEmpty(value))
        {
          _customerName = value;
        }
        else
        {
          throw new CustomerException("Customer name should not be null and be less than 40 characters.");
        }
      }
    }

    /// <summary>
    /// Address of customer
    /// </summary>
    public string Address { get => _address; set => _address = value; }

    /// <summary>
    /// Landmark of customer id
    /// </summary>
    public string Landmark { get => _landmark; set => _landmark = value; }

    /// <summary>
    /// City of customer
    /// </summary>
    public string City { get => _city; set => _city = value; }

    /// <summary>
    /// Country of customer
    /// </summary>
    public string Country { get => _country; set => _country = value; }

    /// <summary>
    /// 10-digit Mobile number of customer
    /// </summary>
    public string Mobile 
    { 
      get => _mobile;
      set
      {
        if(value.Length == 10)
        {
          _mobile = value;
        }
        else
        {
          throw new CustomerException("Mobile Number should be a 10-digit number");
        }
      }
    }
    #endregion

    #region Methods
    public object Clone()
    {
      return new Customer()
      {
        CustomerId = this.CustomerId,
        CustomerCode = this.CustomerCode,
        CustomerName = this.CustomerName,
        Address = this.Address,
        Landmark = this.Landmark,
        City = this.City,
        Country = this.Country,
        Mobile = this.Mobile
      };
    }
    #endregion
  }
}