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
        
    }
}