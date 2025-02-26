using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16_2_2025
{
    class Test5
    {
        public static void Print()
        {
            string Path = "D:\\Capgemini\\BridgeLabz_Code\\Assignment-16-2-2025\\Assignment-16-2-2025\\TextFile.txt";
            string searchWord = "data";
            int count = 0;
            try
            {
                string text= File.ReadAllText(Path); ;
                string[] words = text.Split(' ');
                foreach (string word in words) {
                    if (word.Equals(searchWord))
                    {
                        count++;
                    }
                }
                Console.WriteLine("The word '" + searchWord + "' appears " + count + " times in the file.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString);
            }
        }
    }
}
