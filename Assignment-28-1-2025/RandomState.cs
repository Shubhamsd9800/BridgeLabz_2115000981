using System;

class RandomState{
    public static int[] Generate4DigitRandomArray(int size){
        Random random = new Random();
        int[] randomNumbers = new int[size];

        // Generate random 4-digit numbers
        for (int i = 0; i < size; i++){
            randomNumbers[i] = random.Next(1000, 10000);
        }

        return randomNumbers;
    }

    public static double[] FindAverageMinMax(int[] numbers){
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];
		
        foreach (int num in numbers){
            sum += num;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        double average = sum / numbers.Length;

        return new double[] { average, min, max };
    }

    public static void Perform(){
        int size = 5;
        int[] randomNumbers = Generate4DigitRandomArray(size);

        Console.WriteLine("Generated Random Numbers:");
        foreach (int num in randomNumbers){
            Console.WriteLine(num);
        }
        double[] stats = FindAverageMinMax(randomNumbers);

        Console.WriteLine($"\nAverage: {stats[0]:F2}");
        Console.WriteLine($"Minimum: {stats[1]}");
        Console.WriteLine($"Maximum: {stats[2]}");
    }

}
