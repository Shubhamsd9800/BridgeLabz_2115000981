using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    class Storage<T> {

        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"Added: {item}");

        }
        public bool RemoveItem(T item) {
            if (items.Contains(item)) {
                items.Remove(item);
                Console.WriteLine($"Removed: {item}");
                return true;
            }
            Console.WriteLine($"Item Not Found: {item}");
            return false;        
        
        }
    
        public List<T> GetAllItems()
        {
            return new List<T>(items);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Stored Items:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void CompareItems<U> (U item1, U item2)
        {
            if (item1.Equals(item2))
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }

    class Utility
    {
        public static void PrintDetails<T>(T data)
        {
            Console.WriteLine($"Details: {data}");
        }
    }

}
