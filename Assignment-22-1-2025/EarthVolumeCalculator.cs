using System;

static class EarthVolumeCalculator
{
    public static void CalculateVolume()
    {
        int radiusInKm = 6378;

        double conversionFactor = 0.621371;

        double volumeInKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusInKm, 3);
        double volumeInMiles3 = volumeInKm3 * Math.Pow(conversionFactor, 3);

        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeInKm3:F2} and cubic miles is {volumeInMiles3:F2}");
    }
}
