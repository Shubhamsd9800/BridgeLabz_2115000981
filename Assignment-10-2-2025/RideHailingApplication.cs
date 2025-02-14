using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideHailingApplication
{
    abstract class Vehi
    {
        private string vehicleId;
        private string driverName;
        protected double ratePerKm;
        public Vehi(string vehicleId, string driverName, double
        ratePerKm)
        {
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
        }

        public string VehicleId { get { return vehicleId; } }
        public string DriverName { get { return driverName; } }
        public abstract double CalculateFare(double distance);
        public virtual void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {vehicleId}, Driver: { driverName}, Rate per km: Rs.{ ratePerKm} ");
        }
    }

    interface IGPS
    {
        void GetCurrentLocation();
        void UpdateLocation(string location);
    }

    // Car class
    class Wagon : Vehi, IGPS
    {
        public Wagon(string vehicleId, string driverName, double ratePerKm) :
        base(vehicleId, driverName, ratePerKm)
        { }
        public override double CalculateFare(double distance)
        {
            return ratePerKm * distance;
        }
        public void GetCurrentLocation()
        {
            Console.WriteLine("Fetching current location for Car...");
        }
        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Car location updated to: {location}");
        }
    }

    class Honda : Vehi, IGPS
    {
        public Honda(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }
        public override double CalculateFare(double distance)
        {
            return ratePerKm * distance * 0.9; // Discount for bikes
        }
        public void GetCurrentLocation()
        {
            Console.WriteLine("Fetching current location for Bike...");
        }
        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Bike location updated to: {location}");
        }
    }

    // Auto class
    class Auto : Vehi, IGPS
    {
        public Auto(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }
        public override double CalculateFare(double distance)
        {
            return ratePerKm * distance * 1.1; // Additional charges for
            
        }
        public void GetCurrentLocation()
        {
            Console.WriteLine("Fetching current location for Auto...");
        }
        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Auto location updated to: {location}");
        }
    }
}
