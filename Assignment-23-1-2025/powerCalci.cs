using System;

class powerCalci{
	
	   public static void powercalcu(){
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for (int i = 1; i <= power; i++){
            result *= number;
        }
        Console.WriteLine($"{number} raised to the power of {power} is: {result}");
    }

}