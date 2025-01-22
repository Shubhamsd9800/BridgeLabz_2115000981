using System;
class DistanceConversion
{
	public static void Sol()
	{
		Console.WriteLine("Enter the distance in kilometers:");
		double km = Convert.ToDouble(Console.ReadLine());
		double miles= km*0.621371 ;
		Console.WriteLine("The distance in miles of " + km + " kilometers is " + miles);
	}
}