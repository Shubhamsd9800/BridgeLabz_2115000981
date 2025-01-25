using System;
class HeightConversion{
	
	public static void convert(){
		
		 Console.Write("Enter your height in centimeters: ");
		double heightCm = Convert.ToDouble(Console.ReadLine());
		
		double heightInch= heightCm / 2.54;
		int feet= (int) heightInch / 12;
		double inches=heightInch % 12;
		
		Console.WriteLine($"Your Height in cm is {heightCm:F2} while in feet is {feet} ft and {inches:F2} in and inches is {heightInch:F2}");

	}
}