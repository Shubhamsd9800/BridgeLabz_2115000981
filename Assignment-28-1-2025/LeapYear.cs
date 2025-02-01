using System;

public class LeapYear{
	
	public static void isLeap(){
		
		Console.Write("Enter a year ");
		int year = Convert.ToInt32(Console.ReadLine());
		if(year < 1582){
			Console.WriteLine("The LeapYear >= 1582.");
            return;
		}
		if (isLeapYear(year))
            Console.WriteLine(year + " is a Leap Year.");
        else
            Console.WriteLine(year + " is not a Leap Year.");

	}
	
	static bool isLeapYear(int year){
		return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
	}
}