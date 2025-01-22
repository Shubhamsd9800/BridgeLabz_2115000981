using System;

class PowerCalculation
	{
	public static void Sol()
	{
		Console.WriteLine("Enter the base:");
		double bas = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the exponent:");
		double expo = Convert.ToDouble(Console.ReadLine());
		double res = Math.Pow(bas,expo);
		Console.WriteLine("The result of " + bas + " to the power " + expo + " is: "
		+ res);
	}
	
}