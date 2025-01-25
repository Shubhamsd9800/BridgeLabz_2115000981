using System;

class Interest{
	
	public static void fun(){
		
		Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Time period (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"The Simple Interest is: {simpleInterest} , Principal: {principal}, Rate of Interest: {rate}, and Time {time}");

	}
}