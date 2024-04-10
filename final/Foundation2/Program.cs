using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "City1", "State1", "USA");
        Address address2 = new Address("456 Elm St", "City2", "State2", "Canada");

        Customer customer1 = new Customer("Customer 1", address1);
        Customer customer2 = new Customer("Customer 2", address2);

        Product product1 = new Product("Product 1", 1, 10.99, 2);
        Product product2 = new Product("Product 2", 2, 5.49, 3);
        Product product3 = new Product("Product 3", 3, 7.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.CalculateTotalCost():C}");

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.CalculateTotalCost():C}");
    }
}
