using System;
public class takenumber
{
    public static void Main (string []args)
    {
        int a= int.Parse(args[0]);
        int b= int.Parse(args[1]);
        int sum= a +b;
        Console.WriteLine("sum is: " +sum);
    }
}