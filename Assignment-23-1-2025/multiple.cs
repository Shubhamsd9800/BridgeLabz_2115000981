using System;

class multiple{
	
	 public static void solve(){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Multiples of {number} below 100 are:");
        for (int i = 100; i >= 1; i--){
            if (i % number == 0){
                Console.WriteLine(i);
            }
        }
    }

	
}