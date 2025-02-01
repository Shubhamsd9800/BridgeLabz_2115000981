using System;

class Ques12
{
    public static void CalculateTrigonometricFunctions()
    {
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double radians = Math.PI * angle / 180.0;

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        Console.WriteLine($"Sine of {angle}°: {sine}");
        Console.WriteLine($"Cosine of {angle}°: {cosine}");
        Console.WriteLine($"Tangent of {angle}°: {tangent}");
    }
}
