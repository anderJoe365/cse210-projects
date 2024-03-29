using System;
using System.Security.Cryptography.X509Certificates;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    
    public Address(string street, string city, string state, string country)
    {

        _street = street;
        _city = city;
        _state = state;
        _country = country;

    }

    public bool USCitizen()
    {
        if (_country == "United States")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public string GetAddress()
    {
        
        return $"{_street} \n {_city}, {_state} {_country}";
    }
}