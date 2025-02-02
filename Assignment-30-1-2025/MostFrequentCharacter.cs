using System;

public class MostFrequentCharacter
{
    public static void print()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        char mostFrequentChar = FindMostFrequentCharacter(input);
        Console.WriteLine($"Most Frequent Character: '{mostFrequentChar}'");
    }

    static char FindMostFrequentCharacter(string str)
    {
        int[] freq = new int[256];
        int maxCount = 0;
        char mostFrequentChar = '\0';
        
        for (int i = 0; i < str.Length; i++)
        {
            char currentChar = str[i];
            
            freq[currentChar]++;
            
            if (freq[currentChar] > maxCount)
            {
                maxCount = freq[currentChar];
                mostFrequentChar = currentChar;
            }
        }
        
        return mostFrequentChar;
    }
}
