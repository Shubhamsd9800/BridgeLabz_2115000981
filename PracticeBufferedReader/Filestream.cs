using System;
using System.IO;

class FileStreamExample
{
    static void Main()
    {
        try
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\sample.txt");
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                int i;
                while ((i = fs.ReadByte()) != -1)
                {
                    Console.Write((char)i);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
