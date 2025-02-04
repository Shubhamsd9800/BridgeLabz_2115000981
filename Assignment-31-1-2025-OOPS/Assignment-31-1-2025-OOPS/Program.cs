using System;
using Assignment_31_1_2025_OOPS;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello WOrd");
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Book Author: ");
        string author = Console.ReadLine();

        Console.Write("Enter Book Price: ");
        double price = double.Parse(Console.ReadLine());

        Book book = new Book(title, author, price);
        book.DisplayDetails();
    }
}
