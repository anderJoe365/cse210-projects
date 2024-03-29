using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }

    public string LabelAddress()
    {
        return _address.GetAddress();
    }

    public bool USCustomer()
    {
        return _address.USCitizen();
    }

    public string GetName()
    {
        return _name;
    }

    

}