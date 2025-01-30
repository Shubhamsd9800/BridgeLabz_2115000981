using System;

class NumberArray{
	
	public static void solve(){
		int[] numberArray= new int[5];
		for(int i=0;i<numberArray.Length;i++){
			Console.WriteLine($"Enter the Number {i+1}");
			int n= Convert.ToInt32(Console.ReadLine());
			numberArray[i]=n;
		}
		
		for(int i=0;i<numberArray.Length;i++){
			if(numberArray[i]>0){
				if(numberArray[i] % 2==0){
					Console.WriteLine($"{numberArray[i]} is even Number");
				}
				else{
					Console.WriteLine($"{numberArray[i]} is odd Number");
				}
			}
			else if(numberArray[i]==0){
				Console.WriteLine($"{numberArray[i]} is zero Number");
			}
			else{
				Console.WriteLine($"{numberArray[i]} is Negative Number");
			}
		}
		
		if(numberArray[0]==numberArray[numberArray.Length-1]){
			Console.WriteLine("Equal");
		}
		else if(numberArray[0] > numberArray[numberArray.Length-1]){
			Console.WriteLine("Greater");
		}
		else{
			Console.WriteLine("Smaller");
		}
	}
}