using System;

class SumTillExit1
{
    public static void solve()
    {
		double total=0.0;
		double number;
		Console.WriteLine("--Enter numbers to add to the total. Enter 0 or negative number to stop--");
        
		
		while(true){
			
			Console.Write("Enter the number: ");
			number=Convert.ToDouble(Console.ReadLine());
			if(number<0)
				break;
			
			total+=number;
			
		}
			
		Console.WriteLine($"The sum of all numbers you have entered is:{total}");

    }
	
}

