//using System;
//using System.IO;
//namespace FileHandlinDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Create a Variable to Hold the String Path
//            string filePath = "D:\\Capgemini\\BridgeLabz_Code\\sample.txt";

//            //Creating an Instance StreamReader Object to Read the Data from the File Path
//            StreamReader streamReader = new StreamReader(filePath);

//            Console.WriteLine("Content of the File");

//            // This is used to specify from where to start reading the input stream
//            // BaseStream: Returns the underlying stream.
//            // Seek: The new position within the current stream.
//            // SeekOrigin.Begi: Specifies the beginning of a stream
//            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

//            //It reads a line of characters from the current stream and returns the data as a string.
//            //It return the next line from the input stream, or null if the end of the input stream is reached.
//            string strData = streamReader.ReadLine();

//            // To Read the whole file line by line use While Loop as long the strData is not null
//            while (strData != null)
//            {
//                //Print the String data
//                Console.WriteLine(strData);
//                //Then Read the next String data
//                strData = streamReader.ReadLine();
//            }
//            Console.ReadLine();

//            //Close the streamReader Object
//            streamReader.Close();
//            Console.ReadKey();
//        }
//    }
//}