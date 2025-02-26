using System;
using System.IO;

class Test4
{
    public static void Print()
    {
        string filePath = "D:\\Capgemini\\BridgeLabz_Code\\Assignment-16-2-2025\\Assignment-16-2-2025\\TextFile.txt";
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line + "\n");
                    Console.ReadKey();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}