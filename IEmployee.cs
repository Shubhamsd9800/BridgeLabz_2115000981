using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public interface IEmployee
    {
        string GetDetails();
    }
    public class Manager: IEmployee
    {
        public string Name { get; set; }
        public Manager(string name) => Name = name;
        public string GetDetails() => $"Manager: {Name}";
    }

    public class Developer : IEmployee { 
        public string Name { get; set; }
        public Developer(string name) => Name = name;
        public string GetDetails() => $"Developer: {Name}";
    }

}
