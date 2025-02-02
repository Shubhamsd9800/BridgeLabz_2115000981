using System;

public class LongestWordFinder
{
    public static void print()
    {

        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string longestWord = FindLongestWord(sentence);

        Console.WriteLine($"Longest Word: {longestWord}");
    }


       static string FindLongestWord(string sentence)
    {
        string longestWord = "";
        string currentWord = "";
        int maxLength = 0;

        for (int i = 0; i <= sentence.Length; i++)
        {
            char ch = (i < sentence.Length) ? sentence[i] : ' ';

            if (ch != ' ' && ch != ',' && ch != '.' && ch != '!' && ch != '?') 
            {
                currentWord += ch;
            }
            else
            {
                if (currentWord.Length > maxLength)
                {
                    maxLength = currentWord.Length;
                    longestWord = currentWord;
                }
                currentWord = ""; 
            }
        }
        return longestWord;
    }
}
