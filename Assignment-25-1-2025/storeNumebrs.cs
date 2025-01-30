using System;

class storeNumbers{
	
	public static void solve(){
		Console.WriteLine("Take the size of array");
		int n= Convert.ToInt32(Console.ReadLine());
		int[] numbers= new int[n];
		int total= 0;
		int ind=0;
		while(true){
			Console.WriteLine("Take the array input");
			int input= Convert.ToInt32(Console.ReadLine());
			if(input==10 || input <=0){
				break;
			}
			numbers[ind]=input;
			ind++;
		}
		
		for(int i=0;i<numbers.Length;i++){
			if(numbers[i]<=0){
				break;
			}
			Console.WriteLine(numbers[i]);
			total +=numbers[i];
		}
		
		
		Console.WriteLine($" Total sum of numbers: {total}");
	}
}