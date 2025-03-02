using System;
using System.IO;
class Test1
{
    public static void Print()
    {
        string sourceFilePath = "D:\\Capgemini\\BridgeLabz_Code\\Assignment-20-2-2025\\Assignment-20-2-2025\\source.txt";
        string destinationFilePath = "D:\\Capgemini\\BridgeLabz_Code\\Assignment-20-2-2025\\Assignment-20-2-2025\\destination.txt";
        try
        {
            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {
                sourceStream.CopyTo(destinationStream);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {

            Console.ReadKey();
        }
    }
}



