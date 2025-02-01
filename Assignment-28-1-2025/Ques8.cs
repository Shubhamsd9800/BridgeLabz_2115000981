using System;

class Ques8
{
    public static void FindSmallestAndLargest()
    {
        Console.Write("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));

        Console.WriteLine($"Smallest number: {smallest}");
        Console.WriteLine($"Largest number: {largest}");
    }
}
