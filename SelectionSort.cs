using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14_2_2025
{
    public class SelectionSort
    {

        public static void Sort(int[] scores)
        {
            int n = scores.Length;
            for (int i = 0; i <= n - 2; i++)
            {
                int min = i;
                for (int j = i; j <= n - 1; j++)
                {
                    if (scores[j] < scores[min])
                    {
                        min = j;
                    }
                }
                int temp = scores[min];
                scores[min] = scores[i];
                scores[i] = temp;
            }
        }
        public static void Display(int[] scores)
        {
            foreach (int score in scores)
            {
                Console.Write(score + " ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            int[] examScores = { 78, 92, 85, 66, 90, 73, 88 };
            Console.WriteLine("Original Exam Scores:");
            Display(examScores);
            Sort(examScores);
            Console.WriteLine("Sorted Exam Scores (Ascending Order):");
            Display(examScores);
        }
    }
}
