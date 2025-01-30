using System;

public class DigitFrequency
{
    public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Handle negative numbers
        number = Math.Abs(number);

        int[] frequency = new int[10];

        // Special case for 0
        if (number == 0)
        {
            frequency[0] = 1;
        }
        else
        {
            while (number > 0)
            {
                frequency[number % 10]++;
                number /= 10;
            }
        }

        Console.WriteLine("Digit Frequency");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] != 0)
            {
                Console.WriteLine($"{i}\t{frequency[i]}");
            }
        }
    }
}
