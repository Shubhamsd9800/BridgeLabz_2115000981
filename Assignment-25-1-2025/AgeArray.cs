using System;
class AgeArray{
	
	public static void print(){
		
		int[] age= new int[10];
		for(int i=0;i<age.Length;i++){
			Console.WriteLine($"Enter the Age of Student {i+1}");
			int Age= Convert.ToInt32(Console.ReadLine());
			if(Age<0){
				Console.Error.WriteLine("Invalid Age");
				Environment.Exit(-1);
			}
			age[i]=Age;
		}
		
		for(int j=0;j<age.Length;j++){
			if(age[j]>=18){
				Console.WriteLine($"Student {j+1} with the age {age[j]} can vote");
			}
			else{
				Console.WriteLine($"Student {j+1} with the age {age[j]} can not vote");
			}
		}
	}
}