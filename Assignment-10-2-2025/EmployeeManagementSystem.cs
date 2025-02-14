using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    abstract class Employee
    {
        private int employeeId;
        private string name;
        private double baseSalary;

        public Employee(int id, string name, double salary)
        {
            this.employeeId = id;
            this.name = name;
            this.baseSalary = salary;
        }

        public int EmployeeId { get { return employeeId; } }
        public string Name { get { return name; } }
        public double BaseSalary { get { return baseSalary; } }


        public abstract double CalculateSalary();
        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {employeeId}, Name: {name}, Salary Rs.{CalculateSalary()}");
        }
    }

    interface IDepartment
    {
        void AssignDepartment(string department);
        string GetDepartmentDetails();
    }

    class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        public FullTimeEmployee(int id, string name, double salary) : base(id,name,salary){}
        public override double CalculateSalary()
        {
            return BaseSalary;
        }

        public void AssignDepartment(string dept)
        {
            department = dept;
        }


        public string GetDepartmentDetails()
        {
            return $"Department: {department}";
        }

    }

    class PartTimeEmployee: Employee, IDepartment
    {
        private int workHours;
        private double hourlyRate;
        private string department;
        public PartTimeEmployee(int id, string name, double hourlyRate,int hours): base(id, name, 0)
        {
            this.workHours = hours;
            this.hourlyRate = hourlyRate;
        }
        public override double CalculateSalary()
        {
            return workHours * hourlyRate; // Salary based on hours worked
        }
        public void AssignDepartment(string dept)
        {
            department = dept;
        }

        public string GetDepartmentDetails()
        {
            return $"Department: {department}";
        }
    }
}
