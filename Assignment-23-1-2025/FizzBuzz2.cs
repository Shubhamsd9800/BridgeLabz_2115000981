using System;

class FizzBuzz2{
	
	 public static void Fizz2(){
        Console.Write("Enter a positive integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 0){
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int i = 1;
        while (i <= num){
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
           
            i++;
        }
    }

	
}