using System;

public class Product
{
    private string _productName;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string productName, string id, double price, int quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double ProductPrice()
    {
        return _price * _quantity;
    }

    public string NameAndId()
    {
        return $"{_quantity}: {_productName}, ID: {_id}";
    }
}