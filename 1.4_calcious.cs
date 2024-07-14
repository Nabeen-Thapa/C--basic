using System;
public class temperature
{
	public static void Main(string[] args)
	{
		Console.WriteLine("enter temperature in calciues:");
		float c= int.Parse(Console.ReadLine());
		
		float fan = ( c* 9/5)+32;
		Console.WriteLine("temperature is:" +fan);
		
	}
	
}