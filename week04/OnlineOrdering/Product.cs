using System;

public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string productName, string id, double unitPrice, int qty)
    {
        name = productName;
        productId = id;
        price = unitPrice;
        quantity = qty;
    }

    public double GetTotalPrice()
    {
        return price * quantity;
    }

    public string GetProductInfo()
    {
        return $"{name} (ID: {productId})";
    }
}