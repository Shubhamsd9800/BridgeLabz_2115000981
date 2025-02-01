using System;

public static class Converter1
{
    private const double KmToMilesFactor = 0.621371;
    private const double MilesToKmFactor = 1.60934;
    private const double MetersToFeetFactor = 3.28084;
    private const double FeetToMetersFactor = 0.3048;
    private const double YardsToFeetFactor = 3.0;
    private const double FeetToYardsFactor = 0.333333;
    private const double MetersToInchesFactor = 39.3701;
    private const double InchesToMetersFactor = 0.0254;
    private const double InchesToCmFactor = 2.54;

    public static double ConvertKmToMiles(double km) => km * KmToMilesFactor;
    public static double ConvertMilesToKm(double miles) => miles * MilesToKmFactor;
    public static double ConvertMetersToFeet(double meters) => meters * MetersToFeetFactor;
    public static double ConvertFeetToMeters(double feet) => feet * FeetToMetersFactor;
    public static double ConvertYardsToFeet(double yards) => yards * YardsToFeetFactor;
    public static double ConvertFeetToYards(double feet) => feet * FeetToYardsFactor;
    public static double ConvertMetersToInches(double meters) => meters * MetersToInchesFactor;
    public static double ConvertInchesToMeters(double inches) => inches * InchesToMetersFactor;
    public static double ConvertInchesToCm(double inches) => inches * InchesToCmFactor;

    public static void PerformConversions()
    {
        Console.Write("Enter kilometers to convert to miles: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{km} km = {ConvertKmToMiles(km):F4} miles\n");

        Console.Write("Enter miles to convert to kilometers: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{miles} miles = {ConvertMilesToKm(miles):F4} km\n");

        Console.Write("Enter meters to convert to feet: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {ConvertMetersToFeet(meters):F4} feet\n");

        Console.Write("Enter feet to convert to meters: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {ConvertFeetToMeters(feet):F4} meters\n");

        Console.Write("Enter yards to convert to feet: ");
        double yards = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{yards} yards = {ConvertYardsToFeet(yards):F4} feet\n");

        Console.Write("Enter feet to convert to yards: ");
        feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {ConvertFeetToYards(feet):F4} yards\n");

        Console.Write("Enter meters to convert to inches: ");
        meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {ConvertMetersToInches(meters):F4} inches\n");

        Console.Write("Enter inches to convert to meters: ");
        double inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{inches} inches = {ConvertInchesToMeters(inches):F4} meters\n");

        Console.Write("Enter inches to convert to centimeters: ");
        inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{inches} inches = {ConvertInchesToCm(inches):F4} cm\n");
    }

   
}
