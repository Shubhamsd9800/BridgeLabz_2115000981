using System;

static class PCMCalci
{

    public static void CalculateAverage()
    {
        
        int maths = 94;
        int physics = 95;
        int chemistry = 96;

       
        int totalMaxMarks = 300;

       
        int totalMarks = maths + physics + chemistry;
        double averagePercent = (totalMarks / (double)totalMaxMarks) * 100;

        Console.WriteLine("Sam’s average mark in PCM is " + averagePercent);
    }
}
