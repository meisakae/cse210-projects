using System;
using System.Numerics;

public class Order
{
    private List<Product> Products = new List<Product>();
    private Customer customer;
    public Order(Customer orderCustomer)
    {
        customer = orderCustomer;
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double GetTotalPrice()
    {
        Total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }

        if (customer.LivesInUSA())
        {
            
        }
    }
}