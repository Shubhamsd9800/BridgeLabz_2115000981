using System;

class Cal{
	
	public static void Calculator(){
        double first, second;
        string op;
        Console.WriteLine("Enter the first number:");
        first = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter an operator (+, -, *, /):");
        op = Console.ReadLine();
        Console.WriteLine("Enter the second number:");
        second = Convert.ToDouble(Console.ReadLine());

        switch (op){
            case "+":
                Console.WriteLine($"Result: {first + second}");
                break;
            case "-":
                Console.WriteLine($"Result: {first - second}");
                break;
            case "*":
                Console.WriteLine($"Result: {first * second}");
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine($"Result: {first / second}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }

}