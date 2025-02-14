using System;
using BankingSystem;
using ECommercePlatform;
using EmployeeManagementSystem;
using HospitalPatientManagement;
using LibraryManagementSystem;
using OnlineFoodDeliverySystem;
using RideHailingApplication;
using VehicleRentalSystem;


class Program
{
    public static void Main(string[] args)
    {
        // QUESTION NO-1
        //List<Employee> employees = new List<Employee>();
        //FullTimeEmployee emp1 = new FullTimeEmployee(1, "Somesh",
        //5000);
        //emp1.AssignDepartment("Developer");
        //PartTimeEmployee emp2 = new PartTimeEmployee(2, "Shubham", 20,
        //100);
        //emp2.AssignDepartment("IT");
        //employees.Add(emp1);
        //employees.Add(emp2);

        //foreach(Employee emp in employees)
        //{
        //    emp.DisplayDetails();
        //    if(emp is IDepartment deptEmp)
        //    {
        //        Console.WriteLine(deptEmp.GetDepartmentDetails());
        //    }
        //    Console.WriteLine();
        //}



        // QUESTION NO-2
        //List<Product> products = new List<Product>
        //{
        //new Electronics(1, "Laptop", 100000),
        //new Clothing(2, "T-Shirt", 500),
        //new Groceries(3, "Apple", 200)
        //};

        //foreach (var product in products) {
        //    product.DisplayDetails();
        //    double discount = product.CalculateDiscount();
        //    double tax = (product is ITaxable taxable) ?
        //    taxable.CalculateTax() : 0;
        //    double finalPrice = product.Price + tax - discount;
        //    Console.WriteLine($"Final Price: Rs. {finalPrice}");

        //    if (product is ITaxable taxDetails)
        //    {
        //        Console.WriteLine(taxDetails.GetTaxDetails());
        //    }
        //    Console.WriteLine();
        //}


        // QUESTION NO-3
        //List<Vehicle> vehicles = new List<Vehicle>
        //{
        //new Car("C123", 100),
        //new Bike("B456", 50),
        //new Truck("T789", 200)
        //};

        //int rentalDays = 5;
        //foreach (var vehicle in vehicles)
        //{
        //    vehicle.DisplayDetails();
        //    double rentalCost =
        //    vehicle.CalculateRentalCost(rentalDays);
        //    double insurance = (vehicle is IInsurable insurable) ?
        //    insurable.CalculateInsurance() : 0;
        //    double finalCost = rentalCost + insurance;
        //    Console.WriteLine($"Rental Cost for {rentalDays} days:  Rs.{ rentalCost} ");
        //    Console.WriteLine($"Final Cost (including insurance):Rs.{ finalCost}");
        //if (vehicle is IInsurable insDetails)
        //    {
        //        Console.WriteLine(insDetails.GetInsuranceDetails());
        //    }
        //    Console.WriteLine();
        //}


        // QUESTIONN NO-4
        //List<BankAccount> accounts = new List<BankAccount>
        //{
        //new SavingsAccount("S123", "Somesh", 5000),
        //new CurrentAccount("C456", "Shubham", 10000)
        //};

        //foreach (var account in accounts)
        //{
        //    account.DisplayDetails();
        //    double interest = account.CalculateInterest();
        //    Console.WriteLine($"Calculated Interest: Rs.{interest}");
        //    if (account is ILoanable loanable)
        //    {
        //        Console.WriteLine($"Loan Eligibility Rs.{ loanable.CalculateLoanEligibility()}");
        //    loanable.ApplyForLoan(2000);
        //    }
        //    Console.WriteLine();
        //}



        // QUESTIONN NO-5
        //List<LibraryItem> libraryItems = new List<LibraryItem>
        //{
        //new Book("B001", "C# Programming", "XYX"),
        //new Magazine("M002", "Technologies", "ABC"),
        //new DVD("D003", "C# Tutorial", "C# Corner")
        //};


        //foreach (var item in libraryItems)
        //{
        //    item.GetItemDetails();
        //    Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");
        //    if (item is IReservable reservable)
        //    {
        //        reservable.ReserveItem();
        //        Console.WriteLine($"Availability:{ (reservable.CheckAvailability() ? "Available" : "Not Available")}");
        //    }
        //    Console.WriteLine();
        //}


        // QUESTIONN NO-6
        //List<FoodItem> foodItems = new List<FoodItem>
        //{
        //new VegItem("Paneer Tikka", 100.5, 2),
        //new NonVegItem("Chicken Biryani", 150.0, 1)
        //};
        //foreach (var item in foodItems)
        //{
        //    item.GetItemDetails();
        //    Console.WriteLine($"Total Price before discount: Rs.{ item.CalculateTotalPrice()}");
        //if (item is IDiscountable discountable)
        //    {
        //        discountable.ApplyDiscount(10);
        //        Console.WriteLine($"Discount Applied: Rs.{ discountable.GetDiscountDetails()}");
        //Console.WriteLine($"Final Price:  Rs.{ item.CalculateTotalPrice()} ");
        //}
        //    Console.WriteLine();
        //}


        // QUESTION NO-7
        //List<Patient> patients = new List<Patient>
        //{
        //new InPatient("P001", "ABC", 45, "Pneumonia", "No history",
        //500, 5),
        //new OutPatient("P002", "XYZ", 30, "Flu", "No history", 100)
        //};

        //foreach (var patient in patients)
        //{
        //    patient.GetPatientDetails();
        //    Console.WriteLine($"Total Bill: Rs.{ patient.CalculateBill()}");
        //if (patient is IMedicalRecord recordable)
        //    {
        //        recordable.AddRecord("Initial Diagnosis: Stable condition");
        //        recordable.ViewRecords();
        //    }
        //    Console.WriteLine();
        //}


        // QUESTION NO-8

        List<Vehi> vehicles = new List<Vehi>
        {
        new Wagon("V001", "Shubham Das", 10),
        new Honda("V002", "Shubham Singh", 5),
        new Auto("V003", "Somesh Purwar", 7)
        };
        double distance = 15.0; // Example distance
        foreach (var vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine($"Fare for {distance} km:  Rs.{ vehicle.CalculateFare(distance)} ");
        if (vehicle is IGPS gpsEnabled)
            {
                gpsEnabled.GetCurrentLocation();
                gpsEnabled.UpdateLocation("Downtown");
            }
            Console.WriteLine();
        }
    }
}
