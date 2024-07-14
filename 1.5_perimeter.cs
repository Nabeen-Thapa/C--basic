using System;
public class rectangle
{
	public static void Main(string[] args)
	{
		Console.WriteLine("enter length and breadth:");
		float l= int.Parse(Console.ReadLine());
		float b= int.Parse(Console.ReadLine());
		float area = l*b;
		float per= 2*(l+b);
		Console.WriteLine("area  is:" +area);
		Console.WriteLine("peremeter is:" +per);	
	}
	
}