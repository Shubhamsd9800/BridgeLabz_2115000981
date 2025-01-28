using System;
class Divisible5{
	public static void isDiv(){
		
		Console.Write("Enter the Number: ");
		int num= Convert.ToInt32(Console.ReadLine());
		if(num%5==0){
			Console.Write("true");
		}
		else{
			
			Console.Write("false");
		}
	}
}