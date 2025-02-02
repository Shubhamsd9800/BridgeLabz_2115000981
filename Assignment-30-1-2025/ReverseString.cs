using System;
using System.Text;  
public class ReverseString{
	
	public static void print()
	{
		Console.Write("Enter a string: ");
		string input = Console.ReadLine();
		string reversed = reverseString(input);
		Console.WriteLine($"Reversed String: {reversed}");
	}
	
	static string reverseString(string str){
		// StringBuilder reverse= new StringBuilder();
		
		// for(int i=str.Length-1;i>=0;i--){
			// reverse.Append(str[i]);
		// }
		
		char[] rev= new char[str.Length];
		int i=0;
		int j= str.Length-1;
		
		while(j>=0){
			rev[i]=str[j];
			i++;
			j--;
		}
		return  new string(rev);
	}
}