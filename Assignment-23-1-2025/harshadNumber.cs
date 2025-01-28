using System;

class harshadNumber{
	
	public static void harshad(){

        Console.WriteLine("Enter a number to check if it is a Harshad number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int originalNumber = number;

        while (number != 0){
            int digit = number % 10;
            sum += digit;
            number = number / 10;
        }

        if (originalNumber % sum == 0){
            Console.WriteLine($"{originalNumber} is a Harshad number.");
        }else{
            Console.WriteLine($"{originalNumber} is not a Harshad number.");
        }
    }

}