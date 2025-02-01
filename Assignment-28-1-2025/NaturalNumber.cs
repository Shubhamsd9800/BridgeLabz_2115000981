using System;

public static class NaturalNumber{
	
	public static bool isNatural(int num){
		return num>0;
	}
	
	public static int RecursiveSum(int num){
		if(num==1) return 1;
		return num + RecursiveSum(num-1);
	}
	
	public static int SumUsingFormula(int n)
    {
        return (n * (n + 1)) / 2;
    }
	
	public static void DisplayResults(){
		Console.Write("Enter a Number");
		if (!int.TryParse(Console.ReadLine(), out int n) || !isNatural(n))
        {
            Console.WriteLine(" Invalid input! Please enter a valid natural number (greater than 0).");
            return;
        }
		
		int recursiveSum = RecursiveSum(n);
        int formulaSum = SumUsingFormula(n);

        Console.WriteLine($"Sum using recursion: {recursiveSum}");
        Console.WriteLine($"Sum using formula (n*(n+1)/2): {formulaSum}");

        if (recursiveSum == formulaSum)
        {
            Console.WriteLine(" Both methods give the same result. Calculation is correct!");
        }
        else
        {
            Console.WriteLine(" Mismatch! There is an error in the computation.");
        }
	}
}