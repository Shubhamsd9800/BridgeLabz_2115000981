using System;

class Chocolates{
	
	public static void fun(){
		
		Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
        Console.WriteLine($"The number of chocolates each child gets is: {chocolatesPerChild} \n The number of remaining chocolates is :{remainingChocolates}");

		
	}
}