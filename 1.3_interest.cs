using System;
public class interest 
{
	public static void Main(string[] args)
	{
		Console.WriteLine("enter p t r:");
		float p= int.Parse(Console.ReadLine());
		float t= int.Parse(Console.ReadLine());
		float r= int.Parse(Console.ReadLine());
		float interest= (p*t*r)/100;
		Console.WriteLine("interest  is:" +interest);
		
	}
	
}