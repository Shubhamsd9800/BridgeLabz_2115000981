using System;
class Cylinder{
	
	public static void Sol(){
		Console.Write("Enter the Radius: ");
		double radius = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter the Height: ");
		double height = Convert.ToDouble(Console.ReadLine());
		
		double res= Math.PI * Math.Pow(radius,2) * height;
		
		Console.WriteLine("Volume of cylinder is " + res);
	}
}