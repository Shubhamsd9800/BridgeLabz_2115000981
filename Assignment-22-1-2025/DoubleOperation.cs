using System;
class DoubleOperation{
	
	public static void fun(){
		
		Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b; 
        double result4 = a % b + c;
        Console.WriteLine($"The results of Double Operations are: {result1}, {result2}, {result3}, {result4}");

	}
}