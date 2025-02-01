using System;

public static class Converter2
{
    private const double PoundsToKilogramsFactor = 0.453592;
    private const double KilogramsToPoundsFactor = 2.20462;
    private const double GallonsToLitersFactor = 3.78541;
    private const double LitersToGallonsFactor = 0.264172;

    public static double ConvertFahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;
    public static double ConvertCelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;
    public static double ConvertPoundsToKilograms(double pounds) => pounds * PoundsToKilogramsFactor;
    public static double ConvertKilogramsToPounds(double kilograms) => kilograms * KilogramsToPoundsFactor;
    public static double ConvertGallonsToLiters(double gallons) => gallons * GallonsToLitersFactor;
    public static double ConvertLitersToGallons(double liters) => liters * LitersToGallonsFactor;

    public static void PerformConversions()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{fahrenheit}°F = {ConvertFahrenheitToCelsius(fahrenheit):F2}°C\n");

        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{celsius}°C = {ConvertCelsiusToFahrenheit(celsius):F2}°F\n");

        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{pounds} lbs = {ConvertPoundsToKilograms(pounds):F2} kg\n");

        Console.Write("Enter weight in kilograms: ");
        double kilograms = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{kilograms} kg = {ConvertKilogramsToPounds(kilograms):F2} lbs\n");

        Console.Write("Enter volume in gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{gallons} gallons = {ConvertGallonsToLiters(gallons):F2} liters\n");

        Console.Write("Enter volume in liters: ");
        double liters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{liters} liters = {ConvertLitersToGallons(liters):F2} gallons\n");
    }

 
}
