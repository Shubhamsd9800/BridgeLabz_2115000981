using System;
using System.IO;
class ThrowsExample
{
    static void Main()
    {
        try
        {
            MethodWithThrows();
        }
        catch (IOException e)
        {
            Console.WriteLine("IOException caught: " + e.Message);
        }
    }

    static void MethodWithThrows()
    {
        throw new IOException("Example IOException");
    }
}
