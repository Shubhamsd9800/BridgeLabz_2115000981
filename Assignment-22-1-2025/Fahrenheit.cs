using System;

class Fahrenheit{
	
	public static void convert(){
		
		Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsiusResult = (fahrenheit - 32) * 5 / 9;
       
        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius.");

	}
}