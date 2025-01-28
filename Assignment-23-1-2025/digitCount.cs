using System;

class digitCount{
	
	public static void digit(){
        Console.WriteLine("Enter a number to count the digits:");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (number != 0){
            number = number / 10;
            count++;
        }

        Console.WriteLine($"The number of digits is: {count}");
    }

}