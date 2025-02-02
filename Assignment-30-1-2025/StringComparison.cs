using System;

public class StringComparison
{
    public static void print()
    {
        Console.Write("Enter String 1: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter String 2: ");
        string str2 = Console.ReadLine();

        CompareStringsLexicographically(str1, str2);
    }

    static void CompareStringsLexicographically(string str1, string str2)
    {
        int length1 = str1.Length;
        int length2 = str2.Length;
        int minLength = Math.Min(length1, length2);

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order");
                return;
            }
            else if (str1[i] > str2[i])
            {
                Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order");
                return;
            }
        }


        if (length1 < length2)
        {
            Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order");
        }
        else if (length1 > length2)
        {
            Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order");
        }
        else
        {
            Console.WriteLine("Both strings are equal in lexicographical order");
        }
    }
}
