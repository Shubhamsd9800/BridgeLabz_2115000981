using System;

class CountDown
{
    public static void useWhile()
    {
        Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		while(number>0){
			Console.WriteLine(number);
			number--;
		}

    }
	
}
