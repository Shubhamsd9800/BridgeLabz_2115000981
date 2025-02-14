using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodDeliverySystem
{
    abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;
        public FoodItem(string itemName, double price, int quantity)
        {
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
        }
        public string ItemName { get { return itemName; } }
        public double Price { get { return price; } }
        public int Quantity { get { return quantity; } }
        public abstract double CalculateTotalPrice();

        public virtual void GetItemDetails()
        {
            Console.WriteLine($"Item: {itemName}, Price: Rs.{price},  Quantity: { quantity} ");
        }
    }

    interface IDiscountable
    {
        void ApplyDiscount(double percentage);
        double GetDiscountDetails();
    }
    class VegItem : FoodItem, IDiscountable
    {
        private double discount;
        public VegItem(string itemName, double price, int quantity) :
        base(itemName, price, quantity)
        { }
        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) - discount;
        }
        public void ApplyDiscount(double percentage)
        {
            discount = (Price * Quantity) * (percentage / 100);
        }
        public double GetDiscountDetails()
        {
            return discount;
        }
    }

    // NonVegItem class
    class NonVegItem : FoodItem, IDiscountable
    {
        private double additionalCharge = 5.0;
        private double discount;
        public NonVegItem(string itemName, double price, int quantity) :
        base(itemName, price, quantity)
        { }
        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + additionalCharge - discount;
        }
        public void ApplyDiscount(double percentage)
        {
            discount = (Price * Quantity) * (percentage / 100);
        }
        public double GetDiscountDetails()
        {
            return discount;
        }
    }
}
