using System;

class Ques11
{
    public static void CalculateWindChill()
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the wind speed in miles per hour: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        if (windSpeed < 0)
        {
            Console.WriteLine("Wind speed cannot be negative.");
            return;
        }

        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);

        Console.WriteLine($"The wind chill is: {windChill}°F");
    }
}
