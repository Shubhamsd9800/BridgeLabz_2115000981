using System;

static class DistanceConverter
{
    // Static method to convert kilometers to miles
    public static void ConvertKmToMiles()
    {
        double kilometers = 10.8;

        double conversionFactor = 1.6;

        double miles = kilometers / conversionFactor;

        Console.WriteLine("The distance km in miles is " + miles);
    }
}
