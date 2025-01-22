using System;
class SimpleInterest{
	public static void Sol(){
		
		Console.WriteLine("Enter the Principal:");
		double p = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the Rate:");
		double r = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the Time:");
		double t = Convert.ToDouble(Console.ReadLine());
		double si= (p*r*t)/100;
		Console.WriteLine("The simple interest is " + si );

	}
	
}