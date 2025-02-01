using System;

class StudentVote{
	
	public static bool VoteChecker(int age){
		 if (age < 0)
        {
            return false;
        }
        return age >= 18;

	}
	
	public static void Perform(){
		int[] studentAges = new int[10];
		
		for (int i = 0; i < studentAges.Length; i++){
		Console.Write($"Enter the age of student {i + 1}: ");
		studentAges[i] = Convert.ToInt32(Console.ReadLine());
		if(studentAges[i] <0){
			Console.WriteLine($"{i+1}th student cannot vote");
			continue;
		}
		
		bool canVote=VoteChecker(studentAges[i]);
		Console.WriteLine(canVote ? $"Student {i + 1} can vote." : $"Student {i + 1} cannot vote.");
		
		}

		
	}
	
	
}