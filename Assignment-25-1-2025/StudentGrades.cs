// using System;

public class StudentGrades
{
    public static void print()
    {
        Console.WriteLine("Enter the number of students:");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        int[] physicsMarks = new int[numStudents];
        int[] chemistryMarks = new int[numStudents];
        int[] mathsMarks = new int[numStudents];
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");

            physicsMarks[i] = GetValidMarks("Physics");
            chemistryMarks[i] = GetValidMarks("Chemistry");
            mathsMarks[i] = GetValidMarks("Maths");

            percentages[i] = (physicsMarks[i] + chemistryMarks[i] + mathsMarks[i]) / 3.0;
            grades[i] = GetGrade(percentages[i]);

            Console.WriteLine($"Student {i + 1}: Percentage: {percentages[i]:F2}%, Grade: {grades[i]}");
        }
    }

    private static int GetValidMarks(string subject)
    {
        int marks;
        do
        {
            Console.Write($"Enter {subject} marks (0-100): ");
            marks = Convert.ToInt32(Console.ReadLine());
            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks! Please enter a value between 0 and 100.");
            }
        } while (marks < 0 || marks > 100);

        return marks;
    }

    private static char GetGrade(double percentage)
    {
        if (percentage >= 80)
            return 'A';
        else if (percentage >= 70)
            return 'B';
        else if (percentage >= 60)
            return 'C';
        else if (percentage >= 50)
            return 'D';
        else if (percentage >= 40)
            return 'E';
        else
            return 'R'; // R for "Reappear"
    }
}
