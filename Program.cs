using System;
using GenericsPractice;


class Program
{
    public static void Main(string[] args)
    {
        //Storage<int> intStorage = new Storage<int>();
        //intStorage.AddItem(10);
        //intStorage.AddItem(20);
        //intStorage.DisplayItems();
        //intStorage.RemoveItem(10);
        //intStorage.DisplayItems();
        //intStorage.CompareItems(10, 10); // Same type
        //intStorage.CompareItems("Hello", "World"); // Different type

        //Console.WriteLine();

        //// Storage for strings
        //Storage<string> stringStorage = new Storage<string>();
        //stringStorage.AddItem("Apple");
        //stringStorage.AddItem("Banana");
        //stringStorage.DisplayItems();
        //stringStorage.RemoveItem("Banana");
        //stringStorage.DisplayItems();

        //Console.WriteLine();

        //// Using the generic method
        //Utility.PrintDetails(100);        // Integer
        //Utility.PrintDetails("Hello");    // String
        //Utility.PrintDetails(99.99);      // Double

        Console.WriteLine("Project For Employee struct generics");


        EmployeeStorage<Manager> managerStorage = new EmployeeStorage<Manager>();
        managerStorage.AddEmployee(new Manager("Alice"));
        managerStorage.AddEmployee(new Manager("Bob"));
        managerStorage.DisplayEmployees();

        Console.WriteLine();

        EmployeeStorage<Developer> devStorage = new EmployeeStorage<Developer>();
        devStorage.AddEmployee(new Developer("Charlie"));
        devStorage.AddEmployee(new Developer("David"));
        devStorage.DisplayEmployees();
    }
}