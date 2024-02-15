using System;

class Program
{
    static void Main(string[] args)
    {
        Order o1 = new Order();
        
        o1.SetCustomer("Thomas Wade", "1234 State St", "Houston", "TX", "United States");
        o1.AddProduct("Candy", "JIKE74378", 4.99, 10);
        o1.AddProduct("Model Rocket", "AKJE8937", 30.21, 2);
        
        Console.WriteLine("Packing: ");
        Console.WriteLine(o1.PackingLabel());

        Console.WriteLine("Shipping: ");
        Console.WriteLine(o1.ShippingLabel());

        Console.WriteLine($"Total: {o1.Cost()}");

        Order o2 = new Order();

        o2.SetCustomer("Tim Smith", "7839 Main Circle", "Paris", "region Parisienne", "France");

        o2.AddProduct("Screwdriver", "LKJB34323", 12.34, 1);
        o2.AddProduct("Saw", "LKJB4759", 18.33, 1);
        
        Console.WriteLine("Packing: ");
        Console.WriteLine(o2.PackingLabel());

        Console.WriteLine("Shipping: ");
        Console.WriteLine(o2.ShippingLabel());

        Console.WriteLine($"Total: {o2.Cost()}");

    }
}