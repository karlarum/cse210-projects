using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Customer
        Address address1 = new Address("374 Cloud Street", "Cloud City", "FL", "USA");
        Customer customer1 = new Customer("Georgia Briggs", address1);

        Address address2 = new Address("342 Sun Street", "Sun City", "QLD", "Australia");
        Customer customer2 = new Customer("Lily Lane", address2);

        //Product
        Product product1 = new Product("Jeans", 3401584, 120, 1);
        Product product2 = new Product("Dress", 3431898, 100, 1);
        Product product3 = new Product("Shoes", 372321, 70, 2);
        Product product4 = new Product("Jewelry", 3712231, 200, 1);

        //Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        Console.WriteLine("Order 1: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.CalculateTotalPrice()}");
        Console.WriteLine();

        //Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        Console.WriteLine("Order 2: ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.CalculateTotalPrice()}");
        Console.WriteLine();

        //Order 3
        Order order3 = new Order(customer1);
        order3.AddProduct(product2);
        order3.AddProduct(product3);
        order3.AddProduct(product4);
        Console.WriteLine("Order 3: ");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total: ${order3.CalculateTotalPrice()}");
        Console.WriteLine();

    }
}