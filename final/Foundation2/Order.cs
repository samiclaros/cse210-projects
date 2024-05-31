using System;
using System.Collections.Generic;
public class Order
{
    private List<Product> _products = new();
    private Customer _customer; // Changes here

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product) // With this, I add the "Products" elements to the list
    {
        _products.Add(product);
    }

    public double TotalPrice() // Changes here
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public void PackagingDetails() // Better would be void type
    {
        Console.WriteLine($"Details of the packaging for {_customer.GetName()}:");
        int counter = 1;
        foreach (Product product in _products)
        {
            Console.WriteLine($"{counter}. {product.GetNameProduct()} (ID: {product.GetIDProduct()}) - Price p/unity: ${product.GetPrice()} - Quantity: {product.GetQuantity()}");
            counter++;
        }
    }

    public void ShippingLabel() // Changes here
    {
        Console.WriteLine($"{_customer.GetName()} - {_customer.GetAdress().GetFullAdress()}");
    }
}