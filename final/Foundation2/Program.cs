using System;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.Clear();
        Console.CursorVisible = false;
        Product product1 = new Product("productA", "A-123ABC", 10);
        Product product2 = new Product("productB", "B-456DEF", 15);
        Product product3 = new Product("productC", "C-456DEF", 20);
        Product product4 = new Product("productD", "D-012JKL", 25);
        Product product5 = new Product("productE", "E-345MNO", 35);
        Product product6 = new Product("productF", "F-678PQR", 50);
        Product product7 = new Product("productG", "G-901STU", 75);
        Product product8 = new Product("productH", "H-234VXY", 85);
        Product product9 = new Product("productI", "I-567ZAB", 100);
        Order orderA = new Order();
        orderA.CustomerSetup("Luis S. Rojas","2603 W Evereetwood Dr", "Taylorsville", "UT" "84129", "USA");
        orderA.SetProductList(product1, 1);
        orderA.SetProductList(product2, 2);
        orderA.SetProductList(product3, 3);
        Console.Write("Shipping Label:\n");
        Console.Write($"{orderA.GetShippingLabel()}\n\n");
        Console.Write("Packing Label:\n");
        Console.Write($"{orderA.GetPackingLabel()}\n");
        Console.Write($"Your total price is ${orderA.GetTotalCost()}.\n\n");
        Console.Write("*Total price includes shipping.\n");
        Console.Write("**USA shipping is $5.00, and  outside USA is $35.00.\n\n");
        Console.Write("<Press Any Keys>");
        Console.ReadKey();
        Console.Clear();
        Order orderB = new Order();
        orderB.CustomerSetup("Some Canadian's Name", "456 B Street", "Toronto", "Ontario", "M4C 1T1", "Canada");
        orderB.SetProductList(product1, 1);
        orderB.SetProductList(product2, 2);
        orderB.SetProductList(product3, 3);
        Console.Write("Shipping Label:\n");
        Console.Write($"{orderB.GetShippingLabel()}\n\n");
        Console.Write("Packing Label:\n");
        Console.Write($"{orderB.GetPackingLabel()}\n");
        Console.Write($"Your total price is ${orderB.GetTotalCost()}.\n\n");
        Console.Write("*Total price includes shipping.\n");
        Console.Write("**USA shipping is $5.00, and outside USA is $35.00.\n\n");
        Console.Write("<Press Any Key>");
        Console.ReadKey();
        Console.Clear();
        Order orderC = new Order();
        orderC.CustomerSetup("Another Canadian's Name","789 C Street", "Toronto", "Ontario", "M4C 1T3", "Canada");
        orderC.SetProductList(product1, 4);
        orderC.SetProductList(product3, 1);
        orderC.SetProductList(product5, 3);
        orderC.SetProductList(product7, 1);
        orderC.SetProductList(product9, 2);
        orderC.SetProductList(product2, 1);
        Console.Write("Shipping Label:\n");
        Console.Write($"{orderC.GetShippingLabel()}\n\n");
        Console.Write("Packing Label:\n");
        Console.Write($"{orderC.GetPackingLabel()}\n");
        Console.Write($"Your total price is ${orderC.GetTotalCost()}.\n\n");
        Console.Write("*Total price includes shipping.\n");
        Console.Write("**USA shipping is $5.00, and outside USA is $35.00.\n\n");
        Console.Write("Press Any Key");
        Console.ReadKey();
        Console.Clear();
    }
}