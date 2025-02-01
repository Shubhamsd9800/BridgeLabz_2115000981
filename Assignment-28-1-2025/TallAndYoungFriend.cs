using System;

class TallFriend{
	
	public static string FindYoung(int[] ages){
		int youngest= ages[0];
		string friend="Aman";
		for(int i=0;i<ages.Length;i++){
			if(ages[i]< youngest){
				youngest=ages[i];
				friend= i==1 ? "Akbar" : "Anthony";
			}
		}
		return friend;
	}
	
	public static string FindTallest(double[] heights){
		 double tallestHeight = heights[0];
        string tallestFriend = "Amar";
		
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                tallestFriend = i == 1 ? "Akbar" : "Anthony";
            }
        }
       
        return tallestFriend;

	}
	public static void Perform(){
		int[] ages= new int[3];
		double[] heights= new double[3];
		
		Console.Write("Enter age of Amar: ");
        ages[0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height of Amar (in meters): ");
        heights[0] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter age of Akbar: ");
        ages[1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height of Akbar (in meters): ");
        heights[1] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter age of Anthony: ");
        ages[2] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height of Anthony (in meters): ");
        heights[2] = Convert.ToDouble(Console.ReadLine());
        string youngest = FindYoung(ages);
        string tallest = FindTallest(heights);

        Console.WriteLine($"The youngest friend is: {youngest}");
        Console.WriteLine($"The tallest friend is: {tallest}");

	
	}
	
}