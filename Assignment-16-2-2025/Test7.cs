using System;
using System.IO;

namespace Assignment_16_2_2025
{
    class Test7
    {
        public static void Print()
        {
            string filePath = "D:\\Capgemini\\BridgeLabz_Code\\Assignment-16-2-2025\\Assignment-16-2-2025\\TextFile.txt";
            try
            {
                Console.WriteLine("Enter some text to append: ");
                string userInput = Console.ReadLine();

                // Append text to the existing file
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(userInput);
                }

                Console.WriteLine("Text appended successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
