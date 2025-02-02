using System;
using System.Text;
public class SubStringCheck{
	
	public static void print(){
		Console.WriteLine("Enter the main string:");
		string mainString = Console.ReadLine();

		Console.WriteLine("Enter the substring to search for:");
		string substring = Console.ReadLine();
		
		int count = CountSubstringOccurrences(mainString, substring);
		Console.WriteLine($"The substring '{substring}' appears {count} times in the main string.");
	}
	
	static int CountSubstringOccurrences(string mainString, string subString)
    {
        int count = 0;
        int subLength = subString.Length;

        for (int i = 0; i <= mainString.Length - subLength; i++)
        {
            if (mainString.Substring(i, subLength) == subString) // Compare using Substring()
            {
                count++;
            }
        }

        return count;
    }
}