using System;

public class MeanHeight{
	
	public static void solve(){
		
		double[] height= new double[11];
		double sum= 0.0;
		
		Console.WriteLine("Enter the heights of players");
		for(int i=0;i<height.Length;i++){
			Console.Write($"Player {i+1}");
			height[i]= Convert.ToDouble(Console.ReadLine());
			sum+=height[i];
		}
		
		double mean= sum/height.Length;
		
		Console.WriteLine($" The mean Height of team is {mean:F2} cm");
	}
}