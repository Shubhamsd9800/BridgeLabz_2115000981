
using System;
using System.Collections.Generic;

// Abstract category class
public abstract class ProductCategory { }
public class BookCategory : ProductCategory { }
public class ClothingCategory : ProductCategory { }

// Base class for all products
public abstract class ProductBase
{
    public string Name;
    public double Price;

    protected ProductBase(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();
}

// Generic Product class restricted to specific categories
public class Product<T> : ProductBase where T : ProductCategory
{
    public T Category;

    public Product(string name, double price, T category) : base(name, price)
    {
        Category = category;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}, Category: {Category.GetType().Name}, Price: Rs.{Price}");
    }
}

// Generic method to apply discount
public static class DiscountManager
{
    public static void ApplyDiscount(ProductBase product, double percentage)
    {
        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine($"Discount Applied: {percentage}%, New Price: Rs.{product.Price}");
    }
}





