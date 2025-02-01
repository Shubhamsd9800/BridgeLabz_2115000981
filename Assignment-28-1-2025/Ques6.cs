using System;

class Ques6
{
    public static void CheckSpringSeason()
    {
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter day (1-31): ");
        int day = Convert.ToInt32(Console.ReadLine());

        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            Console.WriteLine("The given date falls in the Spring season.");
        }
        else
        {
            Console.WriteLine("The given date is NOT in the Spring season.");
        }
    }
}
