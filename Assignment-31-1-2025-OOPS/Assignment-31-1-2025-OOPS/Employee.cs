using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_31_1_2025_OOPS
{
    public class Employee
    {
        private string name;
        private int id;
        private double salary;

        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    Console.WriteLine("Salary must be positive.");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"ID: {this.Id}");
            Console.WriteLine($"Salary: {this.Salary}");
        }

        static void Main()
        {
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Employee emp = new Employee(name, id, salary);

            emp.Name = "Updated Name";

            emp.DisplayDetails();
        }
    }
}
