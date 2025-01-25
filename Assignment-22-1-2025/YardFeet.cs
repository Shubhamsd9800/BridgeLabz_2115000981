using System;
class YardToFeetAndInches{
	
	public static void convert(){
		
		Console.Write("Enter the distance in feet: ");
		 int distanceInFeet = Convert.ToInt32(Console.ReadLine());
		 double distanceInYards = distanceInFeet / 3;
		 double distanceInMiles = distanceInYards / 1760;
		 Console.WriteLine($"Your distance in feet is {distanceInFeet}, in yards is {distanceInYards}, and in miles is {distanceInMiles}");

	}
}
