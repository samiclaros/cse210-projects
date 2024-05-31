using System;
using System.Collections.Generic;
public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }

    public string GetNameProduct()
    {
        return _name;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetPrice()
    {
        return _price;
    }


    public string GetIDProduct()
    {
        return _id;
    }
}