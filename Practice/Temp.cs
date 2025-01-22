using System;
class Temperature{
	
	public static void Temp(){
		Console.Write("Enter the Temp in celsius");
		double celcius= Convert.ToDouble(Console.ReadLine());
		double fahrenheit = (celcius * 9/5) + 32;
		
		Console.WriteLine("Temp in Fahrenheit is " + fahrenheit);
		
	}
}