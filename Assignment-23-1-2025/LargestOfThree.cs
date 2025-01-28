using System;

class LargestOfThree
{
    public static void isLargest()
    {
        Console.Write("Enter the number 1: ");
		int number1=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the number 2: ");
		int number2=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the number 3: ");
		int number3=Convert.ToInt32(Console.ReadLine());
		
		Console.Write($"Is the first number the Largest?: ");
		if(number1 > number2 && number1>number3){
			Console.WriteLine(" True ");
		}
		else{
			Console.WriteLine(" False ");
		}
		
		Console.Write($"Is the second number the Largest?: ");
		if(number2 > number1 && number2>number3){
			Console.WriteLine(" True ");
		}
		else{
			Console.WriteLine(" False ");
		}
		
		Console.Write($"Is the third number the Largest?: ");
		if(number3 > number1 && number3>number2){
			Console.WriteLine(" True ");
		}else{
			Console.WriteLine(" False ");
		}

    }
}
