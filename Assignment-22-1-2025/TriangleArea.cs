using System;
class TriangleArea{
	
	public static void calci(){
		
		Console.Write("Enter the base of the triangle in inches:");
		double baseInches = Convert.ToDouble(Console.ReadLine());
 
		Console.Write("Enter the height of the triangle in inches:");
		double heightInches = Convert.ToDouble(Console.ReadLine());


		double areaInch= 0.5 * baseInches * heightInches;
		double areaCm= areaInch * 2.54 * 2.54;
		
		Console.WriteLine($"The area of the triangle in square inches is {areaInch:F2} and in square centimeters is {areaCm:F2}");

	}
}