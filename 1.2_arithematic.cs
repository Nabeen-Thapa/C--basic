using System;
public class arithematic
{
	public static void Main(string[] args)
	{
		int a= int.Parse(args[0]);
		int b= int.Parse(args[1]);
		
		Console.WriteLine("sum is:" +(a+b));
		Console.WriteLine("difference is:" +(a-b));
		Console.WriteLine("mul is:" +(a*b));
		Console.WriteLine("div is:" +(a/b));
	}
	
}