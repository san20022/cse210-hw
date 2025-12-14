using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "2603 W Everettwood Dr",
            "Taylorsville",
            "UT",
            "84129",
            "USA"
        );

        Customer customer1 = new Customer("Luis S. Rojas", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Product A", "A-123ABC", 10, 1));
        order1.AddProduct(new Product("Product B", "B-456DEF", 15, 2));
        order1.AddProduct(new Product("Product C", "C-789GHI", 20, 3));

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"TOTAL: ${order1.GetTotalCost()}");
        Console.WriteLine();

        Address address2 = new Address(
            "456 B Street",
            "Toronto",
            "Ontario",
            "M4C 1T1",
            "Canada"
        );

        Customer customer2 = new Customer("Canadian Customer", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Product D", "D-012JKL", 25, 1));
        order2.AddProduct(new Product("Product E", "E-345MNO", 35, 2));

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"TOTAL: ${order2.GetTotalCost()}");
    }
}
