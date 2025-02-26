using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14_2_2025
{
    public class MergeSort
    {

        public static void Merge(int[] prices, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];
            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = prices[l + i];
            }
            for (int j = 0; j < n2; j++)
                rightArray[j] = prices[m + 1 + j];

            int iIndex = 0, jIndex = 0, k = l;
            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    prices[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    prices[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
            {
                prices[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }
            while (jIndex < n2)
            {
                prices[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }

        }
        public static void Sort(int[] prices, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sort(prices, left, middle);
                Sort(prices, middle + 1, right);
                Merge(prices, left, middle, right);
            }
        }
        public static void Display(int[] prices)
        {
            foreach (int price in prices)
            {
                Console.Write(price + " ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            int[] bookPrices = { 450, 120, 999, 320, 250, 680, 150 };
            Console.WriteLine("Original Book");
            Display(bookPrices);
            Console.WriteLine("Sorted Prices of Books");
            Sort(bookPrices, 0, bookPrices.Length - 1);
            Display(bookPrices);
        }
    }
}
