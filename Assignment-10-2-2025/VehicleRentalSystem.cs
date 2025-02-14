using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;
        public Vehicle(string number, string type, double rate)
        {
            this.vehicleNumber = number;
            this.type = type;
            this.rentalRate = rate;
        }
        public string VehicleNumber { get { return vehicleNumber; } }
        public string Type { get { return type; } }
        public double RentalRate { get { return rentalRate; } }
        public abstract double CalculateRentalCost(int days);
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Vehicle Number: {vehicleNumber}, Type:{ type}, Rental Rate: Rs.{ rentalRate} ");
        }

    }
    interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

    class Car : Vehicle, IInsurable
    {
        public Car(string number, double rate) : base(number, "Car", rate)
        { }
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }
        public double CalculateInsurance()
        {
            return RentalRate * 0.1; // 10% insurance
        }
        public string GetInsuranceDetails()
        {
            return "Insurance: 10% of rental rate";
        }
    }

    // Bike class
    class Bike : Vehicle
    {
        public Bike(string number, double rate) : base(number, "Bike",
        rate)
        { }
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days * 0.9; // 10% discount
        }
    }

    // Truck class
    class Truck : Vehicle, IInsurable
    {
        public Truck(string number, double rate) : base(number, "Truck",
        rate)
        { }
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days * 1.2; // 20% surcharge
        }
        public double CalculateInsurance()
        {
            return RentalRate * 0.2; // 20% insurance
        }
        public string GetInsuranceDetails()
        {
            return "Insurance: 20% of rental rate";
        }
    }
}
