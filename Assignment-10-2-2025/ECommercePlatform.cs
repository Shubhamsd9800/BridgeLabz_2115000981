using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePlatform
{
    abstract class Product
    {
        private int productId;
        private string name;
        private double price;
        public Product(int id, string name, double price)
        {
            this.productId = id;
            this.name = name;
            this.price = price;
        }

        public int ProductId { get { return productId; } }
        public string Name { get { return name; } }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public abstract double CalculateDiscount();
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {productId}, Name: {name}, Price: Rs { price} ");
        }
    }
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }

    class Electronics : Product, ITaxable {
        public Electronics(int id, string name, double price) : base(id,
name, price)
        { }
        public override double CalculateDiscount()
        {
            return Price * 0.1; // 10% discount
        }
        public double CalculateTax()
        {
            return Price * 0.15; // 15% tax
        }
        public string GetTaxDetails()
        {
            return "Tax: 15%";
        }

    }

    class Clothing: Product, ITaxable
    {
        public Clothing(int id, string name, double price) : base(id, name,
price)
        { }
        public override double CalculateDiscount()
        {
            return Price * 0.2; // 20% discount
        }
        public double CalculateTax()
        {
            return Price * 0.05; // 5% tax
        }
        public string GetTaxDetails()
        {
            return "Tax: 5%";
        }
    }

     class Groceries: Product
    {
        public Groceries(int id, string name, double price) : base(id,
name, price)
        { }
        public override double CalculateDiscount()
        {
            return Price * 0.05; // 5% discount
        }

    }

}
