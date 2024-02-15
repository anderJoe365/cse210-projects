using System;
using System.Reflection.Emit;

public class Order
{
    private List<Product> _product;
    private double _shipping;
    private Customer _customer;
    private double _total;
    private string _label;

    public Order()
    {
        _product = new List<Product>();
    }

    public void SetCustomer(string name, string street, string city, string state, string country)
    {
        _customer = new Customer(name, street, city, state, country);
    }

    public double Cost()
    {
        foreach (Product product in _product)
        {
            _total = _total + product.ProductPrice();
        }

        _total = _total + ShippingCost();

        return Math.Round(_total,2);
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetName()} \n {_customer.LabelAddress()}";
    }

    public string PackingLabel()
    {
        _label = "";

        foreach (Product product in _product)
        {
            _label = _label + product.NameAndId();
        }

        return _label;
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _product.Add(product);
    }
    public double ShippingCost()
    {
        if (_customer.USCustomer())
        {
            _shipping = 5.00;
        }
        else
        {
            _shipping = 35.00;
        }

        return _shipping;
    }
}