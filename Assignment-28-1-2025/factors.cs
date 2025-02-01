using System;

public static class FactorsUtility
{
    // Method to find factors and return them as an array
    public static int[] GetFactors(int num)
    {
        int count = 0;

        // Count number of factors
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0) count++;
        }

        // Initialize array and store factors
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    // Method to calculate sum of factors
    public static int GetSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to calculate product of factors
    public static long GetProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to calculate sum of squares of factors
    public static int GetSumOfSquares(int[] factors)
    {
        int sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += (int)Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }

    // Method to display all results
    public static void DisplayResults(int num)
    {
        int[] factors = GetFactors(num);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        int sum = GetSumOfFactors(factors);
        long product = GetProductOfFactors(factors);
        int sumOfSquares = GetSumOfSquares(factors);

        Console.WriteLine($"Sum of factors: {sum}");
        Console.WriteLine($"Product of factors: {product}");
        Console.WriteLine($"Sum of squares of factors: {sumOfSquares}");
    }
}
