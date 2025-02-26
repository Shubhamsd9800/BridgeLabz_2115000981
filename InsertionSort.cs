using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14_2_2025
{
    public class InsertionSort
    {

        public static void Sort(int[] employeeIDs)
        {
            int n = employeeIDs.Length;
            for (int i = 0; i < n; i++)
            {
                int j = i;
                while (j > 0 && employeeIDs[j - 1] > employeeIDs[j])
                {
                    int temp = employeeIDs[j];
                    employeeIDs[j] = employeeIDs[j - 1];
                    employeeIDs[j - 1] = temp;
                    j--;
                }
            }
        }

        public static void Display(int[] employeeIDs)
        {
            foreach (int id in employeeIDs)
            {
                Console.Write(id + " ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            int[] employeeIDs = { 1023, 1001, 1054, 1010, 1032, 1005 };

            Console.WriteLine("Original Employee IDs:");
            Display(employeeIDs);
            Sort(employeeIDs);

            Console.WriteLine("Sorted Employee IDs (Ascending Order):");
            Display(employeeIDs);
        }
    }
}
