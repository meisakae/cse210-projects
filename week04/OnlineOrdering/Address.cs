using System;
using System.Diagnostics.Contracts;

public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string streetName, string cityName, string stateName, string countryName)
    {
        street = streetName;
        city = cityName;
        state = stateName;
        country = countryName;
    }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}