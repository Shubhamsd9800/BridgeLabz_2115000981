using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14_2_2025
{
    class BubbleSort
    {
        public static void Sort(int[] marks)
        {
            int n = marks.Length;
            for (int i = n - 1; i >= 1; i--)
            {
                bool swap = false;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                        swap = true;
                    }
                }
                if (!swap) break;
            }
        }
        public static void Display(int[] marks)
        {
            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            int[] studentMarks = { 85, 72, 90, 60, 88, 76, 95, 80 };
            Console.WriteLine("Original Marks:");
            Display(studentMarks);
            Sort(studentMarks);
            Console.WriteLine("Sorted Marks (Ascending Order):");
            Display(studentMarks);
        }
    }
}
