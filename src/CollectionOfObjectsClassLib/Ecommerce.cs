using System;

namespace Ecommerce
{
  /// <summary>
  /// Represents a product in e-commerce application;
  /// </summary>
  public class Product
  {
    // properties
    public int Id{ get; set; }
    public string Name{ get; set; }
    public double Price{ get; set; }
    public DateTime DateOfManufacture{ get; set; }

  }

}
