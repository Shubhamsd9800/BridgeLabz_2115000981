using System;
class Area {
	public static void Sol(){
		Console.Write("Enter the radius of circle: ");
		double r = Convert.ToDouble(Console.ReadLine());
		double area= Math.PI * Math.Pow(r,2);
		Console.WriteLine("The area of circle with radius " + r + " is " + area);
		
	}
	
}