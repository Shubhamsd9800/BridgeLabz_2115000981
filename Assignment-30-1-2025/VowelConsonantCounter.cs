using System;

public class VowelConsonantCounter{
	public static void print(){
		Console.Write("Enter A string : ");
		string input= Console.ReadLine();
		int v=0;
		int c=0;
		input=input.ToLower();
		foreach(char ch in input){
			if(ch>='a' && ch <='z'){
				if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    v++;
                }
                else
                {
                    c++;
                }
			}
		}
		
		Console.WriteLine("Vowels: " + v);
        Console.WriteLine("Consonants: " + c);
	}
}
