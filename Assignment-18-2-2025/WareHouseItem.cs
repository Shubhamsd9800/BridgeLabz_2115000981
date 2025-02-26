
using System;
using System.Collections.Generic;

// Abstract class representing a warehouse item
public abstract class WarehouseItem
{
    public string Name;
    public double Price;

    protected WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();
}

// Electronics category
public class Electronics : WarehouseItem
{
    public string Brand;

    public Electronics(string name, double price, string brand) : base(name, price)
    {
        Brand = brand;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Electronics: {Name}, Brand: {Brand}, Price: Rs.{Price}");
    }
}

// Groceries category
public class Groceries : WarehouseItem
{
    public DateTime ExpiryDate;

    public Groceries(string name, double price, DateTime expiryDate) : base(name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Groceries: {Name}, Expiry Date: {ExpiryDate.ToShortDateString()}, Price: Rs.{Price}");
    }
}

// Furniture category
public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, double price, string material) : base(name, price)
    {
        Material = material;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Furniture: {Name}, Material: {Material}, Price: Rs.{Price}");
    }
}

// Generic storage class with constraints
public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        foreach (var item in items)
        {
            item.DisplayInfo();
        }
    }
}




