using System;

static class DistanceConverter2
{

    public static void ConvertToMiles()
    {
        Console.Write("Enter the distance in kilometers: ");
        
        double km = Convert.ToDouble(Console.ReadLine());
        double miles = km / 1.6;


        Console.WriteLine($"The total miles is {miles:F2} mile for the given {km} km.");
    }
}