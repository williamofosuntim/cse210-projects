using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA Customer
        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Kojo Mensah", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP-001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MOU-002", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "KEY-003", 45.00, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        // Order 2 - Ghana Customer (International)
        Address address2 = new Address("Oxford Street", "Takoradi", "Western Region", "Ghana");
        Customer customer2 = new Customer("Abena Owusu", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "PHN-101", 499.99, 1));
        order2.AddProduct(new Product("Charger", "CHG-102", 19.99, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}