using System;

class HandShakes{
	
	public static void CalculateHandshakes(){
		
		Console.WriteLine("Number of Students");
	int numberOfStudents= Convert.ToInt32(Console.ReadLine());
	
	Console.WriteLine($"Maximum HandShakes would be {(numberOfStudents * (numberOfStudents - 1)) / 2}");
	}

}