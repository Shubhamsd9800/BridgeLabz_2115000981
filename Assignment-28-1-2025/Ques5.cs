using System;

class Ques5
{
    public static void CheckNumberType()
    {
		Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        // Check if the number is positive, negative, or zero
        if (number > 0)
        {
            Console.WriteLine("The number is Positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is Negative.");
        }
        else
        {
            Console.WriteLine("The number is Zero.");
        }
    }
}
