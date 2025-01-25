using System;
class Calculator{
	
	public static void calci(){
		
	 Console.Write("Enter the first number: ");
	 int number1 = Convert.ToInt32(Console.ReadLine());
	 Console.Write("Enter the second number: ");
	 int number2 = Convert.ToInt32(Console.ReadLine());
	 
	 double addition = number1 + number2;
	 double subtraction = number1 - number2;
	 double multiplication = number1 * number2;
	 double division = number1 / number2;
	 
	Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {number1} and	{number2} is {addition}, {subtraction}, {multiplication}, and	{division}");

	}
}