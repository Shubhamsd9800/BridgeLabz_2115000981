using System;

class MultiDimensionalArray{
    public static void print(){
        Console.WriteLine("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine()); // Fixed input

        Console.WriteLine("Enter the number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine()); // Fixed input

        int ind = 0;
        int[,] matrix = new int[rows, cols];
        int[] array = new int[rows * cols];

        // Taking input for 2D matrix
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                Console.WriteLine($"Element at [{i}, {j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Converting 2D matrix to 1D array
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                array[ind++] = matrix[i, j];
            }
        }

        // Printing 2D Matrix
        Console.WriteLine("\nThe 2D Array (Matrix) is: ");
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                Console.Write(matrix[i, j] + " "); // Added space for formatting
            }
            Console.WriteLine();
        }
		
        Console.WriteLine("\nThe 1D Array is: ");
        foreach(var item in array){
            Console.Write(item + " "); 
        }
    }

}
