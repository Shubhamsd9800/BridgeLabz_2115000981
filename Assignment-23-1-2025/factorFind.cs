using System;

class factorFind{
	
	 public static void factor(){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factors of {number} are:");
        for (int i = 1; i < number; i++){
            if (number % i == 0){
                Console.WriteLine(i);  
            }
        }
    }

}