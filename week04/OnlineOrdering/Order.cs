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
        double total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalPrice();
        }

        if (customer.LivesInUSA())
        {
            total += 5;
        }

        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPakingLable()
    {
        string labal = "";
        foreach (var product in Products)
        {
            labal += product.GetProductInfo() + "\n";
        }

        return labal;
    }

    public string GetShippingLabale()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}