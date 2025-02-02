using System;

public class Fibonacci
{
	public static void print()
	{
		Console.Write("Enter the number of terms for the Fibonacci sequence: ");
		int terms = Convert.ToInt32(Console.ReadLine());
		PrintFibonacci(terms);
	}
	static void PrintFibonacci(int terms)
	{
		int first = 0, second = 1, next;
		for (int i = 1; i <= terms; i++)
        {
            if (i == 1)
            {
                Console.Write(first + " ");
                continue;
            }
            if (i == 2)
            {
                Console.Write(second + " ");
                continue;
            }
            
            next = first + second;
            first = second;
            second = next;
            
            Console.Write(next + " ");
        }
	}
}
