using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Adress adress = new("Av. Blanco Galindo", "Cochabamba", "Cercado", "Bolivia");
        Customer customer = new("Samuel Claros", adress);
        Order order = new(customer);
        Product product = new("Potato", "2343", 4, 2); 
        Product product1 = new("Ketchup", "3456", 5, 1);
        Product product2 = new("Bread", "4577", 5, 3);
        
        Console.WriteLine("If you live in USA, shipping cost will be 5$");
        Console.WriteLine("If you live outside USA, shipping will cost 35$");
        Console.WriteLine(""); // BLANK

        order.AddProduct(product);
        order.AddProduct(product1);
        order.AddProduct(product2);

        order.ShippingLabel();
        Console.WriteLine(""); // BLANK
        order.PackagingDetails();
        Console.WriteLine(" "); // BLANK
        Console.WriteLine($"Total price: {order.TotalPrice()}$");
        Console.WriteLine(" "); // BLANK

        // 2nd order
        Adress adress1 = new("Nephi #345", "Utah", "Utah", "United States");
        Customer customer1 = new("Edgar Ocampo", adress1);
        Order order1 = new(customer1);
        Product product2_1 = new("Paper", "9742", 4, 2); 
        Product product2_2 = new("Cheese", "6969", 3, 3);
        Product product2_3 = new("Milk", "8521", 6, 5);

        Console.WriteLine("If you live in USA, shipping cost will be 5$");
        Console.WriteLine("If you live outside USA, shipping will cost 35$");
        Console.WriteLine(""); // BLANK

        order1.AddProduct(product2_1);
        order1.AddProduct(product2_2);
        order1.AddProduct(product2_3);

        order1.ShippingLabel();
        Console.WriteLine(""); // BLANK
        order1.PackagingDetails();
        Console.WriteLine(" "); // BLANK
        Console.WriteLine($"Total price: {order1.TotalPrice()}$");
        Console.WriteLine(" "); // BLANK
    }
}