using System;

class Ques10
{
    public static void FindRemainderAndQuotient()
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        if (divisor == 0)
        {
            Console.WriteLine("Divisor cannot be zero.");
            return;
        }

        int quotient = number / divisor;
        int remainder = number % divisor;

        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Remainder: {remainder}");
    }
}
