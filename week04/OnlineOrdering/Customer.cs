using System;

public class Customer
{
    private string name;
    private Address address;

    public Customer(string customerName, Address customerAddress)
    {
        name = customerName;
        address = customerAddress;
    }

    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}