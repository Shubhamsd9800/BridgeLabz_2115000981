using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public class EmployeeStorage<T> where T: IEmployee
    {

        public List<T> employees = new List<T>();

        public void AddEmployee(T employee)
        {
            employees.Add(employee);
            Console.WriteLine($"Employee added: {employee.GetDetails()}");
        }
        public void DisplayEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.GetDetails());
            }
        }
    }
}
